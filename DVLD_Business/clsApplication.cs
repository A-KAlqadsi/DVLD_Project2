using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsApplication
    {
        private enum enMode { AddNew = 1, Update = 2 };
        enMode _Mode = enMode.AddNew;
        public int ApplicationID { get; }
        public int ApplicantApplicationID;
        public DateTime ApplicationDate;
        public int ApplicationTypeID;
        public short ApplicationStatus;
        public DateTime LastStatusDate;
        public float PaidFees;
        public int UserID;

        public clsApplication()
        {
            ApplicationID = -1;
            ApplicantApplicationID = -1;
            ApplicationDate = DateTime.Now;
            ApplicationTypeID = -1;
            ApplicationStatus = 0;
            LastStatusDate = DateTime.Now;
            PaidFees = 0;
            UserID = -1;
            _Mode = enMode.AddNew;

        }

        private clsApplication(int applicationID, int applicantApplicationID,DateTime applicationDate,
            int applicationTypeId,short applicationSatus,DateTime lastStatusDate,float paidFees,int userID)
        {
            ApplicationID = applicationID;
            ApplicantApplicationID = applicantApplicationID;
            ApplicationDate= applicationDate;
            ApplicationTypeID= applicationTypeId;
            ApplicationStatus= applicationSatus;
            LastStatusDate = lastStatusDate;
            PaidFees = paidFees;
            UserID = userID;
            _Mode = enMode.Update;
        }

        private bool _AddNewApplication()
        {
            int applicationID = clsApplicationData.AddNewApplication(ApplicantApplicationID,
                ApplicationDate,ApplicationTypeID,ApplicationStatus,LastStatusDate,PaidFees,UserID);
            return applicationID != -1;
        }

        private bool _UpdateApplication()
        {
            return clsApplicationData.UpdateApplication(ApplicationID,ApplicantApplicationID,
                ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, UserID);
        }

        public static clsApplication Find(int applicationID)
        {
            
            int applicantApplicationID = -1;
            DateTime applicationDate = DateTime.Now;
            int applicationTypeID = -1;
            short applicationStatus = 0;
            DateTime lastStatusDate = DateTime.Now;
            float paidFees = 0;
            int userID = -1;
            if(clsApplicationData.GetApplicationById(applicationID,ref applicantApplicationID,
                ref applicationDate,ref applicationTypeID,ref applicationStatus,
                ref lastStatusDate,ref paidFees,ref userID))
            {
                return new clsApplication(applicationID, applicantApplicationID, applicationDate, applicationTypeID, applicationStatus, lastStatusDate, paidFees, userID);
            }
            else 
                return null;

        }

        public static DataTable GetAll()
        {
            return clsApplicationData.GetAllApplications();
        }

        public static bool Delete(int applicationID)
        {
            return clsApplicationData.DeleteApplication(applicationID);
        }

        public static bool IsApplicationExist(int applicationID)
        {
            return clsApplicationData.IsApplicationExist(applicationID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        _Mode = enMode.Update;
                        if (_AddNewApplication())
                            return true;
                        else
                            return false;
                    }
                case enMode.Update:
                    {
                        return _UpdateApplication();
                    }
            }
            return false;
        }


    }
}
