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

        public int TestAppointmentID;
        public int TestTypeID;
        public int LocalDrivingLicenseAppID;
        public DateTime AppointmentDate;
        public float PaidFees;
        public int UserID;
        public bool IsLocked;
        public clsTestAppointment()
        {
            TestAppointmentID = -1;
            TestTypeID = -1;
            LocalDrivingLicenseAppID = -1;
            AppointmentDate = DateTime.Now;
            PaidFees = 0;
            UserID = -1;
            IsLocked = false;
            _Mode = enMode.AddNew;
        }

        private clsTestAppointment(int ID,int testTypeID,int localDrivingLicenseID,DateTime appointmentDate,
            float paidFees,int userID,bool isLocked)
        {
            TestAppointmentID=ID;
            TestTypeID=testTypeID;
            LocalDrivingLicenseAppID=localDrivingLicenseID;
            AppointmentDate=appointmentDate;
            PaidFees=paidFees;
            UserID=userID;
            IsLocked =isLocked;
            _Mode = enMode.Update;
        }

        private bool _AddNew()
        {
             TestAppointmentID = clsTestAppointmentData.AddNewTestAppointment(TestTypeID, LocalDrivingLicenseAppID, AppointmentDate, PaidFees, UserID, IsLocked);
            return TestAppointmentID != -1;
        }
        
        private bool _Update()
        {
            return clsTestAppointmentData.UpdateTestAppointment(TestAppointmentID, TestTypeID, LocalDrivingLicenseAppID, AppointmentDate, PaidFees, UserID, IsLocked);

        }

        public static clsTestAppointment Find(int testAppointmentID)
        {
            int testType = 0, localDrivingLicense = 0, userID = 0;
            DateTime appointmentDate = DateTime.Now;
            float paidFees = 0;
            bool isLocked = false;
            if(clsTestAppointmentData.GetTestAppointmentByID(testAppointmentID,ref testType,ref localDrivingLicense,ref appointmentDate,ref paidFees,ref userID,ref isLocked))
            {
                return new clsTestAppointment(testAppointmentID,testType, localDrivingLicense, appointmentDate, paidFees, userID, isLocked);
            }
            else 
                return null;
        }

        public static bool Delete(int testAppointmentID) 
        {
            return clsTestAppointmentData.DeleteTestAppointment(testAppointmentID);
        }

        public static DataTable GetAll()
        {
            return clsTestAppointmentData.GetAllTestAppointments();
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

        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNew:
                    {
                        if(_AddNew())
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
