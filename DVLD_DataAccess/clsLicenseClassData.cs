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
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * From LicenseClasses WHERE LicenseClassID=@LicenseClassID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseClassID", licenseClassID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound=true;
                    className = reader["ClassName"].ToString();
                    classDescription = reader["ClassDescription"].ToString();
                    minAllowedAge = Convert.ToInt16(reader["MinimumAllowedAge"]);
                    defaultValidityLength = Convert.ToInt16(reader["DefaultValidityLength"]);
                    classFees = Convert.ToSingle(reader["ClassFees"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Logger eventLogger = new Logger(LoggingMethods.EventLogger);
                eventLogger.Log($"LicenseClassData Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }

		public static bool GetLicenseClassByName(string className, ref int licenseClassID, ref string classDescription,
	ref short minAllowedAge, ref short defaultValidityLength, ref float classFees)
		{
			bool isFound = false;
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = "SELECT * From LicenseClasses WHERE ClassName=@ClassName;";

			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@ClassName", className);

			try
			{
				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				if (reader.Read())
				{
					isFound = true;
					licenseClassID =(int)reader["LicenseClassID"];
					classDescription = reader["ClassDescription"].ToString();
					minAllowedAge = Convert.ToInt16(reader["MinimumAllowedAge"]);
					defaultValidityLength = Convert.ToInt16(reader["DefaultValidityLength"]);
					classFees = Convert.ToSingle(reader["ClassFees"]);
				}
				reader.Close();
			}
			catch (Exception ex)
			{
				Logger eventLogger = new Logger(LoggingMethods.EventLogger);
				eventLogger.Log($"LicenseClassData Error: {ex.Message}");
			}
			finally
			{
				connection.Close();
			}
			return isFound;
		}



		public static int AddNewLicenseClass( string className,  string classDescription,
             short minAllowedAge,  short defaultValidityLength,  float classFees)
        {
            int licenseClassID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "INSERT INTO LicenseClasses (ClassName,ClassDescription,MinimumAllowdAge," +
                "DefaultValidityLength,ClassFees) " +
                "Values(@ClassName,@ClassDescription,@MinAge,@ValidityLength,@ClassFees); " +
                "SELECT SCOPE_IDENTITY(); ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClassName", className);
            command.Parameters.AddWithValue("@ClassDescription", classDescription) ;
            command.Parameters.AddWithValue("@MinAge", minAllowedAge);
            command.Parameters.AddWithValue("@ValidityLength", defaultValidityLength);
            command.Parameters.AddWithValue("@ClassFees", classFees);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString(),out licenseClassID))
                {

                }
            }
            catch (Exception ex)
            {
                Logger eventLogger = new Logger(LoggingMethods.EventLogger);
                eventLogger.Log($"LicenseClassData Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return licenseClassID;
        }

        public static bool UpdateLicenseClass(int licenseClassID,string className, string classDescription,
            short minAllowedAge, short defaultValidityLength, float classFees)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Update LicenseClasses " +
                "SET ClassName=@ClassName, ClassDescription=@ClassDescription,MinimumAllowedAge=@MinAge," +
                "DefaultValidityLength=@ValidityLength, ClassFees=@ClassFees " +
                " Where LicenseClassID=@LicenseClassID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseClassID", licenseClassID);
            command.Parameters.AddWithValue("@ClassName", className);
            command.Parameters.AddWithValue("@ClassDescription", classDescription);
            command.Parameters.AddWithValue("@MinAge", minAllowedAge);
            command.Parameters.AddWithValue("@ValidityLength", defaultValidityLength);
            command.Parameters.AddWithValue("@ClassFees", classFees);


            try
            {
                connection.Open();
                rowsAffected =command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Logger eventLogger = new Logger(LoggingMethods.EventLogger);
                eventLogger.Log($"LicenseClassData Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return rowsAffected>0;
        }

        public static bool DeleteLicenseClass(int licenseClassID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE From LicenseClasses WHERE LicenseClassID=@LicenseClassID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseClassID", licenseClassID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                rowsAffected = 0;
                Logger eventLogger = new Logger(LoggingMethods.EventLogger);
                eventLogger.Log($"LicenseClassData Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return rowsAffected > 0;
        }

        public static DataTable GetAllLicenseClasses()
        {
            DataTable table = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * From LicenseClasses;";

            SqlCommand command = new SqlCommand(query, connection);
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
                eventLogger.Log($"LicenseClassData Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return table;

        }

        public static bool IsLicenseClassExist(int licenseClassID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT TOP(1) Found=1 From LicenseClasses WHERE LicenseClassID=@LicenseClassID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseClassID", licenseClassID);

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
                eventLogger.Log($"LicenseClassData Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return isExist;
        }


    }
}
