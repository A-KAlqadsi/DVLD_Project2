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
    public partial class frmAddEditLocalDrivingLicenseApp : Form
    {
        enum enMode { AddNew =1,Update =2}
        enMode _Mode;
        private int _LocalLicenseAppID;
        private int _ApplicationID;
        private const int _AppTypeID = 1; // this is the Id of AddLocalLicenseApplication
        private int _PersonID;
        private int _UserID;
        private int _ClassID ;
        private short _AppStatus = 1; // 1 => New, 2 => canceled, 3 => completed 
        private float _AppFees;
        private clsApplication _Application;
        private clsLocalDrivingLicenseApp _LocalDrivingLicenseApp;

        public frmAddEditLocalDrivingLicenseApp(int localLicenseAppID)
        {
            InitializeComponent();

            _LocalLicenseAppID = localLicenseAppID;
            if(_LocalLicenseAppID == -1)
                _Mode=enMode.AddNew;
            else 
                _Mode=enMode.Update;

        }

        private void _LoadLicenseClasses()
        {
            DataTable dt = clsLicenseClass.GetAll();
            foreach (DataRow dr in dt.Rows)
            {
                cbLicenseClasses.Items.Add(dr["ClassName"]);
            }
            cbLicenseClasses.SelectedIndex = 2;
            _ClassID = cbLicenseClasses.SelectedIndex + 1;

        }

        private void _SetNewLicenseKnownFieldsValues()
        {
            lblUsername.Text = clsLoginUser.LoginUser;
            _UserID = clsUser.Find(clsLoginUser.LoginUser).UserID;
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            clsApplicationType appType = clsApplicationType.Find(_AppTypeID);

            if (appType != null)
            {
                lblApplicationFees.Text= appType.ApplicationFees.ToString();
                _AppFees = appType.ApplicationFees;
            }

        }

        private void _LoadData()
        {

            _LoadLicenseClasses();

            if(_Mode ==enMode.AddNew)
            {
                _SetNewLicenseKnownFieldsValues();
                _Application = new clsApplication();
                _LocalDrivingLicenseApp = new clsLocalDrivingLicenseApp();
                return;
            }

            _LocalDrivingLicenseApp = clsLocalDrivingLicenseApp.Find(_LocalLicenseAppID);
            if(_LocalDrivingLicenseApp == null )
            {
                MessageBox.Show($"This form will be closed because no{Environment.NewLine}local driving license application with Id={_LocalLicenseAppID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            _Application = clsApplication.Find(_LocalDrivingLicenseApp.ApplicationID);

            lblMode.Text = "Edit Local Driving License Application";
            ctrlPersonCardWithFilter1.gbFilter.Enabled = false;
            _PersonID = _Application.ApplicantApplicationID;
            ctrlPersonCardWithFilter1.txtSearch.Text = clsPerson.Find(_Application.ApplicantApplicationID).NationalNo;
            ctrlPersonCardWithFilter1.ctrlPersonCard1.LoadPersonInfo(_Application.ApplicantApplicationID);
            lblUsername.Text = clsUser.Find(_Application.UserID).Username;
            _UserID = clsUser.Find(clsLoginUser.LoginUser).UserID;
            lblDLApplicationID.Text = _LocalLicenseAppID.ToString();
            lblApplicationFees.Text = _Application.PaidFees.ToString();
            lblApplicationDate.Text = _Application.ApplicationDate.ToShortDateString();
            cbLicenseClasses.SelectedIndex = _LocalDrivingLicenseApp.LicenseClassID - 1;
            _ClassID = _LocalDrivingLicenseApp.LicenseClassID;
            _AppStatus = _Application.ApplicationStatus;


        }

        private void frmAddEditLocalDrivingLicenseApp_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(_Mode == enMode.AddNew)
                _PersonID = ctrlPersonCardWithFilter1.PersonID;
            
            if (_PersonID == -1)
            {
                MessageBox.Show($"Choose Person first!!","Ooops!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if(clsLocalDrivingLicenseApp.IsPersonHasSameLicenseClass(_PersonID,_ClassID))
            {
                MessageBox.Show($"Person with ID [{_PersonID}] already has the same license class{Environment.NewLine} choose another class", "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Application.ApplicantApplicationID = _PersonID;
            _Application.ApplicationTypeID= _AppTypeID;
            _Application.ApplicationDate = Convert.ToDateTime(lblApplicationDate.Text);
            _Application.LastStatusDate = DateTime.Now;
            _Application.PaidFees = _AppFees;
            _Application.ApplicationStatus = _AppStatus;
            _Application.UserID = _UserID;

            if (_Application.Save())
            {
                _ApplicationID = _Application.ApplicationID;
                _LocalDrivingLicenseApp.ApplicationID = _ApplicationID;
                _LocalDrivingLicenseApp.LicenseClassID = _ClassID;
                if(_LocalDrivingLicenseApp.Save())
                    MessageBox.Show("New Application added successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("New Application save faid", "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("New Application save faid", "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _LocalLicenseAppID = _LocalDrivingLicenseApp.LocalDrivingLicenseAppID;
            _Mode = enMode.Update;
            lblMode.Text = "Edit Local Driving License Application";
            lblDLApplicationID.Text = _LocalLicenseAppID.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(_Mode == enMode.AddNew)
                _PersonID = ctrlPersonCardWithFilter1.PersonID;

            if(_PersonID == -1)
            {
                MessageBox.Show($"Choose Person Info First!", "Person Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;   
            }

            tcLocalDrivingLicenseInfo.SelectedTab = tpApplicationInfo;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tcLocalDrivingLicenseInfo.SelectedTab = tpPersonalInfo;
        }

        private void cbLicenseClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ClassID = cbLicenseClasses.SelectedIndex + 1;
            //MessageBox.Show($"{_ClassID}"); // test 
        }
    
    }
}
