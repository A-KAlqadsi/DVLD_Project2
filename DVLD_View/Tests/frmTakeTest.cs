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
    public partial class frmTakeTest : Form
    {
        enum enTestType { Vision = 1, Written = 2, Street = 3 }
        enTestType _TestType;
        int _TestTypeID;
        clsTest _Test;
        clsTestAppointment _TestAppointment;
        int _TestID;
        int _TestAppointmentID;
        bool _TestResult = true;

        public frmTakeTest(int testAppointmentID, int testTypeID)
        {
            InitializeComponent();

            _TestTypeID = testTypeID;
            _TestAppointmentID = testAppointmentID;

            if (_TestTypeID == 1)
                _TestType = enTestType.Vision;
            else if (_TestTypeID == 2)
                _TestType = enTestType.Written;
            else
                _TestType = enTestType.Street;
            
        }

        private void _InitilizeFormByTestType()
        {
            
            if (_TestType == enTestType.Vision)
            {
                gbTestType.Text = "Vision Test";

            }
            else if (_TestType == enTestType.Written)
            {
                gbTestType.Text = "Written Test";
            }
            else
            {
                gbTestType.Text = "Street Test";
            }
        }

        private void _LoadData()
        {
            if(clsTestAppointment.IsTestAppointmentPassed(_TestAppointmentID) == 1)
            {
                btnSave.Enabled = false;
                rbPass.Enabled = false;
                rbFail.Enabled = false;
                lblStatus.Visible = true;
                rbPass.Checked = true;
                lblTestID.Text = clsTest.FindTestByAppointmentID(_TestAppointmentID).TestID.ToString();
                lblStatus.Text = "Person already passed this test";
                
            }
            if(clsTestAppointment.IsTestAppointmentPassed(_TestAppointmentID) == 0)
            {
                btnSave.Enabled = false;
                rbPass.Enabled = false;
                rbFail.Enabled = false;
                rbFail.Checked = true;
                lblStatus.Visible = true;
                lblMode.Text = "ReTake Test";
                lblTestID.Text = clsTest.FindTestByAppointmentID(_TestAppointmentID).TestID.ToString();
                lblStatus.Text = "Person already sat this test";
            }

            DataTable dataTable = clsTestAppointment.GetTestAppointmentMasterByID(_TestAppointmentID);
            _TestAppointment = clsTestAppointment.Find(_TestAppointmentID);
            _Test = new clsTest();
            _InitilizeFormByTestType();
            
            foreach (DataRow row in dataTable.Rows)
            {
                lblDLAppID.Text = row["LocalDrivingLicenseApplicationID"].ToString();
                lblApplicant.Text = row["FullName"].ToString();
                lblClassName.Text = row["ClassName"].ToString();
                lblAppFees.Text = row["PaidFees"].ToString();
                lblTestDate.Text = row["AppointmentDate"].ToString();
            }

        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void rbPass_CheckedChanged(object sender, EventArgs e)
        {
            _TestResult = true;
        }

        private void rbFail_CheckedChanged(object sender, EventArgs e)
        {
            _TestResult = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Test.TestAppointmentID = _TestAppointmentID;
            _Test.UserID = clsUser.Find(clsLoginUser.LoginUser).UserID;
            _Test.TestResult = _TestResult;
            _Test.Notes = txtNotes.Text.Trim();
            _TestAppointment.IsLocked = true;
            
            
            if (MessageBox.Show($"Are you sure you want to save? After that you cannot change{Environment.NewLine}the Pass/Fail results after you save!.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.No)
                return;

            _TestAppointment.Save();
            if (_Test.Save())
                MessageBox.Show("Test result added successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Adding test result fail", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            lblTestID.Text = clsTest.FindTestByAppointmentID(_TestAppointmentID).TestID.ToString();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
