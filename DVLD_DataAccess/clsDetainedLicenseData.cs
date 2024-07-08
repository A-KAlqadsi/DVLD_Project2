using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsDetainedLicenseData
    {
        public static bool GetDetainedLicenseByID(int detainID ,ref int licenseID,ref DateTime detainDate,
            ref float fineFees,ref int createdByUserID,ref int releaseID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * From DetainedLicenses WHERE DetainID=@DetainID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DetainID", detainID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    isFound = true;
                    licenseID = (int)reader["LicenseID"];
                    detainDate = Convert.ToDateTime(reader["DetainDate"]);
                    fineFees = Convert.ToSingle(reader["FineFees"]);
                    createdByUserID = (int)reader["CreatedByUserID"];
                    releaseID = (reader["ReleaseID"] != DBNull.Value) ? (int)reader["ReleaseID"] : -1;
                }
                reader.Close();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return isFound;

        }

        public static int AddNewDetainLicense( int licenseID, DateTime detainDate,
             float fineFees, int createdByUserID, int releaseID)
        {
            int detainID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "INSERT INTO DetainedLicenses (LicenseID,DetainDate,FineFees,CreatedByUserID,ReleaseID) " +
                "Values (@LicenseID,@DetainDate,@FineFees,@UserID,@ReleaseID); " +
                "SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", licenseID);
            command.Parameters.AddWithValue("@DetainDate", detainDate);
            command.Parameters.AddWithValue("@FineFees", fineFees);
            command.Parameters.AddWithValue("@UserID", createdByUserID);
            if(releaseID >0)
                command.Parameters.AddWithValue("@ReleaseID", releaseID);
            else
                command.Parameters.AddWithValue("@ReleaseID", DBNull.Value);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(),out detainID))
                {

                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return detainID;

        }

        public static bool UpdateDetainLicense(int detainID, int licenseID, DateTime detainDate,
             float fineFees, int createdByUserID, int releaseID)
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Update DetainedLicenses " +
                "SET LicenseID=@LicenseID, DetainDate=@DetainDate, FineFees=@FineFees," +
                "CreatedByUserID=@UserID, ReleaseID=@ReleaseID " +
                " Where DetainID=@DetainID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DetainID", detainID);
            command.Parameters.AddWithValue("@LicenseID", licenseID);
            command.Parameters.AddWithValue("@DetainDate", detainDate);
            command.Parameters.AddWithValue("@FineFees", fineFees);
            command.Parameters.AddWithValue("@UserID", createdByUserID);
            if(releaseID>0)
                command.Parameters.AddWithValue("@ReleaseID", releaseID);
            else
                command.Parameters.AddWithValue("@ReleaseID", DBNull.Value);

            try
            {
                connection.Open();
                rowAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return rowAffected>0;

        }

        public static bool DeleteDetainedLicense(int detainID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE From DetainedLicenses WHERE DetainID=@DetainID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DetainID", detainID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                connection.Close();
            }

            return rowsAffected > 0;
        }

        public static DataTable GetAllDetainedLicenses()
        {
            DataTable table = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * From DetainedLicenses;";

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

            }
            finally
            {
                connection.Close();
            }
            return table;

        }

        public static bool IsDetainedLicenseExist(int detainID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT TOP(1) Found=1 From DetainedLicenses WHERE DetainID=@DetainID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DetainID", detainID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int found))
                    isExist = true;

            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                connection.Close();
            }

            return isExist;
        }

        public static bool IsDetainedLicenseReleased(int detainID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT TOP(1) ReleaseID From DetainedLicenses WHERE DetainID=@DetainID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DetainID", detainID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int found))
                    isExist = true;
                
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return isExist;
        }


    }
}
