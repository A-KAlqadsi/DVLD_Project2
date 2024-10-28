using DVLD_Business;
using DVLD_View.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_View.Tests.Controls
{
	public partial class ctrlScheduleTest : UserControl
	{
		private enum enMode { AddNew =1, Update =2}
		private enMode _Mode = enMode.AddNew;

		private enum enCreationMode { FirstTimeSchedule =1, RetakeTestSchedule=2}
		private enCreationMode _CreationMode = enCreationMode.FirstTimeSchedule;

		private clsTestType.enTestType _TestTypeId = clsTestType.enTestType.VisionTest;
		private clsLocalDrivingLicenseApp _LocalDrivingLicenseApp { get; set; }
		private int _LocalDrivingLicenseAppId { get; set; } = -1;

		private clsTestAppointment _TestAppointment { get; set; }
		private int _TestAppointmentId { get; set; } = -1;

		public clsTestType.enTestType TestTypeId
		{
			get
			{
				return _TestTypeId;
			}
			set
			{
				_TestTypeId = value;
				switch(_TestTypeId )
				{
					case clsTestType.enTestType.VisionTest:
						{
							gbTestType.Text = "Vision Test";
							pbTestType.Image = Resources.Vision_512;
						}
						break;
					case clsTestType.enTestType.WrittenTest:
						{
							gbTestType.Text = "Written Test";
							pbTestType.Image = Resources.Written_Test_512;
						}
						break;
					case clsTestType.enTestType.StreetTest:
						{
							gbTestType.Text = "Street Test";
							pbTestType.Image = Resources.driving_test_512;
						}
						break;
				}
			}
		}


		public ctrlScheduleTest()
		{
			InitializeComponent();
		}

		public void LoadInfo(int localDrivingLicenseAppId , int testAppointmentId =-1)
		{
			if (testAppointmentId == -1)
				_Mode = enMode.AddNew;
			else
				_Mode = enMode.Update;

			_TestAppointmentId = testAppointmentId;
			_LocalDrivingLicenseAppId = localDrivingLicenseAppId;
			_LocalDrivingLicenseApp = clsLocalDrivingLicenseApp.Find(_LocalDrivingLicenseAppId);

			if(_LocalDrivingLicenseApp == null )
			{
				MessageBox.Show($"Error: no local driving license application with Id{_LocalDrivingLicenseAppId}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				btnSave.Enabled = false;
				return;
			}

			if (_LocalDrivingLicenseApp.DoesAttendTestType(_TestTypeId))
				_CreationMode = enCreationMode.RetakeTestSchedule;
			else
				_CreationMode = enCreationMode.FirstTimeSchedule;
			
			if(_CreationMode == enCreationMode.RetakeTestSchedule)
			{
				lblRTestAppFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.RetakeTest).ApplicationFees.ToString();
				lblMode.Text = "Schedule Retake Test";
				gbRetakeTestInfo.Enabled = true;
				lblRTestAppID.Text = "0";
			}
			else
			{
				lblRTestAppFees.Text = "0";
				lblMode.Text = "Schedule Test";
				lblRTestAppID.Text = "N/A";
				gbRetakeTestInfo.Enabled = false;
			}

			lblDLAppID.Text = _LocalDrivingLicenseApp.LocalDrivingLicenseAppID.ToString();
			lblClassName.Text = _LocalDrivingLicenseApp.LicenseClassInfo.ClassName;
			lblApplicant.Text = _LocalDrivingLicenseApp.ApplicantFullName;
			lblTrial.Text = _LocalDrivingLicenseApp.TotalTrialsPerTest(_TestTypeId).ToString();
			
			if(_Mode == enMode.AddNew)
			{
				lblAppFees.Text = clsTestType.Find(_TestTypeId).TestTypeFees.ToString();
				lblRTestAppID.Text = "N/A";
				dtpTestDate.MinDate = DateTime.Now;
				_TestAppointment = new clsTestAppointment();
			}
			else
			{
				if (!_LoadTestAppointmentData())
					return;
			}

			lblTotalFees.Text = (Convert.ToSingle(lblAppFees.Text) + Convert.ToSingle(lblRTestAppFees.Text)).ToString();

			if (!_HandleActiveTestAppointmentConstraint())
				return;

			if (!_HandleLockedAppointmentConstraint())
				return;

			if (!_HandlePreviousTestConstraint())
				return;
		}

		private bool _LoadTestAppointmentData()
		{
			_TestAppointment = clsTestAppointment.Find(_TestAppointmentId);
			if(_TestAppointment == null)
			{
				MessageBox.Show("Error: No TestAppointment with Id: " + _TestAppointmentId, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				btnSave.Enabled = false;
				return false;
			}

			lblAppFees.Text = _TestAppointment.PaidFees.ToString();

			if (DateTime.Compare(DateTime.Now, _TestAppointment.AppointmentDate) < 0)
				dtpTestDate.MinDate = DateTime.Now;
			else
				dtpTestDate.MinDate = _TestAppointment.AppointmentDate;

			dtpTestDate.Value = _TestAppointment.AppointmentDate;

			if(_TestAppointment.RetakeTestApplicationId == null)
			{
				lblRTestAppFees.Text = "0";
				lblRTestAppID.Text = "N/A";
			}
			else
			{
				lblRTestAppFees.Text = _TestAppointment.RetakeTestApplicationInfo.PaidFees.ToString();
				lblRTestAppID.Text = _TestAppointment.RetakeTestApplicationId.ToString();
			}

			return true;
		}

		private bool _HandleActiveTestAppointmentConstraint()
		{
			if (_Mode == enMode.AddNew && _LocalDrivingLicenseApp.IsThereAnActiveScheduleTest(_TestTypeId))
			{
				lblUserMassage.Visible = true;
				lblUserMassage.Text = "Person Already have an active appointment for this test";
				btnSave.Enabled = false;
				dtpTestDate.Enabled = false;
				return false;
			}
			else
				lblUserMassage.Visible = false;
			return true;	
		}

		private bool _HandleLockedAppointmentConstraint()
		{
			if (_TestAppointment.IsLocked)
			{
				lblUserMassage.Visible = true;
				lblUserMassage.Text = "Person already sat for this test";
				btnSave.Enabled = false;
				dtpTestDate.Enabled = false;
				return false;
			}
			else
				lblUserMassage.Visible = false;
			return true;
		}

		private bool _HandlePreviousTestConstraint()
		{
			switch(_TestTypeId)
			{
				case clsTestType.enTestType.VisionTest:
					lblUserMassage.Visible = false;
					return true;
					
				case clsTestType.enTestType.WrittenTest:
					{
						if(!_LocalDrivingLicenseApp.DoesPassTestType(clsTestType.enTestType.VisionTest))
						{
							lblUserMassage.Text = "Cannot Schedule, Vision Test should be passed first";
							btnSave.Enabled = false;
							dtpTestDate.Enabled = false;
							lblUserMassage.Visible = true;
							return false;
						}
						else
						{
							lblUserMassage.Visible = false;
							btnSave.Enabled = true;
							dtpTestDate.Enabled = true;
						}
					
					}
					break;
				case clsTestType.enTestType.StreetTest:
					{
						if (!_LocalDrivingLicenseApp.DoesPassTestType(clsTestType.enTestType.WrittenTest))
						{
							lblUserMassage.Text = "Cannot Schedule, Written Test should be passed first";
							btnSave.Enabled = false;
							dtpTestDate.Enabled = false;
							lblUserMassage.Visible = true;
							return false;
						}
						else
						{
							lblUserMassage.Visible = false;
							btnSave.Enabled = true;
							dtpTestDate.Enabled = true;
						}
						
					}
					break;
			}
			return true;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!_HandleRetakeTestApplication())
				return;

			_TestAppointment.LocalDrivingLicenseAppID = _LocalDrivingLicenseApp.LocalDrivingLicenseAppID;
			_TestAppointment.AppointmentDate = dtpTestDate.Value;
			_TestAppointment.PaidFees = Convert.ToSingle(lblAppFees.Text);
			_TestAppointment.TestTypeID = _TestTypeId;
			_TestAppointment.UserID = Globals.Global.CurrentUser.UserID;

			if(_TestAppointment.Save())
			{
				_Mode = enMode.Update;
				MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
				MessageBox.Show("Error: Data is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

		}

		private bool _HandleRetakeTestApplication()
		{
			if(_Mode == enMode.AddNew && _CreationMode == enCreationMode.RetakeTestSchedule)
			{
				clsApplication application = new clsApplication();
				application.ApplicantPersonID = _LocalDrivingLicenseApp.ApplicantPersonID;
				application.ApplicationDate = DateTime.Now;
				application.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
				application.ApplicationTypeID = clsApplication.enApplicationType.RetakeTest;
				application.LastStatusDate = DateTime.Now;
				application.PaidFees = clsApplicationType.Find((int)clsApplication.enApplicationType.RetakeTest).ApplicationFees;
				application.UserID = Globals.Global.CurrentUser.UserID;
				if(!application.Save())
				{
					_TestAppointment.RetakeTestApplicationId = -1;
					MessageBox.Show("Failed to Create application", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
					
				}

				_TestAppointment.RetakeTestApplicationId = application.ApplicationID;
				
			}
			return true;
		}

	}
}
