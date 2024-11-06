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
