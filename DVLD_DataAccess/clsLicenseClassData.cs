using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsLicenseClassData
    {
        public static bool GetLicenseClassByID(int licenseClassID,ref string className,ref string classDescription,
            ref short minAllowedAge,ref short defaultValidityLength,ref float classFees)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetLicenseClassById", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@LicenseClassID", licenseClassID);

					try
					{
						connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
							if (reader.Read())
							{
								isFound = true;
								className = reader["ClassName"].ToString();
								classDescription = reader["ClassDescription"].ToString();
								minAllowedAge = Convert.ToInt16(reader["MinimumAllowedAge"]);
								defaultValidityLength = Convert.ToInt16(reader["DefaultValidityLength"]);
								classFees = Convert.ToSingle(reader["ClassFees"]);
							}
						}
                            
					}
					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"LicenseClassData Error: {ex.Message}");
					}
				}
			}
            
            return isFound;
        }

		public static bool GetLicenseClassByName(string className, ref int licenseClassID, ref string classDescription,
	    ref short minAllowedAge, ref short defaultValidityLength, ref float classFees)
		{
			bool isFound = false;
			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{
				using (SqlCommand command = new SqlCommand("SP_GetLicenseClassByName", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@ClassName", className);

					try
					{
						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
								isFound = true;
								licenseClassID = (int)reader["LicenseClassId"];
								classDescription = reader["ClassDescription"].ToString();
								minAllowedAge = Convert.ToInt16(reader["MinimumAllowedAge"]);
								defaultValidityLength = Convert.ToInt16(reader["DefaultValidityLength"]);
								classFees = Convert.ToSingle(reader["ClassFees"]);
							}
						}

					}
					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"LicenseClassData Error: {ex.Message}");
					}
				}
			}

			return isFound;
		}

		public static int AddNewLicenseClass( string className,  string classDescription,
             short minAllowedAge,  short defaultValidityLength,  float classFees)
        {
            int licenseClassID = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_AddNewLicenseClass", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@ClassName", className);
					command.Parameters.AddWithValue("@ClassDescription", classDescription);
					command.Parameters.AddWithValue("@MinAge", minAllowedAge);
					command.Parameters.AddWithValue("@ValidityLength", defaultValidityLength);
					command.Parameters.AddWithValue("@ClassFees", classFees);

                    var outputParamId = new SqlParameter("@NewLicenseClassId", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputParamId);

					try
					{
						connection.Open();
                        command.ExecuteNonQuery();
                        licenseClassID = (int)outputParamId.Value;
					}
					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"LicenseClassData Error: {ex.Message}");
					}
					
				}
			}

            return licenseClassID;
        }

        public static bool UpdateLicenseClass(int licenseClassID,string className, string classDescription,
            short minAllowedAge, short defaultValidityLength, float classFees)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateLicenseClass", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@LicenseClassId", licenseClassID);
					command.Parameters.AddWithValue("@ClassName", className);
					command.Parameters.AddWithValue("@ClassDescription", classDescription);
					command.Parameters.AddWithValue("@MinAge", minAllowedAge);
					command.Parameters.AddWithValue("@ValidityLength", defaultValidityLength);
					command.Parameters.AddWithValue("@ClassFees", classFees);


					try
					{
						connection.Open();
						rowsAffected =(int) command.ExecuteScalar();
					}
					catch (Exception ex)
					{
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"LicenseClassData Error: {ex.Message}");
					}
				}
                 
			}

            return rowsAffected>0;
        }


		public static DataTable GetAllLicenseClasses()
		{
			DataTable table = new DataTable();

			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{

				using (SqlCommand command = new SqlCommand("SP_GetAllLicenseClasses", connection))
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
						eventLogger.Log($"LicenseClassData Error: {ex.Message}");
					}

				}
			}
			return table;

		}



    }
}
