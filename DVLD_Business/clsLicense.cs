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

        public enum enIssueReason { FirstTime = 1, Renew = 2, DamagedReplacement = 3, LostReplacement = 4 };
        public enIssueReason IssueReason;

		public int LicenseID { get; set; }
        public int ApplicationId { get; set; }

        public int DriverID { get; set; }
        public clsDriver DriverInfo { get; set; }
        public int LicenseClassID { get; set; }
        public clsLicenseClass LicenseClassInfo { get; set; }  
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public float PaidFees { get; set; }
        public bool IsActive { get; set; }
        public int UserID { get; set; }

		public string IssueReasonText
		{
			get
			{
				return _GetIssueReasonText(this.IssueReason);
			}
		}


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
            IsActive = true;
            IssueReason = enIssueReason.FirstTime;
            UserID = -1;
            _Mode = enMode.AddNew;
        }

        private clsLicense(int licenseID,int applicationID,int driverID,int classID,DateTime issueDate,
            DateTime expirationDate,string notes ,float paidFees,bool isActive,enIssueReason issueReason,int userID)
        {
            LicenseID=licenseID;
            ApplicationId=applicationID;
            DriverID=driverID;
            DriverInfo = clsDriver.Find(DriverID);
            LicenseClassID=classID;
            LicenseClassInfo = clsLicenseClass.Find(LicenseClassID);
            IssueDate=issueDate;
            ExpirationDate=expirationDate;
            Notes=notes;
            PaidFees= paidFees;
            IsActive=isActive;
            IssueReason=issueReason;
            UserID=userID;
            _Mode = enMode.Update;
        }

        private string _GetIssueReasonText(enIssueReason issueReason)
        {
            switch (issueReason)
            {
                case enIssueReason.FirstTime:
                    return "First Time";
                   
                case enIssueReason.Renew:
                    return "Renew";
                case enIssueReason.DamagedReplacement:
                    return "Replacement For Damage";
                case enIssueReason.LostReplacement:
                    return "Replacement For Lost";
                default:
                    return "unknown";
            }
        }


		private bool _AddNewLicense()
        {
             this.LicenseID  = clsLicenseData.AddNewLicense(ApplicationId, DriverID, LicenseClassID,IssueDate,ExpirationDate,Notes,PaidFees,IsActive,(byte)IssueReason,UserID);
            return this.LicenseID != -1;
        }
        
        private bool _UpdateLicense()
        {
            return clsLicenseData.UpdateLicense(LicenseID,ApplicationId, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, (byte)IssueReason, UserID);
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
            byte issueReason = 0;
            int userID = -1;

            if (clsLicenseData.GetLicenseByID(licenseID, ref applicationId, ref driverID, ref licenseClassID, ref issueDate, ref expirationDate, ref notes, ref paidFees, ref isActive, ref issueReason, ref userID))
            {
                return new clsLicense(licenseID,applicationId,driverID,licenseClassID,issueDate,expirationDate,notes,paidFees,isActive,(enIssueReason)issueReason,userID);
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
            byte issueReason = 0;
            int userID = -1;

            if (clsLicenseData.GetLicenseByApplicationID(applicationId, ref licenseID , ref driverID, ref licenseClassID, ref issueDate, ref expirationDate, ref notes, ref paidFees, ref isActive, ref issueReason, ref userID))
            {
                return new clsLicense(licenseID, applicationId, driverID, licenseClassID, issueDate, expirationDate, notes, paidFees, isActive, (enIssueReason)issueReason, userID);
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
        public static bool IsLicenseActive(int licenseID)
        {
            return clsLicenseData.IsLicenseActive(licenseID);
        }
        public static int IsLicenseDetained(int licenseID)
        {
            return clsLicenseData.IsLicenseDetainedAndNotReleased(licenseID);
        }

        public static bool IsLicenseExpired(int licenseID)
        {
            return clsLicenseData.IsLicenseExpired(licenseID);
        }

        public static int IsLicenseInternational(int licenseID)
        {
            return clsLicenseData.IsLicenseInternational(licenseID);
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

        public static bool DeactivateLicense(int licenseID, bool newActivity)
        {
            return clsLicenseData.DeactivateLicense(licenseID, newActivity);
        }

        public static int GetActiveLicenseByPersonId(int personID, int licenseClassId)
        {
            return clsLicenseData.GetActiveLicenseIDByPersonID(personID, licenseClassId);
        }
        
        public static bool IsLicenseExistByPersonId (int personID, int licenseClassId)
        {
            return clsLicenseData.GetActiveLicenseIDByPersonID(personID, licenseClassId) != -1;
        }


    }
}
