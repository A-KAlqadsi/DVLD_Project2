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
    public partial class frmAddNewInternationalLicenseApp : Form
    {

        private int _InternationalLicenseID;

        public frmAddNewInternationalLicenseApp()
        {
            InitializeComponent();
        }

		private void ctrlDriverLicenseCardWithFilter1_OnLicenseSelected(object sender, ctrlDriverLicenseCardWithFilter.OnLicenseSelectedEventArgs e)
		{

			int SelectedLicenseID = e.LicenseID;

			lblLicenseID.Text = SelectedLicenseID.ToString();

			llShowLicenseHistory.Enabled = (SelectedLicenseID != -1);

			if (SelectedLicenseID == -1)

			{
				return;
			}

			//check the license class, person could not issue international license without having
			//normal license of class 3.

			if (ctrlDriverLicenseCardWithFilter1.SelectedLicenseInfo.LicenseClassID != 3)
			{
				MessageBox.Show("Selected License should be Class 3, select another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			//check if person already have an active international license
			int ActiveInternaionalLicenseID = clsInternationalLicense.GetActiveInternationalLicenseIDByDriverID(ctrlDriverLicenseCardWithFilter1.SelectedLicenseInfo.DriverID);

			if (ActiveInternaionalLicenseID != -1)
			{
				MessageBox.Show("Person already have an active international license with ID = " + ActiveInternaionalLicenseID.ToString(), "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				llShowLicense.Enabled = true;
				_InternationalLicenseID = ActiveInternaionalLicenseID;
				btnIssue.Enabled = false;
				return;
			}

			btnIssue.Enabled = true;
		}

		private void frmAddNewInternationalLicenseApp_Load(object sender, EventArgs e)
        {
			lblApplicationDate.Text = Format.DateToShort(DateTime.Now);
			lblIssueDate.Text = lblApplicationDate.Text;
			lblExpirationDate.Text = Format.DateToShort(DateTime.Now.AddYears(1));//add one year.
			lblAppFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.NewInternationalLicense).ApplicationFees.ToString();
			lblUsername.Text = Global.CurrentUser.Username;

		}


		private void btnIssue_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show($"Are you sure you want to issue international license for licenseID={_InternationalLicenseID}", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                return;

			clsInternationalLicense InternationalLicense = new clsInternationalLicense();
			//those are the information for the base application, because it inhirts from application, they are part of the sub class.

			InternationalLicense.ApplicantPersonID = ctrlDriverLicenseCardWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID;
			InternationalLicense.ApplicationDate = DateTime.Now;
			InternationalLicense.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
			InternationalLicense.LastStatusDate = DateTime.Now;
			InternationalLicense.PaidFees = clsApplicationType.Find((int)clsApplication.enApplicationType.NewInternationalLicense).ApplicationFees;
			InternationalLicense.UserID = Global.CurrentUser.UserID;


			InternationalLicense.DriverID = ctrlDriverLicenseCardWithFilter1.SelectedLicenseInfo.DriverID;
			InternationalLicense.IssuedUsingLocalLicenseID = ctrlDriverLicenseCardWithFilter1.SelectedLicenseInfo.LicenseID;
			InternationalLicense.IssueDate = DateTime.Now;
			InternationalLicense.ExpirationDate = DateTime.Now.AddYears(1);


			if (!InternationalLicense.Save())
			{
				MessageBox.Show("Failed to Issue International License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;
			}

			lblILAppID.Text = InternationalLicense.ApplicationID.ToString();
			_InternationalLicenseID = InternationalLicense.InternationalLicenseID;
			lblIntLicenseID.Text = InternationalLicense.InternationalLicenseID.ToString();
			MessageBox.Show("International License Issued Successfully with ID=" + InternationalLicense.InternationalLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

			btnIssue.Enabled = false;
			ctrlDriverLicenseCardWithFilter1.FilterEnabled = false;
			llShowLicense.Enabled = true;

		}

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory licenseHistory = new frmLicenseHistory(ctrlDriverLicenseCardWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            licenseHistory.ShowDialog();
        }

        private void llShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {           
            frmShowInternationalLicenseCard internationalLicense = new frmShowInternationalLicenseCard(_InternationalLicenseID);
            internationalLicense.ShowDialog();
        }

		
	}
}
