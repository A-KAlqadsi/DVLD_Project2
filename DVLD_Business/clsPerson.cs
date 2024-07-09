using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsPerson
    {
        private enum enMode { AddNew=1,Update=2};
        enMode _Mode= enMode.AddNew;
        public int PersonID { get; set; }
        public string NationalNo;
        public string FirstName, SecondName, ThirdName, LastName;
        public DateTime DateOfBirth;
        public string  Address, Phone, Email;
        public short Gender;
        public int NationalityCountryID;
        public string ImagePath;

        public clsPerson()
        {
            PersonID = -1;
            NationalNo = string.Empty;
            FirstName = string.Empty;
            SecondName = string.Empty;
            ThirdName = string.Empty;
            LastName = string.Empty;
            DateOfBirth = DateTime.Now;
            Gender = 0;
            Address = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            NationalityCountryID = -1;
            ImagePath = string.Empty;
            _Mode = enMode.AddNew;

        }

        private clsPerson(int personID,string nationalNo,string firstName,string secondName,
            string thirdName,string lastName,DateTime dateOfBirth,short gender ,string address,
            string phone,string email,int nationalityCountryID,string imagePath)
        {
            PersonID=personID;
            NationalNo=nationalNo;
            FirstName=firstName;
            SecondName=secondName;
            ThirdName=thirdName;
            LastName=lastName;
            DateOfBirth=dateOfBirth;
            Gender =gender;
            Address =address;
            Phone =phone;
            Email =email;
            NationalityCountryID = nationalityCountryID;
            ImagePath=imagePath;
            _Mode = enMode.Update;
        }

        private bool _AddNewPerson()
        {
            PersonID = clsPersonData.AddNewPerson(NationalNo, FirstName, SecondName, 
                ThirdName, LastName, DateOfBirth, Gender, Address,
                Phone, Email, NationalityCountryID, ImagePath);
            return PersonID != -1;
        }

        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(PersonID, NationalNo, FirstName, SecondName,
                ThirdName, LastName, DateOfBirth, Gender, Address,
                Phone, Email, NationalityCountryID, ImagePath);
        }

        public static clsPerson Find(int personID)
        {
            string nationalNo = "", firstName = "", secondName = "", thirdName ="", lastName = "";
            DateTime dateOfBirth = DateTime.Now;
            short gender = 0;
            string address = "", phone = "", email = "",imagePath ="";
            int nationalityCountryID = -1;
            
            if(clsPersonData.GetPersonById(personID,ref nationalNo,ref firstName,ref secondName,ref thirdName,ref lastName,
                ref dateOfBirth,ref gender,ref address,ref phone,ref email,ref nationalityCountryID,ref imagePath))
            {
                return new clsPerson(personID, nationalNo, firstName,secondName,thirdName,
                    lastName,dateOfBirth,gender,address,phone,email,
                    nationalityCountryID,imagePath);
            }
            else 
                return null;

        }

        public static clsPerson Find(string nationalNo)
        {
            int personID = -1;
            string firstName = "", secondName = "", thirdName = "", lastName = "";
            DateTime dateOfBirth = DateTime.Now;
            short gender =0;
            string address = "", phone = "", email = "", imagePath = "";
            int nationalityCountryID = -1;

            if (clsPersonData.GetPersonByNationalNo(nationalNo, ref personID, ref firstName, ref secondName, ref thirdName, ref lastName,
                ref dateOfBirth, ref gender, ref address, ref phone, ref email, ref nationalityCountryID, ref imagePath))
            {
                return new clsPerson(personID, nationalNo, firstName, secondName, thirdName,
                    lastName, dateOfBirth, gender, address, phone, email,
                    nationalityCountryID, imagePath);
            }
            else
                return null;

        }

        public static DataTable GetAll()
        {
            return clsPersonData.GetAllPeople();
        }

        public static bool Delete(int personID)
        {
            return clsPersonData.DeletePerson(personID);
        }

        public static bool IsPersonExist(int personID)
        {
            return clsPersonData.IsPersonExist(personID);
        }

        public static bool IsPersonExist(string nationalNo)
        {
            return clsPersonData.IsPersonExist(nationalNo);
        }


        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNew:
                    {
                        _Mode = enMode.Update;
                        if (_AddNewPerson())
                            return true;
                        else
                            return false;
                    }
                case enMode.Update:
                    {
                        return _UpdatePerson();
                    }
            }
            return false;
        }

        public string FullName()
        {
            return FirstName + " " + SecondName + " " + ThirdName + " " + LastName;
        }

    }
}
