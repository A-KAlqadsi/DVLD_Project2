using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsReleasedLicenseData
    {
        public static bool GetReleasedLicenseByID(int releaseID,ref int applicationID,
            ref DateTime releaseDate,ref int createdByUserID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * From ReleasedLicenses WHERE ReleaseID=@ReleaseID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ReleaseID", releaseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    isFound = true;
                    applicationID = (int)reader["ApplicationID"];
                    releaseDate = Convert.ToDateTime(reader["ReleaseDate"]);
                    createdByUserID = (int)reader["CreatedByUserID"];
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                Logger eventLogger = new Logger(LoggingMethods.EventLogger);
                eventLogger.Log($"ReleasedLicenseData Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }


        public static int AddNewReleaseLicense( int applicationID,
             DateTime releaseDate,  int createdByUserID)
        {
            int releaseID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "INSERT INTO ReleasedLicenses(ApplicationID,ReleaseDate,CreatedByUserID) " +
                "Values(@ApplicationID,@ReleaseDate,@UserID); " +
                "SELECT SCOPE_IDENTITY(); ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", applicationID);
            command.Parameters.AddWithValue("@ReleaseDate", releaseDate);
            command.Parameters.AddWithValue("@UserID", createdByUserID);
           
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out releaseID))
                {

                }

            }
            catch (Exception ex)
            {
                Logger eventLogger = new Logger(LoggingMethods.EventLogger);
                eventLogger.Log($"ReleasedLicenseData Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return releaseID;
        }

        public static bool UpdateReleaseLicense(int releaseID,int applicationID,
            DateTime releaseDate, int createdByUserID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Update ReleasedLicenses " +
                "SET ApplicationID=@ApplicationID, ReleaseDate=@ReleaseDate, CreatedByUserID=@UserID " +
                "Where ReleaseID=@ReleaseID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ReleaseID", releaseID);
            command.Parameters.AddWithValue("@ApplicationID", applicationID);
            command.Parameters.AddWithValue("@ReleaseDate", releaseDate);
            command.Parameters.AddWithValue("@UserID", createdByUserID);

            try
            {
                connection.Open();
                rowsAffected=command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Logger eventLogger = new Logger(LoggingMethods.EventLogger);
                eventLogger.Log($"ReleasedLicenseData Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return rowsAffected>0;
        }


        public static bool DeleteReleasedLicense(int releaseID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE From ReleasedLicenses WHERE ReleaseID=@ReleaseID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ReleaseID", releaseID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Logger eventLogger = new Logger(LoggingMethods.EventLogger);
                eventLogger.Log($"ReleasedLicenseData Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return rowsAffected > 0;
        }

        public static DataTable GetAllReleasedLicenses()
        {
            DataTable table = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * From ReleasedLicenses;";

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
                eventLogger.Log($"ReleasedLicenseData Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return table;

        }

        public static bool IsReleasedLicenseExist(int releaseID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT TOP(1) Found=1 From ReleasedLicenses WHERE ReleaseID=@ReleaseID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ReleaseID", releaseID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int found))
                    isExist = true;

            }
            catch (Exception ex)
            {
                Logger eventLogger = new Logger(LoggingMethods.EventLogger);
                eventLogger.Log($"ReleasedLicenseData Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return isExist;
        }

    }
}
