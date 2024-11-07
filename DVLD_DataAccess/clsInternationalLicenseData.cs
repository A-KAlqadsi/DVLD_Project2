using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http.Headers;


namespace DVLD_DataAccess
{
    public class clsInternationalLicenseData
    {

        public static bool GetInternationalLicenseInfoByID(int internationlLicenseID,ref int applicationID,
            ref int driverID,ref int issuedUsingLocalLicense,ref DateTime issueDate,
            ref DateTime expirationDate,ref bool isActive,ref int createdByUserID)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetInternationalLicenseInfoByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@LicenseID", internationlLicenseID);
                    
					try
					{
						connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
							if (reader.Read())
							{
								isFound = true;
								applicationID = (int)reader["ApplicationID"];
								driverID = (int)reader["DriverID"];
								issuedUsingLocalLicense = (int)reader["IssuedUsingLocalLicenseID"];
								issueDate = Convert.ToDateTime(reader["IssueDate"]);
								expirationDate = Convert.ToDateTime(reader["ExpirationDate"]);
								isActive = Convert.ToBoolean(reader["IsActive"]);
								createdByUserID = (int)reader["CreatedByUserID"];
							}
						}
                        
					}
					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"InternationalLicenseData Error: {ex.Message}");
					}
				}
			}



			return isFound;
        }

        public static int AddNewInternationalLicense(  int applicationID,
             int driverID,  int issuedUsingLocalLicense,  DateTime issueDate,
             DateTime expirationDate,  bool isActive,  int createdByUserID)
        {

            int licenseID = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddNewInternationalLicense", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@ApplicationID", applicationID);
					command.Parameters.AddWithValue("@DriverID", driverID);
					command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", issuedUsingLocalLicense);
					command.Parameters.AddWithValue("@IssueDate", issueDate);
					command.Parameters.AddWithValue("@ExpirationDate", expirationDate);
					command.Parameters.AddWithValue("@IsActive", isActive);
					command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

                    var outputParamId = new SqlParameter("@NewInternationalLicenseId", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputParamId);

					try
					{
						connection.Open();
                        command.ExecuteNonQuery();
                        licenseID = (int)outputParamId.Value;
					}
					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"InternationalLicenseData Error: {ex.Message}");
					}
				}
			}

            return licenseID;
        }

        public static bool UpdateInternationalLicense(int internationalLicenseID, int applicationID,
                 int driverID, int issuedUsingLocalLicense, DateTime issueDate,
                 DateTime expirationDate, bool isActive, int createdByUserID)
        {

            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateInternationalLicense", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@InternationalLicenseID", internationalLicenseID);
					command.Parameters.AddWithValue("@ApplicationID", applicationID);
					command.Parameters.AddWithValue("@DriverID", driverID);
					command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", issuedUsingLocalLicense);
					command.Parameters.AddWithValue("@IssueDate", issueDate);
					command.Parameters.AddWithValue("@ExpirationDate", expirationDate);
					command.Parameters.AddWithValue("@IsActive", isActive);
					command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

					try
					{
						connection.Open();
						rowsAffected = (int)command.ExecuteScalar();
					}
					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"InternationalLicenseData Error: {ex.Message}");
					}
					
				}
            }
            return rowsAffected>0;
        }


        public static DataTable GetAllInternationalLicenses()
        {
			DataTable table = new DataTable();

			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{

				using (SqlCommand command = new SqlCommand("SP_GetAllInternationalLicenses", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					try
					{
						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.HasRows)
								table.Load(reader);
						}
					}
					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"International License Data Error: {ex.Message}");
					}

				}
			}
			return table;

		}

        public static DataTable GetAllDriverInternationalLicense(int driverId)
        {
			DataTable table = new DataTable();

			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{

				using (SqlCommand command = new SqlCommand("SP_GetDriverInternationalLicenses", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@DriverId", driverId);

					try
					{
						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.HasRows)
								table.Load(reader);
						}
					}
					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"International License Data Error: {ex.Message}");
					}

				}
			}
			return table;

		}

		public static int GetActiveInternationalLicenseIDByDriverID(int DriverID)
		{
			int InternationalLicenseID = -1;

			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{
				using (SqlCommand command = new SqlCommand("", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@DriverID", DriverID);

					try
					{
						connection.Open();

						object result = command.ExecuteScalar();

						if (result != null && int.TryParse(result.ToString(), out int insertedID))
						{
							InternationalLicenseID = insertedID;
						}
					}

					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"International License Data Error: {ex.Message}");

					}
				}

			}

			return InternationalLicenseID;
		}


		// will be kicked soon 
		public static DataTable FindInternationalLicenseMaster(int internationalLicenseID)
        {
            DataTable table = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Select * from DriverInternationalLicenses_View where InternationalLicenseID =@InternationalLicense;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@InternationalLicense", internationalLicenseID);
            
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
                eventLogger.Log($"InternationalLicenseData Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return table;

        }

		public static bool DeleteInternationalLicense(int internationalLicenseID)
		{
			int rowsAffected = 0;
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = "DELETE From InternationalLicenses WHERE InternationalLicenseID=@InternationalLicenseID;";
			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@InternationalLicenseID", internationalLicenseID);

			try
			{
				connection.Open();
				rowsAffected = command.ExecuteNonQuery();

			}
			catch (Exception ex)
			{
				Logger eventLogger = new Logger(LoggingMethods.EventLogger);
				eventLogger.Log($"InternationalLicenseData Error: {ex.Message}");
			}
			finally
			{
				connection.Close();
			}

			return rowsAffected > 0;
		}

		public static bool IsLicenseExist(int internationalLicenseID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT TOP(1) Found=1 From InternationalLicenses WHERE InternationalLicenseID=@InternationalLicenseID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@InternationalLicenseID", internationalLicenseID);

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
                eventLogger.Log($"InternationalLicenseData Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return isExist;
        }

        public static bool IsLicenseActive(int InternationalLicenseID)
        {
            bool isActive = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT TOP(1) IsActive From InternationalLicenses WHERE InternationalLicenseID=@InternationalLicenseID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && bool.TryParse(result.ToString(), out bool activity))
                    isActive = activity;

            }
            catch (Exception ex)
            {
                Logger eventLogger = new Logger(LoggingMethods.EventLogger);
                eventLogger.Log($"InternationalLicenseData Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return isActive;
        }

    }
}
