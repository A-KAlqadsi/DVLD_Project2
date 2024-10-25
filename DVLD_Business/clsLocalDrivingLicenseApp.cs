using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsLocalDrivingLicenseApp:clsApplication
    {
        enum enMode { AddNew=1,Update=2 }
        enMode _Mode = enMode.AddNew;

        public int LocalDrivingLicenseAppID;
        public int LicenseClassID { get; set; }
        public clsLicenseClass LicenseClassInfo { get; set; }

        public string PersonFullName
        {
            get
            {
                return base.PersonInfo.FullName;
            }
        }

        public clsLocalDrivingLicenseApp()
        {
            LocalDrivingLicenseAppID = -1;
            LicenseClassID = -1;
            _Mode=enMode.AddNew;
        }

        private clsLocalDrivingLicenseApp(int localDrivingLicenseID,int licenseClassID, int applicationID, int applicantPersonID, DateTime applicationDate,
			enApplicationType applicationTypeId, enApplicationStatus applicationStatus, DateTime lastStatusDate, float paidFees, int userID)
        {
            this.LocalDrivingLicenseAppID = localDrivingLicenseID;
            this.ApplicationID = applicationID;
            this.LicenseClassID = licenseClassID;
            this.ApplicantPersonID = applicantPersonID;
            this.ApplicationDate = applicationDate;
            this.ApplicationTypeID = applicationTypeId;
            this.ApplicationStatus = applicationStatus;
            this.LastStatusDate = lastStatusDate;
            this.PaidFees = paidFees;
            this.UserID = userID;
            this.LicenseClassInfo = clsLicenseClass.Find(licenseClassID);
            _Mode = enMode.Update;
        }

        private bool _AddNew()
        {
            this.LocalDrivingLicenseAppID = clsLocalDrivingLicenseAppData.AddNewLocalLicenseDrivingApp(ApplicationID, LicenseClassID);
            return LocalDrivingLicenseAppID != -1;
        }

        private bool _Update()
        {
            return clsLocalDrivingLicenseAppData.UpdateLocalLicenseDrivingApp(this.LocalDrivingLicenseAppID, this.ApplicationID,this.LicenseClassID);
        }

        public static clsLocalDrivingLicenseApp Find(int localDrivingLicenseID)
        {
            int appID = -1;
            int classId = -1;
            bool isFound = clsLocalDrivingLicenseAppData.GetLocalDrivingLicenseAppByID(localDrivingLicenseID, ref appID, ref classId);

			if (isFound)
            {
                clsApplication application = clsApplication.FindBaseApplication(appID);

                return new clsLocalDrivingLicenseApp(localDrivingLicenseID,classId, 
                    application.ApplicationID,application.ApplicantPersonID
                    ,application.ApplicationDate,application.ApplicationTypeID,
                    application.ApplicationStatus,application.LastStatusDate,
                    application.PaidFees,application.UserID);
            }
            else 
                return null;
        }

		public static clsLocalDrivingLicenseApp FindByApplicationId(int applicationId)
		{
			int localDrivingLicenseID = -1;
			int classId = -1;
			bool isFound = clsLocalDrivingLicenseAppData.GetLocalDrivingLicenseAppByID(applicationId, ref localDrivingLicenseID, ref classId);

			if (isFound)
			{
				clsApplication application = clsApplication.FindBaseApplication(applicationId);

				return new clsLocalDrivingLicenseApp(localDrivingLicenseID, classId,
					application.ApplicationID, application.ApplicantPersonID
					, application.ApplicationDate, application.ApplicationTypeID,
					application.ApplicationStatus, application.LastStatusDate,
					application.PaidFees, application.UserID);
			}
			else
				return null;
		}


		public bool Delete()
        {
            // we first delete the local application then the base application
            bool isLocalDeleted = false;
            bool isBaseDeleted = false;

            isLocalDeleted = clsLocalDrivingLicenseAppData.DeleteLocalDrivingLicenseApp(this.LocalDrivingLicenseAppID);

            if (!isLocalDeleted)
                return false;

            isBaseDeleted = base.Delete();
            return isBaseDeleted;
        }


        public static DataTable GetAll()
        {
            return clsLocalDrivingLicenseAppData.GetAllLocalDrivingLicenseApplications();
        }

        public bool Save()
        {
            // first we save the base application then the sub
            base._Mode = (clsApplication.enMode)this._Mode;
            if (!base.Save())
                return false;

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

        public  bool DoesPassTestType( clsTestType.enTestType testTypeId )
        {
            return clsLocalDrivingLicenseAppData.DoesPassTestType(this.LocalDrivingLicenseAppID, (int)testTypeId);
        }
        
        public  bool DoesAttendTestType( clsTestType.enTestType testTypeId )
        {
            return clsLocalDrivingLicenseAppData.DoesAttendTestType(this.LocalDrivingLicenseAppID, (int)testTypeId);
        }
        
        public  bool IsThereAnActiveScheduleTest( clsTestType.enTestType testTypeId )
        {
            return clsLocalDrivingLicenseAppData.IsThereAnActiveScheduleTest(this.LocalDrivingLicenseAppID, (int)testTypeId);
        }

		public byte TotalTrialsPerTest(clsTestType.enTestType TestTypeID)
		{
			return clsLocalDrivingLicenseAppData.TotalTrialsPerTest(this.LocalDrivingLicenseAppID, (int)TestTypeID);
		}

    }
}
