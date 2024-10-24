using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsApplication
    {
		public enum enApplicationType
		{
			NewDrivingLicense = 1, RenewDrivingLicense = 2, ReplaceLostDrivingLicense = 3,
			ReplaceDamagedDrivingLicense = 4, ReleaseDetainedDrivingLicense = 5, NewInternationalLicense = 6, RetakeTest = 7
		};

        public enum enApplicationStatus  {New =1, Cancelled= 2, Completed=3 };

		private enum enMode { AddNew = 1, Update = 2 };

		public enApplicationStatus ApplicationStatus { get; set; }
        public string StatusText
        {
            get
            {
				switch (ApplicationStatus)
				{
					case enApplicationStatus.New:
						return "New";
					case enApplicationStatus.Cancelled:
						return "Cancelled";
					case enApplicationStatus.Completed:
						return "Completed";
					default:
						return "Unknown";
				}
			}
        }

		
        enMode _Mode = enMode.AddNew;

        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public clsPerson PersonInfo { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }

        public clsApplicationType ApplicationTypeInfo { get; set; }


		public DateTime LastStatusDate { get; set; }
        public float PaidFees { get; set; }
        public int UserID { get; set; }
        public clsUser UserInfo { get; set; }


		public clsApplication()
        {
            ApplicationID = -1;
            ApplicantPersonID = -1;
            ApplicationDate = DateTime.Now;
            ApplicationTypeID = -1;
            ApplicationStatus = enApplicationStatus.New;
            LastStatusDate = DateTime.Now;
            PaidFees = 0;
            UserID = -1;
            _Mode = enMode.AddNew;

        }

        private clsApplication(int applicationID, int applicantPersonID, DateTime applicationDate,
            int applicationTypeId, enApplicationStatus applicationStatus, DateTime lastStatusDate, float paidFees, int userID)
        {
            ApplicationID = applicationID;
			ApplicationDate = applicationDate;

			ApplicantPersonID = applicantPersonID;
			PersonInfo = clsPerson.Find(applicantPersonID);

            ApplicationTypeID = applicationTypeId;
			ApplicationTypeInfo = clsApplicationType.Find(applicationTypeId);

			ApplicationStatus = applicationStatus;
            LastStatusDate = lastStatusDate;
            PaidFees = paidFees;

            UserID = userID;
            UserInfo = clsUser.Find(userID);
            _Mode = enMode.Update;
        }

        private bool _AddNewApplication()
        {
            ApplicationID = clsApplicationData.AddNewApplication(ApplicantPersonID,
                 ApplicationDate, ApplicationTypeID,(byte)ApplicationStatus, LastStatusDate, PaidFees, UserID);
            return ApplicationID != -1;
        }

        private bool _UpdateApplication()
        {
            return clsApplicationData.UpdateApplication(ApplicationID, ApplicantPersonID,
                ApplicationDate, ApplicationTypeID, (byte)ApplicationStatus, LastStatusDate, PaidFees, UserID);
        }

        public static clsApplication FindBaseApplication(int applicationID)
        {

            int ApplicantPersonID = -1;
            DateTime applicationDate = DateTime.Now;
            int applicationTypeID = -1;
            byte applicationStatus = 0;
            DateTime lastStatusDate = DateTime.Now;
            float paidFees = 0;
            int userID = -1;
            if (clsApplicationData.GetApplicationById(applicationID, ref ApplicantPersonID,
                ref applicationDate, ref applicationTypeID, ref applicationStatus,
                ref lastStatusDate, ref paidFees, ref userID))
            {
                return new clsApplication(applicationID, ApplicantPersonID, applicationDate, applicationTypeID,(enApplicationStatus)applicationStatus, lastStatusDate, paidFees, userID);
            }
            else
                return null;

        }

        public static bool UpdateApplicationStatus(int applicationID, byte newStatus)
        {
            return clsApplicationData.UpdateApplicationStatus(applicationID, newStatus);
        }

        public static bool Delete(int applicationID)
        {
            return clsApplicationData.DeleteApplication(applicationID);
        }

        public static bool IsApplicationExist(int applicationID)
        {
            return clsApplicationData.IsApplicationExist(applicationID);
        }

        public static short GetStatus(int applicationID)
        {
            return clsApplicationData.GetApplicationStatus(applicationID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewApplication())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
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

        public  bool Cancel()
        {
            return clsApplicationData.UpdateApplicationStatus(this.ApplicationID, 2);
        }

        public bool SetComplete()
        {
            return clsApplicationData.UpdateApplicationStatus(this.ApplicationID, 3);
        }

        public static bool DoesPersonHasActiveApplication(int personId, int applicationTypeId)
        {
            return clsApplicationData.DosePersonHasActiveApplications(personId, applicationTypeId); ;
        }

		public  bool DoesPersonHasActiveApplication( int applicationTypeId)
		{
			return clsApplicationData.DosePersonHasActiveApplications( this.ApplicantPersonID,applicationTypeId); ;
		}

		public static  int GetActiveApplicationId(int personId, enApplicationType applicationTypeId)
        {
            return clsApplicationData.GetActiveApplicationId(personId, (int)applicationTypeId);
        }
		public int GetActiveApplicationId( enApplicationType applicationTypeId)
		{
			return clsApplicationData.GetActiveApplicationId(this.ApplicantPersonID, (int)applicationTypeId);
		}

		public static int GetActiveApplicationIdForLicenseClass(int personId, enApplicationType applicationTypeId, int licenseClassId)
        {
            return clsApplicationData.GetActiveApplicationIdForLicenseClass(personId, (int)applicationTypeId, licenseClassId);
        }
    }
}
