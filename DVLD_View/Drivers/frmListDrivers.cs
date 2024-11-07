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
    public partial class frmListDrivers : Form
    {
        public frmListDrivers()
        {
            InitializeComponent();
        }


        private DataTable _dtAllDrivers;

        private void frmListDrivers_Load(object sender, EventArgs e)
        {
            cbFilterDrivers.SelectedIndex = 0;
            _dtAllDrivers = clsDriver.GetAll();
            dgvListDrivers.DataSource = _dtAllDrivers;
			lblRecordsCount.Text = dgvListDrivers.Rows.Count.ToString();
			if (dgvListDrivers.Rows.Count > 0)
			{
				dgvListDrivers.Columns[0].HeaderText = "Driver ID";
				dgvListDrivers.Columns[0].Width = 125;

				dgvListDrivers.Columns[1].HeaderText = "Person ID";
				dgvListDrivers.Columns[1].Width = 125;

				dgvListDrivers.Columns[2].HeaderText = "National No.";
				dgvListDrivers.Columns[2].Width = 160;

				dgvListDrivers.Columns[3].HeaderText = "Full Name";
				dgvListDrivers.Columns[3].Width = 400;

				dgvListDrivers.Columns[4].HeaderText = "Date";
				dgvListDrivers.Columns[4].Width = 200;

				dgvListDrivers.Columns[5].HeaderText = "Active Licenses";
				dgvListDrivers.Columns[5].Width = 200;
			}


		}

		private void cbFilterDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
			txtFilter.Visible = (cbFilterDrivers.Text != "None");


			if (cbFilterDrivers.Text == "None")
			{
				txtFilter.Enabled = false;
			}
			else
				txtFilter.Enabled = true;

			txtFilter.Text = "";
			txtFilter.Focus();
		}

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

			string FilterColumn = "";
			//Map Selected Filter to real Column name 
			switch (cbFilterDrivers.Text)
			{
				case "Driver ID":
					FilterColumn = "DriverID";
					break;

				case "Person ID":
					FilterColumn = "PersonID";
					break;

				case "National No.":
					FilterColumn = "NationalNo";
					break;


				case "Full Name":
					FilterColumn = "FullName";
					break;

				default:
					FilterColumn = "None";
					break;

			}

			//Reset the filters in case nothing selected or filter value conains nothing.
			if (txtFilter.Text.Trim() == "" || FilterColumn == "None")
			{
				_dtAllDrivers.DefaultView.RowFilter = "";
				lblRecordsCount.Text = dgvListDrivers.Rows.Count.ToString();
				return;
			}


			if (FilterColumn != "FullName" && FilterColumn != "NationalNo")
				//in this case we deal with numbers not string.
				_dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text.Trim());
			else
				_dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text.Trim());

			lblRecordsCount.Text = _dtAllDrivers.Rows.Count.ToString();


		}
        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (cbFilterDrivers.SelectedIndex == 1 || cbFilterDrivers.SelectedIndex == 2 || cbFilterDrivers.SelectedIndex == 5)
			{
				e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
			}
		}
       

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmPersonDetails frm = new frmPersonDetails((int)dgvListDrivers.CurrentRow.Cells[1].Value);
			frm.ShowDialog();
		}

		private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmLicenseHistory frm = new frmLicenseHistory((int)dgvListDrivers.CurrentRow.Cells[1].Value);
			frm.ShowDialog();
		}
	}
}
