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
       
        private DataTable _dtUsers;

        public frmManageUsers()
        {
            InitializeComponent();
        }
      

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _dtUsers = clsUser.GetAll();
            dgvListUsers.DataSource = _dtUsers;
            lblRecordsCount.Text = dgvListUsers.Rows.Count.ToString();
            if(dgvListUsers.Rows.Count > 0 )
            {
				dgvListUsers.Columns[0].HeaderText = "User ID";
				dgvListUsers.Columns[0].Width = 90;

				dgvListUsers.Columns[1].HeaderText = "Person ID";
                dgvListUsers.Columns[1].Width = 90; 

				dgvListUsers.Columns[2].HeaderText = "Full Name";
				dgvListUsers.Columns[2].Width = 250;

				dgvListUsers.Columns[3].HeaderText = "UserName";
				dgvListUsers.Columns[3].Width = 120;

				dgvListUsers.Columns[4].HeaderText = "Is Active";
				dgvListUsers.Columns[4].Width = 90;
			}

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void cbFilterUsers_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbFilterUsers.Text == "Is Active")
			{
				txtFilter.Visible = false;
				cbIsActiveFilter.Visible = true;
				cbIsActiveFilter.Focus();
				cbIsActiveFilter.SelectedIndex = 0;
			}
			else
			{
				cbIsActiveFilter.Visible = false;
				txtFilter.Visible = (cbFilterUsers.Text != "None");
				txtFilter.Focus();
				txtFilter.Text = "";
			}
		}

		private void cbIsActiveFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			string filterValue = cbIsActiveFilter.Text;
			string filterColumn = "IsActive";

			switch (filterValue)
			{
				case "All":
					break;
				case "Yes":
					filterValue = "1";
					break;
				case "No":
					filterValue = "0";
					break;
			}

			if (filterValue == "All")
				_dtUsers.DefaultView.RowFilter = "";
			else
				_dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, filterValue);
			lblRecordsCount.Text = dgvListUsers.Rows.Count.ToString();

		}

		private void txtFilter_TextChanged(object sender, EventArgs e)
		{
			string filterColumn = "";
			switch (cbFilterUsers.Text)
			{
				case "User ID":
					filterColumn = "UserID";
					break;
				case "Full Name":
					filterColumn = "FullName";
					break;
				case "UserName":
					filterColumn = "UserName";
					break;
				case "Person ID":
					filterColumn = "PersonID";
					break;
				default:
					filterColumn = "None";
					break;

			}

			if (txtFilter.Text.Trim() == "" || filterColumn == "None")
			{
				_dtUsers.DefaultView.RowFilter = "";
				lblRecordsCount.Text = dgvListUsers.Rows.Count.ToString();
				return;
			}

			if (filterColumn == "UserID" || filterColumn == "PersonID")
				_dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, txtFilter.Text.Trim());
			else
				_dtUsers.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", filterColumn, txtFilter.Text.Trim());
			lblRecordsCount.Text = dgvListUsers.Rows.Count.ToString();

		}

		private void tsmiShowDetails_Click(object sender, EventArgs e)
        {
            frmUserDetails user = new frmUserDetails((int)dgvListUsers.CurrentRow.Cells[0].Value);
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
            frmAddEditUser addEdit = new frmAddEditUser();
            addEdit.ShowDialog();
            frmManageUsers_Load(null, null);
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddEditUser addEdit = new frmAddEditUser();
            addEdit.ShowDialog();
			frmManageUsers_Load(null, null);
		}

		private void tsmiEdit_Click(object sender, EventArgs e)
        {
            
            frmAddEditUser addEdit = new frmAddEditUser((int)dgvListUsers.CurrentRow.Cells[0].Value);
            addEdit.ShowDialog();
			frmManageUsers_Load(null, null);
		}

		private void tsmiDelete_Click(object sender, EventArgs e)
        {
            int userID = (int)dgvListUsers.CurrentRow.Cells[0].Value;
            string userName = (string)dgvListUsers.CurrentRow.Cells[3].Value;
            
			if(clsLoginUser.LoginUser == userName)
            {
                MessageBox.Show($"[{userName}] is login in the system now, cannot be deleted", "Delete Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

			if (MessageBox.Show($"Are you sure you want to delete user with ID[{userID}]?", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				clsUser.Delete(userID);
				frmManageUsers_Load(null, null);
			}
			else
				MessageBox.Show("User cannot be deleted due to data connected to it.", "Delete Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);

		}
        
        private void tsmiChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword changePassword = new frmChangePassword((int)dgvListUsers.CurrentRow.Cells[0].Value);
            changePassword.ShowDialog();
        }

        private void tsmiSendEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet, soon will be added as feature", "Not Impelementd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void tsmiPhoneCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet, soon will be added as feature", "Not Impelementd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterUsers.Text == "User ID" || cbFilterUsers.Text == "Person ID")
               e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);					
		}
       
       
    }
}
