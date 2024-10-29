using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsLicenseClass
    {
        private enum enMode { AddNew = 1, Update = 2 };
        enMode _Mode = enMode.AddNew;

        public int ClassID;
        public string ClassName;
        public string Description;
        public short MinimumAllowedAge;
        public short ValidityLength;
        public float ClassFees;

        public clsLicenseClass()
        {
            ClassID = -1;
            ClassName= string.Empty;
            Description= string.Empty;
            MinimumAllowedAge = 0;
            ValidityLength = 0;
            ClassFees = 0;
            _Mode= enMode.AddNew;
        }

        private clsLicenseClass(int classID,string className,string description,
            short minimumAllowedAge,short validityLength,float classFees)
        {
            ClassID= classID;
            ClassName= className;
            Description= description;
            MinimumAllowedAge = minimumAllowedAge;
            ValidityLength = validityLength;
            ClassFees = classFees;
            _Mode = enMode.Update;
        }

        private bool _AddNewClass()
        {
            this.ClassID = clsLicenseClassData.AddNewLicenseClass(ClassName, Description, MinimumAllowedAge, ValidityLength, ClassFees);
            return this.ClassID != -1;
        }

        private bool _UpdateClass()
        {
            return clsLicenseClassData.UpdateLicenseClass(ClassID,ClassName, Description, MinimumAllowedAge, ValidityLength, ClassFees);
        }

        public static clsLicenseClass Find(int classID)
        {
            string className="",description="";
            short minimumAllowedAge = 0;
            short validityLength = 0;
            float classFees = 0;
            if (clsLicenseClassData.GetLicenseClassByID(classID, ref className, ref description,
                ref minimumAllowedAge, ref validityLength, ref classFees))
                return new clsLicenseClass(classID, className, description, minimumAllowedAge, validityLength, classFees);
            else 
                return null;

        }

		public static clsLicenseClass FindByClassName(string className)
		{
            int classID = -1;
            string description = "";
			short minimumAllowedAge = 0;
			short validityLength = 0;
			float classFees = 0;
			if (clsLicenseClassData.GetLicenseClassByName(className, ref classID, ref description,
				ref minimumAllowedAge, ref validityLength, ref classFees))
				return new clsLicenseClass(classID, className, description, minimumAllowedAge, validityLength, classFees);
			else
				return null;

		}

		public static DataTable GetAll()
        {
            return clsLicenseClassData.GetAllLicenseClasses();
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewClass())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.Update:
                    return _UpdateClass();
            }
            return false;
        }


    }
}
