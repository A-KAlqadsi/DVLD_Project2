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
    public partial class frmManageInternationalLicenseApp : Form
    {
        public frmManageInternationalLicenseApp()
        {
            InitializeComponent();
        }

		private DataTable _dtInternationalLicenseApplications;

        private void frmManageInternationalLicenseApp_Load(object sender, EventArgs e)
        {
			_dtInternationalLicenseApplications = clsInternationalLicense.GetAll();
			cbFilterInterLicenseApps.SelectedIndex = 0;

			dgvListInternationalLicenses.DataSource = _dtInternationalLicenseApplications;
			lblRecordsCount.Text = dgvListInternationalLicenses.Rows.Count.ToString();

			if (dgvListInternationalLicenses.Rows.Count > 0)
			{
				dgvListInternationalLicenses.Columns[0].HeaderText = "Int.License ID";
				dgvListInternationalLicenses.Columns[0].Width = 160;

				dgvListInternationalLicenses.Columns[1].HeaderText = "Application ID";
				dgvListInternationalLicenses.Columns[1].Width = 150;

				dgvListInternationalLicenses.Columns[2].HeaderText = "Driver ID";
				dgvListInternationalLicenses.Columns[2].Width = 130;

				dgvListInternationalLicenses.Columns[3].HeaderText = "L.License ID";
				dgvListInternationalLicenses.Columns[3].Width = 130;

				dgvListInternationalLicenses.Columns[4].HeaderText = "Issue Date";
				dgvListInternationalLicenses.Columns[4].Width = 180;

				dgvListInternationalLicenses.Columns[5].HeaderText = "Expiration Date";
				dgvListInternationalLicenses.Columns[5].Width = 180;

				dgvListInternationalLicenses.Columns[6].HeaderText = "Is Active";
				dgvListInternationalLicenses.Columns[6].Width = 120;

			}
		}

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddNewInternationalLicenseApp addEdit = new frmAddNewInternationalLicenseApp();
            addEdit.ShowDialog();
            frmManageInternationalLicenseApp_Load(null,null);

        }

        private void cbFilterInterLicenseApps_SelectedIndexChanged(object sender, EventArgs e)
        {
			if (cbFilterInterLicenseApps.Text == "Is Active")
			{
				txtFilter.Visible = false;
				cbActivityFilter.Visible = true;
				cbActivityFilter.Focus();
				cbActivityFilter.SelectedIndex = 0;
			}

			else

			{

				txtFilter.Visible = (cbFilterInterLicenseApps.Text != "None");
				cbActivityFilter.Visible = false;

				if (cbActivityFilter.Text == "None")
				{
					txtFilter.Enabled = false;
					//_dtDetainedLicenses.DefaultView.RowFilter = "";
					//lblTotalRecords.Text = dgvDetainedLicenses.Rows.Count.ToString();

				}
				else
					txtFilter.Enabled = true;

				txtFilter.Text = "";
				txtFilter.Focus();
			}
		}

        private void cbActivityFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
			string FilterColumn = "IsActive";
			string FilterValue = cbActivityFilter.Text;

			switch (FilterValue)
			{
				case "All":
					break;
				case "Yes":
					FilterValue = "1";
					break;
				case "No":
					FilterValue = "0";
					break;
			}


			if (FilterValue == "All")
				_dtInternationalLicenseApplications.DefaultView.RowFilter = "";
			else
				//in this case we deal with numbers not string.
				_dtInternationalLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

			lblRecordsCount.Text = _dtInternationalLicenseApplications.Rows.Count.ToString();

		}

		private void txtFilter_TextChanged(object sender, EventArgs e)
        {

			string FilterColumn = "";
			//Map Selected Filter to real Column name 
			switch (cbFilterInterLicenseApps.Text)
			{
				case "International License ID":
					FilterColumn = "InternationalLicenseID";
					break;
				case "Application ID":
					{
						FilterColumn = "ApplicationID";
						break;
					};

				case "Driver ID":
					FilterColumn = "DriverID";
					break;

				case "Local License ID":
					FilterColumn = "IssuedUsingLocalLicenseID";
					break;

				case "Is Active":
					FilterColumn = "IsActive";
					break;


				default:
					FilterColumn = "None";
					break;
			}


			//Reset the filters in case nothing selected or filter value conains nothing.
			if (txtFilter.Text.Trim() == "" || FilterColumn == "None")
			{
				_dtInternationalLicenseApplications.DefaultView.RowFilter = "";
				lblRecordsCount.Text = dgvListInternationalLicenses.Rows.Count.ToString();
				return;
			}

			_dtInternationalLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text.Trim());

			lblRecordsCount.Text = _dtInternationalLicenseApplications.Rows.Count.ToString();

		}

		private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}
		
		private void tsmiShowPersonDetails_Click(object sender, EventArgs e)
        {
            int driverID = (int)dgvListInternationalLicenses.CurrentRow.Cells[2].Value;
            int personId = clsDriver.Find(driverID).PersonID;
            frmPersonDetails person = new frmPersonDetails(personId);
            person.ShowDialog();
        }

        private void tsmiShowLicenseDetails_Click(object sender, EventArgs e)
        {
            int intLicenseID = (int)dgvListInternationalLicenses.CurrentRow.Cells[0].Value;
            frmShowInternationalLicenseCard card = new frmShowInternationalLicenseCard(intLicenseID);
            card.ShowDialog();

        }

        private void tsmiShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            int driverID = (int)dgvListInternationalLicenses.CurrentRow.Cells[2].Value;
            int personId = clsDriver.Find(driverID).PersonID;
            frmLicenseHistory licenesHistory = new frmLicenseHistory(personId);
            licenesHistory.ShowDialog();
        }
    }
}
