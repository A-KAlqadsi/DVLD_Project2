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

namespace DVLD_View
{
    public partial class frmChangePassword : Form
    {
        private int _UserID;
        private clsUser _User;
        private bool _IsEmpty = false;
        public frmChangePassword(int userID)
        {
            InitializeComponent();
            _UserID = userID;
        }

        private void _LoadData()
        {
            _User = clsUser.Find(_UserID);

            if (_User == null)
            {
                MessageBox.Show($"This screen will be closed because no User with ID=[{_UserID}]","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ctrlUserPersonCard1.LoadUserInfo(_User.UserID);

        }

        private bool _IsFieldsEmpty()
        {
            epPasswordValidate.Clear();
            if (txtCurrentPassword.Text.Trim() == "")
            {
                _IsEmpty = true;
                epPasswordValidate.SetError(txtCurrentPassword, "Current password is required!");
            }
            if (txtNewPassword.Text.Trim() == "")
            {
                _IsEmpty = true;
                epPasswordValidate.SetError(txtNewPassword, "New password is required!!");
            }
            if (txtConfirmPassword.Text.Trim() == "")
            {
                _IsEmpty = true;
                epPasswordValidate.SetError(txtConfirmPassword, "Confirm password is required!!");
            }
            return _IsEmpty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(_IsFieldsEmpty())
            {
                _IsEmpty = false;
                return;
            }

            if(_User.Password != txtCurrentPassword.Text)
            {
                epPasswordValidate.SetError(txtCurrentPassword, "Current password is wrong!");
                return;
            }

            if(txtNewPassword.Text != txtConfirmPassword.Text)
            {
                epPasswordValidate.SetError(txtConfirmPassword, "Confirm password dosn't match new password!");
                return;
            }
            
            _User.Password= txtNewPassword.Text;

            if(_User.Save())
                MessageBox.Show("Password updated successfully", "Save Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Password update fail", "Save Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtCurrentPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
