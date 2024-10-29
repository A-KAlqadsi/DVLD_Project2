using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_View
{
    public partial class frmRenewLocalDrivingLicense : Form
    {
        
        private bool _IsActive;
        private bool _IsDetained;
        private bool _IsFound;
        private int _LocalLicenseID;
        private int _PersonID = -1;
        private int _NewLicenseID = -1;
        clsApplication _Application;
        int _ApplicationID = -1;
        clsLicense _LocalLicense;

        public frmRenewLocalDrivingLicense()
        {
            InitializeComponent();
        }

        private void ctrlDriverLicenseCardWithFilter1_OnLicenseSelected(int obj)
        {
            _LocalLicenseID = obj;
            _IsFound =  ctrlDriverLicenseCardWithFilter1.IsFound;
            _IsActive = ctrlDriverLicenseCardWithFilter1.IsActive;
            _IsDetained = ctrlDriverLicenseCardWithFilter1.IsDetained;

            if (!_IsFound)
                return;

            llShowLicenseHistory.Enabled = true;

            ctrlRenewLicenseApplicationInfo1.LoadInitialData(_LocalLicenseID);

            if(!clsLicense.IsLicenseExpired(_LocalLicenseID))
            {
                MessageBox.Show($"Local License with License ID=[{_LocalLicenseID}] not expired{Environment.NewLine}Will Expire in:[{clsLicense.Find(_LocalLicenseID).ExpirationDate.ToShortDateString()}]", "Renew Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int driverID = clsLicense.Find(_LocalLicenseID).DriverID;
            _PersonID = clsDriver.Find(driverID).PersonID;
            int userID = clsUser.Find(ctrlRenewLicenseApplicationInfo1.lblUsername.Text).UserID;
            
           
            if (_IsFound && _IsActive && !_IsDetained)
            {
                btnIssue.Enabled = true;
            }
            else
            {
                btnIssue.Enabled = false;
            }



            if (!_IsActive)
            {
                MessageBox.Show($"Local license with ID=[{_LocalLicenseID}] is not active", "Not allowd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           

            if (_IsDetained)
            {
                MessageBox.Show($"License with ID=[{_LocalLicenseID}] is Detained, Release it first", "Not allowd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Application = new clsApplication();
            _LocalLicense = new clsLicense();

            
            btnIssue.Enabled = true; // make the issue button enabled!
            
            float licenseFees = ctrlRenewLicenseApplicationInfo1.LicenseFees;
            float totalFees = ctrlRenewLicenseApplicationInfo1.LicenseFees + ctrlRenewLicenseApplicationInfo1.AppFees;
            ctrlRenewLicenseApplicationInfo1.lblLicenseFees.Text = licenseFees.ToString();
            ctrlRenewLicenseApplicationInfo1.lblTotalFees.Text = totalFees.ToString();

            // application data

            _Application.ApplicationDate = Convert.ToDateTime(ctrlRenewLicenseApplicationInfo1.lblApplicationDate.Text);
            _Application.ApplicationTypeID = (clsApplication.enApplicationType)ctrlRenewLicenseApplicationInfo1.AppTypeID;
            _Application.UserID = userID;
            _Application.ApplicantPersonID = _PersonID;
            _Application.PaidFees = Convert.ToSingle(ctrlRenewLicenseApplicationInfo1.lblAppFees.Text);
            _Application.LastStatusDate = DateTime.Now;
            _Application.ApplicationStatus = clsApplication.enApplicationStatus.New;

            // local license ID;
            _LocalLicense.IssueDate =Convert.ToDateTime(ctrlRenewLicenseApplicationInfo1.lblIssueDate.Text);
            _LocalLicense.ExpirationDate = Convert.ToDateTime(ctrlRenewLicenseApplicationInfo1.lblExpirationDate.Text);
            _LocalLicense.IssueReason = 2;
            _LocalLicense.PaidFees= ctrlRenewLicenseApplicationInfo1.LicenseFees;
            _LocalLicense.DriverID = driverID;
            _LocalLicense.IsActive = true;
            _LocalLicense.UserID = userID;
            _LocalLicense.Notes = ctrlRenewLicenseApplicationInfo1.txtNotes.Text.Trim();
            _LocalLicense.LicenseClassID = ctrlRenewLicenseApplicationInfo1.ClassID;


        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            int applicationID = -1;
            if (!clsLicense.IsLicenseActive(_LocalLicenseID))
            {
                MessageBox.Show($"Local license with ID=[{_LocalLicenseID}] is not active", "Not Allowd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssue.Enabled = false;
                return;
            }

            if (MessageBox.Show($"Are you sure you want to renew license for licenseID={_LocalLicenseID}", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                return;

            if (_Application.Save())
            {
                applicationID = _Application.ApplicationID;
            }

            if (applicationID != -1)
                _LocalLicense.ApplicationId = applicationID;
            else
            {
                MessageBox.Show("Failed to renew local license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_LocalLicense.Save())
            {
                ctrlRenewLicenseApplicationInfo1.lblRenewedLicenseID.Text = _LocalLicense.LicenseID.ToString();
                ctrlRenewLicenseApplicationInfo1.lblRLAppID.Text = _LocalLicense.ApplicationId.ToString();

                MessageBox.Show($"New license issued successfully with ID={_LocalLicense.LicenseID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clsApplication.UpdateApplicationStatus(applicationID, 3);
                _NewLicenseID = _LocalLicense.LicenseID;
                clsLicense.DeactivateLicense(_LocalLicenseID,false);

                llShowLicense.Enabled = true;
            }
            else
                MessageBox.Show($"Fail to renew local license", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseCard license = new frmShowLicenseCard(_NewLicenseID);
            license.ShowDialog();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory history = new frmLicenseHistory(_PersonID);
            history.ShowDialog();
        }
    }
}
