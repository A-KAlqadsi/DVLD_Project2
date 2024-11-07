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
    public partial class frmManageDetainedLicenses : Form
    {
        public frmManageDetainedLicenses()
        {
            InitializeComponent();
        }

        DataTable _dtDetainedLicenses;


        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicense detainLicense = new frmDetainLicense();
            detainLicense.ShowDialog();
            frmManageDetainedLicenses_Load(null,null);

        }

        private void btnReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            frmReleaseLicense releaseLicnse = new frmReleaseLicense();
            releaseLicnse.ShowDialog();
            frmManageDetainedLicenses_Load(null,null);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManageDetainedLicenses_Load(object sender, EventArgs e)
        {
			cbFilterDetainedLicenses.SelectedIndex = 0;

			_dtDetainedLicenses = DetainedLicense.GetAllDetainedLicenses();

			dgvListDetainedLicenses.DataSource = _dtDetainedLicenses;
			lblRecordsCount.Text = dgvListDetainedLicenses.Rows.Count.ToString();

			if (dgvListDetainedLicenses.Rows.Count > 0)
			{
				dgvListDetainedLicenses.Columns[0].HeaderText = "D.ID";
				dgvListDetainedLicenses.Columns[0].Width = 90;

				dgvListDetainedLicenses.Columns[1].HeaderText = "L.ID";
				dgvListDetainedLicenses.Columns[1].Width = 90;

				dgvListDetainedLicenses.Columns[2].HeaderText = "D.Date";
				dgvListDetainedLicenses.Columns[2].Width = 160;

				dgvListDetainedLicenses.Columns[3].HeaderText = "Is Released";
				dgvListDetainedLicenses.Columns[3].Width = 110;

				dgvListDetainedLicenses.Columns[4].HeaderText = "Fine Fees";
				dgvListDetainedLicenses.Columns[4].Width = 110;

				dgvListDetainedLicenses.Columns[5].HeaderText = "Release Date";
				dgvListDetainedLicenses.Columns[5].Width = 160;

				dgvListDetainedLicenses.Columns[6].HeaderText = "N.No.";
				dgvListDetainedLicenses.Columns[6].Width = 90;

				dgvListDetainedLicenses.Columns[7].HeaderText = "Full Name";
				dgvListDetainedLicenses.Columns[7].Width = 330;

				dgvListDetainedLicenses.Columns[8].HeaderText = "Release App.ID";
				dgvListDetainedLicenses.Columns[8].Width = 150;

			}
		}

        private void cbFilterDetainedLicenses_SelectedIndexChanged(object sender, EventArgs e)
        {
			if (cbFilterDetainedLicenses.Text == "Is Released")
			{
				txtFilter.Visible = false;
				cbIsReleaseFilter.Visible = true;
				cbIsReleaseFilter.Focus();
				cbIsReleaseFilter.SelectedIndex = 0;
			}

			else

			{

				txtFilter.Visible = (cbFilterDetainedLicenses.Text != "None");
				cbIsReleaseFilter.Visible = false;

				if (cbFilterDetainedLicenses.Text == "None")
				{
					txtFilter.Enabled = false;
					
				}
				else
					txtFilter.Enabled = true;

				txtFilter.Text = "";
				txtFilter.Focus();
			}
		}

        private void cbIsReleaseFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
			string FilterColumn = "IsReleased";
			string FilterValue = cbIsReleaseFilter.Text;

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
				_dtDetainedLicenses.DefaultView.RowFilter = "";
			else
				//in this case we deal with numbers not string.
				_dtDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

			lblRecordsCount.Text = _dtDetainedLicenses.Rows.Count.ToString();

		}

		private void txtFilter_TextChanged(object sender, EventArgs e)
        {

			string FilterColumn = "";
			//Map Selected Filter to real Column name 
			switch (cbFilterDetainedLicenses.Text)
			{
				case "Detain ID":
					FilterColumn = "DetainID";
					break;
				case "Is Released":
					{
						FilterColumn = "IsReleased";
						break;
					};

				case "National No.":
					FilterColumn = "NationalNo";
					break;


				case "Full Name":
					FilterColumn = "FullName";
					break;

				case "Release Application ID":
					FilterColumn = "ReleaseApplicationID";
					break;

				default:
					FilterColumn = "None";
					break;
			}


			//Reset the filters in case nothing selected or filter value conains nothing.
			if (txtFilter.Text.Trim() == "" || FilterColumn == "None")
			{
				_dtDetainedLicenses.DefaultView.RowFilter = "";
				lblRecordsCount.Text = dgvListDetainedLicenses.Rows.Count.ToString();
				return;
			}


			if (FilterColumn == "DetainID" || FilterColumn == "ReleaseApplicationID")
				//in this case we deal with numbers not string.
				_dtDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text.Trim());
			else
				_dtDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text.Trim());

			lblRecordsCount.Text = _dtDetainedLicenses.Rows.Count.ToString();

		}
		
        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
			int selectedIndex = cbFilterDetainedLicenses.SelectedIndex;
			if (selectedIndex == 1 || selectedIndex == 2 || selectedIndex == 5 || selectedIndex == 7)
			{

				e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
			}
		}

        private void tsmiShowPersonDetails_Click(object sender, EventArgs e)
        {
            string nationalNo= dgvListDetainedLicenses.CurrentRow.Cells[6].Value.ToString();
            int personID = clsPerson.Find(nationalNo).PersonID;
            frmPersonDetails person = new frmPersonDetails(personID);
            person.ShowDialog();
        }

        private void tsmiShowLicenseDetails_Click(object sender, EventArgs e)
        {
           
            frmShowLicenseCard license = new frmShowLicenseCard((int)dgvListDetainedLicenses.CurrentRow.Cells[1].Value);
            license.ShowDialog();
        }

        private void tsmiShowPersonHistory_Click(object sender, EventArgs e)
        {
            string nationalNo = dgvListDetainedLicenses.CurrentRow.Cells[6].Value.ToString();
            int personID = clsPerson.Find(nationalNo).PersonID;
            frmLicenseHistory licenseHistory = new frmLicenseHistory(personID);
            licenseHistory.ShowDialog();
        }

        private void tsmiReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            
            frmReleaseLicense releaseLicnse = new frmReleaseLicense((int)dgvListDetainedLicenses.CurrentRow.Cells[1].Value);
            releaseLicnse.ShowDialog();
            frmManageDetainedLicenses_Load(null,null);
        }

        private void dgvListDetainedLicenses_SelectionChanged(object sender, EventArgs e)
        {
            bool isRelease = Convert.ToBoolean(dgvListDetainedLicenses.CurrentRow.Cells[3].Value);
            if (isRelease)
                tsmiReleaseDetainedLicense.Enabled = false;
            else
                tsmiReleaseDetainedLicense.Enabled = true;

        }

		private void cmsManageDetainedLicense_Opening(object sender, CancelEventArgs e)
		{
			tsmiReleaseDetainedLicense.Enabled = !(bool)dgvListDetainedLicenses.CurrentRow.Cells[3].Value;

		}
	}
}
