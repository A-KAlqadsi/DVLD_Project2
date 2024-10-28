using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsTest
    {
        enum enMode { AddNew = 1, Update = 2 }
        enMode _Mode = enMode.AddNew;
        
        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public clsTestAppointment TestAppointmentInfo { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int UserID { get; set; }
        
        public clsTest()
        {
            TestID = -1;
            TestAppointmentID = -1;
            TestResult = false;
            Notes =string.Empty;
            _Mode=enMode.AddNew;
        }

        private clsTest(int testID,int testAppointmentID,bool testResult ,string notes,int userID)
        {
            TestID=testID;
            TestAppointmentID=testAppointmentID;
            TestAppointmentInfo = clsTestAppointment.Find(testAppointmentID);
            TestResult=testResult;
            Notes=notes;
            UserID=userID;
            _Mode = enMode.Update;
        }

        private bool _AddNew()
        {
            this.TestID =clsTestData.AddNewTest(TestAppointmentID,TestResult,Notes,UserID);
            return this.TestID != -1;
        }

        private bool _Update()
        {
            return clsTestData.UpdateTest(TestID, TestAppointmentID, TestResult, Notes, UserID);
        }

        public static clsTest Find(int testID)
        {
            int appointmentID = 0, userID = -1;
            bool testResult = false;
            string notes = string.Empty;
            if (clsTestData.GetTestByID(testID, ref appointmentID, ref testResult, ref notes, ref userID))
                return new clsTest(testID, appointmentID, testResult, notes, userID);
            else 
                return null;
        }

		public static clsTest GetLastTestByPersonIdAndTestTypeAndLicenseClass(int personId, int testTypeId, int licenseClassId)
		{
			int appointmentID = 0, userID = -1;
            int testId = -1;
			bool testResult = false;
			string notes = string.Empty;
			if (clsTestData.GetLastTestByPersonIdAndTestTypeAndLicenseClass(personId,testTypeId,licenseClassId,ref testId, ref appointmentID, ref testResult, ref notes, ref userID))
				return new clsTest(testId, appointmentID, testResult, notes, userID);
			else
				return null;
		}

        
        public static DataTable GetAll()
        {
            return clsTestData.GetAllTests();
        }

       
        public static byte CountPassedTest(int localDrivingLicenseApplicationID)
        {
            return clsTestData.CountPassedTests(localDrivingLicenseApplicationID);
        }
        public static bool PassedAllTests(int localDrivingLicenseApplicationID)
        {
            return clsTestData.CountPassedTests(localDrivingLicenseApplicationID) == 3;
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

    }
}
