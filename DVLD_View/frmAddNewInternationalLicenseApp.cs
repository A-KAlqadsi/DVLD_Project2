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
    public partial class frmAddNewInternationalLicenseApp : Form
    {
        private bool _IsClass3;
        private bool _IsActive;
        private bool _IsDetained;
        private bool _IsFound;
        private int _LocalLicenseID;
        private int _PersonID = -1;

        clsApplication _Application;
        int _ApplicationID = -1;
        clsInternationalLicense _InterLicense;
        int _InterLicenseID = -1;

        public frmAddNewInternationalLicenseApp()
        {
            InitializeComponent();
        }

        private void frmAddNewInternationalLicenseApp_Load(object sender, EventArgs e)
        {
            btnIssue.Enabled = false;
            llShowLicense.Enabled = true;

        }

        private void ctrlDriverLicenseCardWithFilter1_OnLicenseSelected(int obj)
        {
            _LocalLicenseID = obj;
            _IsFound = ctrlDriverLicenseCardWithFilter1.IsFound;
            _IsClass3 = ctrlDriverLicenseCardWithFilter1.IsClass3;
            _IsActive = ctrlDriverLicenseCardWithFilter1.IsActive;
            _IsDetained = ctrlDriverLicenseCardWithFilter1.IsDetained;
            
            if (!_IsFound)
                return;
            
            int driverID = clsLicense.Find(_LocalLicenseID).DriverID;
            _PersonID = clsDriver.Find(driverID).PersonID;
            int userID = clsUser.Find(ctrlInternationalApplicationInfo1.lblUsername.Text).UserID;
            int interLicense = clsLicense.IsLicenseInternational(_LocalLicenseID);


            if (_IsFound && _IsActive && _IsClass3 && !_IsDetained)
            {
                btnIssue.Enabled = true;
            }
            else
            {
                btnIssue.Enabled =false;
            }

           


            if (interLicense != -1 && clsInternationalLicense.IsLicenseActive(interLicense))
            {
                MessageBox.Show($"Person has an active International license with ID={interLicense}", "Proccess Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssue.Enabled = false;
                return;
            }

            if (!_IsActive)
            {
                MessageBox.Show($"Local license with ID=[{_LocalLicenseID}] is not active", "Not allowd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_IsClass3)
            {
                MessageBox.Show($"License with ID=[{_LocalLicenseID}] is not Class 3{Environment.NewLine}International Licenses only for Class 3", "Not allowd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_IsDetained)
            {
                MessageBox.Show($"License with ID=[{_LocalLicenseID}] is Detained, Release it first", "Not allowd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Application = new clsApplication();
            _InterLicense = new clsInternationalLicense();
            
            ctrlInternationalApplicationInfo1.lblLicenseID.Text = _LocalLicenseID.ToString();
            btnIssue.Enabled = true; // make the issue button enabled!

            // application data

            _Application.ApplicationDate = Convert.ToDateTime(ctrlInternationalApplicationInfo1.lblApplicationDate.Text);
            _Application.ApplicationTypeID = ctrlInternationalApplicationInfo1.AppTypeID;
            _Application.UserID = userID;
            _Application.ApplicantApplicationID = _PersonID;
            _Application.PaidFees = Convert.ToSingle(ctrlInternationalApplicationInfo1.lblAppFees.Text);
            _Application.LastStatusDate = DateTime.Now;
            _Application.ApplicationStatus = 1;

            // international license data
            _InterLicense.DriverID = driverID;
            _InterLicense.UserID = userID;
            _InterLicense.IssueDate = Convert.ToDateTime(ctrlInternationalApplicationInfo1.lblIssueDate.Text);
            _InterLicense.ExpirationDate = Convert.ToDateTime(ctrlInternationalApplicationInfo1.lblExpirationDate.Text);
            _InterLicense.LicenseID = _LocalLicenseID;
            _InterLicense.IsActive = true;

        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            int applicationID =-1;
            if (MessageBox.Show($"Are you sure you want to issue international license for licenseID={_LocalLicenseID}", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                return;

            if (_Application.Save())
            {
                applicationID = _Application.ApplicationID;
            }

            if (applicationID != -1)
                _InterLicense.ApplicationId = applicationID;
            else
            {
                MessageBox.Show("Failed to issue application for international license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_InterLicense.Save())
            {
                ctrlInternationalApplicationInfo1.lblIntLicenseID.Text = _InterLicense.InternationalLicenseID.ToString();
                ctrlInternationalApplicationInfo1.lblILAppID.Text = _InterLicense.ApplicationId.ToString();

                MessageBox.Show($"Internationl license issued successfully with ID={_InterLicense.InternationalLicenseID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clsApplication.UpdateApplicationStatus(applicationID, 3);
                llShowLicense.Enabled = true;
            }
            else
                MessageBox.Show($"Fail to issue internationl license", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory licenseHistory = new frmLicenseHistory(_PersonID);
            licenseHistory.ShowDialog();
        }

        private void llShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            frmShowInternationalLicenseCard internationalLicense = new frmShowInternationalLicenseCard(_InterLicenseID);
            internationalLicense.ShowDialog();
        }
    }
}
