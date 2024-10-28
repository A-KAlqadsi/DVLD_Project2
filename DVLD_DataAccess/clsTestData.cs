using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsTestData
    {
        public static bool GetTestByID(int testID,ref int testAppointmentID,ref bool testResult,
            ref string notes, ref int createdByUserID)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_GetTestById", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@TestID", testID);

					try
					{
						connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
							if (reader.Read())
							{
								isFound = true;
								testAppointmentID = (int)reader["TestAppointmentID"];
								testResult = Convert.ToBoolean(reader["TestResult"]);
								notes = (reader["Notes"] != DBNull.Value) ? reader["Notes"].ToString() : "";
								createdByUserID = (int)reader["CreatedByUserID"];
							}
						}
					}
					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"TestData Error: {ex.Message}");
					}	
				}
			}
			return isFound;
        }


		public static bool GetLastTestByPersonIdAndTestTypeAndLicenseClass(int personId, int testTypeId ,int licenseClassId ,ref int testID, ref int testAppointmentID, ref bool testResult,
	    ref string notes, ref int createdByUserID)
		{
			bool isFound = false;
			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{

				using (SqlCommand command = new SqlCommand("SP_GetLastTestByPersonAndTestTypeAndLicenseClass", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@PersonId", personId);
					command.Parameters.AddWithValue("@TestType", testTypeId);
					command.Parameters.AddWithValue("@LicenseClassId", licenseClassId);

					try
					{
						connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
							if (reader.Read())
							{
								isFound = true;
								testID = (int)reader["TestId"];
								testAppointmentID = (int)reader["TestAppointmentID"];
								testResult = Convert.ToBoolean(reader["TestResult"]);
								notes = (reader["Notes"] != DBNull.Value) ? reader["Notes"].ToString() : "";
								createdByUserID = (int)reader["CreatedByUserID"];
							}
						}
					}
					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"TestData Error: {ex.Message}");
					}
				}
			}

			return isFound;
		}

        public static int AddNewTest(int testAppointmentID,bool testResult,
             string notes,int createdByUserID)
        {
            int testID = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_AddNewTest", connection))
                {
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);
					command.Parameters.AddWithValue("@TestResult", testResult);
					command.Parameters.AddWithValue("@UserID", createdByUserID);
					if (string.IsNullOrEmpty(notes))
						command.Parameters.AddWithValue("@Notes", DBNull.Value);
					else
						command.Parameters.AddWithValue("@Notes", notes);

                    var outputParamId = new SqlParameter("@NewTestId", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputParamId);

					try
					{
						connection.Open();
                        command.ExecuteNonQuery();
                        testID = (int)outputParamId.Value;
					}
					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"TestData Error: {ex.Message}");
					}
				}
                   
			}
            return testID;
        }

        public static bool UpdateTest(int testID, int testAppointmentID, bool testResult,
            string notes, int createdByUserID)
        {
            int rowAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateTest", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@TestID", testID);
					command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);
					command.Parameters.AddWithValue("@TestResult", testResult);
					command.Parameters.AddWithValue("@UserID", createdByUserID);
					if (string.IsNullOrEmpty(notes))
						command.Parameters.AddWithValue("@Notes", DBNull.Value);
					else
						command.Parameters.AddWithValue("@Notes", notes);

					try
					{
						connection.Open();
						rowAffected =(int)command.ExecuteScalar();
					}
					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"TestData Error: {ex.Message}");
					}
				}
			}
			return rowAffected>0;
        }

		public static DataTable GetAllTests()
		{
			DataTable table = new DataTable();

			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{

				using (SqlCommand command = new SqlCommand("SP_GetAllTests", connection))
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
						eventLogger.Log($"TestData Error: {ex.Message}");
					}

				}
			}
			return table;
		}

        public static byte CountPassedTests(int localDrivingLicenseAppID)
        {
            byte passedTests = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetPassedTestCount", connection))
                {
					command.Parameters.AddWithValue("@localDrivingLicenseAppID", localDrivingLicenseAppID);

					try
					{
						connection.Open();
                        passedTests = (byte)command.ExecuteScalar();

					}
					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"TestData Error: {ex.Message}");
					}					
				}
			}
            return passedTests;
        }

    }
}
