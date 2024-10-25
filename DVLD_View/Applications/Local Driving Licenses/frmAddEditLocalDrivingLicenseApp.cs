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
using DVLD_View.Globals;

namespace DVLD_View
{
    public partial class frmAddEditLocalDrivingLicenseApp : Form
    {
        enum enMode { AddNew =1,Update =2}
        enMode _Mode;
        private int _LocalLicenseAppID;
        private int _SelectedPersonID;

        private clsLocalDrivingLicenseApp _LocalDrivingLicenseApp;

		public frmAddEditLocalDrivingLicenseApp()
		{
			InitializeComponent();
		    _Mode = enMode.AddNew;
		}

		public frmAddEditLocalDrivingLicenseApp(int localLicenseAppID)
        {
            InitializeComponent();

            _LocalLicenseAppID = localLicenseAppID;
            _Mode=enMode.Update;
        }

        private void _FillLicenseClassesInComboBox()
        {
            DataTable dt = clsLicenseClass.GetAll();
            foreach (DataRow dr in dt.Rows)
            {
                cbLicenseClasses.Items.Add(dr["ClassName"]);
            }
        }

        private void _ResetDefaultValues()
        {
            _FillLicenseClassesInComboBox();

			if (_Mode == enMode.AddNew)
            {
                
                lblMode.Text = "Add New Local Driving License Application";
                this.Text = "Add New Local Driving License Application";
                _LocalDrivingLicenseApp = new clsLocalDrivingLicenseApp();
				cbLicenseClasses.SelectedIndex = 2;

				lblApplicationFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.NewDrivingLicense).ApplicationFees.ToString();
                lblApplicationDate.Text = Format.DateToShort(DateTime.Now);
				lblUsername.Text = Global.CurrentUser.Username;

				btnSave.Enabled = false;
				tpApplicationInfo.Enabled = false;

			}
			else
            {
				lblMode.Text = "Update Local Driving License Application";
				this.Text = "Update Local Driving License Application";
                btnSave.Enabled = true;
                tpApplicationInfo.Enabled = true;
			}
        }

        private void _LoadData()
        {

            ctrlPersonCardWithFilter1.gbFilter.Enabled = false;

			_LocalDrivingLicenseApp = clsLocalDrivingLicenseApp.Find(_LocalLicenseAppID);
            if(_LocalDrivingLicenseApp == null )
            {
                MessageBox.Show($"This form will be closed because no{Environment.NewLine}local driving license application with Id={_LocalLicenseAppID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ctrlPersonCardWithFilter1.LoadPersonInfo(_LocalDrivingLicenseApp.ApplicantPersonID);
            lblDLApplicationID.Text = _LocalDrivingLicenseApp.LocalDrivingLicenseAppID.ToString();
            lblApplicationDate.Text = Format.DateToShort(_LocalDrivingLicenseApp.ApplicationDate);
            lblApplicationFees.Text = _LocalDrivingLicenseApp.PaidFees.ToString();
            lblUsername.Text = clsUser.Find(_LocalDrivingLicenseApp.UserID).Username;
            cbLicenseClasses.SelectedIndex = cbLicenseClasses.FindString( clsLicenseClass.Find(_LocalDrivingLicenseApp.LicenseClassID).ClassName);
        }

        private void frmAddEditLocalDrivingLicenseApp_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if(_Mode == enMode.Update)
                _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int licenseClassId = clsLicenseClass.FindByClassName(cbLicenseClasses.Text).ClassID;
            int activeApplicationId = clsApplication.GetActiveApplicationIdForLicenseClass(_SelectedPersonID, clsApplication.enApplicationType.NewDrivingLicense, licenseClassId);

            if(activeApplicationId != -1)
            {
				MessageBox.Show("Choose another License Class, the selected Person Already have an active application for the selected class with id=" + activeApplicationId, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				cbLicenseClasses.Focus();
				return;
			}

            if (clsLicense.IsLicenseExistByPersonId(_SelectedPersonID, licenseClassId))
            {
				MessageBox.Show("Person already have a license with the same applied driving class, Choose different driving class", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				cbLicenseClasses.Focus();
				return;
			}

            _LocalDrivingLicenseApp.ApplicantPersonID = _SelectedPersonID;
            _LocalDrivingLicenseApp.ApplicationDate = DateTime.Now;
            _LocalDrivingLicenseApp.ApplicationStatus = clsApplication.enApplicationStatus.New;
            _LocalDrivingLicenseApp.ApplicationTypeID = clsApplication.enApplicationType.NewDrivingLicense;
            _LocalDrivingLicenseApp.LastStatusDate = DateTime.Now;
            _LocalDrivingLicenseApp.LicenseClassID = licenseClassId;
            _LocalDrivingLicenseApp.PaidFees = Convert.ToSingle(lblApplicationFees.TabIndex);

            if(_LocalDrivingLicenseApp.Save())
            {
                lblDLApplicationID.Text = _LocalDrivingLicenseApp.LocalDrivingLicenseAppID.ToString();
                lblMode.Text = "Update Local Driving License Application";
                _Mode = enMode.Update;

				MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
            else
				MessageBox.Show("Error: Data is not saved successfully.", "Fail Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(_Mode == enMode.Update 
                || ctrlPersonCardWithFilter1.PersonID != -1) // incase addNew mode it will check this
            {
                btnSave.Enabled = true;
                tpApplicationInfo.Enabled = true;
                tcLocalDrivingLicenseInfo.SelectedTab = tpApplicationInfo;
                return;
            }
            else
            {
				MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter1.FilterFocus();
			}

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tcLocalDrivingLicenseInfo.SelectedTab = tpPersonalInfo;
        }

		private void ctrlPersonCardWithFilter1_OnPersonSelected(object sender, People.Controls.Events.OnPersonSelectedEventArgs e)
		{
            _SelectedPersonID = e.PersonId;
		}

		private void frmAddEditLocalDrivingLicenseApp_Activated(object sender, EventArgs e)
		{
            ctrlPersonCardWithFilter1.FilterFocus();
		}
	}
}
