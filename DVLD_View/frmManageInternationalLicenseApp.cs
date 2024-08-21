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


        private DataView _DataView;

        private DataView _LoadAllLocalDrivingLicenseApplicationIntoView()
        {
            DataView _DataView;
            DataTable _DataTable;
            _DataTable = clsInternationalLicense.GetAll();
            _DataView = _DataTable.DefaultView;
            _DataView.Sort = "InternationalLicenseID DESC";
            return _DataView;
        }

        private void _ResetFilter()
        {
            cbFilterInterLicenseApps.SelectedIndex = 0;
            cbActivityFilter.SelectedIndex = 0;
            txtFilter.Clear();
            txtFilter.Visible = false;
            cbActivityFilter.Visible = false;
        }

        private void _RefreshLDLApplications(DataView dv)
        {

            int count = 0;
            dgvListInternationalLicenses.Rows.Clear();

            if (dv != null)
                count = dv.Count;

            foreach (DataRowView drv in dv)
            {
                dgvListInternationalLicenses.Rows.Add(drv[0], drv[1], drv[2], drv[3],
                    drv[4], drv[5], drv[6]);
            }

            lblRecordsCount.Text = count.ToString();

        }


        private void frmManageInternationalLicenseApp_Load(object sender, EventArgs e)
        {
            _ResetFilter();
            _RefreshLDLApplications(_LoadAllLocalDrivingLicenseApplicationIntoView());

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddNewInternationalLicenseApp addEdit = new frmAddNewInternationalLicenseApp();
            addEdit.ShowDialog();
            _RefreshLDLApplications(_LoadAllLocalDrivingLicenseApplicationIntoView());

        }

        private void cbFilterInterLicenseApps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterInterLicenseApps.SelectedIndex == 0)
            {
                _ResetFilter();
            }
            else if (cbFilterInterLicenseApps.SelectedIndex == 5)
            {
                _RefreshLDLApplications(_LoadAllLocalDrivingLicenseApplicationIntoView());
                txtFilter.Visible = false;
                cbActivityFilter.Visible = true;
            }
            else
            {
                cbActivityFilter.SelectedIndex = 0;
                cbActivityFilter.Visible = false;
                txtFilter.Visible = true;
                txtFilter.Focus();
            }
        }

        private void cbActivityFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbActivityFilter.SelectedIndex)
            {
                case 0:
                    _RefreshLDLApplications(_LoadAllLocalDrivingLicenseApplicationIntoView());
                    break;
                case 1:
                    _FilterInterLicenseByActivity(true);
                    break;
                case 2:
                    _FilterInterLicenseByActivity(false);
                    break;
                

            }
        }

        private void _FilterInterLicenseByActivity(bool activity)
        {
            _DataView = _LoadAllLocalDrivingLicenseApplicationIntoView();
            _DataView.RowFilter = $"IsActive = '{activity}'";
            _RefreshLDLApplications(_DataView);
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            int value;
            switch (cbFilterInterLicenseApps.SelectedIndex)
            {
                case 1:
                    {
                        if (txtFilter.Text.Trim() == "")
                        {
                            _RefreshLDLApplications(_LoadAllLocalDrivingLicenseApplicationIntoView());
                            return;
                        }
                        if (int.TryParse(txtFilter.Text.Trim(), out value))
                            _FilterByIDs("InternationalLicenseID",value);
                    }
                    break;
                case 2:
                    if (txtFilter.Text.Trim() == "")
                    {
                        _RefreshLDLApplications(_LoadAllLocalDrivingLicenseApplicationIntoView());
                        return;
                    }
                    if (int.TryParse(txtFilter.Text.Trim(), out value))
                        _FilterByIDs("ApplicationID", value);
                    break;
                case 3:
                    if (txtFilter.Text.Trim() == "")
                    {
                        _RefreshLDLApplications(_LoadAllLocalDrivingLicenseApplicationIntoView());
                        return;
                    }
                    if (int.TryParse(txtFilter.Text.Trim(), out value))
                        _FilterByIDs("DriverID", value);
                    break;
                case 4:
                    if (txtFilter.Text.Trim() == "")
                    {
                        _RefreshLDLApplications(_LoadAllLocalDrivingLicenseApplicationIntoView());
                        return;
                    }
                    if (int.TryParse(txtFilter.Text.Trim(), out value))
                        _FilterByIDs("IssuedUsingLocalLicenseID", value);
                    break;
                    

            }
        }
        private void _FilterByIDs(string columnName,int iD)
        {
            _DataView = _LoadAllLocalDrivingLicenseApplicationIntoView();
            _DataView.RowFilter = $"{columnName} = {iD}";
            _RefreshLDLApplications(_DataView);
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            _FilterValidate(e);
        }
        private void _FilterValidate(KeyPressEventArgs e)
        {
            if (cbFilterInterLicenseApps.SelectedIndex != 5)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            }
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
            //int driverID = clsDriver.FindByPersonID(applicationID).DriverID;
            frmLicenseHistory licenesHistory = new frmLicenseHistory(personId);
            licenesHistory.ShowDialog();
        }
    }
}
