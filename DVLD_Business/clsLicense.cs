using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsLicense
    {
        enum enMode { AddNew =1,Update=2 }
        enMode _Mode;

        public int LicenseID;
        public int ApplicationId;
        public int DriverID;
        public int LicenseClassID;
        public DateTime IssueDate;
        public DateTime ExpirationDate;
        public string Notes;
        public float PaidFees;
        public bool IsActive;
        public short IssueReason;
        public int UserID;

        public clsLicense()
        {
            LicenseID = -1;
            ApplicationId = -1;
            DriverID = -1;
            LicenseClassID = -1;
            IssueDate = DateTime.Now;
            ExpirationDate=DateTime.Now;
            Notes= string.Empty;
            PaidFees= 0;
            IsActive = false;
            IssueReason = 0;
            UserID = -1;
            _Mode = enMode.AddNew;
        }

        private clsLicense(int licenseID,int applicationID,int driverID,int classID,DateTime issueDate,
            DateTime expirationDate,string notes ,float paidFees,bool isActive,short issueReason,int userID)
        {
            LicenseID=licenseID;
            ApplicationId=applicationID;
            DriverID=driverID;
            LicenseClassID=classID;
            IssueDate=issueDate;
            ExpirationDate=expirationDate;
            Notes=notes;
            PaidFees= paidFees;
            IsActive=isActive;
            IssueReason=issueReason;
            UserID=userID;
            _Mode = enMode.Update;
        }

        private bool _AddNewLicense()
        {
             this.LicenseID  = clsLicenseData.AddNewLicense(ApplicationId, DriverID, LicenseClassID,IssueDate,ExpirationDate,Notes,PaidFees,IsActive,IssueReason,UserID);
            return this.LicenseID != -1;
        }
        
        private bool _UpdateLicense()
        {
            return clsLicenseData.UpdateLicense(LicenseID,ApplicationId, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, UserID);
        }

        public static clsLicense Find(int licenseID)
        {
            
            int applicationId = -1;
            int driverID = -1;
            int licenseClassID = -1;
            DateTime issueDate = DateTime.Now;
            DateTime expirationDate = DateTime.Now;
            string notes = string.Empty;
            float paidFees = 0;
            bool isActive = false;
            short issueReason = 0;
            int userID = -1;

            if (clsLicenseData.GetLicenseByID(licenseID, ref applicationId, ref driverID, ref licenseClassID, ref issueDate, ref expirationDate, ref notes, ref paidFees, ref isActive, ref issueReason, ref userID))
            {
                return new clsLicense(licenseID,applicationId,driverID,licenseClassID,issueDate,expirationDate,notes,paidFees,isActive,issueReason,userID);
            }
            else
                return null;

        }

        public static clsLicense FindByApplicationID(int applicationId)
        {

            int licenseID = -1;
            int driverID = -1;
            int licenseClassID = -1;
            DateTime issueDate = DateTime.Now;
            DateTime expirationDate = DateTime.Now;
            string notes = string.Empty;
            float paidFees = 0;
            bool isActive = false;
            short issueReason = 0;
            int userID = -1;

            if (clsLicenseData.GetLicenseByApplicationID(applicationId, ref licenseID , ref driverID, ref licenseClassID, ref issueDate, ref expirationDate, ref notes, ref paidFees, ref isActive, ref issueReason, ref userID))
            {
                return new clsLicense(licenseID, applicationId, driverID, licenseClassID, issueDate, expirationDate, notes, paidFees, isActive, issueReason, userID);
            }
            else
                return null;

        }
        public static DataTable FindMaster(int licenseID)
        {
            return clsLicenseData.GetLicenseByIdMaster(licenseID);
        }
        public static DataTable GetAll()
        {
            return clsLicenseData.GetAllLicenses();
        }
        public static DataTable GetAllDriverLicenses(int driverId)
        {
            return clsLicenseData.GetAllDriverLicenses(driverId);
        }
        public static bool Delete(int licenseID)
        {
            return clsLicenseData.DeleteLicense(licenseID);
        }

        public static bool IsLicenseExist(int licenseID)
        {
            return clsLicenseData.IsLicenseExist(licenseID);
        }
        public static bool IsApplicationHasLicense(int applicationID)
        {
            return clsLicenseData.IsApplicationHasLicense(applicationID);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        
                        if (_AddNewLicense())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.Update:
                    return _UpdateLicense();
            }
            return false;
        }

    }
}
