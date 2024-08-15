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
        private int _LocalDrivingLicenseID;
        public frmManageLocalDrivingLicenseApp()
        {
            InitializeComponent();
        }
        private DataView _DataView;

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Filter part
        private void cbFilterLocalDrivingLicenseApps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterLocalDrivingLicenseApps.SelectedIndex == 0)
            {
                _ResetFilter();
            }
            else if (cbFilterLocalDrivingLicenseApps.SelectedItem == "Status")
            {
                _RefreshLDLApplications(_LoadAllLocalDrivingLicenseApplicationIntoView());
                txtFilter.Visible = false;
                cbStatusFilter.Visible = true;
            }
            else
            {
                cbStatusFilter.SelectedIndex = 0;
                cbStatusFilter.Visible = false;
                txtFilter.Visible = true;
                txtFilter.Focus();
            }
        }

        private void cbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbStatusFilter.SelectedIndex)
            {
                case 0:
                    _RefreshLDLApplications(_LoadAllLocalDrivingLicenseApplicationIntoView());
                    break;
                case 1:
                    _FilterAppsByStatus(cbStatusFilter.Text.Trim());
                    break;
                case 2:
                    _FilterAppsByStatus(cbStatusFilter.Text.Trim());
                    break;
                case 3:
                    _FilterAppsByStatus(cbStatusFilter.Text.Trim());
                    break;

            }
        }

        private void _FilterAppsByStatus(string status)
        {
            _DataView = _LoadAllLocalDrivingLicenseApplicationIntoView();
            _DataView.RowFilter = $"Status Like '{status}'";
            _RefreshLDLApplications(_DataView);
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            int value;
            switch (cbFilterLocalDrivingLicenseApps.SelectedIndex)
            {
                case 1:
                    {
                        if(txtFilter.Text.Trim() == "")
                        {
                            _RefreshLDLApplications(_LoadAllLocalDrivingLicenseApplicationIntoView());
                            return;
                        }
                        if(int.TryParse(txtFilter.Text.Trim(), out value))
                            _FilterByAppsID(value);
                    }
                break;
                case 2:
                    _FilterByClassName(txtFilter.Text.Trim());
                    break;
                case 3:
                    _FilterByNationalNo(txtFilter.Text.Trim());
                    break;
                case 4:
                    _FilterByFullName(txtFilter.Text.Trim());
                    break;
                case 5:
                    if (txtFilter.Text.Trim() == "")
                    {
                        _RefreshLDLApplications(_LoadAllLocalDrivingLicenseApplicationIntoView());
                        return;
                    }
                    if (int.TryParse(txtFilter.Text.Trim(), out  value))
                        _FilterByPassedTests(value);
                    break;

            }
        }

        private void _FilterByAppsID(int iD)
        {
            _DataView = _LoadAllLocalDrivingLicenseApplicationIntoView();
            _DataView.RowFilter = $"LocalDrivingLicenseApplicationID = {iD}";
            _RefreshLDLApplications(_DataView);
        }
        private void _FilterByClassName(string className)
        {
            _DataView = _LoadAllLocalDrivingLicenseApplicationIntoView();
            _DataView.RowFilter = $"ClassName Like '{className}%'";
            _RefreshLDLApplications(_DataView);
        }
        private void _FilterByNationalNo(string nationalNo)
        {
            _DataView = _LoadAllLocalDrivingLicenseApplicationIntoView();
            _DataView.RowFilter = $"NationalNo Like '{nationalNo}%'";
            _RefreshLDLApplications(_DataView);
        }
        private void _FilterByFullName(string fullName)
        {
            _DataView = _LoadAllLocalDrivingLicenseApplicationIntoView();
            _DataView.RowFilter = $"FullName Like '{fullName}%'";
            _RefreshLDLApplications(_DataView);
        }
        private void _FilterByPassedTests(int passedTests)
        {
            _DataView = _LoadAllLocalDrivingLicenseApplicationIntoView();
            _DataView.RowFilter = $"PassedTestCount = {passedTests}";
            _RefreshLDLApplications(_DataView);
        }

        private void _FilterValidate(KeyPressEventArgs e)
        {
            if (cbFilterLocalDrivingLicenseApps.SelectedIndex == 1 || cbFilterLocalDrivingLicenseApps.SelectedIndex == 5)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            }
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            _FilterValidate(e);
        }

        // End Filter 
        private void tsmiScheduleVisionTest_Click(object sender, EventArgs e)
        {
            int testTypeID = Convert.ToInt32(tsmiScheduleVisionTest.Tag);
            int lDLAppID = (int) dgvListLocalDrivingLicenseApps.CurrentRow.Cells[0].Value;
            frmTestAppointment testAppointment = new frmTestAppointment(lDLAppID,testTypeID);
            testAppointment.ShowDialog();
            _RefreshLDLApplications(_LoadAllLocalDrivingLicenseApplicationIntoView());
        }

        private void tsmiScheduleWrittenTest_Click(object sender, EventArgs e)
        {
            int testTypeID = Convert.ToInt32(tsmiScheduleWrittenTest.Tag);
            int lDLAppID = (int)dgvListLocalDrivingLicenseApps.CurrentRow.Cells[0].Value;
            frmTestAppointment testAppointment = new frmTestAppointment(lDLAppID, testTypeID);
            testAppointment.ShowDialog();
           

            _RefreshLDLApplications(_LoadAllLocalDrivingLicenseApplicationIntoView());

        }
        private void tsmiScheduleStreetTest_Click(object sender, EventArgs e)
        {
            int testTypeID = Convert.ToInt32(tsmiScheduleStreetTest.Tag);
            int lDLAppID = (int)dgvListLocalDrivingLicenseApps.CurrentRow.Cells[0].Value;
            frmTestAppointment testAppointment = new frmTestAppointment(lDLAppID, testTypeID);
            testAppointment.ShowDialog();

            if (clsTest.CountPassedTest(lDLAppID) == 3)
                clsApplication.UpdateApplicationStatus(clsLocalDrivingLicenseApp.Find(lDLAppID).ApplicationID, 3);

            _RefreshLDLApplications(_LoadAllLocalDrivingLicenseApplicationIntoView());

        }

        private void _ValidateTestOrders()
        {
            int lDLAppID = (int)dgvListLocalDrivingLicenseApps.CurrentRow.Cells[0].Value;           
            
            if(clsTest.CountPassedTest(lDLAppID) == 3)
            {
                tsmiScheduleTests.Enabled = false;
                if (clsLicense.IsApplicationHasLicense(clsLocalDrivingLicenseApp.Find(lDLAppID).ApplicationID))
                    tsmiIssueDrivingLicense.Enabled = false;
                else
                    tsmiIssueDrivingLicense.Enabled = true;
            }
            else 
                tsmiScheduleTests.Enabled =true;

            
            
            if (clsTest.IsTestPassed(lDLAppID, 1))
            {
                tsmiScheduleVisionTest.Enabled = false;
            }
            else
                tsmiScheduleVisionTest.Enabled = true;



            if (clsTest.IsTestPassed(lDLAppID,1) && !clsTest.IsTestPassed(lDLAppID, 2))
            {
                tsmiScheduleWrittenTest.Enabled = true;
            }
            else
                tsmiScheduleWrittenTest.Enabled = false;


            if (clsTest.IsTestPassed(lDLAppID, 1) && clsTest.IsTestPassed(lDLAppID, 2) && !clsTest.IsTestPassed(lDLAppID, 3))
            {
                tsmiScheduleStreetTest.Enabled = true;
            }
            else
            {
                tsmiScheduleStreetTest.Enabled = false;
            }
        }

        private void dgvListLocalDrivingLicenseApps_SelectionChanged(object sender, EventArgs e)
        {
            _LocalDrivingLicenseID = (int)dgvListLocalDrivingLicenseApps.CurrentRow.Cells[0].Value;
            if (clsLocalDrivingLicenseApp.Find(_LocalDrivingLicenseID) == null)
                return;
            int applicatoinID = clsLocalDrivingLicenseApp.Find(_LocalDrivingLicenseID).ApplicationID;
            if (clsApplication.GetStatus(applicatoinID) == 2)
            {
                tsmiCancelApplication.Enabled = false;
                tsmiEditApplication.Enabled = false;
                tsmiScheduleTests.Enabled = false;
                tsmiShowLicense.Enabled = false;
                tsmiDeleteApplication.Enabled = true;
                return;
            }
            else
            {
                tsmiCancelApplication.Enabled = true;
                tsmiEditApplication.Enabled = true;
                tsmiScheduleTests.Enabled = true;
                tsmiShowLicense.Enabled = true;
                tsmiDeleteApplication.Enabled = true;
            }
            

            if (clsTest.CountPassedTest(_LocalDrivingLicenseID) == 3 && !clsLicense.IsApplicationHasLicense(applicatoinID))
                tsmiIssueDrivingLicense.Enabled = true;
            else
                tsmiIssueDrivingLicense.Enabled = false;

            if (clsLicense.IsApplicationHasLicense(applicatoinID))
            {
                tsmiShowLicense.Enabled = true;
                tsmiCancelApplication.Enabled = false;
                tsmiDeleteApplication.Enabled = false;
                tsmiEditApplication.Enabled = false;
            }
            else
            {
                tsmiShowLicense.Enabled = false;
                tsmiCancelApplication.Enabled = true;
                tsmiDeleteApplication.Enabled = true;
                tsmiEditApplication.Enabled = true;
            }

            _ValidateTestOrders();
        }

        private void tsmiIssueDrivingLicense_Click(object sender, EventArgs e)
        {
            int lDLAppID = (int)dgvListLocalDrivingLicenseApps.CurrentRow.Cells[0].Value;
            frmIssueDrivingLicense isseLicense = new frmIssueDrivingLicense(lDLAppID);
            isseLicense.ShowDialog();

            if (clsLicense.IsApplicationHasLicense(clsLocalDrivingLicenseApp.Find(lDLAppID).ApplicationID))
            {
                tsmiIssueDrivingLicense.Enabled = false;
                tsmiShowLicense.Enabled = true;
            }
            else
                tsmiIssueDrivingLicense.Enabled = true;
        }

        private void tsmiShowLicense_Click(object sender, EventArgs e)
        {
            int lDLAppID = (int)dgvListLocalDrivingLicenseApps.CurrentRow.Cells[0].Value;
            int applicationID = clsLocalDrivingLicenseApp.Find(lDLAppID).ApplicationID;
            int licenseId; 
            clsLicense license =  clsLicense.FindByApplicationID(applicationID);
            if (license == null)
                licenseId = -1;
            else
                licenseId = license.LicenseID;

            frmShowLicenseCard licenseCard = new frmShowLicenseCard(licenseId);
            licenseCard.ShowDialog();

        }

        private void tsmiEditApplication_Click(object sender, EventArgs e)
        {
            int lDLAppID = (int)dgvListLocalDrivingLicenseApps.CurrentRow.Cells[0].Value;
            frmAddEditLocalDrivingLicenseApp frm = new frmAddEditLocalDrivingLicenseApp(lDLAppID);
            frm.ShowDialog();
            _RefreshLDLApplications(_LoadAllLocalDrivingLicenseApplicationIntoView());
        }

        private void tsmiCancelApplication_Click(object sender, EventArgs e)
        {
            int lDLAppID = (int)dgvListLocalDrivingLicenseApps.CurrentRow.Cells[0].Value;
            int applicationID = clsLocalDrivingLicenseApp.Find(lDLAppID).ApplicationID;
            
            if (MessageBox.Show("Are you sure you want to cancel this application","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                if(clsApplication.UpdateApplicationStatus(applicationID, 2))
                {
                    tsmiCancelApplication.Enabled = false;
                    tsmiEditApplication.Enabled = false;
                    tsmiScheduleTests.Enabled = false;
                    tsmiShowLicense.Enabled = false;
                    tsmiDeleteApplication.Enabled = true;
                }



                _RefreshLDLApplications(_LoadAllLocalDrivingLicenseApplicationIntoView());
            }

        }

        private void tsmiDeleteApplication_Click(object sender, EventArgs e)
        {
            int lDLAppID = (int)dgvListLocalDrivingLicenseApps.CurrentRow.Cells[0].Value;
            int applicationID = clsLocalDrivingLicenseApp.Find(lDLAppID).ApplicationID;

            if (clsTest.CountPassedTest(lDLAppID) == 0 && !clsTestAppointment.IsPersonHasTestAppointment(lDLAppID))
            {

                if (MessageBox.Show("Are you sure you want to delete this application", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (clsLocalDrivingLicenseApp.Delete(lDLAppID))
                    {
                        if (clsApplication.Delete(applicationID))
                        {
                            MessageBox.Show("Application deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _RefreshLDLApplications(_LoadAllLocalDrivingLicenseApplicationIntoView());
                        }
                    }

                }
            }
            else
                MessageBox.Show("You cannot delete this application because it has connections in other resources!!", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            

            
        }

        private void tsmiShowAppDetails_Click(object sender, EventArgs e)
        {
            int lDLAppID = (int)dgvListLocalDrivingLicenseApps.CurrentRow.Cells[0].Value;

            frmShowApplicationInfo showAppInfo = new frmShowApplicationInfo(lDLAppID);
            showAppInfo.ShowDialog();
        }
    }
}
