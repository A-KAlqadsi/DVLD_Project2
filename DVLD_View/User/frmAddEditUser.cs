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
    public partial class frmAddEditUser : Form
    {
        public enum enMode { AddNew =1,Update =2}
        enMode _Mode;
        
        private int _UserID;
        private clsUser _User;
        
        public frmAddEditUser()
        {
            InitializeComponent();
            
            _Mode = enMode.AddNew;
        }

		public frmAddEditUser(int userID)
		{
			InitializeComponent();
			_UserID = userID;
            _Mode = enMode.Update;
		}

        private void _ResetDefaultValues()
        {
			if (_Mode == enMode.AddNew)
			{
				_User = new clsUser();
				lblMode.Text = "Add New User";
				this.Text = "Add New User";
                tpLoginInfo.Enabled = false;
                btnSave.Enabled = false;
                ctrlPersonCardWithFilter1.FilterFocus();
			}
			else
			{
				lblMode.Text = "Update User";
				this.Text = "Update User";
				tpLoginInfo.Enabled = true;
				btnSave.Enabled = true;

			}

            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            chbIsActive.Checked = true;
		}

		private void _LoadData()
        {
            ctrlPersonCardWithFilter1.FilterEnabled = false;
			_User = clsUser.Find(_UserID);
            if (_User == null)
            {
                MessageBox.Show($"This form will be closed because no user with ID=[{_UserID}]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

			ctrlPersonCardWithFilter1.LoadPersonInfo(_User.PersonID);
			lblUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.Username;
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            chbIsActive.Checked = _User.IsActive;

        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if(_Mode == enMode.Update)
                _LoadData();
        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {
			if (!this.ValidateChildren())
			{
				MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

            _User.Username = txtUserName.Text.Trim();
            _User.Password = txtPassword.Text.Trim();
            _User.IsActive = chbIsActive.Checked;
            _User.PersonID = ctrlPersonCardWithFilter1.PersonID;

			if (_User.Save())
            {
				lblUserID.Text = _User.UserID.ToString();
                ctrlPersonCardWithFilter1.FilterEnabled = false;
				_Mode = enMode.Update;
				lblMode.Text = "Update User";
				this.Text = "Update User";
				
                MessageBox.Show("New user added successfully", "Save Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
                MessageBox.Show("New user save failed!!", "Save Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
           if(_Mode == enMode.Update)
           {
                tcUserInfo.SelectedTab = tpLoginInfo;
                btnSave.Enabled = true;
                tpLoginInfo.Enabled = true;
                return;
           }

           if(ctrlPersonCardWithFilter1.PersonID != -1)
           {
                if(clsUser.IsUserExistForPersonID(ctrlPersonCardWithFilter1.PersonID))
                {
					MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
					ctrlPersonCardWithFilter1.FilterFocus();
				}
				else
				{
                    btnSave.Enabled = true;
                    tpLoginInfo.Enabled = true;
                    tcUserInfo.SelectedTab = tpLoginInfo;
				}
		   }
           else
           {
				MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
				ctrlPersonCardWithFilter1.FilterFocus();
		   }
        }

        private void btnPrevious_Click_1(object sender, EventArgs e)
        {
            tcUserInfo.SelectedTab = tpPersonalInfo;
        }

		private void txtUserName_Validating(object sender, CancelEventArgs e)
		{
            if(string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                epLoginInfoValidate.SetError(txtUserName, "Username is required!");
                return;
            }
            else
            {
                epLoginInfoValidate.SetError(txtUserName, null);
            }

            if(txtUserName.Text.Trim() != _User.Username && clsUser.IsUserExist(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                epLoginInfoValidate.SetError(txtUserName, "Username already exist!");
            }
            else
            {
                epLoginInfoValidate.SetError(txtUserName, null);
            }

		}

		private void txtPassword_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
			{
				e.Cancel = true;
				epLoginInfoValidate.SetError(txtPassword, "Password is required!");
				return;
			}
			else
			{
				epLoginInfoValidate.SetError(txtPassword, null);
			};
		}

		private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
		{
            if(txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                e.Cancel = true;
                epLoginInfoValidate.SetError(txtConfirmPassword, "Password doesn't match!");
            }
            else
            {
                epLoginInfoValidate.SetError(txtConfirmPassword, null);
            };
		}

		private void frmAddEditUser_Activated(object sender, EventArgs e)
		{
            ctrlPersonCardWithFilter1.FilterFocus();
		}
	}
}
