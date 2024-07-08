using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsInternationalLicense
    {
        enum enMode { AddNew = 1, Update = 2 }
        enMode _Mode;

        
        public int InternationalLicenseID;
        public int ApplicationId;
        public int DriverID;
        public int LicenseID;
        public DateTime IssueDate;
        public DateTime ExpirationDate;
        public bool IsActive;
        public int UserID;


        public clsInternationalLicense()
        {
            InternationalLicenseID = -1;
            ApplicationId = -1;
            DriverID = -1;
            LicenseID = -1;
            IssueDate = DateTime.Now;
            ExpirationDate=DateTime.Now;
            IsActive = false;
            UserID = -1;
            _Mode=enMode.AddNew;
        }

        private clsInternationalLicense(int internationalID,int applicationID,int driverID,
            int licenseID,DateTime issueDate,DateTime expirationDate,bool isActive ,int userID)
        {
            InternationalLicenseID=internationalID;
            ApplicationId=applicationID;
            DriverID=driverID;
            LicenseID=licenseID;
            IssueDate=issueDate;
            ExpirationDate=expirationDate;
            IsActive = isActive;
            UserID=userID;
            _Mode = enMode.Update;
        }

        private bool _AddNewLicense()
        {
            int InternationalLicenseID = clsInternationalLicenseData.AddNewInternationaLicense(ApplicationId, DriverID, LicenseID, IssueDate, ExpirationDate, IsActive, UserID);
            return InternationalLicenseID != -1;
        }

        private bool _UpdateLicense()
        {
            return clsInternationalLicenseData.UpdateInternationaLicense(InternationalLicenseID, ApplicationId, DriverID, LicenseID, IssueDate, ExpirationDate, IsActive, UserID);
        }

        public static clsInternationalLicense Find(int internationalLicenseID)
        {

            int applicationId = -1;
            int driverID = -1;
            int licenseID = -1;
            DateTime issueDate = DateTime.Now;
            DateTime expirationDate = DateTime.Now;
            bool isActive = false;
            int userID = -1;

            if (clsInternationalLicenseData.GetLicenseByID(internationalLicenseID, ref applicationId, ref driverID, ref licenseID, ref issueDate, ref expirationDate, ref isActive, ref userID))
            {
                return new clsInternationalLicense(internationalLicenseID,applicationId,driverID, licenseID,issueDate,expirationDate,isActive,userID);
            }
            else
                return null;

        }

        public static DataTable GetAll()
        {
            return clsInternationalLicenseData.GetAllInternationalLicenses();
        }

        public static bool Delete(int internationalLicenseID)
        {
            return clsInternationalLicenseData.DeleteInternationalLicense(internationalLicenseID);
        }

        public static bool IsLicenseExist(int internationalLicenseID)
        {
            return clsLicenseData.IsLicenseExist(internationalLicenseID);
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
