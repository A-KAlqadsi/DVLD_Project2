using System;
using System.Data;
using System.Data.SqlClient;


namespace DVLD_DataAccess
{
    public class clsApplicationTypesData
    {
        public static bool GetApplicationTypeByID(int appTypeID ,ref string appTypeTitle,ref float appFees)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * From ApplicationTypes WHERE ApplicationTypeID=@ApplicationTypeID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationTypeID", appTypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    isFound = true;
                    appTypeTitle = reader["ApplicationTypeTitle"].ToString();
                    appFees = Convert.ToSingle(reader["ApplicationFees"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Logger eventLogger = new Logger(LoggingMethods.EventLogger);
                eventLogger.Log($"ApplicationTypeData Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static int AddNewApplicationType(string appTypeTitle, float appFees)
        {
            int appTypeID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "INSERT INTO ApplicationTypes(ApplicationTypeTitle,ApplicationFees) " +
                "Values (@AppTypeTitle,@AppFees); " +
                "SELECT SCOPE_IDENTITY(); ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AppTypeTitle", appTypeTitle);
            command.Parameters.AddWithValue("@AppFees", appFees);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString(),out appTypeID))
                {

                }
            }
            catch (Exception ex)
            {
                Logger eventLogger = new Logger(LoggingMethods.EventLogger);
                eventLogger.Log($"ApplicationTypeData Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return appTypeID;
        }

        public static bool UpdateApplicationType(int appTypeID,string appTypeTitle, float appFees)
        {
           int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Update ApplicationTypes " +
                "SET ApplicationTypeTitle=@AppTypeTitle, ApplicationFees=@AppFees " +
                "WHERE ApplicationTypeID=@AppTypeID; ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AppTypeID", appTypeID);
            command.Parameters.AddWithValue("@AppTypeTitle", appTypeTitle);
            command.Parameters.AddWithValue("@AppFees", appFees);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Logger eventLogger = new Logger(LoggingMethods.EventLogger);
                eventLogger.Log($"ApplicationTypeData Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return rowsAffected>0;
        }

        public static bool DeleteApplicationType(int appTypeID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE From ApplicationTypes WHERE ApplicationTypeID=@AppTypeID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AppTypeID", appTypeID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                rowsAffected = 0;
                Logger eventLogger = new Logger(LoggingMethods.EventLogger);
                eventLogger.Log($"ApplicationTypeData Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return rowsAffected > 0;
        }

        public static DataTable GetAllApplicationTypes()
        {
            DataTable table = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * From ApplicationTypes;";

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
                eventLogger.Log($"ApplicationTypeData Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return table;

        }

        public static bool IsApplicationTypeExist(int appTypeID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT TOP(1) Found=1 From ApplicationTypes WHERE ApplicationTypeID=@AppTypeID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AppTypeID", appTypeID);

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
                eventLogger.Log($"ApplicationTypeData Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return isExist;
        }

    }
}
