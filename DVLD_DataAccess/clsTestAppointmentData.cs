using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsTestAppointmentData
    {
        public static bool GetTestAppointmentByID(int testAppointmentID, ref int testTypeID,
            ref int localDrivingLicenseAppID, ref DateTime appointmentDate, ref float paidFees,
            ref int createdByUserID, ref bool isLocked,ref int? retakeTestApplicationId)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_GetTestAppointmentById", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);

					try
					{
						connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
							if (reader.Read())
							{
								isFound = true;
								testTypeID = (int)reader["TestTypeID"];
								localDrivingLicenseAppID = (int)reader["LocalDrivingLicenseApplicationID"];
								appointmentDate = Convert.ToDateTime(reader["AppointmentDate"]);
								paidFees = Convert.ToSingle(reader["PaidFees"]);
								createdByUserID = (int)reader["CreatedByUserID"];
								isLocked = Convert.ToBoolean(reader["IsLocked"]);
                                if (reader["RetakeTestApplicationId"] == DBNull.Value)
                                    retakeTestApplicationId = null;
                                else
                                    retakeTestApplicationId = (int)reader["RetakeTestApplicationId"];
							}
							
						}

					}
					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"TestAppointmentData Error: {ex.Message}");
					}
					
				}
                   
			}
            return isFound;
        }

        public static bool GetLastTestAppointment (int localDrivingLicenseAppID, int testTypeID, int testAppointmentID,
			  ref DateTime appointmentDate, ref float paidFees,
			ref int createdByUserID, ref bool isLocked,ref int? retakeTestApplicationId)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using(SqlCommand command = new SqlCommand("SP_GetLastTestAppointment", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@LocalDrivingLicenseAppId", localDrivingLicenseAppID);
					command.Parameters.AddWithValue("@TestTypeId", testTypeID);

                    try
                    {
                        connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
								isFound = true;
								testAppointmentID = (int)reader["TestAppointmentId"];
								appointmentDate = Convert.ToDateTime(reader["AppointmentDate"]);
								paidFees = Convert.ToSingle(reader["PaidFees"]);
								createdByUserID = (int)reader["CreatedByUserID"];
								isLocked = Convert.ToBoolean(reader["IsLocked"]);
								if (reader["RetakeTestApplicationId"] == DBNull.Value)
									retakeTestApplicationId = null;
								else
									retakeTestApplicationId = (int)reader["RetakeTestApplicationId"];
							}

						}


					}
                    catch (Exception ex)
                    {
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"TestAppointmentData Error: {ex.Message}");
					}

				}
			}

            return isFound;
        }

		public static int AddNewTestAppointment( int testTypeID,
             int localDrivingLicenseAppID,  DateTime appointmentDate,  float paidFees,
             int createdByUserID,int? RetakeTestApplicationID =null)
        {
            int testAppointmentID = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("AddNewTestAppointment", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@TestTypeID", testTypeID);
					command.Parameters.AddWithValue("@localLicenseID", localDrivingLicenseAppID);
					command.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
					command.Parameters.AddWithValue("@PaidFees", paidFees);
					command.Parameters.AddWithValue("@UserID", createdByUserID);
                    if(RetakeTestApplicationID != null )
                        command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
                    else
						command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);

                    SqlParameter outputPramaId = new SqlParameter("@NewTestAppointmentId", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputPramaId);

					try
					{
                        connection.Open();
                        command.ExecuteNonQuery();
                        testAppointmentID =(int)outputPramaId.Value;
					}
					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"TestAppointmentData Error: {ex.Message}");
					}
					
				}
                   
			}

            return testAppointmentID;
        }

        public static bool UpdateTestAppointment(int testAppointmentID,int testTypeID,
            int localDrivingLicenseAppID, DateTime appointmentDate, float paidFees,
            int createdByUserID, bool isLocked, int? RetakeTestApplicationID = null)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateTestAppointment", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);
					command.Parameters.AddWithValue("@TestTypeID", testTypeID);
					command.Parameters.AddWithValue("@localLicenseID", localDrivingLicenseAppID);
					command.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
					command.Parameters.AddWithValue("@PaidFees", paidFees);
					command.Parameters.AddWithValue("@UserID", createdByUserID);
					command.Parameters.AddWithValue("@IsLocked", isLocked);
					if (RetakeTestApplicationID != null)
						command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
					else
						command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);

					try
					{
                        connection.Open();
                        rowsAffected = (int)command.ExecuteScalar();
					}
					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"TestAppointmentData Error: {ex.Message}");
					}
					finally
					{
						connection.Close();
					}
				}
                    
			}

            return rowsAffected>0;
        }

		public static DataTable GetAllTestAppointments()
		{
			DataTable table = new DataTable();

			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{

				using (SqlCommand command = new SqlCommand("SP_GetAllTestAppointments", connection))
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
						eventLogger.Log($"TestAppointmentData Error: {ex.Message}");
					}

				}
			}
			return table;

		}

		public static DataTable GetApplicationTestAppointmentsPerTestType(int localDrivingLicenseAppId, int testTypeId)
		{
			DataTable table = new DataTable();

			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{

				using (SqlCommand command = new SqlCommand("GetApplicationTestAppointmentsPerTestType", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@LocalDrivingLicenseAppId", localDrivingLicenseAppId);
					command.Parameters.AddWithValue("@TestTypeId", testTypeId);

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
						eventLogger.Log($"TestAppointmentData Error: {ex.Message}");
					}

				}
			}
			return table;

		}

		public static int GetTestId(int testAppointmentID)
		{
			int testId = -1;
			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{

				using (SqlCommand command = new SqlCommand("SP_GetTestId", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@TestAppointmentId", testAppointmentID);

					try
					{
						connection.Open();
						testId = (int) command.ExecuteScalar();

					}
					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"TestAppointmentData Error: {ex.Message}");
					}

				}

			}
			return testId;
		}



		// will be removed
		public static DataTable GetestAppointmentsMasterByID(int testAppointmentID)
        {
            DataTable table = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * From TestAppointments_View Where TestAppointmentID=@TestAppointmentID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);

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
                eventLogger.Log($"TestAppointmentData Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return table;

        }

        public static bool IsTestAppointmentExist(int testAppointmentID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT TOP(1) Found=1 From TestAppointments WHERE TestAppointmentID=@TestAppointmentID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);

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
                eventLogger.Log($"TestAppointmentData Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return isExist;
        }

        public static bool IsPersonHasActiveTestAppointment(int localDrivingLicenseAppID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT TOP(1) Found=1 From TestAppointments WHERE LocalDrivingLicenseApplicationID=@LocalDrivingLicenseAppID And IsLocked=@IsLocked";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseAppID", localDrivingLicenseAppID);
            command.Parameters.AddWithValue("@IsLocked", false);


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
                eventLogger.Log($"TestAppointmentData Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return isExist;
        }

        public static bool IsPersonHasTestAppointment(int localDrivingLicenseAppID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT TOP(1) Found=1 From TestAppointments WHERE LocalDrivingLicenseApplicationID=@LocalDrivingLicenseAppID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseAppID", localDrivingLicenseAppID);
           

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
                eventLogger.Log($"TestAppointmentData Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return isExist;
        }

        public static int IsTestAppointmentPassed(int testAppointmentID)
        {
            int testResult = 2;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT TestResult  From Tests WHERE TestAppointmentID=@TestAppointmentID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && bool.TryParse(result.ToString(), out bool findResult))
                {
                    testResult = findResult ? 1 : 0;
                }

            }
            catch (Exception ex)
            {
                Logger eventLogger = new Logger(LoggingMethods.EventLogger);
                eventLogger.Log($"TestAppointmentData Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return testResult;
        }

    }
}
