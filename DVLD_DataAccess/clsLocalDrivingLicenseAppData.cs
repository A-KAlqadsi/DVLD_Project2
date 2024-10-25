using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsLocalDrivingLicenseAppData
    {
        public static bool GetLocalDrivingLicenseAppByID(int localLicenseID,ref int appID,ref int licenseClassID)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_GetLocalDrivingLicenseApplicationInfoByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@LocalDrivingLicenseAppId", localLicenseID);

					try
					{
						connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
							if (reader.Read())
							{
								isFound = true;
								appID = (int)reader["ApplicationID"];
								licenseClassID = (int)reader["LicenseClassID"];
							}
							
						}
                           
					}
					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"LocalDrivingLicenseAppData Error: {ex.Message}");
					}
				}
			}
                
            return isFound;
        }

		public static bool GetLocalDrivingLicenseAppByApplicationID( int appID, ref int localLicenseID, ref int licenseClassID)
		{
			bool isFound = false;
			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{

				using (SqlCommand command = new SqlCommand("SP_GetLocalDrivingLicenseApplicationInfoByApplicationId", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@ApplicationId", appID);

					try
					{
						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
								isFound = true;
								localLicenseID = (int)reader["LocalDrivingLicenseApplicationId"];
								licenseClassID = (int)reader["LicenseClassID"];
							}

						}

					}
					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"LocalDrivingLicenseAppData Error: {ex.Message}");
					}
				}
			}

			return isFound;
		}
    
		public static int AddNewLocalLicenseDrivingApp(int appID, int licenseClassID)
        {
            int localLicenseID = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddNewLocalDrivingLicenseApplication", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@LicenseClassId", licenseClassID);
					command.Parameters.AddWithValue("@ApplicationId", appID);

                    var outputParamId = new SqlParameter("@NewLocalDrivingLicenseAppId", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputParamId);
                   
					try
					{
						connection.Open();
						command.ExecuteNonQuery();
						localLicenseID =(int)outputParamId.Value;
					}
					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"LocalDrivingLicenseAppData Error: {ex.Message}");
					}
					
				}
                   
			}

            return localLicenseID;
        }

        public static bool UpdateLocalLicenseDrivingApp(int localLicenseID,int appID, int licenseClassID)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateLocalDrivingLicenseApplication", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@LocalDrivingLicenseAppId", localLicenseID);
					command.Parameters.AddWithValue("@LicenseClassID", licenseClassID);
					command.Parameters.AddWithValue("@ApplicationId", appID);

					try
					{
						connection.Open();
						rowsAffected = (int)command.ExecuteScalar();
					}
					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"LocalDrivingLicenseAppData Error: {ex.Message}");
					}
				}
			}

            return rowsAffected>0;
        }

        public static bool DeleteLocalDrivingLicenseApp(int localLicenseID)
        {
			int rowsAffected = 0;
			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{
				using (SqlCommand command = new SqlCommand("SP_DeleteLocalDrivingLicenseApplication", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@LocalDrivingLicenseAppId", localLicenseID);

					try
					{
						connection.Open();
						rowsAffected = (int)command.ExecuteScalar();
					}
					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"LocalDrivingLicenseAppData Error: {ex.Message}");
					}
				}
			}
			return rowsAffected > 0;
		}

        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
			DataTable table = new DataTable();

			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{

				using (SqlCommand command = new SqlCommand("SP_GetAllLocalDrivingLicenseApplications", connection))
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
						eventLogger.Log($"LocalDrivingLicenseApplicationData Error: {ex.Message}");
					}

				}
			}
			return table;

		}

		public static bool DoesPassTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)

		{
			bool Result = false;

			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{
				using (SqlCommand command = new SqlCommand("SP_DoesPassedTestType", connection))
				{
					command.Parameters.AddWithValue("@LocalDrivingLicenseAppId", LocalDrivingLicenseApplicationID);
					command.Parameters.AddWithValue("@TestTypeId", TestTypeID);

					SqlParameter returnValue = new SqlParameter();
					returnValue.Direction = ParameterDirection.ReturnValue;
					command.Parameters.Add(returnValue);

					try
					{
						connection.Open();
						command.ExecuteNonQuery();
						Result = (int)returnValue.Value == 1;
					}

					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"LocalDrivingLicenseApplicationData Error: {ex.Message}");
					}
				}
			}

			return Result;
		}

		public static bool DoesAttendTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)

		{
			bool Result = false;

			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{
				using (SqlCommand command = new SqlCommand("SP_DoesAttendTestType", connection))
				{
					command.Parameters.AddWithValue("@LocalDrivingLicenseAppId", LocalDrivingLicenseApplicationID);
					command.Parameters.AddWithValue("@TestTypeId", TestTypeID);

					SqlParameter returnValue = new SqlParameter();
					returnValue.Direction = ParameterDirection.ReturnValue;
					command.Parameters.Add(returnValue);

					try
					{
						connection.Open();
						command.ExecuteNonQuery();
						Result = (int)returnValue.Value == 1;
					}

					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"LocalDrivingLicenseApplicationData Error: {ex.Message}");
					}
				}
			}

			return Result;
		}

		public static bool IsThereAnActiveScheduleTest(int LocalDrivingLicenseApplicationID, int TestTypeID)

		{
			bool Result = false;

			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{
				using (SqlCommand command = new SqlCommand("SP_IsThereAnActiveScheduleTest", connection))
				{
					command.Parameters.AddWithValue("@LocalDrivingLicenseAppId", LocalDrivingLicenseApplicationID);
					command.Parameters.AddWithValue("@TestTypeId", TestTypeID);

					SqlParameter returnValue = new SqlParameter();
					returnValue.Direction = ParameterDirection.ReturnValue;
					command.Parameters.Add(returnValue);

					try
					{
						connection.Open();
						command.ExecuteNonQuery();
						Result = (int)returnValue.Value == 1;
					}

					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"LocalDrivingLicenseApplicationData Error: {ex.Message}");
					}
				}
			}

			return Result;
		}

		public static byte TotalTrialsPerTest(int LocalDrivingLicenseApplicationID, int TestTypeID)

		{
			byte totalTrials = 0;

			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{
				using (SqlCommand command = new SqlCommand("SP_TotalTrialsPerTest", connection))
				{
					command.Parameters.AddWithValue("@LocalDrivingLicenseAppId", LocalDrivingLicenseApplicationID);
					command.Parameters.AddWithValue("@TestTypeId", TestTypeID);

					try
					{
						connection.Open();
						totalTrials = (byte) command.ExecuteScalar();
					}

					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"LocalDrivingLicenseApplicationData Error: {ex.Message}");
					}
				}
			}

			return totalTrials;
		}


    }
}