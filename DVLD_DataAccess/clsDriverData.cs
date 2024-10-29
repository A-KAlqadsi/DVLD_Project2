using System;
using System.Data.SqlClient;
using System.Data;


namespace DVLD_DataAccess
{
    public class clsDriverData
    {
        public static bool GetDriverByDriverId(int driverID, ref int personID, ref int createdUserID ,ref DateTime createdDate)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetDriverById", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@DriverID", driverID);

					try
					{
						connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
							if (reader.Read())
							{
								isFound = true;
								personID = (int)reader["PersonID"];
								createdUserID = (int)reader["CreatedByUserID"];
								createdDate = Convert.ToDateTime(reader["CreatedDate"]);
							}
						}
					}
					catch (Exception ex)
					{
						isFound = false;
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"DriverData Error: {ex.Message}");
					}
				}
			}
            return isFound;
        }

        public static bool GetDriverByPersonId( int personID,ref int driverID, ref int createdUserID, ref DateTime createdDate)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetDriverByPersonId", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@PersonID", personID);

					try
					{
						connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
							if (reader.Read())
							{
								isFound = true;
								driverID = (int)reader["DriverID"];
								createdUserID = (int)reader["CreatedByUserID"];
								createdDate = Convert.ToDateTime(reader["CreatedDate"]);

							}
						}
					}
					catch (Exception ex)
					{
						isFound = false;
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"DriverData Error: {ex.Message}");
					}
				}
			}
            return isFound;
        }

        public static int AddNewDriver( int personID,  int createdUserID, DateTime createdDate)
        {
            int DriverId = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddNewDriver", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@PersonID", personID);
					command.Parameters.AddWithValue("@CreatedByUserID", createdUserID);
					command.Parameters.AddWithValue("@CreatedDate", createdDate);
                    var outputParamId = new SqlParameter("@NewDriverId", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output,
                    };
                    command.Parameters.Add(outputParamId);

					try
					{
						connection.Open();
                        command.ExecuteNonQuery();
                        DriverId = (int)outputParamId.Value;
					}
					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"DriverData Error: {ex.Message}");
					}
				}
                 
			}
            return DriverId;
        }

        public static bool UpdateDriver(int driverID, int personID, int createdUserID, DateTime createdDate)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateDriver", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@DriverID", driverID);
					command.Parameters.AddWithValue("@PersonID", personID);
					command.Parameters.AddWithValue("@CreatedByUserID", createdUserID);
					command.Parameters.AddWithValue("@CreatedDate", createdDate);

					try
					{
						connection.Open();

						rowsAffected =(int)command.ExecuteScalar();
					}
					catch (Exception ex)
					{
						rowsAffected = 0;
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"DriverData Error: {ex.Message}");
					}
				}
			}
            return rowsAffected > 0;
        }

		public static DataTable GetAllDrivers()
		{
			DataTable table = new DataTable();

			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{

				using (SqlCommand command = new SqlCommand("SP_GetAllDrivers", connection))
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
						eventLogger.Log($"DriverData Error: {ex.Message}");
					}

				}
			}
			return table;

		}

         
        // will be kicked soon
        public static bool IsPersonADriver(int personID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT TOP(1) Found=1 From Drivers WHERE PersonID=@PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", personID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int found))
                    isExist = true;

            }
            catch (Exception ex)
            {
                isExist = false;
                Logger eventLogger = new Logger(LoggingMethods.EventLogger);
                eventLogger.Log($"DriverData Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return isExist;
        }


    }
}
