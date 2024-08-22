using System;
using System.Data;
using System.Data.SqlClient;


namespace DVLD_DataAccess
{
    public class clsLicenseData
    {
        public static bool GetLicenseByID(int licenseID,ref int applicationId,ref int driverID,
            ref int licenseClass,ref DateTime issueDate,ref DateTime expirationDate,ref string notes,
            ref float paidFees,ref bool isActive ,ref short issueReason,ref int createdByUserID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * From Licenses WHERE LicenseID=@LicenseID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", licenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    isFound = true;
                    applicationId = (int)reader["ApplicationID"];
                    driverID = (int)reader["DriverID"];
                    licenseClass = (int)reader["LicenseClass"];
                    issueDate = Convert.ToDateTime(reader["IssueDate"]);
                    expirationDate = Convert.ToDateTime(reader["ExpirationDate"]);
                    notes = (reader["Notes"] != DBNull.Value) ? reader["Notes"].ToString() : "";
                    paidFees = Convert.ToSingle(reader["PaidFees"]);
                    isActive = Convert.ToBoolean(reader["IsActive"]);
                    issueReason = Convert.ToInt16(reader["IssueReason"]);
                    createdByUserID = (int)reader["CreatedByUserID"];
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

        public static bool GetLicenseByApplicationID(int applicationId,ref int licenseID, ref int driverID,
        ref int licenseClass, ref DateTime issueDate, ref DateTime expirationDate, ref string notes,
        ref float paidFees, ref bool isActive, ref short issueReason, ref int createdByUserID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * From Licenses WHERE ApplicationID=@ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", applicationId);
            

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    licenseID = (int)reader["LicenseID"];
                    driverID = (int)reader["DriverID"];
                    licenseClass = (int)reader["LicenseClass"];
                    issueDate = Convert.ToDateTime(reader["IssueDate"]);
                    expirationDate = Convert.ToDateTime(reader["ExpirationDate"]);
                    notes = (reader["Notes"] != DBNull.Value) ? reader["Notes"].ToString() : "";
                    paidFees = Convert.ToSingle(reader["PaidFees"]);
                    isActive = Convert.ToBoolean(reader["IsActive"]);
                    issueReason = Convert.ToInt16(reader["IssueReason"]);
                    createdByUserID = (int)reader["CreatedByUserID"];
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

        public static DataTable GetLicenseByIdMaster(int licenseID)
        {
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * From DriverLicenses_View WHERE LicenseID=@LicenseID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", licenseID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                    table.Load(reader);
                reader.Close();

            }
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return table;
        }

        public static int AddNewLicense( int applicationId, int driverID,
             int licenseClass,  DateTime issueDate,  DateTime expirationDate,  string notes,
             float paidFees,  bool isActive,  short issueReason,  int createdByUserID)
        {
            int licenseID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "INSERT INTO Licenses (ApplicationID,DriverID,LicenseClass,IssueDate," +
                "ExpirationDate,Notes,PaidFees,IsActive,IssueReason,CreatedByUserID) " +
                "Values(@ApplicationID,@DriverID,@LicenseClass,@IssueDate,@ExpirationDate,@Notes," +
                "@PaidFees,@IsActive,@IssueReason,@CreatedByUserID); " +
                "SELECT SCOPE_IDENTITY(); ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", applicationId);
            command.Parameters.AddWithValue("@DriverID", driverID);
            command.Parameters.AddWithValue("@LicenseClass", licenseClass);
            command.Parameters.AddWithValue("@IssueDate", issueDate);
            command.Parameters.AddWithValue("@ExpirationDate", expirationDate);
            command.Parameters.AddWithValue("@PaidFees", paidFees);
            command.Parameters.AddWithValue("@IsActive", isActive);
            command.Parameters.AddWithValue("@IssueReason", issueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

            if (string.IsNullOrEmpty(notes))
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
            else
                command.Parameters.AddWithValue("@Notes", notes);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString(),out licenseID))
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
            return licenseID;
        }

