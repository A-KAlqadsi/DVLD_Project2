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
    public partial class frmDetainLicense : Form
    {
        
        private bool _IsDetained;
        private bool _IsFound;
        private int  _LocalLicenseID;
        private int  _PersonID = -1;
        clsDetainedLicense _DetainLicense;
        private int _DetainID =-1;

        public frmDetainLicense()
        {
            InitializeComponent();
        }

        private void _SetDefaults()
        {
            lblDetainDate.Text = DateTime.Now.ToShortDateString();
            lblUsername.Text = clsLoginUser.LoginUser;
            ctrlDriverLicenseCardWithFilter1.txtSearchLicenseID.Focus();
            txtFineFees.Enabled = true;
        }

        private void ctrlDriverLicenseCardWithFilter1_OnLicenseSelected(int obj)
        {
            txtFineFees.Enabled = true;
            txtFineFees.Focus();

            _LocalLicenseID = obj;
            _IsFound = ctrlDriverLicenseCardWithFilter1.IsFound;
            _IsDetained = ctrlDriverLicenseCardWithFilter1.IsDetained;

            if (!_IsFound)
                return;

            llShowLicenseHistory.Enabled = true;
            lblLicenseID.Text = _LocalLicenseID.ToString();

            if (_IsDetained)
            {
                MessageBox.Show($"Selected license is already detained!, select another one!", "Not allowd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_IsFound && !_IsDetained)
            {
                btnDetain.Enabled = true;
            }
            else
            {
                btnDetain.Enabled = false;
            }

            _DetainLicense = new clsDetainedLicense();

            _DetainLicense.LicenseID = _LocalLicenseID;
            _DetainLicense.ReleaseID = -1;
            _DetainLicense.DetainDate = Convert.ToDateTime(lblDetainDate.Text);
            _DetainLicense.UserID = clsUser.Find(clsLoginUser.LoginUser).UserID;


        }

        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            _SetDefaults();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if(clsLicense.IsLicenseDetained(_LocalLicenseID))
            {
                MessageBox.Show($"Selected license is already detained!, select another one!", "Not allowd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDetain.Enabled = false;
                return;
            }

            if (string.IsNullOrEmpty(txtFineFees.Text))
            {
                MessageBox.Show("Add the fines fees first!", "Not Allowd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Are you sure you want to renew license for licenseID={_LocalLicenseID}", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                return;

            float fineFees = Convert.ToSingle(txtFineFees.Text);
            _DetainLicense.FineFees = fineFees;

            if (_DetainLicense.Save())
            {
                MessageBox.Show($"New detaind added successfully for license with ID:{_LocalLicenseID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                llShowLicense.Enabled = true;
            }
            else
                MessageBox.Show("Adding detained failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            _DetainID = _DetainLicense.DetainID;
            lblDetainID.Text = _DetainID.ToString();
            txtFineFees.Enabled =false;


        }

        private void llShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseCard license = new frmShowLicenseCard(_LocalLicenseID);
            license.ShowDialog();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory licenseHistory = new frmLicenseHistory(_LocalLicenseID);
            licenseHistory.ShowDialog();
        }
    }
}
