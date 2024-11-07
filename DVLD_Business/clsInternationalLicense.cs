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
    public class clsInternationalLicense:clsApplication
    {

		public enum enMode { AddNew = 0, Update = 1 };
		public enMode Mode = enMode.AddNew;

		public clsDriver DriverInfo;
		public int InternationalLicenseID { set; get; }
		public int DriverID { set; get; }
		public int IssuedUsingLocalLicenseID { set; get; }
		public DateTime IssueDate { set; get; }
		public DateTime ExpirationDate { set; get; }
		public bool IsActive { set; get; }




        public clsInternationalLicense()
        {

			//here we set the applicaiton type to New International License.
			this.ApplicationTypeID = clsApplication.enApplicationType.NewInternationalLicense;

			this.InternationalLicenseID = -1;
			this.DriverID = -1;
			this.IssuedUsingLocalLicenseID = -1;
			this.IssueDate = DateTime.Now;
			this.ExpirationDate = DateTime.Now;

			this.IsActive = true;


			Mode = enMode.AddNew;
		}

		public clsInternationalLicense(int ApplicationID, int ApplicantPersonID,
			DateTime ApplicationDate,
			 enApplicationStatus ApplicationStatus, DateTime LastStatusDate,
			 float PaidFees, int CreatedByUserID,
			 int InternationalLicenseID, int DriverID, int IssuedUsingLocalLicenseID,
			DateTime IssueDate, DateTime ExpirationDate, bool IsActive)

		{
			//this is for the base clase
			base.ApplicationID = ApplicationID;
			base.ApplicantPersonID = ApplicantPersonID;
			base.ApplicationDate = ApplicationDate;
			base.ApplicationTypeID = clsApplication.enApplicationType.NewInternationalLicense;
			base.ApplicationStatus = ApplicationStatus;
			base.LastStatusDate = LastStatusDate;
			base.PaidFees = PaidFees;
			base.UserID = CreatedByUserID;

			this.InternationalLicenseID = InternationalLicenseID;
			this.ApplicationID = ApplicationID;
			this.DriverID = DriverID;
			this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
			this.IssueDate = IssueDate;
			this.ExpirationDate = ExpirationDate;
			this.IsActive = IsActive;
			this.UserID = CreatedByUserID;

			this.DriverInfo = clsDriver.Find(this.DriverID);

			Mode = enMode.Update;
		}

		private bool _AddNewLicense()
        {
            this.InternationalLicenseID = clsInternationalLicenseData.AddNewInternationalLicense(this.ApplicationID, DriverID, this.IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, UserID);
            return this.InternationalLicenseID != -1;
        }

        private bool _UpdateLicense()
        {
            return clsInternationalLicenseData.UpdateInternationalLicense(InternationalLicenseID, this.ApplicationID, DriverID, this.IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, UserID);
        }

        public static clsInternationalLicense Find(int internationalLicenseID)
        {

			int ApplicationID = -1;
			int DriverID = -1; int IssuedUsingLocalLicenseID = -1;
			DateTime IssueDate = DateTime.Now; DateTime ExpirationDate = DateTime.Now;
			bool IsActive = true; int CreatedByUserID = 1;

			if (clsInternationalLicenseData.GetInternationalLicenseInfoByID(internationalLicenseID, ref ApplicationID, ref DriverID,
				ref IssuedUsingLocalLicenseID,
			ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
			{
				//now we find the base application
				clsApplication Application = clsApplication.FindBaseApplication(ApplicationID);


				return new clsInternationalLicense(Application.ApplicationID,
					Application.ApplicantPersonID,
									 Application.ApplicationDate,
									(enApplicationStatus)Application.ApplicationStatus, Application.LastStatusDate,
									 Application.PaidFees, Application.UserID,
									 internationalLicenseID, DriverID, IssuedUsingLocalLicenseID,
										 IssueDate, ExpirationDate, IsActive);

			}

			else
				return null;

		}

        public static DataTable GetAll()
        {
            return clsInternationalLicenseData.GetAllInternationalLicenses();
        }

        public static DataTable GetAllDriverLicenses(int driverId)
        {
            return clsInternationalLicenseData.GetAllDriverInternationalLicense(driverId);
        }

       

		public static int GetActiveInternationalLicenseIDByDriverID(int DriverID)
		{

			return clsInternationalLicenseData.GetActiveInternationalLicenseIDByDriverID(DriverID);

		}

		public bool Save()
		{

			//Because of inheritance first we call the save method in the base class,
			//it will take care of adding all information to the application table.
			base._Mode = (clsApplication.enMode)Mode;
			if (!base.Save())
				return false;

			switch (Mode)
			{
				case enMode.AddNew:
					if (_AddNewLicense())
					{

						Mode = enMode.Update;
						return true;
					}
					else
					{
						return false;
					}

				case enMode.Update:

					return _UpdateLicense();

			}

			return false;
		}
		// will be kicked soon
		public static DataTable FindMaster(int internationalLicenseID)
		{
			return clsInternationalLicenseData.FindInternationalLicenseMaster(internationalLicenseID);
		}
	}
}
