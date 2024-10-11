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
using DVLD_View.Globals;

namespace DVLD_View.User
{
	public partial class frmAddUpdateUser : Form
	{
		enum enMode { AddNew = 1, Update =2}
		enMode _Mode = enMode.AddNew;
		private clsUser _User;
		private int _UserId;


		public frmAddUpdateUser()
		{
			InitializeComponent();
			_Mode = enMode.AddNew;
		}

		public frmAddUpdateUser(int userId)
		{
			InitializeComponent();
			_UserId = userId;
			_Mode = enMode.Update;
		}

		private void _ResetDefualtValues()
		{
			//this will initialize the reset the defaule values

			if (_Mode == enMode.AddNew)
			{
				lblMode.Text = "Add New User";
				this.Text = "Add New User";
				_User = new clsUser();

				tpLoginInfo.Enabled = false;

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
			chkIsActive.Checked = true;


		}

		private void _LoadData()
		{

			_User = clsUser.Find(_UserId);
			ctrlPersonCardWithFilter1.FilterEnabled = false;

			if (_User == null)
			{
				MessageBox.Show("No User with ID = " + _User, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.Close();

				return;
			}

			//the following code will not be executed if the person was not found
			lblUserID.Text = _User.UserID.ToString();
			txtUserName.Text = _User.Username;
			txtPassword.Text = _User.Password;
			txtConfirmPassword.Text = _User.Password;
			chkIsActive.Checked = _User.IsActive;
			ctrlPersonCardWithFilter1.LoadPersonInfo(_User.PersonID);
			
		}

		private void frmAddUpdateUser_Load(object sender, EventArgs e)
		{
			_ResetDefualtValues();
			if(_Mode == enMode.Update)
				_LoadData();
		}

		private void txtUserName_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
			{
				e.Cancel = true;
				errorProvider1.SetError(txtUserName, "Username is required!");
				return;
			}
			else
			{
				errorProvider1.SetError(txtUserName, null);
			};

			if (txtUserName.Text.Trim() != _User.Username && clsUser.IsUserExist(txtUserName.Text.Trim()))
			{
				e.Cancel = true;
				errorProvider1.SetError(txtUserName, "Username already exist!");
			}
			else
			{
				errorProvider1.SetError(txtUserName, null);
			};
		}

		private void txtPassword_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
			{
				e.Cancel = true;
				errorProvider1.SetError(txtPassword, "Password is required!");
				return;
			}
			else
			{
				errorProvider1.SetError(txtPassword, null);
			};
		}

		private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
		{
			if (txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
			{
				e.Cancel = true;
				errorProvider1.SetError(txtConfirmPassword, "Password doesn't match!");
			}
			else
			{
				errorProvider1.SetError(txtConfirmPassword, null);
			};
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!this.ValidateChildren())
			{
				MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			_User.Username = txtUserName.Text.Trim();
			//_User.Password = txtPassword.Text.Trim();
			_User.Password = Global.ComputeHash(txtPassword.Text.Trim());
			_User.IsActive = chkIsActive.Checked;
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

		private void btnPersonInfoNext_Click(object sender, EventArgs e)
		{
			if (_Mode == enMode.Update)
			{
				tabControl1.SelectedTab = tpLoginInfo;
				btnSave.Enabled = true;
				tpLoginInfo.Enabled = true;
				return;
			}

			if (ctrlPersonCardWithFilter1.PersonID != -1)
			{
				if (clsUser.IsUserExistForPersonID(ctrlPersonCardWithFilter1.PersonID))
				{
					MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
					ctrlPersonCardWithFilter1.FilterFocus();
				}
				else
				{
					btnSave.Enabled = true;
					tpLoginInfo.Enabled = true;
					tabControl1.SelectedTab = tpLoginInfo;
				}
			}
			else
			{
				MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
				ctrlPersonCardWithFilter1.FilterFocus();
			}
		}

		private void frmAddUpdateUser_Activated(object sender, EventArgs e)
		{
			ctrlPersonCardWithFilter1.FilterFocus();
		}
	}
}
