using System;
using System.Data.SqlClient;
using System.Data;


namespace DVLD_DataAccess
{
    public class clsCountryData
    {
        public static bool GetCountryByCountryId(int countryID, ref string countryName)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * From Countries WHERE CountryID=@CountryID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryID", countryID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    countryName = reader["CountryName"].ToString();
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                Logger eventLogger = new Logger(LoggingMethods.EventLogger);
                eventLogger.Log($"CountryData Error: {ex.Message}");
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool GetCountryByName(string countryName, ref int countryID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * From Countries WHERE CountryName=@CountryName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", countryName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    countryID =(int)reader["CountryID"];
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                Logger eventLogger = new Logger(LoggingMethods.EventLogger);
                eventLogger.Log($"CountryData Error: {ex.Message}");
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static DataTable GetAllCountries()
        {
            DataTable table = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * From Countries";

            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    table.Load(reader);
                reader.Close();

            }
            catch (Exception ex)
            {
                Logger eventLogger = new Logger(LoggingMethods.EventLogger);
                eventLogger.Log($"CountryData Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return table;

        }

    }
}
