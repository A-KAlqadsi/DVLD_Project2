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
    public partial class frmManageUsers : Form
    {
        private DataView _DataView;
        private DataTable _DataTable;
        private clsPerson _Person;

        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void _RefreshUsers(DataView dv)
        {
            dgvListUsers.Rows.Clear();
            bool isActive;
            int counter = 0;
            if (dv != null)
                counter = dv.Count;

            for (int i = 0; i < dv.Count; i++)
            {
                
                isActive = Convert.ToBoolean(dv[i]["IsActive"]);

                dgvListUsers.Rows.Add(dv[i]["UserID"], dv[i]["PersonID"], dv[i]["FullName"], dv[i]["Username"],isActive);
            }


            lblRecordsCount.Text = counter.ToString();

        }

        private void _LoadAllUsers()
        {
            _DataTable = clsUser.GetAllMaster();
            _DataView = _DataTable.DefaultView;
            _RefreshUsers(_DataView);
        }

        private void _ResetFilter()
        {
            _LoadAllUsers();

            cbFilterUsers.SelectedIndex = 0;
            cbIsActiveFilter.SelectedIndex = 0;
            txtFilter.Clear();
            txtFilter.Visible = false;
            cbIsActiveFilter.Visible = false;
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _ResetFilter();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiShowDetails_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Show user details will be here");
            int iD =(int)dgvListUsers.CurrentRow.Cells[0].Value;
            frmUserDetails user = new frmUserDetails(iD);
            user.ShowDialog();
        }

        private void dgvListUsers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int iD = (int)dgvListUsers.CurrentRow.Cells[0].Value;
            frmUserDetails user = new frmUserDetails(iD);
            user.ShowDialog();
        }

        private void tsmiAddNewUser_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Add new user will be here");
            frmAddEditUser addEdit = new frmAddEditUser(-1);
            addEdit.ShowDialog();
            _ResetFilter();
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Add new user will be here");
            frmAddEditUser addEdit = new frmAddEditUser(-1);
            addEdit.ShowDialog();
            _ResetFilter();
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Edit user will be here");
            int userID = (int)dgvListUsers.CurrentRow.Cells[0].Value;
            frmAddEditUser addEdit = new frmAddEditUser(userID);
            addEdit.ShowDialog();
            _ResetFilter();              
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete user will be here");

        }
        private void tsmiChangePassword_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Change user password will be here");
            int userID = (int)dgvListUsers.CurrentRow.Cells[0].Value;
            frmChangePassword changePassword = new frmChangePassword(userID);
            changePassword.ShowDialog();
        }

        private void tsmiSendEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Send email to user will be here");

        }

        private void tsmiPhoneCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phone call to user will be here");

        }      

        private void cbFilterUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterUsers.SelectedItem == "None")
            {
                _ResetFilter();
            }
            else if (cbFilterUsers.SelectedItem == "Is Active")
            {
                _LoadAllUsers();
                cbIsActiveFilter.Visible = true;
                txtFilter.Visible = false;
            }
            else
            {
                cbIsActiveFilter.SelectedIndex = 0;
                txtFilter.Visible = true;
                txtFilter.Focus();
                cbIsActiveFilter.Visible = false;
            }
        }

        private void cbIsActiveFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbIsActiveFilter.SelectedIndex)
            {
                case 0:
                    _LoadAllUsers();
                    break;
                case 1:
                    _FilterByActivity(true);
                    break;
                case 2:
                    _FilterByActivity(false);
                    break;
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            switch (cbFilterUsers.SelectedIndex)
            {
                case 1:
                    {
                        if(txtFilter.Text.Trim() == "")
                        {
                            _LoadAllUsers();
                            return;
                        }
                        if(int.TryParse(txtFilter.Text.ToString(), out int userID ))
                            _FilterByUserID(userID);
                    }
                    break;
                case 2:
                    {
                        if (txtFilter.Text.Trim() == "")
                        {
                            _LoadAllUsers();
                            return;
                        }

                        if (int.TryParse(txtFilter.Text.ToString(), out int personID))
                            _FilterByPersonID(personID);
                    }
                    break;
                case 3:
                    _FilterByFullName(txtFilter.Text);
                    break;
                case 4:
                    _FilterByUsername(txtFilter.Text);
                    break;
            }
        }

        private void _FilterByUserID(int userID)
        {
            _DataView.RowFilter = $"UserID ={userID}";
            _RefreshUsers(_DataView);
        }

        private void _FilterByPersonID(int personID)
        {
            _DataView.RowFilter = $"PersonID ={personID}";
            _RefreshUsers(_DataView);
        }

        private void _FilterByFullName(string fullName)
        {
            _DataView.RowFilter = $"FullName LIKE '{fullName}%'";
            _RefreshUsers(_DataView);
        }


        private void _FilterByUsername(string username)
        {
            _DataView.RowFilter = $"Username LIKE '{username}%'";
            _RefreshUsers(_DataView);
        }

        private void _FilterByActivity(bool isAcive)
        {
            _DataView.RowFilter = $"IsActive ={isAcive}";
            _RefreshUsers(_DataView);
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            _FilterValidate(e);
        }
        private void _FilterValidate(KeyPressEventArgs e)
        {
            if(cbFilterUsers.SelectedIndex == 1 || cbFilterUsers.SelectedIndex ==2)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
        }
    }
}
