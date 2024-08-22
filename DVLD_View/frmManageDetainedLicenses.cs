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



        private DataView _DataView;

        private DataView _LoadAllDetainedLicensesIntoView()
        {
            DataView _DataView;
            DataTable _DataTable;
            _DataTable = clsDetainedLicense.GetAllMaster();
            _DataView = _DataTable.DefaultView;
            _DataView.Sort = "DetainID DESC";
            return _DataView;
        }

        private void _ResetFilter()
        {
            cbFilterDetainedLicenses.SelectedIndex = 0;
            cbIsReleaseFilter.SelectedIndex = 0;
            txtFilter.Clear();
            txtFilter.Visible = false;
            cbIsReleaseFilter.Visible = false;
        }



        private void _RefreshDetainedLicenses(DataView dv)
        {

            int count = 0;
            dgvListDetainedLicenses.Rows.Clear();
            bool isRelease = false;
            if (dv != null)
                count = dv.Count;

            foreach (DataRowView drv in dv)
            {
                isRelease = Convert.ToBoolean(drv[3]);
                dgvListDetainedLicenses.Rows.Add(drv[0], drv[1], drv[2], isRelease,
                    drv[4], drv[5], drv[6], drv[7], drv[8]);
            }

            lblRecordsCount.Text = count.ToString();

        }



        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicense detainLicense = new frmDetainLicense();
            detainLicense.ShowDialog();
            _RefreshDetainedLicenses(_LoadAllDetainedLicensesIntoView());

        }

        private void btnReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            frmReleaseLicense releaseLicnse = new frmReleaseLicense(-1);
            releaseLicnse.ShowDialog();
            _RefreshDetainedLicenses(_LoadAllDetainedLicensesIntoView());

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManageDetainedLicenses_Load(object sender, EventArgs e)
        {
            _ResetFilter();
            _RefreshDetainedLicenses(_LoadAllDetainedLicensesIntoView());
        }

        private void cbFilterDetainedLicenses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterDetainedLicenses.SelectedIndex == 0)
            {
                _ResetFilter();
            }
            else if (cbFilterDetainedLicenses.SelectedIndex == 3)
            {
                _RefreshDetainedLicenses(_LoadAllDetainedLicensesIntoView());
                txtFilter.Visible = false;
                cbIsReleaseFilter.Visible = true;
            }
            else
            {
                cbIsReleaseFilter.SelectedIndex = 0;
                cbIsReleaseFilter.Visible = false;
                txtFilter.Visible = true;
                txtFilter.Focus();
            }
        }

        private void cbIsReleaseFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbIsReleaseFilter.SelectedIndex)
            {
                case 0:
                    _RefreshDetainedLicenses(_LoadAllDetainedLicensesIntoView());
                    break;
                case 1:
                    _FilterByIsReales(1);
                    break;
                case 2:
                    _FilterByIsReales(0);
                    break;
                

            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            int value;
            switch (cbFilterDetainedLicenses.SelectedIndex)
            {
                case 1:
                    {
                        if (txtFilter.Text.Trim() == "")
                        {
                            _RefreshDetainedLicenses(_LoadAllDetainedLicensesIntoView());
                            return;
                        }
                        if (int.TryParse(txtFilter.Text.Trim(), out value))
                            _FilterByID("DetainID",value);
                    }
                    break;
                case 2:
                    if (txtFilter.Text.Trim() == "")
                    {
                        _RefreshDetainedLicenses(_LoadAllDetainedLicensesIntoView());
                        return;
                    }
                    if (int.TryParse(txtFilter.Text.Trim(), out value))
                        _FilterByID("LicenseID", value);
                    break;
                case 4:
                    if (txtFilter.Text.Trim() == "")
                    {
                        _RefreshDetainedLicenses(_LoadAllDetainedLicensesIntoView());
                        return;
                    }
                    if (float.TryParse(txtFilter.Text.Trim(), out float fees))
                        _FilterByFineFees(fees);
                    break;
                case 5:
                    _FilterByText("NationalNo", txtFilter.Text.Trim());
                    break;
                case 6:
                    _FilterByText("FullName", txtFilter.Text.Trim());
                    break;
                case 7:
                    if (txtFilter.Text.Trim() == "")
                    {
                        _RefreshDetainedLicenses(_LoadAllDetainedLicensesIntoView());
                        return;
                    }
                    if (int.TryParse(txtFilter.Text.Trim(), out value))
                        _FilterByID("ApplicationID", value);
                    break;
            }
        }
        private void _FilterByIsReales(int isRelease)
        {
            _DataView = _LoadAllDetainedLicensesIntoView();
            _DataView.RowFilter = $"IsReleased = '{isRelease}'";
            _RefreshDetainedLicenses(_DataView);
        }
        private void _FilterByID(string columnName, int iD)
        {
            _DataView = _LoadAllDetainedLicensesIntoView();
            _DataView.RowFilter = $"{columnName} = {iD}";
            _RefreshDetainedLicenses(_DataView);
        }

        private void _FilterByFineFees(float fineFees)
        {
            _DataView = _LoadAllDetainedLicensesIntoView();
            _DataView.RowFilter = $"FineFees = {fineFees}";
            _RefreshDetainedLicenses(_DataView);
        }


        private void _FilterByText(string columnName,  string nationalNo)
        {
            _DataView = _LoadAllDetainedLicensesIntoView();
            _DataView.RowFilter = $"{columnName} Like '{nationalNo}%'";
            _RefreshDetainedLicenses(_DataView);
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            _FilterValidate(e);
        }

        private void _FilterValidate(KeyPressEventArgs e)
        {
            int selectedIndex = cbFilterDetainedLicenses.SelectedIndex;
            if (selectedIndex == 1 ||selectedIndex==2 || selectedIndex == 5 || selectedIndex==7)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
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
            int licenseID = (int)dgvListDetainedLicenses.CurrentRow.Cells[1].Value;
            frmShowLicenseCard license = new frmShowLicenseCard(licenseID);
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
            int licenseID = (int)dgvListDetainedLicenses.CurrentRow.Cells[1].Value;


            frmReleaseLicense releaseLicnse = new frmReleaseLicense(licenseID);
            releaseLicnse.ShowDialog();
            _RefreshDetainedLicenses(_LoadAllDetainedLicensesIntoView());
        }

        private void dgvListDetainedLicenses_SelectionChanged(object sender, EventArgs e)
        {
            bool isRelease = Convert.ToBoolean(dgvListDetainedLicenses.CurrentRow.Cells[3].Value);
            if (isRelease)
                tsmiReleaseDetainedLicense.Enabled = false;
            else
                tsmiReleaseDetainedLicense.Enabled = true;

        }


        // Filter part


    }
}
