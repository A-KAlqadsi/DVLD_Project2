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
        public enum enTestType { VisionTest = 1, WrittenTest =2, StreetTest =3}
       
        public clsTestType.enTestType ID;
        public string TestTypeTitle;
        public string TestTypeDescription;
        public float TestTypeFees;
        public clsTestType()
        {
            this.ID = enTestType.VisionTest;
            TestTypeTitle= string.Empty;
            TestTypeDescription= string.Empty;
            TestTypeFees= 0;
            _Mode= enMode.AddNew;   
        }

        private clsTestType(enTestType ID,string title,string description,float fees)
        {
            this.ID = ID;
            TestTypeTitle= title;
            TestTypeDescription= description;
            TestTypeFees= fees;
            _Mode = enMode.Update;
        }

        private bool _AddNew()
        {
            this.ID  =(clsTestType.enTestType)clsTestTypesData.AddNewTestType(TestTypeTitle, TestTypeDescription,TestTypeFees);
            return this.TestTypeTitle != "";
        }

        private bool _Update()
        {
            return clsTestTypesData.UpdateTestType((int)this.ID, TestTypeTitle, TestTypeDescription, TestTypeFees);
        }

        public static clsTestType Find(enTestType ID)
        {
            string title="", description="";
            float fees = 0;
            if(clsTestTypesData.GetTestTypeByID((int)ID,ref title,ref description,ref fees))
                return new clsTestType(ID,title,description,fees);
            else 
                return null;
        }

      
        public static DataTable GetAll()
        {
            return clsTestTypesData.GetAllTestTypes();
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
