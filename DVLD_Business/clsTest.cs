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
        
        public int TestID { get; }
        public int TestAppointmentID;
        public bool TestResult;
        public string Notes;
        public int UserID;
        
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
            TestResult=testResult;
            Notes=notes;
            UserID=userID;
            _Mode = enMode.Update;
        }

        private bool _AddNew()
        {
            int testID =clsTestData.AddNewTest(TestAppointmentID,TestResult,Notes,UserID);
            return testID != -1;
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

        public static bool Delete(int testID)
        {
            return clsTestData.DeleteTest(testID);
        }
        
        public static DataTable GetAll()
        {
            return clsTestData.GetAllTests();
        }

        public static bool IsTestExist(int testID)
        {
            return clsTestData.IsTestExist(testID);
        }

        public static int CountPassedTest(int localDrivingLicenseApplicationID)
        {
            return clsTestData.CountPassedTests(localDrivingLicenseApplicationID);
        }

        public static bool IsTestPassed(int localDrivingLicenseApplicationID, int testTypeID, bool testResult=true)
        {
            return clsTestData.IsTestPassed(localDrivingLicenseApplicationID,testTypeID,testResult);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        _Mode = enMode.Update;
                        if (_AddNew())
                            return true;
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
