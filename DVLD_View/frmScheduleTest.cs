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
    public partial class frmScheduleTest : Form
    {
        enum enTestType { Vision = 1, Written=2,Street=3}
        enum enMode { AddNew =1, Update =2}
        enMode _Mode;
        enTestType _TestType;
        int _TestTypeID;
        int _LDLAppID;
        clsTestAppointment _TestAppointment;
        clsApplication _ReTakeTestApplication;
        int _ApplicantID;
        const int _RetakeTestAppID = 7;
        float _TestTypeFees = 0;
        float _RetakeTestFees = 0;
        int _TestAppointmentID;
        public frmScheduleTest(int lDLAppId, int testTypeID, int appointmentID)
        {
            InitializeComponent();
            _TestTypeID = testTypeID;
            _TestAppointmentID = appointmentID;
            _LDLAppID = lDLAppId;

            if(_TestAppointmentID == -1)
                _Mode = enMode.AddNew;
            else 
                _Mode = enMode.Update;

            if (_TestTypeID == 1)
                _TestType = enTestType.Vision;
            else if (_TestTypeID == 2)
                _TestType = enTestType.Written;
            else 
                _TestType = enTestType.Street;
            
        }

        private void _MakeDateInFuture()
        {
            dtpTestDate.MinDate=DateTime.Now;
        }

        private void _InitilizeTestTypeDefaults()
        {
            _SetDefaults();
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
            _MakeDateInFuture();
            _InitilizeTestTypeDefaults();
            _CheckTestAppointmentStatus();
            _RetakeTestInfo();
            lblTotalFees.Text = (_RetakeTestFees + _TestTypeFees).ToString();

            if(_Mode == enMode.AddNew)
            {
                _TestAppointment = new clsTestAppointment();
                return;
            }

            _TestAppointment = clsTestAppointment.Find(_TestAppointmentID);
            if (_TestAppointment == null)
            {
                MessageBox.Show($"This form will be closed because no Test appointment wiht ID = {_TestAppointmentID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            
            dtpTestDate.Value = _TestAppointment.AppointmentDate;

        }

        private void  _RetakeTestInfo()
        {
            if(!clsTest.IsTestPassed(_LDLAppID,_TestTypeID))
            {
                _ReTakeTestApplication = new clsApplication();
                _ReTakeTestApplication.ApplicantApplicationID = _ApplicantID;
                _ReTakeTestApplication.ApplicationTypeID = _RetakeTestAppID;
                _ReTakeTestApplication.PaidFees = clsApplicationType.Find(_RetakeTestAppID).ApplicationFees;
                _ReTakeTestApplication.ApplicationStatus = 1;
                _ReTakeTestApplication.ApplicationDate = DateTime.Now;
                _ReTakeTestApplication.UserID =clsUser.Find(clsLoginUser.LoginUser).UserID;
                _ReTakeTestApplication.LastStatusDate = DateTime.Now;
                lblRTestAppFees.Text = _ReTakeTestApplication.PaidFees.ToString();
                _RetakeTestFees = _ReTakeTestApplication.PaidFees;
                gbRetakeTestInfo.Enabled = true;

            }
        }

        private void _SetDefaults()
        {
            clsLocalDrivingLicenseApp localLicense = clsLocalDrivingLicenseApp.Find(_LDLAppID);
            clsTestType testType = clsTestType.Find(_TestTypeID);
            
            if (localLicense != null)
            {
                clsApplication application = clsApplication.Find(localLicense.ApplicationID);
                clsLicenseClass licenseClass = clsLicenseClass.Find(localLicense.LicenseClassID);
                lblDLAppID.Text = localLicense.LocalDrivingLicenseAppID.ToString();
                lblClassName.Text = licenseClass.ClassName;
                lblApplicant.Text = clsPerson.Find(application.ApplicantApplicationID).FullName();
                lblAppFees.Text = testType.TestTypeFees.ToString();
                _TestTypeFees = testType.TestTypeFees;
                lblTrial.Text = "0";// In progress
                _ApplicantID = application.ApplicantApplicationID;
            }


        }

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {

            _LoadData();
        }

        private void _CheckTestAppointmentStatus()
        {
            int testStatus = clsTestAppointment.IsTestAppointmentPassed(_TestAppointmentID);
            if (testStatus == 2)
                return;
            if (testStatus == 0)
            {
                lblMode.Text = "Schedule Retake Test";
                lblStatus.Visible = true;
                lblStatus.Text = "Person already sat for the test, appointment locked.";
                dtpTestDate.Enabled = false;
                btnSave.Enabled = false;
            }
            if (testStatus == 1)
            {
                lblStatus.Visible = true;
                lblStatus.Text = "Person already pass for the test, appointment locked";
                dtpTestDate.Enabled = false;
                btnSave.Enabled = false;
            }
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            _TestAppointment.LocalDrivingLicenseAppID = _LDLAppID;
            _TestAppointment.AppointmentDate = dtpTestDate.Value;
            _TestAppointment.TestTypeID = _TestTypeID;
            _TestAppointment.PaidFees = Convert.ToSingle(lblAppFees.Text);
            _TestAppointment.UserID =clsUser.Find(clsLoginUser.LoginUser).UserID;
            _TestAppointment.IsLocked = false;
            
            if(gbRetakeTestInfo.Enabled)
            {
                _ReTakeTestApplication.Save();
            }

            if (_TestAppointment.Save())
                MessageBox.Show("Test appointment added successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Test appointment save failed!", "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
