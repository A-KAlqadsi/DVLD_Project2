using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsLocalDrivingLicenseApp
    {
        enum enMode { AddNew=1,Update=2 }
        enMode _Mode;
        public int LocalDrivingLicenseAppID;
        public int ApplicationID;
        public int LicenseClassID;

        public clsLocalDrivingLicenseApp()
        {
            LocalDrivingLicenseAppID = -1;
            ApplicationID = -1;
            LicenseClassID = -1;
            _Mode=enMode.AddNew;
        }

        private clsLocalDrivingLicenseApp(int localDrivingLicenseID,int applicationID,int licenseclassID)
        {
            LocalDrivingLicenseAppID=localDrivingLicenseID;
            ApplicationID=applicationID;
            LicenseClassID=licenseclassID;
            _Mode = enMode.Update;
        }

        private bool _AddNew()
        {
            LocalDrivingLicenseAppID = clsLocalDrivingLicenseAppData.AddNewLocalLicenseDrivingApp(ApplicationID, LicenseClassID);
            return LocalDrivingLicenseAppID != -1;
        }

        private bool _Update()
        {
            return clsLocalDrivingLicenseAppData.UpdateLocalLicenseDrivingApp(LocalDrivingLicenseAppID, ApplicationID, LicenseClassID);
        }

        public static clsLocalDrivingLicenseApp Find(int localDrivingLicenseID)
        {
            int appID = -1;
            int classId = -1;
            if(clsLocalDrivingLicenseAppData.GetLocalDrivingLicenseAppByID(localDrivingLicenseID,ref appID,ref classId))
            {
                return new clsLocalDrivingLicenseApp(localDrivingLicenseID,appID,classId);
            }
            else 
                return null;
        }

        public static bool Delete(int localDrivingLicenseID)
        {
            return clsLocalDrivingLicenseAppData.DeleteLocalDrivingLicenseApp(localDrivingLicenseID);
        }

        public static bool IsLicenseExist(int localDrivingLicenseID)
        {
            return clsLocalDrivingLicenseAppData.IsLocalDrivingLicenseAppExist(localDrivingLicenseID);
        }

        public static DataTable GetAll()
        {
            return clsLocalDrivingLicenseAppData.GetAllLocalDrivingLicenseApps_Master();
        }
        public bool Save()
        {
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
    
        public static bool IsPersonHasSameLicenseClass(int personID, int classID)
        {
            return clsLocalDrivingLicenseAppData.IsPersonHasSameLicenseClass(personID, classID);
        }

    }
}
