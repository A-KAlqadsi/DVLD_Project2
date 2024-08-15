using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsDriver
    {
        enum enMode { AddNew = 1, Update = 2 }
        enMode _Mode;

        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int UserID;
        public DateTime CreateDate;

        public clsDriver()
        {
            DriverID = -1;
            PersonID = -1;
            UserID = -1;
            CreateDate = DateTime.Now;
            _Mode = enMode.AddNew;
        }

        private clsDriver(int driverID, int personID, int userID,DateTime createDate)
        {
            
            PersonID = personID;
            DriverID = DriverID;
            UserID= userID;
            CreateDate = createDate;
            _Mode = enMode.Update;
        }

        private bool _AddNewDriver()
        {
            this.DriverID = clsDriverData.AddNewDriver(PersonID,UserID,CreateDate);
            return this.DriverID != -1;
        }

        private bool _UpdateDriver()
        {
            return clsDriverData.UpdateDriver(DriverID, PersonID, UserID, CreateDate);
        }

        public static clsDriver Find(int driverID)
        {
            int personID = -1;
            int userID = -1;
            DateTime createDate =DateTime.Now;

            if (clsDriverData.GetDriverByDriverId(driverID,ref personID,ref userID,ref createDate))
            {
                return new clsDriver(driverID,personID,userID,createDate);
            }
            else
                return null;

        }

        public static DataTable GetAll()
        {
            return clsDriverData.GetAllDrivers();
        }

        public static bool Delete(int driverID)
        {
            return clsDriverData.DeleteDriver(driverID);
        }

        public static bool IsDriverExist(int driverID)
        {
            return clsDriverData.IsDriverExist(driverID);
        }

        public static bool IsPersonADriver(int personID)
        {
            return clsDriverData.IsPersonADriver(personID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        _Mode = enMode.Update;
                        if (_AddNewDriver())
                            return true;
                        else
                            return false;
                    }
                case enMode.Update:
                    return _UpdateDriver();
            }
            return false;
        }

    }
}
