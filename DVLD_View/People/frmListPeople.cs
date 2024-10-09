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
    public partial class frmListPeople : Form
    {
        private DataTable _dtAllPeople;
        private DataTable _dtPeople;

        public frmListPeople()
        {
            InitializeComponent();
        }

        private void frmListPeople_Load(object sender, EventArgs e)
        {
			cbFilterPeople.SelectedIndex = 0;
            _dtAllPeople = clsPerson.GetAll();
            _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                       "FirstName", "SecondName", "ThirdName", "LastName",
                                                       "GenderCaption", "DateOfBirth", "CountryName",
                                                       "Phone", "Email");
            dgvListPeople.DataSource = _dtPeople;

            lblRecordsCount.Text = dgvListPeople.Rows.Count.ToString();
            if (dgvListPeople.Rows.Count > 0)
            {
				dgvListPeople.Columns[0].HeaderText = "Person ID";
				dgvListPeople.Columns[0].Width = 100;

				dgvListPeople.Columns[1].HeaderText = "National No.";
				dgvListPeople.Columns[1].Width = 110;


				dgvListPeople.Columns[2].HeaderText = "First Name";
				dgvListPeople.Columns[2].Width = 120;

				dgvListPeople.Columns[3].HeaderText = "Second Name";
				dgvListPeople.Columns[3].Width = 120;


				dgvListPeople.Columns[4].HeaderText = "Third Name";
				dgvListPeople.Columns[4].Width = 110;

				dgvListPeople.Columns[5].HeaderText = "Last Name";
				dgvListPeople.Columns[5].Width = 120;

				dgvListPeople.Columns[6].HeaderText = "Gender";
				dgvListPeople.Columns[6].Width = 100;

				dgvListPeople.Columns[7].HeaderText = "Date Of Birth";
				dgvListPeople.Columns[7].Width = 150;

				dgvListPeople.Columns[8].HeaderText = "Nationality";
				dgvListPeople.Columns[8].Width = 100;


				dgvListPeople.Columns[9].HeaderText = "Phone";
				dgvListPeople.Columns[9].Width = 100;


				dgvListPeople.Columns[10].HeaderText = "Email";
				dgvListPeople.Columns[10].Width = 160;
			}

			     
        }

		//Filter part
		private void cbFilterPeople_SelectedIndexChanged(object sender, EventArgs e)
		{
			txtFilter.Visible = (cbFilterPeople.Text != "None");
			txtFilter.Text = "";
			if (txtFilter.Visible)
			{
				txtFilter.Focus();
			}
			
		}

		private void txtFilter_TextChanged(object sender, EventArgs e)
		{
			string FilterColumn = "";

			switch (cbFilterPeople.Text)
			{
				case "Person ID":
					FilterColumn = "PersonID";
					break;

				case "National No.":
					FilterColumn = "NationalNo";
					break;

				case "First Name":
					FilterColumn = "FirstName";
					break;

				case "Second Name":
					FilterColumn = "SecondName";
					break;

				case "Third Name":
					FilterColumn = "ThirdName";
					break;

				case "Last Name":
					FilterColumn = "LastName";
					break;

				case "Nationality":
					FilterColumn = "CountryName";
					break;

				case "Gender":
					FilterColumn = "GenderCaption";
					break;

				case "Phone":
					FilterColumn = "Phone";
					break;

				case "Email":
					FilterColumn = "Email";
					break;

				default:
					FilterColumn = "None";
					break;

			}
			if (txtFilter.Text.Trim() == "" || FilterColumn == "None")
			{
				_dtPeople.DefaultView.RowFilter = "";
				lblRecordsCount.Text = dgvListPeople.Rows.Count.ToString();
				return;
			}

			if (FilterColumn == "PersonID")
				_dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text.Trim());
			else
				_dtPeople.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterColumn, txtFilter.Text.Trim());

			lblRecordsCount.Text = dgvListPeople.Rows.Count.ToString();
		}


		private void tsmiShowDetails_Click(object sender, EventArgs e)
        {
            int personID =(int)dgvListPeople.CurrentRow.Cells[0].Value;
            frmPersonDetails personDetails = new frmPersonDetails(personID);
            personDetails.ShowDialog();
            personDetails.StartPosition = FormStartPosition.CenterParent;
        }

        private void tsmiAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson addEditPerson = new frmAddEditPerson();
            addEditPerson.ShowDialog();
            frmListPeople_Load(null, null);
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("edit person will be here");
            int iD = (int)dgvListPeople.CurrentRow.Cells[0].Value;
            frmAddEditPerson addEdit = new frmAddEditPerson(iD);
            addEdit.ShowDialog();
			frmListPeople_Load(null, null);
		}

		private void tsmiDelete_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Delete person will be here");
            int iD = (int)dgvListPeople.CurrentRow.Cells[0].Value;
            
            if(MessageBox.Show($"Are you sure you want to delete Person with ID=[{iD}]","Confirm Delete",MessageBoxButtons.OKCancel,MessageBoxIcon.Information)== DialogResult.OK)
            {
                if (clsPerson.Delete(iD))
                {
                    MessageBox.Show($"Delete person with ID = [{iD}] success!", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmListPeople_Load(null, null);
                }
                else
                {
                    MessageBox.Show($"Delete person with ID = [{iD}] fail!", "Delete Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsmiSendEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("send email to person will be here");

        }

        private void tsmiPhoneCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show("call phone to person will be here");

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this button is not work");            
        }


		private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (cbFilterPeople.SelectedIndex == 1)
			{
				if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
					e.Handled = true;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnAddPerson_Click(object sender, EventArgs e)
		{
			frmAddEditPerson frm = new frmAddEditPerson();
			frm.ShowDialog();
			frmListPeople_Load(null, null);
		}
	}
}
