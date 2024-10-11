using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsTestTypesData
    {
        public static bool GetTestTypeByID(int testTypeID,ref string testTypeTitle,ref string testTypeDescription,ref float testTypeFees)
        {
			bool isFound = false;
			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{
				using (SqlCommand command = new SqlCommand("SP_GetTestType", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@TestTypeID", testTypeID);

					try
					{
						connection.Open();

						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
								testTypeTitle = (string)reader["TestTypeTitle"];
								testTypeDescription = (string)reader["TestTypeDescription"];
								testTypeFees = Convert.ToSingle(reader["TestTypeFees"]);
								isFound = true;
							}

						}

					}
					catch (Exception ex)
					{
						isFound = false;
						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"TestTypeData Error: {ex.Message}");
					}

				}
			}

			return isFound;
		}

        public static int AddNewTestType(string testTypeTitle,string testTypeDescription , float testTypeFees)
        {
			int Id = -1;
			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{
				using (SqlCommand command = new SqlCommand("SP_AddNewTestType", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue("@Title", testTypeTitle);
					command.Parameters.AddWithValue("@Description", testTypeDescription);

					command.Parameters.AddWithValue("@Fees", testTypeFees);

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
						eventLogger.Log($"TestTypeData Error: {ex.Message}");
					}
				}
			}
			return Id;
		}

        public static bool UpdateTestType(int testTypeID,string testTypeTitle, string testTypeDescription, float testTypeFees)
        {
			int rowsAffected = 0;
			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{
				using (SqlCommand command = new SqlCommand("SP_UpdateTestType", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue("@Id", testTypeID);
					command.Parameters.AddWithValue("@Description", testTypeDescription);
					command.Parameters.AddWithValue("@Title", testTypeTitle);
					command.Parameters.AddWithValue("@Fees", testTypeFees);

					try
					{
						connection.Open();
						rowsAffected = (int)command.ExecuteScalar();

					}
					catch (Exception ex)
					{

						Logger eventLogger = new Logger(LoggingMethods.EventLogger);
						eventLogger.Log($"TestTypeData Error: {ex.Message}");
					}

				}

			}
			return rowsAffected > 0;
		}

        public static DataTable GetAllTestTypes()
        {
			DataTable table = new DataTable();

			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{

				using (SqlCommand command = new SqlCommand("SP_GetAllTestTypes", connection))
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
						eventLogger.Log($"TestTypesData Error: {ex.Message}");
					}

				}
			}
			return table;

		}


    }
}
