using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Security.Policy;


namespace DVLD_DataAccess
{
    public class clsUserData
    {
		/*
         
         */
		public static bool GetUserByUserId(int userID, ref int personID,ref string userName,ref string password,ref bool isActive)
        {
			bool isFound = false;
			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{
				using (SqlCommand command = new SqlCommand("SP_GetUserById", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@UserId", userID);

					try
					{
						connection.Open();

						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
								isFound = true;
								personID = (int)reader["PersonID"];
								userName = reader["UserName"].ToString();
								password = reader["Password"].ToString();
								isActive = (bool)reader["IsActive"];
							}

						}

					}
					catch (Exception ex)
					{
						isFound = false;
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"UserData Error: {ex.Message}");
					}
				}
			}
			return isFound;
		}

        public static bool GetUserByUsername(string userName, ref int userID, ref int personID, ref string password, ref bool isActive)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * From Users WHERE UserName=@UserName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", userName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    userID = (int)reader["UserID"];
                    personID = (int)reader["PersonID"];
                    password = reader["Password"].ToString();
                    isActive = Convert.ToBoolean(reader["IsActive"]);

                }
                reader.Close();

            }
            catch (Exception ex)
            {
                isFound = false;
                Logger eventLogger = new Logger(LoggingMethods.EventLogger);
                eventLogger.Log($"UserData Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

		public static bool GetUserByPersonId(int personID , ref int userID,ref string userName, ref string password, ref bool isActive)
		{
			bool isFound = false;
			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{
				using (SqlCommand command = new SqlCommand("SP_GetUserByPersonId", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@PersonId", personID);

					try
					{
						connection.Open();

						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
								isFound = true;
								userID = (int)reader["UserId"];
								userName = reader["UserName"].ToString();
								password = reader["Password"].ToString();
								isActive = (bool)reader["IsActive"];
							}

						}

					}
					catch (Exception ex)
					{
						isFound = false;
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"UserData Error: {ex.Message}");
					}
				}
			}
			return isFound;
		}

		public static bool GetUserByUsernameAndPassword(string userName, string password, ref int userID, ref int personID , ref bool isActive)
		{
			bool isFound = false;
			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{
				using (SqlCommand command = new SqlCommand("SP_GetUserByUserNameAndPassword", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@UserName", userName);
					command.Parameters.AddWithValue("@Password", password);

					try
					{
						connection.Open();

						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
								isFound = true;
								personID = (int)reader["PersonId"];
								userID = (int)reader["UserId"];
								isActive = (bool)reader["IsActive"];
							}

						}

					}
					catch (Exception ex)
					{
						isFound = false;
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"UserData Error: {ex.Message}");
					}
				}
			}
			return isFound;
		}

		public static int AddNewUser( int personID, string userName, string password, bool isActive)
        {
			int userId = -1;
			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{
				using (SqlCommand command = new SqlCommand("SP_AddNewUser", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue("@PersonID", personID);
					command.Parameters.AddWithValue("@UserName", userName);
					command.Parameters.AddWithValue("@Password", password);
					command.Parameters.AddWithValue("@IsActive", isActive);

					var outPutIdParm = new SqlParameter("@NewUserId", SqlDbType.Int)
					{
						Direction = ParameterDirection.Output
					};
					command.Parameters.Add(outPutIdParm);

					try
					{
						connection.Open();
						command.ExecuteNonQuery();
						userId = (int)outPutIdParm.Value;

					}
					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"UserData Error: {ex.Message}");
					}
				}
			}
			return userId;
		}
		
		public static bool UpdateUser(int userID, int personID, string userName, string password, bool isActive)
        {
			int rowsAffected = 0;
			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{
				using (SqlCommand command = new SqlCommand("SP_UpdateUser", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@UserID", userID);
					command.Parameters.AddWithValue("@PersonID", personID);
					command.Parameters.AddWithValue("@UserName", userName);
					command.Parameters.AddWithValue("@Password", password);
					command.Parameters.AddWithValue("@IsActive", isActive);

					try
					{
						connection.Open();
						rowsAffected = (int)command.ExecuteScalar();
					}
					catch (Exception ex)
					{

						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"UserData Error: {ex.Message}");
					}

				}
			}
			return rowsAffected > 0;
		}

        public static DataTable GetAllUsers()
        {
			DataTable table = new DataTable();

			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{

				using (SqlCommand command = new SqlCommand("SP_GetAllUsers", connection))
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
						eventLogger.Log($"UserData Error: {ex.Message}");
					}
				}
			}
			return table;

		}

        public static bool DeleteUser(int userID)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_DeleteUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@UserID", userID);

					try
					{
						connection.Open();
						rowsAffected =(int)command.ExecuteScalar();

					}
					catch (Exception ex)
					{
						rowsAffected = 0;
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"UserData Error: {ex.Message}");
					}
				}
                    
			}
            return rowsAffected > 0;
        }

        public static bool IsUserExist(int userID)
        {
			bool isExist = false;
			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{
				using (SqlCommand command = new SqlCommand("SP_IsUserExistsByUserId", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@UserId", userID);

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
						eventLogger.Log($"UserData Error: {ex.Message}");
					}
				}
			}
			return isExist;
		}

        public static bool IsUserExist(string userName)
        {
			bool isExist = false;
			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{
				using (SqlCommand command = new SqlCommand("SP_IsUserExistsByUserName", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@UserName", userName);

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
						eventLogger.Log($"UserData Error: {ex.Message}");
					}
				}
			}
			return isExist;
		}

		public static bool IsUserExistForPersonId(int personId)
		{
			bool isExist = false;
			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{
				using (SqlCommand command = new SqlCommand("SP_IsUserExistsForPersonId", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@PersonId", personId);

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
						eventLogger.Log($"UserData Error: {ex.Message}");
					}
				}
			}
			return isExist;
		}


    }
}
