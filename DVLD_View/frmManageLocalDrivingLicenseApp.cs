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
    public partial class frmManageLocalDrivingLicenseApp : Form
    {
        public frmManageLocalDrivingLicenseApp()
        {
            InitializeComponent();
        }
        

        private DataView _LoadAllLocalDrivingLicenseApplicationIntoView()
        {
            DataView _DataView;
            DataTable _DataTable;
            _DataTable = clsLocalDrivingLicenseApp.GetAll();
            _DataView = _DataTable.DefaultView;
            _DataView.Sort = "LocalDrivingLicenseApplicationID DESC";
            return _DataView;
        }

        private void _ResetFilter()
        {
            cbFilterLocalDrivingLicenseApps.SelectedIndex = 0;
            cbStatusFilter.SelectedIndex = 0;
            txtFilter.Clear();
            txtFilter.Visible = false;
            cbStatusFilter.Visible = false;
        }

        private void _RefreshLDLApplications(DataView dv)
        {
            int count = 0;
            dgvListLocalDrivingLicenseApps.Rows.Clear();

            if(dv != null)
                count = dv.Count;

            foreach (DataRowView drv in dv)
            {
                dgvListLocalDrivingLicenseApps.Rows.Add(drv[0], drv[1], drv[2], drv[3],
                    drv[4], drv[5], drv[6]);
            }

            lblRecordsCount.Text = count.ToString();

        }
        

        private void frmManageLocalDrivingLicenseApp_Load(object sender, EventArgs e)
        {
            _ResetFilter();
            _RefreshLDLApplications(_LoadAllLocalDrivingLicenseApplicationIntoView());
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddEditLocalDrivingLicenseApp addEdit = new frmAddEditLocalDrivingLicenseApp(-1);
            addEdit.ShowDialog();
            _RefreshLDLApplications(_LoadAllLocalDrivingLicenseApplicationIntoView());

        }
    }
}
