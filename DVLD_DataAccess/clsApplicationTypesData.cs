using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Security.Policy;


namespace DVLD_DataAccess
{
    public class clsApplicationTypesData
    {
        public static bool GetApplicationTypeByID(int appTypeID ,ref string appTypeTitle,ref float appFees)
        {
			bool isFound = false;
			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{
				using (SqlCommand command = new SqlCommand("SP_GetApplicationType", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@ApplicationTypeID", appTypeID);

					try
					{
						connection.Open();

						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
                                appTypeTitle = (string)reader["ApplicationTypeTitle"];
                                appFees = Convert.ToSingle(reader["ApplicationFees"]);
								isFound = true;
							}

						}

					}
					catch (Exception ex)
					{
						isFound = false;
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"ApplicationTypeData Error: {ex.Message}");
					}

				}

			}

			return isFound;
		}

        public static int AddNewApplicationType(string appTypeTitle, float appFees)
        {
			int Id = -1;
			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{
				using (SqlCommand command = new SqlCommand("SP_AddNewApplicationType", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue("@Title", appTypeTitle);
					command.Parameters.AddWithValue("@Fees", appFees);

					var outPutIdParm = new SqlParameter("@NewTypeId", SqlDbType.Int)
					{
						Direction = ParameterDirection.Output
					};
					command.Parameters.Add(outPutIdParm);

					try
					{
						connection.Open();
						command.ExecuteNonQuery();
						Id = (int)outPutIdParm.Value;

					}
					catch (Exception ex)
					{

						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"ApplicationTypeData Error: {ex.Message}");
					}

				}

			}

			return Id;
		}

        public static bool UpdateApplicationType(int appTypeID,string appTypeTitle, float appFees)
        {
           int rowsAffected = 0;
			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{
				using (SqlCommand command = new SqlCommand("SP_UpdateApplicationType", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue("@Id", appTypeID);
					command.Parameters.AddWithValue("@Title", appTypeTitle);
					command.Parameters.AddWithValue("@Fees", appFees);

					try
					{
						connection.Open();
						rowsAffected = (int)command.ExecuteScalar();
						
					}
					catch (Exception ex)
					{

						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"ApplicationTypeData Error: {ex.Message}");
					}

				}

			}
			return rowsAffected>0;
        }

        public static DataTable GetAllApplicationTypes()
        {
			DataTable table = new DataTable();

			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{

				using (SqlCommand command = new SqlCommand("SP_GetAllApplicationTypes", connection))
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
						eventLogger.Log($"ApplicationTypesData Error: {ex.Message}");
					}

				}
			}
			return table;

		}

    }
}
