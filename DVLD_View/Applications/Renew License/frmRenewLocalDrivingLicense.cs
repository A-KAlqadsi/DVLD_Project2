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
    public partial class frmRenewLocalDrivingLicense : Form
    {
        
        private int _NewLicenseID = -1;

        public frmRenewLocalDrivingLicense()
        {
            InitializeComponent();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
			if (MessageBox.Show("Are you sure you want to Renew the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
			{
				return;
			}

			clsLicense newLicense =
				ctrlDriverLicenseCardWithFilter1.SelectedLicenseInfo.
				RenewLicense(txtNotes.Text.Trim(), Global.CurrentUser.UserID);

			if(newLicense == null)
			{
				MessageBox.Show("Failed to Renew the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;
			}

			lblRLAppID.Text = newLicense.ApplicationId.ToString();
			_NewLicenseID = newLicense.LicenseID;
			lblRenewedLicenseID.Text = _NewLicenseID.ToString();
			MessageBox.Show("Licensed Renewed Successfully with ID=" + _NewLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

			btnIssue.Enabled = false;
			ctrlDriverLicenseCardWithFilter1.FilterEnabled = false;
			llShowLicense.Enabled = true;

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
            frmLicenseHistory history = new frmLicenseHistory(ctrlDriverLicenseCardWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            history.ShowDialog();
        }

		private void ctrlDriverLicenseCardWithFilter1_OnLicenseSelected(object sender, ctrlDriverLicenseCardWithFilter.OnLicenseSelectedEventArgs e)
		{
			int SelectedLicenseID = e.LicenseID;

			lblOldLicenseID.Text = SelectedLicenseID.ToString();

			llShowLicenseHistory.Enabled = (SelectedLicenseID != -1);

			if (SelectedLicenseID == -1)

			{
				return;
			}
			int DefaultValidityLength = ctrlDriverLicenseCardWithFilter1.SelectedLicenseInfo.LicenseClassInfo.ValidityLength;
			lblExpirationDate.Text = Format.DateToShort(DateTime.Now.AddYears(DefaultValidityLength));
			lblLicenseFees.Text = ctrlDriverLicenseCardWithFilter1.SelectedLicenseInfo.LicenseClassInfo.ClassFees.ToString();
			lblTotalFees.Text = (Convert.ToSingle(lblAppFees.Text) + Convert.ToSingle(lblLicenseFees.Text)).ToString();
			txtNotes.Text = ctrlDriverLicenseCardWithFilter1.SelectedLicenseInfo.Notes;

            if(!ctrlDriverLicenseCardWithFilter1.SelectedLicenseInfo.IsLicenseExpired())
            {
				MessageBox.Show("Selected License is not yet expired, it will expire on: " + Format.DateToShort(ctrlDriverLicenseCardWithFilter1.SelectedLicenseInfo.ExpirationDate)
					, "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				btnIssue.Enabled = false;
				return;
			}

            if(!ctrlDriverLicenseCardWithFilter1.SelectedLicenseInfo.IsActive)
            {
				MessageBox.Show("Selected License is not Not Active, choose an active license."
					, "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				btnIssue.Enabled = false;
				return;
			}

			btnIssue.Enabled = true;

		}

		private void frmRenewLocalDrivingLicense_Load(object sender, EventArgs e)
		{
			llShowLicense.Enabled = false;

            ctrlDriverLicenseCardWithFilter1.txtLicenseIDFocus();

            lblApplicationDate.Text = Format.DateToShort(DateTime.Now);
            lblIssueDate.Text = lblApplicationDate.Text;
            lblExpirationDate.Text = "????";
            lblAppFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.RenewDrivingLicense).ApplicationFees.ToString();

            lblUsername.Text = Global.CurrentUser.Username;

		}
	}
}