        public static bool UpdateLicense(int licenseID, int applicationId, int driverID,
             int licenseClass, DateTime issueDate, DateTime expirationDate, string notes,
             float paidFees, bool isActive, short issueReason, int createdByUserID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Update Licenses " +
                "SET ApplicationID=@ApplicationID, DriverID=@DriverID, LicenseClass=@LicenseClass," +
                "IssueDate=@IssueDate, ExpirationDate=@ExpirationDate, Notes=@Notes, " +
                "PaidFees=@PaidFees,IsActive=@IsActive, IssueReason=@IssueReason, CreatedByUserID=@CreatedByUserID " +
                "Where LicenseID=@LicenseID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", licenseID);
            command.Parameters.AddWithValue("@ApplicationID", applicationId);
            command.Parameters.AddWithValue("@DriverID", driverID);
            command.Parameters.AddWithValue("@LicenseClass", licenseClass);
            command.Parameters.AddWithValue("@IssueDate", issueDate);
            command.Parameters.AddWithValue("@ExpirationDate", expirationDate);
            command.Parameters.AddWithValue("@PaidFees", paidFees);
            command.Parameters.AddWithValue("@IsActive", isActive);
            command.Parameters.AddWithValue("@IssueReason", issueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

            if (string.IsNullOrEmpty(notes))
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
            else
                command.Parameters.AddWithValue("@Notes", notes);

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
            return rowsAffected >0;
        }

        public static bool UpdateLicenseActivity(int licenseID,bool isActive)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Update Licenses " +
                " Set IsActive=@IsActive " +
                "Where LicenseID=@LicenseID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", licenseID);
            command.Parameters.AddWithValue("@IsActive", isActive);
            
            
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


        public static bool DeleteLicense(int licenseID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE From Licenses WHERE LicenseID=@LicenseID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", licenseID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                rowsAffected = 0;
            }
            finally
            {
                connection.Close();
            }

            return rowsAffected > 0;
        }

        public static DataTable GetAllLicenses()
        {
            DataTable table = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * From Licenses";

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

        public static DataTable GetAllDriverLicenses(int driverId)
        {
            DataTable table = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select l.LicenseID, l.ApplicationID,lc.ClassName,l.IssueDate, l.ExpirationDate,l.IsActive " +
                "from Licenses l " +
                "Join LicenseClasses lc " +
                "On (l.LicenseClass = lc.LicenseClassID) " +
                "where l.DriverID = @DriverID ;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", driverId);

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

        public static bool IsLicenseExist(int licenseID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT TOP(1) Found=1 From Licenses WHERE LicenseID=@LicenseID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", licenseID);

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

        public static int IsLicenseInternational(int licenseID)
        {
            
            int interLicenseID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT TOP(1) InternationalLicenseID From InternationalLicenses WHERE IssuedUsingLocalLicenseID=@LicenseID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", licenseID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out interLicenseID))
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

            return interLicenseID;
        }


        public static bool IsLicenseActive(int licenseID)
        {
            bool isActive = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT TOP(1) IsActive From Licenses WHERE LicenseID=@LicenseID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", licenseID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && bool.TryParse(result.ToString(), out bool activity))
                    isActive = activity;

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return isActive;
        }

        public static int IsLicenseDetainedAndNotReleased(int licenseID)
        {
            
            int detainID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT TOP(1) DetainID From DetainedLicenses WHERE LicenseID=@LicenseID AND ReleaseID Is Null;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", licenseID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out detainID))
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


        public static bool IsApplicationHasLicense(int applicationID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT TOP(1) Found=1 From Licenses WHERE ApplicationID=@ApplicationID ;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", applicationID);


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

        public static bool IsLicenseExpired(int licenseID)
        {
            bool isExpired = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select Found=1 from Licenses where LicenseID=@LicenseID AND IssueDate >= ExpirationDate;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", licenseID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int isFound))
                    isExpired = true;
                else
                    isExpired = false;

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return isExpired;
        }


    }
}
