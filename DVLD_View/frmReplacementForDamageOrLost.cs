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
    public partial class frmReplacementForDamageOrLost : Form
    {
        enum enReplaceFor { Lost =3, Damage=4}
        enReplaceFor _ReplaceFor = enReplaceFor.Damage;

        private bool _IsActive;
        private bool _IsDetained;
        private bool _IsFound;
        private int _LocalLicenseID;
        private int _PersonID = -1;
        private int _NewLicenseID = -1;
        clsApplication _Application;
        int _ApplicationID = -1;
        clsLicense _LocalLicense;
        private int _AppTypeID = -1;


        public frmReplacementForDamageOrLost()
        {
            InitializeComponent();

        }

        private void rbDamageLicense_CheckedChanged(object sender, EventArgs e)
        {
            lblMode.Text = "Replacement For Damage License";
            _ReplaceFor = enReplaceFor.Damage;
            ctrlAppInfoForLicenseReplacement1.lblAppFees.Text = clsApplicationType.Find((int)_ReplaceFor).ApplicationFees.ToString();
        }

        private void rbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            lblMode.Text = "Replacement For Lost License";
            _ReplaceFor = enReplaceFor.Lost;
             
            ctrlAppInfoForLicenseReplacement1.lblAppFees.Text = clsApplicationType.Find((int)_ReplaceFor).ApplicationFees.ToString();
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

            if (MessageBox.Show($"Are you sure you want to replace license for licenseID={_LocalLicenseID}", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
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
                ctrlAppInfoForLicenseReplacement1.lblReplacedLicenseID.Text = _LocalLicense.LicenseID.ToString();
                ctrlAppInfoForLicenseReplacement1.lblRLAppID.Text = _LocalLicense.ApplicationId.ToString();

                MessageBox.Show($"New license issued successfully with ID={_LocalLicense.LicenseID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clsApplication.UpdateApplicationStatus(applicationID, 3);
                _NewLicenseID = _LocalLicense.LicenseID;
                clsLicense.UpdateLicenseActivity(_LocalLicenseID, false);

                llShowLicense.Enabled = true;
                
            }
            else
                MessageBox.Show($"Fail to renew local license", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void frmReplacementForDamageOrLost_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseCardWithFilter1.txtSearchLicenseID.Focus();

        }

        private void ctrlDriverLicenseCardWithFilter1_OnLicenseSelected(int obj)
        {
            clsLicense oldLicense;
            _LocalLicenseID = obj;
            _IsFound = ctrlDriverLicenseCardWithFilter1.IsFound;
            _IsActive = ctrlDriverLicenseCardWithFilter1.IsActive;
            _IsDetained = ctrlDriverLicenseCardWithFilter1.IsDetained;

            if (_ReplaceFor == enReplaceFor.Lost)
                _AppTypeID = 3;
            else
                _AppTypeID = 4;

            if(!_IsFound)
                return;

            llShowLicenseHistory.Enabled = true;
            ctrlAppInfoForLicenseReplacement1.LoadInitialData(_LocalLicenseID,_AppTypeID);

            if (clsLicense.IsLicenseExpired(_LocalLicenseID))
            {
                MessageBox.Show($"Local License with License ID=[{_LocalLicenseID}] is expired in:[{clsLicense.Find(_LocalLicenseID).ExpirationDate.ToShortDateString()}]{Environment.NewLine}" +
                    $"Renew it!", "Replacement Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            oldLicense = clsLicense.Find(_LocalLicenseID);

            int driverID = oldLicense.DriverID;
            _PersonID = clsDriver.Find(driverID).PersonID;
            int userID = clsUser.Find(ctrlAppInfoForLicenseReplacement1.lblUsername.Text).UserID;


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

            
            // application data

            _Application.ApplicationDate = Convert.ToDateTime(ctrlAppInfoForLicenseReplacement1.lblApplicationDate.Text);
            _Application.ApplicationTypeID = _AppTypeID;
            _Application.UserID = userID;
            _Application.ApplicantApplicationID = _PersonID;
            _Application.PaidFees = Convert.ToSingle(ctrlAppInfoForLicenseReplacement1.lblAppFees.Text);
            _Application.LastStatusDate = DateTime.Now;
            _Application.ApplicationStatus = 1;

            // local license ID;
            _LocalLicense.IssueDate = oldLicense.IssueDate;
            _LocalLicense.ExpirationDate = oldLicense.ExpirationDate;
            _LocalLicense.IssueReason =(short)_AppTypeID;
            _LocalLicense.PaidFees = oldLicense.PaidFees;
            _LocalLicense.DriverID = driverID;
            _LocalLicense.IsActive = true;
            _LocalLicense.UserID = userID;
            _LocalLicense.LicenseClassID = oldLicense.LicenseClassID;

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
