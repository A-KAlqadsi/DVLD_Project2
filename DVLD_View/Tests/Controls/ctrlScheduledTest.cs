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
	public partial class ctrlScheduledTest : UserControl
	{
		private clsTestType.enTestType _TestTypeId = clsTestType.enTestType.VisionTest;
		public clsTestType.enTestType TestTypeId
		{
			get { return _TestTypeId; }
			set
			{
				_TestTypeId = value;
				switch(_TestTypeId)
				{
					case clsTestType.enTestType.VisionTest:
						lblMode.Text = "Vision Test";
						pbTestAppointment.Image = Resources.Vision_512;
						break;
					case clsTestType.enTestType.WrittenTest:
						lblMode.Text = "Written Test";
						pbTestAppointment.Image = Resources.Written_Test_512;
						break;
					case clsTestType.enTestType.StreetTest:
						lblMode.Text = "Street Test";
						pbTestAppointment.Image = Resources.driving_test_512;
						break;
				}
			}
		}

		private int _TestAppointmentId;
		public int TestAppointmentId
		{
			get { return _TestAppointmentId; }
		}

		private int _TestId = -1;
		public int TestId
		{
			get
			{
				return _TestId;
			}
		}

		private int _LocalDrivingLicenseAppId;
		private clsLocalDrivingLicenseApp _LocalDrivingLicenseApp;
		private clsTestAppointment _TestAppointment;

		public ctrlScheduledTest()
		{
			InitializeComponent();
		}

		public void LoadInfo(int testAppointmentId)
		{
			_TestAppointmentId = testAppointmentId;
			_TestAppointment = clsTestAppointment.Find(_TestAppointmentId);

			if( _TestAppointment == null )
			{
				MessageBox.Show("Error: No  Appointment ID = " + _TestAppointmentId.ToString(),
				   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				_TestAppointmentId = -1;
				return;
			}

			_LocalDrivingLicenseAppId = _TestAppointment.LocalDrivingLicenseAppID;

			_TestId = _TestAppointment.TestId;

			_LocalDrivingLicenseApp = clsLocalDrivingLicenseApp.Find(_LocalDrivingLicenseAppId);

			if (_LocalDrivingLicenseApp == null)
			{
				MessageBox.Show("Error: No  Local Driving License Application ID = " + _LocalDrivingLicenseAppId.ToString(),
				   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				_LocalDrivingLicenseAppId = -1;
				return;
			}

			lblApplicant.Text = _LocalDrivingLicenseApp.ApplicantFullName;
			lblClassName.Text = _LocalDrivingLicenseApp.LicenseClassInfo.ClassName;
			lblDLAppID.Text = _LocalDrivingLicenseApp.LocalDrivingLicenseAppID.ToString();

			lblTrial.Text = _LocalDrivingLicenseApp.TotalTrialsPerTest(_TestTypeId).ToString();

			lblTestDate.Text = Globals.Format.DateToShort(_TestAppointment.AppointmentDate);
			lblAppFees.Text = _TestAppointment.PaidFees.ToString();
			lblTestID.Text = (_TestAppointment.TestId == -1) ? "Not Taken Yet" : _TestAppointment.TestId.ToString();

		}


	}
}
