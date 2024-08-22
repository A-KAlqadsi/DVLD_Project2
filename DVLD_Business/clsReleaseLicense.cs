using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsReleaseLicense
    {
        enum enMode { AddNew = 1,Update =2}
        enMode _Mode;

        public int ReleaseID { get; set; }
        public int ApplicationID;
        public DateTime ReleaseDate;
        public int UserID;

        public clsReleaseLicense()
        {
            ReleaseID = -1;
            ApplicationID = -1;
            ReleaseDate = DateTime.Now;
            UserID = -1;
            _Mode=enMode.AddNew;
        }

        private clsReleaseLicense(int releaseID,int applicationID,DateTime releaseDate,int userID)
        {
            ReleaseID = releaseID;
            ApplicationID=applicationID;
            ReleaseDate = releaseDate;
            UserID = userID;
            _Mode = enMode.Update;
        }

        private bool _AddNew()
        {
            this.ReleaseID =clsReleasedLicenseData.AddNewReleaseLicense(ApplicationID,ReleaseDate,UserID);
            return this.ReleaseID != -1;

        }

        private bool _Update()
        {
            return clsReleasedLicenseData.UpdateReleaseLicense(ReleaseID,ApplicationID,ReleaseDate,UserID);
        }

        public static clsReleaseLicense Find(int releaseID)
        {
            int appID = -1;
            DateTime releaseDate=DateTime.Now;
            int userID = -1;
            if(clsReleasedLicenseData.GetReleasedLicenseByID(releaseID,ref appID,ref releaseDate,ref userID))
            {
                return new clsReleaseLicense(releaseID,appID,releaseDate,userID);
            }
            return null;
        }

        public static bool Delete(int releaseID) 
        {
            return clsReleasedLicenseData.DeleteReleasedLicense(releaseID);
        }

        public static DataTable GetAll()
        {
            return clsReleasedLicenseData.GetAllReleasedLicenses();
        }

        public static bool IsReleseLicenseExist(int releaseID)
        {
            return clsReleasedLicenseData.IsReleasedLicenseExist(releaseID);
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
