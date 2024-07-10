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
        private int _PersonID = -1;
        private string _UserName;
        private int _UserPersonID;
        private int _UserID;
        private clsUser _User;
        private bool _IsEmpty = false;
        
        public frmAddEditUser(int userID)
        {
            InitializeComponent();
            _UserID = userID;
            if (_UserID == -1)
                _Mode = enMode.AddNew;
            else 
                _Mode = enMode.Update;
        }

        private void _LoadData()
        {
            if(_Mode == enMode.AddNew)
            {
                _User = new clsUser();
                this.Text = "Add User";
                lblMode.Text = "Add New User";
                return;
            }

            _User = clsUser.Find(_UserID);
            if (_User == null)
            {
                MessageBox.Show($"This form will be closed because no user with ID=[{_UserID}]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblMode.Text = "Edit User";
            this.Text = "Edit User";
            _UserPersonID = _User.PersonID;
            ctrlPersonCard1.LoadPersonInfo(_UserPersonID);

            lblUserID.Text =_User.UserID.ToString();
            _UserName = _User.Username;
            txtUserName.Text = _User.Username;
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            chbIsActive.Checked = _User.IsActive;

        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnSelectPerson_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Select a person will be here ");
            frmFindPerson findPerson = new frmFindPerson();
            findPerson.evPersonIDBack += _evPersonIDBack;
            
            findPerson.ShowDialog();
        }

        private void _evPersonIDBack(int personID)
        {
            if(personID!= -1)
            {
                _PersonID = personID;
                ctrlPersonCard1.LoadPersonInfo(personID);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Next button will be here ");
            if(_PersonID != -1)
            {
                if (clsUser.IsPersonUserExist(_PersonID) && _PersonID != _UserPersonID)
                {
                    MessageBox.Show($"Person with ID=[{_PersonID}] already has user account!", "Save Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            tcUserInfo.SelectedTab = tpLoginInfo;
        }
        
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tcUserInfo.SelectedTab = tpPersonalInfo;
        }

        private bool _IsFieldsEmpty()
        {
            epLoginInfoValidate.Clear();
            if(txtUserName.Text.Trim() == "")
            {
                _IsEmpty = true;
                epLoginInfoValidate.SetError(txtUserName, "User name is required!");
            }
            if(txtPassword.Text.Trim() == "")
            {
                _IsEmpty = true;
                epLoginInfoValidate.SetError(txtPassword, "Password is required!!");
            }
            if (txtConfirmPassword.Text.Trim() == "")
            {
                _IsEmpty = true;
                epLoginInfoValidate.SetError(txtConfirmPassword, "Confirm password is required!!");
            }
            return _IsEmpty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Save user will be here ");
            if(_PersonID == -1 && _Mode == enMode.AddNew)
            {
                MessageBox.Show("Select personal Info first!", "Save Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tcUserInfo.SelectedTab = tpPersonalInfo;
                return;
            }

            if(clsUser.IsPersonUserExist(_PersonID) && _PersonID != _UserPersonID)
            {
                MessageBox.Show($"Person with ID=[{_PersonID}] already has user account!", "Save Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(_IsFieldsEmpty())
            {
                tcUserInfo.SelectedTab = tpLoginInfo;
                _IsEmpty = false;
                return;
            }

            if(clsUser.IsUserExist(txtUserName.Text.ToString()) && txtUserName.Text.ToString() != _UserName)
            {
                epLoginInfoValidate.SetError(txtUserName, "Username already exist!");
                return;
            }

            if(txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                epLoginInfoValidate.SetError(txtConfirmPassword, "Confirm password dosn't match password!");
                return;
            }
            
            _User.Username = txtUserName.Text.ToString();
            _User.Password = txtPassword.Text.ToString();
            
            if(_PersonID != -1)
                _User.PersonID = _PersonID;
            else 
                _User.PersonID = _UserPersonID;

            _User.IsActive = chbIsActive.Checked;

            if (_User.Save())
                MessageBox.Show("New user added successfully", "Save Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("New user save failed!!", "Save Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            lblMode.Text = "Edit User";
            lblUserID.Text = _User.UserID.ToString();
            _UserID = _User.UserID;
            _UserName = _User.Username;
            _UserPersonID =_User.PersonID;
            _Mode = enMode.Update;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
