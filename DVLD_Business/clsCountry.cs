using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsCountry
    {
        enum enMode { AddNew = 1, Update = 2 }
        enMode _Mode;

        public int CountryID { get; }
        public string CountryName;
       

        public clsCountry()
        {
            CountryID = -1;
            CountryName = string.Empty;
            _Mode = enMode.AddNew;
        }

        private clsCountry(int countryID, string countryName)
        {
            CountryName = countryName;
            CountryID = countryID;
            _Mode = enMode.Update;
        }

        private bool _AddNewCountry()
        {
            int countryID = clsCountryData.AddNewCountry(CountryName);
            return countryID != -1;
        }

        private bool _UpdateCountry()
        {
            return clsCountryData.UpdateCountry(CountryID,CountryName);
        }

        public static clsCountry Find(int countryID)
        {
            string CountryName = string.Empty;

            if (clsCountryData.GetCountryByCountryId(countryID, ref CountryName))
            {
                return new clsCountry(countryID,CountryName);
            }
            else
                return null;

        }

        public static clsCountry Find(string countryName)
        {
            int CountryID = -1;
            if (clsCountryData.GetCountryByName(countryName, ref CountryID))
            {
                return new clsCountry(CountryID ,countryName);
            }
            else
                return null;
        }

        public static DataTable GetAll()
        {
            return clsCountryData.GetAllCountries();
        }

        public static bool Delete(int countryID)
        {
            return clsCountryData.DeleteCountry(countryID);
        }

        public static bool IsCountryExist(int countryID)
        {
            return clsCountryData.IsCountryExist(countryID);
        }

        public static bool IsCountryExist(string countryName)
        {
            return clsCountryData.IsCountryExist(countryName);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        _Mode = enMode.Update;
                        if (_AddNewCountry())
                            return true;
                        else
                            return false;
                    }
                case enMode.Update:
                    return _UpdateCountry();
            }
            return false;
        }

    }
}
