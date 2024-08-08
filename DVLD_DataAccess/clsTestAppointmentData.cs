using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsTestAppointmentData
    {
        public static bool GetTestAppointmentByID(int testAppointmentID, ref int testTypeID,
            ref int localDrivingLicenseAppID, ref DateTime appointmentDate, ref float paidFees,
            ref int createdByUserID, ref bool isLocked)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * From TestAppointments WHERE TestAppointmentID=@TestAppointmentID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    testTypeID = (int)reader["TestTypeID"];
                    localDrivingLicenseAppID = (int)reader["LocalDrivingLicenseApplicationID"];
                    appointmentDate = Convert.ToDateTime(reader["AppointmentDate"]);
                    paidFees = Convert.ToSingle(reader["PaidFees"]);
                    createdByUserID = (int)reader["CreatedByUserID"];
                    isLocked = Convert.ToBoolean(reader["IsLocked"]);
                }
                reader.Close();

            }
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }

        public static int AddNewTestAppointment( int testTypeID,
             int localDrivingLicenseAppID,  DateTime appointmentDate,  float paidFees,
             int createdByUserID,  bool isLocked)
        {
            int testAppointmentID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "INSERT INTO TestAppointments(TestTypeID,LocalDrivingLicenseApplicationID," +
                "AppointmentDate,PaidFees,CreatedByUserID,IsLocked) " +
                "Values (@TestTypeID,@localLicenseID,@AppointmentDate,@PaidFees,@UserID,@IsLocked); " +
                "SELECT SCOPE_IDENTITY(); ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", testTypeID);
            command.Parameters.AddWithValue("@localLicenseID", localDrivingLicenseAppID);
            command.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
            command.Parameters.AddWithValue("@PaidFees", paidFees);
            command.Parameters.AddWithValue("@UserID", createdByUserID);
            command.Parameters.AddWithValue("@IsLocked", isLocked);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(),out testAppointmentID))
                {

                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return testAppointmentID;
        }

        public static bool UpdateTestAppointment(int testAppointmentID,int testTypeID,
            int localDrivingLicenseAppID, DateTime appointmentDate, float paidFees,
            int createdByUserID, bool isLocked)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Update TestAppointments " +
                " SET TestTypeID=@TestTypeID,LocalDrivingLicenseApplicationID=@localLicenseID," +
                "AppointmentDate=@AppointmentDate,PaidFees=@PaidFees,CreatedByUserID=@UserID,IsLocked=@IsLocked " +
                " Where TestAppointmentID=@TestAppointmentID; ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);
            command.Parameters.AddWithValue("@TestTypeID", testTypeID);
            command.Parameters.AddWithValue("@localLicenseID", localDrivingLicenseAppID);
            command.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
            command.Parameters.AddWithValue("@PaidFees", paidFees);
            command.Parameters.AddWithValue("@UserID", createdByUserID);
            command.Parameters.AddWithValue("@IsLocked", isLocked);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return rowsAffected>0;
        }

        public static bool DeleteTestAppointment(int testAppointmentID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE From TestAppointments WHERE TestAppointmentID=@TestAppointmentID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                rowsAffected = 0;
            }
            finally
            {
                connection.Close();
            }

            return rowsAffected > 0;
        }

        public static DataTable GetAllTestAppointments()
        {
            DataTable table = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * From TestAppointments;";

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

            }
            finally
            {
                connection.Close();
            }
            return table;

        }

        public static DataTable GetestAppointmentsMasterByID(int testAppointmentID)
        {
            DataTable table = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * From TestAppointments_View Where TestAppointmentID=@TestAppointmentID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);

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

            }
            finally
            {
                connection.Close();
            }
            return table;

        }

        public static bool IsTestAppointmentExist(int testAppointmentID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT TOP(1) Found=1 From TestAppointments WHERE TestAppointmentID=@TestAppointmentID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int found))
                    isExist = true;

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return isExist;
        }

        public static bool IsPersonHasActiveTestAppointment(int localDrivingLicenseAppID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT TOP(1) Found=1 From TestAppointments WHERE LocalDrivingLicenseApplicationID=@LocalDrivingLicenseAppID And IsLocked=@IsLocked";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseAppID", localDrivingLicenseAppID);
            command.Parameters.AddWithValue("@IsLocked", false);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int found))
                    isExist = true;

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return isExist;
        }

        public static int IsTestAppointmentPassed(int testAppointmentID)
        {
            int testResult = 2;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT TestResult  From Tests WHERE TestAppointmentID=@TestAppointmentID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && bool.TryParse(result.ToString(), out bool findResult))
                {
                    testResult = findResult ? 1 : 0;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return testResult;
        }

    }
}
