using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsPersonData
    {
        public static bool GetPersonById(int personID,ref string nationalNo , ref string firstName
            ,ref string secondName ,ref string thirdName ,ref string lastName,
            ref DateTime DateOfBirth ,ref short gender , ref string address, ref string phone ,ref string email,
            ref int nationalityCountryID ,ref string imagePath)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetPersonById", connection))
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
								nationalNo = reader["NationalNo"].ToString();
								firstName = reader["FirstName"].ToString();
								secondName = reader["SecondName"].ToString();
								thirdName = (reader["ThirdName"] == DBNull.Value) ? "" : reader["ThirdName"].ToString();
								lastName = reader["LastName"].ToString();
								DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
								gender = Convert.ToInt16(reader["Gender"]);
								address = reader["Address"].ToString();
								phone = reader["Phone"].ToString();
								email = (reader["Email"] == DBNull.Value) ? "" : reader["Email"].ToString();
								nationalityCountryID = Convert.ToInt32(reader["NationalityCountryID"]);
								imagePath = (reader["ImagePath"] == DBNull.Value) ? "" : reader["ImagePath"].ToString();
							}
							
						}
                          
					}
					catch (Exception ex)
					{
						isFound = false;
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"PersonData Error: {ex.Message}");
					}
					
				}

			}

            return isFound;
        }

        public static bool GetPersonByNationalNo(string nationalNo, ref int personID, ref string firstName
                    , ref string secondName, ref string thirdName, ref string lastName,
                    ref DateTime DateOfBirth, ref short gender, ref string address, ref string phone, ref string email,
                    ref int nationalityCountryID, ref string imagePath)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetPersonByNationalNo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NationalNo", nationalNo);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                personID = Convert.ToInt32(reader["PersonId"]);
                                firstName = reader["FirstName"].ToString();
                                secondName = reader["SecondName"].ToString();
                                thirdName = (reader["ThirdName"] == DBNull.Value) ? "" : reader["ThirdName"].ToString();
                                lastName = reader["LastName"].ToString();
                                DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                                gender = Convert.ToInt16(reader["Gender"]);
                                address = reader["Address"].ToString();
                                phone = reader["Phone"].ToString();
                                email = (reader["Email"] == DBNull.Value) ? "" : reader["Email"].ToString();
                                nationalityCountryID = Convert.ToInt32(reader["NationalityCountryID"]);
                                imagePath = (reader["ImagePath"] == DBNull.Value) ? "" : reader["ImagePath"].ToString();
                            }

                        }

                    }
                    catch (Exception ex)
                    {
                        isFound = false;
                        Logger eventLogger = new Logger(LoggingMethods.EventLogger);
                        eventLogger.Log($"PersonData Error: {ex.Message}");
                    }

                }

            }
            return isFound;
        }

		public static int AddNewPerson(string nationalNo, string firstName
            ,  string secondName,  string thirdName,  string lastName,
             DateTime DateOfBirth,  short gender,  string address,  string phone, string email,
             int nationalityCountryID,  string imagePath)
        {
            int personID = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddNewPerson", connection))
                {
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue("@NationalNo", nationalNo);
					command.Parameters.AddWithValue("@FirstName", firstName);
					command.Parameters.AddWithValue("@SecondName", secondName);
					command.Parameters.AddWithValue("@LastName", lastName);
					command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
					command.Parameters.AddWithValue("@Gender", gender);
					command.Parameters.AddWithValue("@Address", address);
					command.Parameters.AddWithValue("@phone", phone);
					command.Parameters.AddWithValue("@CountryId", nationalityCountryID);

					if (!string.IsNullOrEmpty(thirdName))		
						command.Parameters.AddWithValue("@ThirdName", thirdName);

					if (!string.IsNullOrEmpty(email))
						command.Parameters.AddWithValue("@Email", email);

					if (!string.IsNullOrEmpty(imagePath))
						command.Parameters.AddWithValue("@ImagePath", imagePath);

                   
					var outPutIdParm = new SqlParameter("@NewPersonId", SqlDbType.Int)
					{
						Direction = ParameterDirection.Output
					};
					command.Parameters.Add(outPutIdParm);

					try
					{
						connection.Open();
						command.ExecuteNonQuery();
						personID =  (int)outPutIdParm.Value;

					}
					catch (Exception ex)
					{
                        
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"PersonData Error: {ex.Message}");
					}
					
				}
                    
			}

            return personID;
        }

        public static bool UpdatePerson(int personID, string nationalNo, string firstName
            , string secondName, string thirdName, string lastName,
             DateTime DateOfBirth, short gender, string address, string phone, string email,
             int nationalityCountryID, string imagePath)
        {
            int rowsAffected = 0;
			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{
				using (SqlCommand command = new SqlCommand("SP_UpdatePerson", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue("@PersonId", personID);
					command.Parameters.AddWithValue("@NationalNo", nationalNo);
					command.Parameters.AddWithValue("@FirstName", firstName);
					command.Parameters.AddWithValue("@SecondName", secondName);
					command.Parameters.AddWithValue("@LastName", lastName);
					command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
					command.Parameters.AddWithValue("@Gender", gender);
					command.Parameters.AddWithValue("@Address", address);
					command.Parameters.AddWithValue("@phone", phone);
					command.Parameters.AddWithValue("@CountryId", nationalityCountryID);

					if (!string.IsNullOrEmpty(thirdName))
						command.Parameters.AddWithValue("@ThirdName", thirdName);

					if (!string.IsNullOrEmpty(email))
						command.Parameters.AddWithValue("@Email", email);

					if (!string.IsNullOrEmpty(imagePath))
						command.Parameters.AddWithValue("@ImagePath", imagePath);


					try
					{
						connection.Open();
					    rowsAffected = (int)command.ExecuteScalar();
					}
					catch (Exception ex)
					{

						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"PersonData Error: {ex.Message}");
					}

				}
			}
            return rowsAffected > 0;
		}

        public static DataTable GetAllPeople()
        {
            DataTable table = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                
                using (SqlCommand command = new SqlCommand("SP_GetAllPeople", connection))
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
                        eventLogger.Log($"PersonData Error: {ex.Message}");
                    }
                    
                }
            }
            return table;

        }

        public static bool DeletePerson(int personID)
        {
			int rowsAffected = 0;
			using (var connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{
				using (var command = new SqlCommand("SP_DeletePerson", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@PersonId", personID);

                    try
                    {
						connection.Open();

						rowsAffected = (int)command.ExecuteScalar();						
					}
                    catch (Exception ex)
                    {
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"PersonData Error: {ex.Message}");
					}
				}

			}
            return rowsAffected > 0;
		}

		public static bool IsPersonExist(int personID)
        {
            bool isExist = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_IsPersonExistsById", connection))
                {
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@PersonId", personID);

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
						eventLogger.Log($"PersonData Error: {ex.Message}");
					}
				}
			}
            return isExist;
        }

        public static bool IsPersonExist(string nationalNo)
        {
			bool isExist = false;
			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{
				using (SqlCommand command = new SqlCommand("SP_IsPersonExistsByNationalNo", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@NationalNo", nationalNo);

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
						eventLogger.Log($"PersonData Error: {ex.Message}");
					}
				}
			}
			return isExist;
		}
    }

}

