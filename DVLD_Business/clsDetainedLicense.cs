using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsDetainedLicense
    {
        enum enMode { AddNew = 1, Update = 2 }
        enMode _Mode;

        public int DetainID;
        public int LicenseID;
        public DateTime DetainDate;
        public float FineFees;
        public int UserID;
        public int ReleaseID;

        public clsDetainedLicense()
        {
            DetainID = -1;
            LicenseID = -1;
            DetainDate= DateTime.Now;
            FineFees = 0;
            UserID = -1;
            ReleaseID = -1;
            _Mode=enMode.AddNew;
        }

        private clsDetainedLicense(int detainID,int licenseID,DateTime detainDate,float fineFees,int userID,int releaseID )
        {
            DetainID= detainID;
            LicenseID= licenseID;
            DetainDate= detainDate;
            FineFees= fineFees;
            UserID= userID;
            ReleaseID= releaseID;
            _Mode = enMode.Update;
        }

        private bool _AddNewDetain()
        {
            int detainID = clsDetainedLicenseData.AddNewDetainLicense(LicenseID, DetainDate, FineFees, UserID, ReleaseID);
            return detainID != -1;
        }

        private bool _UpdateDetain()
        {
            return clsDetainedLicenseData.UpdateDetainLicense(DetainID,LicenseID, DetainDate, FineFees, UserID, ReleaseID);
            
        }

        public static clsDetainedLicense Find(int detainID)
        {
            
            int licenseID = -1;
            DateTime detainDate=DateTime.Now;
            float fineFees=0;
            int userID=-1;
            int releaseID = -1;
            if (clsDetainedLicenseData.GetDetainedLicenseByID(detainID, ref licenseID, ref detainDate, ref fineFees, ref userID, ref releaseID))
                return new clsDetainedLicense(detainID, licenseID, detainDate, fineFees, userID, releaseID);
            else
                return null;

        }

        public static DataTable GetAll()
        {
            return clsDetainedLicenseData.GetAllDetainedLicenses();
        }

        public static bool Delete(int detainID) 
        { 
            return clsDetainedLicenseData.DeleteDetainedLicense(detainID);
        }

        public static bool IsDetainLicenseExist(int detainID)
        {
            return clsDetainedLicenseData.IsDetainedLicenseExist(detainID);
        }
        
        public static bool IsDetainLicenseRelease(int detainID)
        {
            return clsDetainedLicenseData.IsDetainedLicenseReleased(detainID);
        }

        public bool Save()
        {
            
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        _Mode = enMode.Update;
                        if (_AddNewDetain())
                            return true;
                        else
                            return false;
                    }
                case enMode.Update:
                    return _UpdateDetain();
            }
            return false;
        }

    }
}
