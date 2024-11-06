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
using static DVLD_Business.clsLicense;

namespace DVLD_View
{
    public partial class frmReplacementForDamageOrLost : Form
    {
        private int _NewLicenseID = -1;

        public frmReplacementForDamageOrLost()
        {
            InitializeComponent();

        }

		private int _GetApplicationTypeID()
		{
			//this will decide which application type to use accirding 
			// to user selection.

			if (rbDamageLicense.Checked)

				return (int)clsApplication.enApplicationType.ReplaceDamagedDrivingLicense;
			else
				return (int)clsApplication.enApplicationType.ReplaceLostDrivingLicense;
		}

		private enIssueReason _GetIssueReason()
		{
			//this will decide which reason to issue a replacement for

			if (rbDamageLicense.Checked)

				return enIssueReason.DamagedReplacement;
			else
				return enIssueReason.LostReplacement;
		}

		private void rbDamageLicense_CheckedChanged(object sender, EventArgs e)
        {
            lblMode.Text = "Replacement For Damage License";
			this.Text = lblMode.Text;
			lblAppFees.Text = clsApplicationType.Find(_GetApplicationTypeID()).ApplicationFees.ToString();

		}

		private void rbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            lblMode.Text = "Replacement For Lost License";
			this.Text = lblMode.Text;
			lblAppFees.Text = clsApplicationType.Find(_GetApplicationTypeID()).ApplicationFees.ToString();

		}

		private void btnIssue_Click(object sender, EventArgs e)
        {
			if (MessageBox.Show("Are you sure you want to Renew the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
			{
				return;
			}

			clsLicense newLicense = ctrlDriverLicenseCardWithFilter1.SelectedLicenseInfo.Replace(_GetIssueReason(), Global.CurrentUser.UserID);

			if (newLicense == null)
			{
				MessageBox.Show("Failed to Renew the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;
			}

			lblRLAppID.Text = newLicense.ApplicationId.ToString();
			lblReplacedLicenseID.Text = newLicense.LicenseID.ToString();
			_NewLicenseID= newLicense.LicenseID;

			MessageBox.Show("Licensed Replaced Successfully with ID=" + _NewLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

			btnIssue.Enabled = false;
			gbApplicationInfoForLicenseReplacement.Enabled = false;
			ctrlDriverLicenseCardWithFilter1.FilterEnabled = false;
			llShowLicense.Enabled = true;

		}

        private void frmReplacementForDamageOrLost_Load(object sender, EventArgs e)
        {
			llShowLicense.Enabled = false;
			lblApplicationDate.Text = Format.DateToShort(DateTime.Now);
			lblUsername.Text = Global.CurrentUser.Username;

			rbDamageLicense.Checked = true;
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

			if (!ctrlDriverLicenseCardWithFilter1.SelectedLicenseInfo.IsActive)
			{
				MessageBox.Show("Selected License is not Not Active, choose an active license."
					, "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				btnIssue.Enabled = false;
				return;
			}

			btnIssue.Enabled = true;


		}
	}
}
