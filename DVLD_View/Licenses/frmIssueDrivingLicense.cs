using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DVLD_Business;
using DVLD_View.Globals;

namespace DVLD_View
{
    public partial class frmIssueDrivingLicense : Form
    {
        private int _LocalDrivingLicenseAppID;
        private clsLocalDrivingLicenseApp _LocalDrivingLicenseApp;

        public frmIssueDrivingLicense(int localDrivingLicenseAppID)
        {
            InitializeComponent();
            _LocalDrivingLicenseAppID = localDrivingLicenseAppID;
        }

      
		private void frmIssueDrivingLicense_Load(object sender, EventArgs e)
        {
            txtNotes.Focus();
			_LocalDrivingLicenseApp = clsLocalDrivingLicenseApp.Find(_LocalDrivingLicenseAppID);

            if(_LocalDrivingLicenseApp == null )
            {
				MessageBox.Show("No Application with ID=" + _LocalDrivingLicenseAppID.ToString(), "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
                return;
            }

           if(! _LocalDrivingLicenseApp.PassedAllTests())
           {
                MessageBox.Show("Person Should Pass All Tests First.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); 
                return;
           }

            int licenseId = _LocalDrivingLicenseApp.GetActiveLicenseId();
		   if ( licenseId != -1)
           {
                MessageBox.Show("Person already has an active license of this class with Id:" + licenseId.ToString(), "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
           }


			ctrlApplicationCard1.LoadApplicationInfo(_LocalDrivingLicenseAppID);
		}

        private void btnIssue_Click(object sender, EventArgs e)
        {
            int licenseId = _LocalDrivingLicenseApp.IssueDrivingLicenseForFirstTime(txtNotes.Text.Trim(), Global.CurrentUser.UserID);
			if (licenseId != -1)
			{
				MessageBox.Show("License Issued Successfully with License ID = " + licenseId.ToString(),
					"Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

				this.Close();
			}
			else
			{
				MessageBox.Show("License Was not Issued ! ",
				 "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
    }
}
