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
    public partial class frmDetainLicense : Form
    {
        
        private int  _LocalLicenseID;
        private int _DetainID =-1;

        public frmDetainLicense()
        {
            InitializeComponent();
        }
       
        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
			lblDetainDate.Text =Globals.Format.DateToShort(DateTime.Now);
			lblUsername.Text = Globals.Global.CurrentUser.Username;
		}

        private void btnDetain_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show($"Are you sure you want to detain license for licenseID={_LocalLicenseID}", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                return;

            _DetainID = ctrlDriverLicenseCardWithFilter1.SelectedLicenseInfo.Detain(Convert.ToSingle(txtFineFees.Text.Trim()), Global.CurrentUser.UserID);

            if(_DetainID ==-1)
            {
				MessageBox.Show("Failed to Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;
			}

			MessageBox.Show($"New detain added successfully for license with ID:{_LocalLicenseID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

			
            lblDetainID.Text = _DetainID.ToString();
            txtFineFees.Enabled =false;
            ctrlDriverLicenseCardWithFilter1.FilterEnabled = false;
            btnDetain.Enabled = false;
            llShowLicense.Enabled =true;

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

		private void ctrlDriverLicenseCardWithFilter1_OnLicenseSelected(object sender, ctrlDriverLicenseCardWithFilter.OnLicenseSelectedEventArgs e)
		{
            _LocalLicenseID = e.LicenseID;


			lblLicenseID.Text = _LocalLicenseID.ToString();

			llShowLicenseHistory.Enabled = (_LocalLicenseID != -1);

			if (_LocalLicenseID == -1)

			{
				return;
			}

            if(ctrlDriverLicenseCardWithFilter1.SelectedLicenseInfo.IsDetained )
            {
				MessageBox.Show("Selected License already detained, choose another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			txtFineFees.Focus();
			btnDetain.Enabled = true;

		}
	}
}
