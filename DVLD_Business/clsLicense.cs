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
            int licenseID= clsLicenseData.AddNewLicense(ApplicationId, DriverID, LicenseClassID,IssueDate,ExpirationDate,Notes,PaidFees,IsActive,IssueReason,UserID);
            return licenseID != -1;
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
                return new clsLicense();
            }
            else
                return null;

        }

        public static DataTable GetAll()
        {
            return clsLicenseData.GetAllLicenses();
        }
        
        public static bool Delete(int licenseID)
        {
            return clsLicenseData.DeleteLicense(licenseID);
        }

        public static bool IsLicenseExist(int licenseID)
        {
            return clsLicenseData.IsLicenseExist(licenseID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        _Mode = enMode.Update;
                        if (_AddNewLicense())
                            return true;
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
