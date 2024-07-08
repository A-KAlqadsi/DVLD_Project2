﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsApplicationType
    {
        enum enMode { AddNew = 1, Update = 2 }
        enMode _Mode;

        public int ApplicationTypeID { get; }
        public string ApplicationTitle;
        public float ApplicationFees;

        public clsApplicationType()
        {
            ApplicationTypeID = -1;
            ApplicationTitle = string.Empty;
            ApplicationFees = 0;
            _Mode = enMode.AddNew;
        }

        private clsApplicationType(int applicationTypeID, string applicationTitle, float applicationFees)
        {
            ApplicationTitle = applicationTitle;
            ApplicationTypeID = applicationTypeID;
            ApplicationFees=applicationFees;
            _Mode = enMode.Update;
        }

        private bool _AddNewApplicationType()
        {
            int applicationTypeID = clsApplicationTypesData.AddNewApplicationType( ApplicationTitle, ApplicationFees);
            return applicationTypeID != -1;
        }

        private bool _UpdateApplicationType()
        {
            return clsApplicationTypesData.UpdateApplicationType(ApplicationTypeID, ApplicationTitle, ApplicationFees);
        }

        public static clsApplicationType Find(int applicationTypeID)
        {
            
            string ApplicationTitle = string.Empty;
            float applicationFees = 0;

            if (clsApplicationTypesData.GetApplicationTypeByID(applicationTypeID, ref ApplicationTitle, ref applicationFees))
            {
                return new clsApplicationType(applicationTypeID, ApplicationTitle, applicationFees);
            }
            else
                return null;

        }

        public static DataTable GetAll()
        {
            return clsApplicationTypesData.GetAllApplicationTypes();
        }

        public static bool Delete(int applicationTypeID)
        {
            return clsApplicationTypesData.DeleteApplicationType(applicationTypeID);
        }

        public static bool IsApplicationTypeExist(int applicationTypeID)
        {
            return clsApplicationTypesData.IsApplicationTypeExist(applicationTypeID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        _Mode = enMode.Update;
                        if (_AddNewApplicationType())
                            return true;
                        else
                            return false;
                    }
                case enMode.Update:
                    return _UpdateApplicationType();
            }
            return false;
        }

    }
}
