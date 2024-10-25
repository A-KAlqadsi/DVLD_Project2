using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsTestAppointment
    {
        enum enMode { AddNew =1,Update=2}
        enMode _Mode = enMode.AddNew;

        public int TestAppointmentID { get; set; }
        public clsTestType.enTestType TestTypeID { get; set; }
        public int LocalDrivingLicenseAppID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public float PaidFees { get; set; }
        public int UserID { get; set; }
        public bool IsLocked { get; set; }

        public int? RetakeTestApplicationId { get; set; }
        public clsApplication RetakeTestApplicationInfo { get; set; }
        
        public int TestId
        {
            get
            {
                return GetTestId();
            }
        }

        public clsTestAppointment()
        {
            TestAppointmentID = -1;
            TestTypeID = clsTestType.enTestType.VisionTest;
            LocalDrivingLicenseAppID = -1;
            AppointmentDate = DateTime.Now;
            PaidFees = 0;
            UserID = -1;
            _Mode = enMode.AddNew;
            RetakeTestApplicationId = null;
        }

        private clsTestAppointment(int ID,clsTestType.enTestType testTypeID,int localDrivingLicenseID,DateTime appointmentDate,
            float paidFees,int userID,bool isLocked, int? retakeTestApplicationId)
        {
            TestAppointmentID=ID;
            TestTypeID=testTypeID;
            LocalDrivingLicenseAppID=localDrivingLicenseID;
            AppointmentDate=appointmentDate;
            PaidFees=paidFees;
            UserID=userID;
            IsLocked =isLocked;
            _Mode = enMode.Update;
            RetakeTestApplicationId = retakeTestApplicationId;
            if (RetakeTestApplicationId != null)
                RetakeTestApplicationInfo = clsApplication.FindBaseApplication(RetakeTestApplicationId ?? -1);
            else
                RetakeTestApplicationInfo = null;
        }

        private bool _AddNew()
        {
             TestAppointmentID = clsTestAppointmentData.AddNewTestAppointment((int)TestTypeID, LocalDrivingLicenseAppID, AppointmentDate, PaidFees, UserID,RetakeTestApplicationId);
            return TestAppointmentID != -1;
        }
        
        private bool _Update()
        {
            return clsTestAppointmentData.UpdateTestAppointment(TestAppointmentID, (int)TestTypeID, LocalDrivingLicenseAppID, AppointmentDate, PaidFees, UserID, IsLocked,RetakeTestApplicationId);
        }

        public static clsTestAppointment Find(int testAppointmentID)
        {
            int testType = 0, localDrivingLicense = 0, userID = 0;
            DateTime appointmentDate = DateTime.Now;
            float paidFees = 0;
            bool isLocked = false;
            int? retakeTestApplicationId = null;
            
            if(clsTestAppointmentData.GetTestAppointmentByID(testAppointmentID,ref testType,ref localDrivingLicense,ref appointmentDate,ref paidFees,ref userID,ref isLocked,ref retakeTestApplicationId))
            {
                return new clsTestAppointment(testAppointmentID,(clsTestType.enTestType)testType, localDrivingLicense, appointmentDate, paidFees, userID, isLocked,retakeTestApplicationId);
            }
            else 
                return null;
        }

		public static clsTestAppointment FindLastTestAppointment(int localDrivingLicenseId, clsTestType.enTestType testTypeId )
		{
			int testAppointmentID = 0, userID = 0;
			DateTime appointmentDate = DateTime.Now;
			float paidFees = 0;
			bool isLocked = false;
			int? retakeTestApplicationId = null;

			if (clsTestAppointmentData.GetLastTestAppointment(localDrivingLicenseId,(int)testTypeId, testAppointmentID, ref appointmentDate, ref paidFees, ref userID, ref isLocked, ref retakeTestApplicationId))
			{
				return new clsTestAppointment(testAppointmentID, testTypeId, localDrivingLicenseId, appointmentDate, paidFees, userID, isLocked, retakeTestApplicationId);
			}
			else
				return null;
		}

		public static DataTable GetAll()
        {
            return clsTestAppointmentData.GetAllTestAppointments();
        }

        public static DataTable GetAllTestAppointmentPerTestType(int localDrivingLicenseId, clsTestType.enTestType testTypeId)
        {
            return clsTestAppointmentData.GetApplicationTestAppointmentsPerTestType(localDrivingLicenseId, (int)testTypeId);
        }

        private int GetTestId()
        {
            return clsTestAppointmentData.GetTestId(this.TestAppointmentID);
        }

		public bool Save()
		{
			switch (_Mode)
			{
				case enMode.AddNew:
					{
						if (_AddNew())
						{
							_Mode = enMode.Update;
							return true;
						}
						else
							return false;
					}
				case enMode.Update:
					return _Update();
			}
			return false;
		}



		public static DataTable GetTestAppointmentMasterByID(int testAppointmentID)
        {
            return clsTestAppointmentData.GetestAppointmentsMasterByID(testAppointmentID);
        }

        public static bool IsTestAppointmentExist(int testAppointmentID)
        {
            return clsTestAppointmentData.IsTestAppointmentExist(testAppointmentID);
        }
        public static bool IsPersonHasActiveTestAppointment(int localDrivingLicenseAppID)
        {
            return clsTestAppointmentData.IsPersonHasActiveTestAppointment(localDrivingLicenseAppID);
        }
        public static bool IsPersonHasTestAppointment(int localDrivingLicenseAppID)
        {
            return clsTestAppointmentData.IsPersonHasTestAppointment(localDrivingLicenseAppID);
        }
        public static int IsTestAppointmentPassed(int testAppointmentID)
        {
            return clsTestAppointmentData.IsTestAppointmentPassed(testAppointmentID);
        }

    }
}
