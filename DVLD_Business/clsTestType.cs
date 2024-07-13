using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DVLD_DataAccess;
using Microsoft.SqlServer.Server;

namespace DVLD_Business
{
    public class clsTestType
    {
        enum enMode { AddNew =1,Update=2 }
        enMode _Mode=enMode.AddNew;
        
        public int TestTypeID { get; }
        public string TestTypeTitle;
        public string TestTypeDescription;
        public float TestTypeFees;
        public clsTestType()
        {
            TestTypeID = -1;
            TestTypeTitle= string.Empty;
            TestTypeDescription= string.Empty;
            TestTypeFees= 0;
            _Mode= enMode.AddNew;   
        }

        private clsTestType(int testTypeID,string title,string description,float fees)
        {
            TestTypeID= testTypeID;
            TestTypeTitle= title;
            TestTypeDescription= description;
            TestTypeFees= fees;
            _Mode = enMode.Update;
        }

        private bool _AddNew()
        {
            int testTypeID = clsTestTypesData.AddNewTestType(TestTypeTitle, TestTypeDescription,TestTypeFees);
            return testTypeID != -1;
        }

        private bool _Update()
        {
            return clsTestTypesData.UpdateTestType(TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);
        }

        public static clsTestType Find(int testTypeId)
        {
            string title="", description="";
            float fees = 0;
            if(clsTestTypesData.GetTestTypeByID(testTypeId,ref title,ref description,ref fees))
                return new clsTestType(testTypeId,title,description,fees);
            else 
                return null;
        }

        public static bool Delete(int testTypeId)
        {
            return clsTestTypesData.DeleteTestType(testTypeId);
        }

        public static DataTable GetAll()
        {
            return clsTestTypesData.GetAllTestTypes();
        }

        public static bool IsTestTypeExist(int testTypeId)
        {
            return clsTestTypesData.IsTestTypeExist(testTypeId);
        }

        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNew:
                    {
                        _Mode = enMode.AddNew;
                        if(_AddNew())
                            return true;
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
