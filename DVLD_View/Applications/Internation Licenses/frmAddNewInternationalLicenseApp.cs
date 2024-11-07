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
