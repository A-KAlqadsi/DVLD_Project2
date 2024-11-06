using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.CompilerServices;
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

        public DetainedLicense DetainedLicenseInfo { get; set; }


		public  bool IsDetained
        {
            get { return DetainedLicense.IsLicenseDetained(this.LicenseID); }
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
            this.DetainedLicenseInfo = DetainedLicense.FindByLicenseID(this.LicenseID);
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

            bool isFound = clsLicenseData.GetLicenseByID(licenseID, ref applicationId,
                ref driverID, ref licenseClassID, ref issueDate, ref expirationDate,
                ref notes, ref paidFees, ref isActive, ref issueReason, ref userID);

			if (isFound)
            {
                return new clsLicense(licenseID,applicationId,driverID,licenseClassID,
                    issueDate,expirationDate,notes,paidFees,isActive,
                    (enIssueReason)issueReason,userID);
            }
            else
                return null;

        }

       
        public static DataTable GetAll()
        {
            return clsLicenseData.GetAllLicenses();
        }

        public static DataTable GetAllDriverLicenses(int driverId)
        {
            return clsLicenseData.GetAllDriverLicenses(driverId);
        }
       
        public bool IsLicenseExpired()
        {
            return this.ExpirationDate < DateTime.Now;
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

        public static int GetActiveLicenseByPersonId(int personID, int licenseClassId)
        {
            return clsLicenseData.GetActiveLicenseIDByPersonID(personID, licenseClassId);
        }
        
        public static bool IsLicenseExistByPersonId (int personID, int licenseClassId)
        {
            return clsLicenseData.GetActiveLicenseIDByPersonID(personID, licenseClassId) != -1;
        }

		public bool DeactivateCurrentLicense()
		{
			return clsLicenseData.DeactivateLicense(this.LicenseID);
		}

        // detain and release 
        public int Detain(float fineFees , int createdByUserId)
        {
            DetainedLicense detainedLicense = new DetainedLicense();
            detainedLicense.CreatedByUserID =createdByUserId;
            detainedLicense.LicenseID = this.LicenseID;
            detainedLicense.FineFees = fineFees;

            if (detainedLicense.Save())
                return detainedLicense.DetainID;
            else
                return -1;

        }
        
        public bool ReleaseDetainedLicense(int releaseByUserId, ref int applicationId)
        {
            clsApplication application = new clsApplication();
            application.ApplicationDate = DateTime.Now;
            application.ApplicationTypeID = clsApplication.enApplicationType.ReleaseDetainedDrivingLicense;
            application.PaidFees = clsApplicationType.Find((int)clsApplication.enApplicationType.RenewDrivingLicense).ApplicationFees;
            application.ApplicantPersonID = DriverInfo.PersonID;
            application.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            application.LastStatusDate = DateTime.Now;
            application.UserID = releaseByUserId;

            if(!application.Save())
            {
                applicationId = -1;
                return false;
            }
            applicationId = application.ApplicationID;

            return this.DetainedLicenseInfo.ReleaseDetainedLicense(releaseByUserId,applicationId);
        }

        // renew 
        public clsLicense RenewLicense(string notes, int createdByUserId )
        {
            clsApplication application = new clsApplication();
			application.ApplicationDate = DateTime.Now;
			application.ApplicationTypeID = clsApplication.enApplicationType.RenewDrivingLicense;
			application.PaidFees = clsApplicationType.Find((int)clsApplication.enApplicationType.RenewDrivingLicense).ApplicationFees;
			application.ApplicantPersonID = DriverInfo.PersonID;
			application.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
			application.LastStatusDate = DateTime.Now;
			application.UserID = createdByUserId;

            if (!application.Save())
                return null;

            clsLicense newLicense = new clsLicense();
            newLicense.UserID = createdByUserId;
            newLicense.ApplicationId= application.ApplicationID;
            newLicense.DriverID = this.DriverInfo.DriverID;
			newLicense.IsActive = true;
            newLicense.LicenseClassID = this.LicenseClassID;

            int validityLength = this.LicenseClassInfo.ValidityLength;
			newLicense.IssueDate = DateTime.Now;
			newLicense.ExpirationDate = DateTime.Now.AddYears(validityLength);
            newLicense.IssueReason = enIssueReason.Renew;
			newLicense.Notes = notes;

            if (!newLicense.Save())
                return null;

            DeactivateCurrentLicense();

            return newLicense;
		}
		// replace
        public clsLicense Replace(enIssueReason issueReason, int createdByUserId)
        {
            clsApplication application = new clsApplication();

            application.UserID = createdByUserId;
            application.ApplicantPersonID = this.DriverInfo.PersonID;
            application.ApplicationDate = DateTime.Now;
            application.LastStatusDate = DateTime.Now;
            application.ApplicationStatus = clsApplication.enApplicationStatus.Completed;

            application.ApplicationTypeID = (issueReason == enIssueReason.LostReplacement) ? 
                                            clsApplication.enApplicationType.ReplaceLostDrivingLicense :
                                            clsApplication.enApplicationType.ReplaceDamagedDrivingLicense;
            application.PaidFees = clsApplicationType.Find(((int)application.ApplicationTypeID)).ApplicationFees;

            if (!application.Save())
                return null;

            clsLicense newLicense = new clsLicense();

			newLicense.UserID = createdByUserId;
			newLicense.ApplicationId = application.ApplicationID;
			newLicense.DriverID = this.DriverID;
			newLicense.IsActive = true;
			newLicense.LicenseClassID = this.LicenseClassID;
            newLicense.PaidFees = 0;

			newLicense.IssueDate = DateTime.Now;
            newLicense.ExpirationDate = this.ExpirationDate;
			newLicense.IssueReason = issueReason;
            newLicense.Notes = this.Notes;

            if (!newLicense.Save())
                return null;

            DeactivateCurrentLicense();

            return newLicense;
		}



		// will be kicked soon
		public static int IsLicenseInternational(int licenseID)
		{
			return clsLicenseData.IsLicenseInternational(licenseID);
		}
		// will be kicked soon
		public static bool IsApplicationHasLicense(int applicationID)
		{
			return clsLicenseData.IsApplicationHasLicense(applicationID);
		}

		// will be kicked soon
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

			if (clsLicenseData.GetLicenseByApplicationID(applicationId, ref licenseID, ref driverID, ref licenseClassID, ref issueDate, ref expirationDate, ref notes, ref paidFees, ref isActive, ref issueReason, ref userID))
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
		// will be kicked soon
		public static bool IsLicenseExpired(int licenseID)
		{
			return clsLicenseData.IsLicenseExpired(licenseID);
		}
		public static bool DeactivateLicense(int licenseID, bool newActivity)
		{
			return clsLicenseData.DeactivateLicense(licenseID, newActivity);

		}

		public static bool IsLicenseActive(int licenseID)
		{
			return clsLicenseData.IsLicenseActive(licenseID);
		}

		public static int IsLicenseDetained(int licenseID)
		{
			return clsLicenseData.IsLicenseDetainedAndNotReleased(licenseID);
		}


	}
}
