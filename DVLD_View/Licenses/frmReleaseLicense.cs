using DVLD_Business;
using DVLD_View.Globals;
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
    public partial class frmReleaseLicense : Form
    {
        private int _LocalLicenseID;

        public frmReleaseLicense(int licenseID)
        {
            InitializeComponent();
            _LocalLicenseID = licenseID;
            ctrlDriverLicenseCardWithFilter1.LoadLicenseInfo(_LocalLicenseID);
            ctrlDriverLicenseCardWithFilter1.FilterEnabled = false;
        }
		public frmReleaseLicense()
		{
			InitializeComponent();

		}

		private void ctrlDriverLicenseCardWithFilter1_OnLicenseSelected(object sender, ctrlDriverLicenseCardWithFilter.OnLicenseSelectedEventArgs e)
		{
            _LocalLicenseID = e.LicenseID;

            llShowLicenseHistory.Enabled = (_LocalLicenseID != -1);
            
            if(_LocalLicenseID == -1)
            {
				return;
			}

            if(!ctrlDriverLicenseCardWithFilter1.SelectedLicenseInfo.IsDetained)
            {
				MessageBox.Show("Selected License is not detained, choose another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

            lblApplicationFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.ReleaseDetainedDrivingLicense).ApplicationFees.ToString();
            lblLicenseID.Text = _LocalLicenseID.ToString();
            lblUsername.Text = ctrlDriverLicenseCardWithFilter1.SelectedLicenseInfo.DetainedLicenseInfo.CreatedByUserInfo.Username;
            lblDetainDate.Text = Format.DateToShort(DateTime.Now);
            lblDetainID.Text = ctrlDriverLicenseCardWithFilter1.SelectedLicenseInfo.DetainedLicenseInfo.DetainID.ToString();
            lblFineFees.Text = ctrlDriverLicenseCardWithFilter1.SelectedLicenseInfo.DetainedLicenseInfo.FineFees.ToString();
            lblTotalFees.Text = (Convert.ToSingle(lblFineFees.Text) + Convert.ToSingle(lblApplicationFees.Text)).ToString();

            btnRelease.Enabled = true;

		}

		private void btnRelease_Click(object sender, EventArgs e)
        {

			if (MessageBox.Show("Are you sure you want to release this detained  license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
			{
				return;
			}
			int applicationID = -1;

            bool isReleased = ctrlDriverLicenseCardWithFilter1.SelectedLicenseInfo.ReleaseDetainedLicense(Global.CurrentUser.UserID, ref applicationID);
            if(!isReleased)
            {
				MessageBox.Show("Failed to to release the Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			MessageBox.Show("Detained License released Successfully ", "Detained License Released", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            btnRelease.Enabled = false;
            llShowLicense.Enabled =true;
            ctrlDriverLicenseCardWithFilter1.FilterEnabled = false;
			ctrlDriverLicenseCardWithFilter1.LoadLicenseInfo(_LocalLicenseID);

		}

		private void llShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseCard license = new frmShowLicenseCard(_LocalLicenseID);
            license.ShowDialog();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory licenseHistory = new frmLicenseHistory(ctrlDriverLicenseCardWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            licenseHistory.ShowDialog();
        }

		private void frmReleaseLicense_Activated(object sender, EventArgs e)
		{
			ctrlDriverLicenseCardWithFilter1.txtLicenseIDFocus();
		}
	}
}
