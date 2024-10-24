using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_DataAccess
{
    public class clsApplicationData
    {
		
		public static bool GetApplicationById(int applicationID, ref int applicantPersonID,
            ref DateTime ApplicationDate, ref int applicationTypeID,ref byte applicationStatus,
            ref DateTime lastStatusDate, ref float paidFees,ref int createdByUserID)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_GetApplicationById", connection))
                {
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@ApplicationID", applicationID);

					try
					{
						connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
							if (reader.Read())
							{
								isFound = true;
								applicantPersonID = (int)reader["ApplicantPersonID"];
								ApplicationDate = Convert.ToDateTime(reader["ApplicationDate"]);
								applicationTypeID = (int)reader["ApplicationTypeID"];
								applicationStatus = Convert.ToByte(reader["ApplicationStatus"]);
								lastStatusDate = Convert.ToDateTime(reader["LastStatusDate"]);
								paidFees = Convert.ToSingle(reader["PaidFees"]);
								createdByUserID = (int)reader["CreatedByUserID"];
							}
						}
					}
					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"ApplicationData Error: {ex.Message}");
						isFound = false;
					}
				}
                   
			}

            return isFound;
        }
       
        public static int AddNewApplication( int applicantPersonID,
             DateTime ApplicationDate,  int applicationTypeID,  short applicationStatus,
             DateTime lastStatusDate, float paidFees, int createdByUserID)
        {
            int applicationID = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddNewApplication", connection))
                {
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@PersonId", applicantPersonID);
					command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
					command.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);
					command.Parameters.AddWithValue("@ApplicationStatus", applicationStatus);
					command.Parameters.AddWithValue("@LastStatusDate", lastStatusDate);
					command.Parameters.AddWithValue("@PaidFees", paidFees);
					command.Parameters.AddWithValue("@UserId", createdByUserID);

					var outPutIdParm = new SqlParameter("@NewApplicationId", SqlDbType.Int)
					{
						Direction = ParameterDirection.Output
					};
					command.Parameters.Add(outPutIdParm);

					try
					{
						connection.Open();

                        command.ExecuteNonQuery();
                        applicationID = (int)outPutIdParm.Value;
					}
					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"ApplicationData Error: {ex.Message}");
					}
					
				}
                    
			}

            return applicationID;
        }

        public static bool UpdateApplication(int applicationID,int applicantPersonID,
             DateTime ApplicationDate, int applicationTypeID, byte applicationStatus,
             DateTime lastStatusDate, float paidFees, int createdByUserID)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateApplication", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@ApplicationID", applicationID);
					command.Parameters.AddWithValue("@PersonID", applicantPersonID);
					command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
					command.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);
					command.Parameters.AddWithValue("@ApplicationStatus", applicationStatus);
					command.Parameters.AddWithValue("@LastStatusDate", lastStatusDate);
					command.Parameters.AddWithValue("@PaidFees", paidFees);
					command.Parameters.AddWithValue("@UserID", createdByUserID);

					try
					{
						connection.Open();
                        rowsAffected = (int)command.ExecuteScalar();

					}
					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"ApplicationData Error: {ex.Message}");
					}
				}
			}

            return rowsAffected>0;
        }

        public static bool UpdateApplicationStatus(int applicationID, byte newStatus)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateApplicationStatus", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@ApplicationID", applicationID);
					command.Parameters.AddWithValue("@NewStatus", newStatus);
					try
					{
						connection.Open();
						rowsAffected =(int) command.ExecuteScalar();
					}
					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"ApplicationData Error: {ex.Message}");
					}
				}
			}
            return rowsAffected > 0;
        }

        public static bool DeleteApplication(int applicationID)
        {
			int rowsAffected = 0;
			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{
				using (SqlCommand command = new SqlCommand("SP_DeleteApplicationStatus", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@ApplicationID", applicationID);
					try
					{
						connection.Open();
						rowsAffected = (int)command.ExecuteScalar();
					}
					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"ApplicationData Error: {ex.Message}");
					}
				}
			}
			return rowsAffected > 0;
		}

        public static DataTable GetAllApplications()
        {
			DataTable table = new DataTable();

			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{

				using (SqlCommand command = new SqlCommand("SP_GetAllApplications", connection))
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
						eventLogger.Log($"ApplicationData Error: {ex.Message}");
					}

				}
			}
			return table;
		}

        public static bool IsApplicationExist(int applicationId)
        {
            bool isExist = false;
			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{
				using (SqlCommand command = new SqlCommand("SP_IsApplicationExists", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@ApplicationID", applicationId);
					
					SqlParameter returnValue = new SqlParameter();
					returnValue.Direction = ParameterDirection.ReturnValue;
					command.Parameters.Add(returnValue);

					try
					{
						connection.Open();
						command.ExecuteNonQuery();
						isExist = (int)returnValue.Value != 0;
						
					}
					catch (Exception ex)
					{
						isExist = false;
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"ApplicationData Error: {ex.Message}");
					}
				}
			}
			return isExist;
        }

		public static int GetActiveApplicationId(int personId, int applicationTypeId)
		{
			int activeApplicationId = -1;
			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{
				using (SqlCommand command = new SqlCommand("SP_GetActiveApplicationId", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@PersonId", personId);
					command.Parameters.AddWithValue("@ApplicationTypeId", applicationTypeId);
					try
					{
						connection.Open();
						activeApplicationId = (int)command.ExecuteScalar();
					}
					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"ApplicationData Error: {ex.Message}");
					}
				}
			}
			return activeApplicationId;
		}

		public static bool DosePersonHasActiveApplications(int personId, int applicationTypeId)
		{
			return GetActiveApplicationId(personId, applicationTypeId) != -1;
		}

		public static int GetActiveApplicationIdForLicenseClass(int personId, int applicationTypeId, int licenseClassId)
		{
			int activeApplicationId = -1;
			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{
				using (SqlCommand command = new SqlCommand("SP_GetActiveApplicationIdForLicenseClass", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@PersonId", personId);
					command.Parameters.AddWithValue("@ApplicationTypeId", applicationTypeId);
					command.Parameters.AddWithValue("@LicenseClassId", licenseClassId);
					try
					{
						connection.Open();
						activeApplicationId = (int)command.ExecuteScalar();
					}
					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"ApplicationData Error: {ex.Message}");
					}
				}
			}
			return activeApplicationId;
		}


		// my before solution
		public static short GetApplicationStatus(int applicationId)
        {
            short status = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT TOP(1) ApplicationStatus From Applications WHERE ApplicationID=@ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", applicationId);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && short.TryParse(result.ToString(), out status))
                {

                }

            }
            catch (Exception ex)
            {
                Logger eventLogger = new Logger(LoggingMethods.EventLogger);
                eventLogger.Log($"ApplicationData Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return status;
        }


    }
}
