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
       
        public int CountryID { get; }
        public string CountryName;
       
        private clsCountry(int countryID, string countryName)
        {
            CountryName = countryName;
            CountryID = countryID;
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


    }
}
