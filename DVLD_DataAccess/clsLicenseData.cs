using System;
using System.Data;
using System.Data.SqlClient;


namespace DVLD_DataAccess
{
    public class clsLicenseData
    {
        public static bool GetLicenseByID(int licenseID,ref int applicationId,ref int driverID,
            ref int licenseClass,ref DateTime issueDate,ref DateTime expirationDate,ref string notes,
            ref float paidFees,ref bool isActive ,ref byte issueReason,ref int createdByUserID)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetLicenseById", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@LicenseID", licenseID);

					try
					{
						connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
							if (reader.Read())
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
								issueReason = Convert.ToByte(reader["IssueReason"]);
								createdByUserID = (int)reader["CreatedByUserID"];
							}
						}
                           
					}
					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"LicenseData Error: {ex.Message}");
					}
				}
			}
            return isFound;
        }

        // will be kicked soon
        public static bool GetLicenseByApplicationID(int applicationId,ref int licenseID, ref int driverID,
        ref int licenseClass, ref DateTime issueDate, ref DateTime expirationDate, ref string notes,
        ref float paidFees, ref bool isActive, ref byte issueReason, ref int createdByUserID)
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
                    issueReason = Convert.ToByte(reader["IssueReason"]);
                    createdByUserID = (int)reader["CreatedByUserID"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Logger eventLogger = new Logger(LoggingMethods.EventLogger);
                eventLogger.Log($"LicenseData Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }

       
        public static int AddNewLicense( int applicationId, int driverID,
             int licenseClass,  DateTime issueDate,  DateTime expirationDate,  string notes,
             float paidFees,  bool isActive,  byte issueReason,  int createdByUserID)
        {
            int licenseID = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddNewLicense", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
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

                    var outputParamId = new SqlParameter("@NewLicenseId", SqlDbType.Int)

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
						eventLogger.Log($"LicenseData Error: {ex.Message}");
					}
				}
			}

            return licenseID;
        }

        public static bool UpdateLicense(int licenseID, int applicationId, int driverID,
             int licenseClass, DateTime issueDate, DateTime expirationDate, string notes,
             float paidFees, bool isActive, short issueReason, int createdByUserID)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateLicense", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
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
						rowsAffected = (int)command.ExecuteScalar();

					}
					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"LicenseData Error: {ex.Message}");
					}
				}
			}
               
            
            return rowsAffected >0;
        }

		public static DataTable GetAllLicenses()
		{
			DataTable table = new DataTable();

			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{

				using (SqlCommand command = new SqlCommand("SP_GetAllLicenses", connection))
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
						eventLogger.Log($"LicenseData Error: {ex.Message}");
					}

				}
			}
			return table;

		}

		public static int GetActiveLicenseIDByPersonID(int PersonID, int LicenseClassID)
		{
			int LicenseID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

				SqlCommand command = new SqlCommand("SP_GetActiveLicenseIDByPersonID", connection);

				command.Parameters.AddWithValue("@PersonID", PersonID);
				command.Parameters.AddWithValue("@LicenseClassId", LicenseClassID);

				try
				{
					connection.Open();

					object result = command.ExecuteScalar();

					if (result != null && int.TryParse(result.ToString(), out int insertedID))
					{
						LicenseID = insertedID;
					}
				}

				catch (Exception ex)
				{
					//Console.WriteLine("Error: " + ex.Message);

				}

			}

			return LicenseID;
		}

		public static bool DeactivateLicense(int licenseID, bool isActive)
		{
			int rowsAffected = 0;
			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{
				using (SqlCommand command = new SqlCommand("SP_DeactivateLicense", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@LicenseID", licenseID);
					
					try
					{
						connection.Open();
						rowsAffected =(int)command.ExecuteScalar();

					}
					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"LicenseData Error: {ex.Message}");
					}
					
				}
					
			}
			return rowsAffected > 0;
		}


		// will be kicked soon 

		// will be kicked soon
		public static DataTable GetLicenseByIdMaster(int licenseID)
		{
			DataTable table = new DataTable();
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = "Select * from LicenseInfo_View";

			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@LicenseID", licenseID);
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
				eventLogger.Log($"LicenseData Error: {ex.Message}");
			}
			finally
			{
				connection.Close();
			}
			return table;
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
				Logger eventLogger = new Logger(LoggingMethods.EventLogger);
				eventLogger.Log($"LicenseData Error: {ex.Message}");
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
                Logger eventLogger = new Logger(LoggingMethods.EventLogger);
                eventLogger.Log($"LicenseData Error: {ex.Message}");
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
                Logger eventLogger = new Logger(LoggingMethods.EventLogger);
                eventLogger.Log($"LicenseData Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return detainID;
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
				Logger eventLogger = new Logger(LoggingMethods.EventLogger);
				eventLogger.Log($"LicenseData Error: {ex.Message}");
			}
			finally
			{
				connection.Close();
			}

			return isExist;
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
                Logger eventLogger = new Logger(LoggingMethods.EventLogger);
                eventLogger.Log($"LicenseData Error: {ex.Message}");
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
                Logger eventLogger = new Logger(LoggingMethods.EventLogger);
                eventLogger.Log($"LicenseData Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return isExpired;
        }

		// will be kicked soon
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
				Logger eventLogger = new Logger(LoggingMethods.EventLogger);
				eventLogger.Log($"LicenseData Error: {ex.Message}");
			}
			finally
			{
				connection.Close();
			}
			return table;

		}

		// will be kicked soon
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
				Logger eventLogger = new Logger(LoggingMethods.EventLogger);
				eventLogger.Log($"LicenseData Error: {ex.Message}");
			}
			finally
			{
				connection.Close();
			}

			return rowsAffected > 0;
		}



	}
}
