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
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * From Tests WHERE TestID=@TestID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestID", testID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound= true;
                    testAppointmentID = (int)reader["TestAppointmentID"];
                    testResult = Convert.ToBoolean(reader["TestResult"]);
                    notes = (reader["Notes"] != DBNull.Value) ? reader["Notes"].ToString() : "";
                    createdByUserID = (int)reader["CreatedByUserID"];
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

        public static int AddNewTest(int testAppointmentID,bool testResult,
             string notes,int createdByUserID)
        {
            int testID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "INSERT INTO Tests(TestAppointmentID,TestResult,Notes,CreatedByUserID) " +
                "Values(@TestAppointmentID,@TestResult,@Notes,@UserID); " +
                "SELECT SCOPE_IDENTITY(); ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);
            command.Parameters.AddWithValue("@TestResult", testResult);
            command.Parameters.AddWithValue("@UserID", createdByUserID);
            if(string.IsNullOrEmpty(notes))
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
            else
                command.Parameters.AddWithValue("@Notes", notes);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString(),out testID))
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

            return testID;
        }

        public static bool UpdateTest(int testID, int testAppointmentID, bool testResult,
            string notes, int createdByUserID)
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Update Tests " +
                "SET TestAppointmentID=@TestAppointmentID, TestResult=@TestResult, Notes=@Notes, CreatedByUserID=@UserID " +
                " Where TestID=@TestID";

            SqlCommand command = new SqlCommand(query, connection);
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
                rowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return rowAffected>0;
        }

        public static bool DeleteTest(int testID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE From Tests WHERE TestID=@TestID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestID", testID);

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

        public static DataTable GetAllTests()
        {
            DataTable table = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * From Tests;";

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

        public static bool IsTestExist(int testID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT TOP(1) Found=1 From Tests WHERE TestID=@TestID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestID", testID);

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

        public static int CountPassedTests(int localDrivingLicenseAppID)
        {
            int passedTests = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT COUNT(dbo.TestAppointments.TestTypeID) " +
                "FROM dbo.Tests INNER JOIN " +
                "dbo.TestAppointments ON (dbo.Tests.TestAppointmentID = dbo.TestAppointments.TestAppointmentID) " +
                "WHERE (dbo.TestAppointments.LocalDrivingLicenseApplicationID = @localDrivingLicenseAppID) AND (dbo.Tests.TestResult = 1);";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@localDrivingLicenseAppID", localDrivingLicenseAppID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int tests))
                    passedTests =tests;

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return passedTests;
        }

        public static bool IsTestPassed(int localDrivingLicenseAppID, int testTypeID, bool testResult = true)
        {
            bool isPassed = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT TOP(1) Found=1 " +
                "FROM dbo.Tests INNER JOIN " +
                "dbo.TestAppointments ON (dbo.Tests.TestAppointmentID = dbo.TestAppointments.TestAppointmentID) " +
                "WHERE (dbo.TestAppointments.LocalDrivingLicenseApplicationID = @localDrivingLicenseAppID) AND (dbo.Tests.TestResult = @Result) AND (dbo.TestAppointments.TestTypeID=@TestTypeID);";
            
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@localDrivingLicenseAppID", localDrivingLicenseAppID);
            command.Parameters.AddWithValue("@TestTypeID", testTypeID);
            command.Parameters.AddWithValue("@Result", testResult);
            
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int tests))
                    isPassed = true;

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return isPassed;
        }

        

    }
}
