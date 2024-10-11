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
    public partial class frmChangePassword : Form
    {
        private int _UserID;
        private clsUser _User;

        public frmChangePassword(int userID)
        {
            InitializeComponent();
            _UserID = userID;
        }

        private void _ResetDefaultValues()
        {
			txtCurrentPassword.Clear();
			txtNewPassword.Clear();
			txtConfirmPassword.Clear();
			txtCurrentPassword.Focus();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
			if (!this.ValidateChildren())
			{
				MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			_User.Password= Global.ComputeHash(txtNewPassword.Text.Trim());

            if (_User.Save())
            {
                MessageBox.Show("Password updated successfully", "Save Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefaultValues();
            }
            else
                MessageBox.Show("Password update fail", "Save Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

			_User = clsUser.Find(_UserID);

			if (_User == null)
			{
				MessageBox.Show($"This screen will be closed because no User with ID=[{_UserID}]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
				return;
			}

			ctrlUserPersonCard1.LoadUserInfo(_User.UserID);
		}

		private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
		{
            if (string.IsNullOrEmpty(txtCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                epPasswordValidate.SetError(txtCurrentPassword, "Current password is required!");
                return;
            }
            else
                epPasswordValidate.SetError(txtCurrentPassword, null);

            if(txtCurrentPassword.Text.Trim() != _User.Password)
            {
                e.Cancel = true;
                epPasswordValidate.SetError(txtCurrentPassword, "Current password is wrong!");
            }
            else 
                epPasswordValidate.SetError(txtCurrentPassword,null);

		}

		private void txtNewPassword_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(txtCurrentPassword.Text.Trim()))
			{
				e.Cancel = true;
				epPasswordValidate.SetError(txtCurrentPassword, "New password is required!");
				return;
			}
			else
				epPasswordValidate.SetError(txtCurrentPassword, null);
		}

		private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
		{
            if (txtConfirmPassword.Text.Trim() != txtNewPassword.Text.Trim())
            {
                e.Cancel = true;
                epPasswordValidate.SetError(txtConfirmPassword, "Confirm password doesn't match new password!");
            }
            else
                epPasswordValidate.SetError(txtConfirmPassword, null);
		}
	}
}
