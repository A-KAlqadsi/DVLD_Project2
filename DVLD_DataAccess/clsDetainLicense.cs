using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
	public class clsDetainLicense
	{
		public static bool GetDetainedLicenseInfoByID(int DetainID,
		ref int LicenseID, ref DateTime DetainDate,
		ref float FineFees, ref int CreatedByUserID,
		ref bool IsReleased, ref DateTime? ReleaseDate,
		ref int? ReleasedByUserID, ref int? ReleaseApplicationID)
		{
			bool isFound = false;

			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{

				using (SqlCommand command = new SqlCommand("SP_GetDetainedLicenseInfoByID", connection))
				{
					command.Parameters.AddWithValue("@DetainID", DetainID);
					command.CommandType = CommandType.StoredProcedure;

					try
					{
						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{

								// The record was found
								isFound = true;

								LicenseID = (int)reader["LicenseID"];
								DetainDate = (DateTime)reader["DetainDate"];
								FineFees = Convert.ToSingle(reader["FineFees"]);
								CreatedByUserID = (int)reader["CreatedByUserID"];

								IsReleased = (bool)reader["IsReleased"];

								if (reader["ReleaseDate"] == DBNull.Value)

									ReleaseDate = null;
								else
									ReleaseDate = (DateTime)reader["ReleaseDate"];


								if (reader["ReleasedByUserID"] == DBNull.Value)

									ReleasedByUserID = null;
								else
									ReleasedByUserID = (int)reader["ReleasedByUserID"];

								if (reader["ReleaseApplicationID"] == DBNull.Value)

									ReleaseApplicationID = null;
								else
									ReleaseApplicationID = (int)reader["ReleaseApplicationID"];

							}
							else
							{
								// The record was not found
								isFound = false;
							}

							reader.Close();

						}
					}
					catch (Exception ex)
					{
						isFound = false;
					}
				
				}

							
			}

			return isFound;
		}

		public static bool GetDetainedLicenseInfoByLicenseID(int LicenseID,
		   ref int DetainID, ref DateTime DetainDate,
		   ref float FineFees, ref int CreatedByUserID,
		   ref bool IsReleased, ref DateTime? ReleaseDate,
		   ref int? ReleasedByUserID, ref int? ReleaseApplicationID)
		{
			bool isFound = false;

			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{
				using (SqlCommand command = new SqlCommand("SP_GetDetainedLicenseInfoByLicenseID", connection))
				{
					command.Parameters.AddWithValue("@LicenseID", LicenseID);
					command.CommandType = CommandType.StoredProcedure;
					try
					{
						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{

								// The record was found
								isFound = true;

								DetainID = (int)reader["DetainID"];
								DetainDate = (DateTime)reader["DetainDate"];
								FineFees = Convert.ToSingle(reader["FineFees"]);
								CreatedByUserID = (int)reader["CreatedByUserID"];

								IsReleased = (bool)reader["IsReleased"];

								if (reader["ReleaseDate"] == DBNull.Value)

									ReleaseDate = null;
								else
									ReleaseDate = (DateTime)reader["ReleaseDate"];


								if (reader["ReleasedByUserID"] == DBNull.Value)

									ReleasedByUserID = null;
								else
									ReleasedByUserID = (int)reader["ReleasedByUserID"];

								if (reader["ReleaseApplicationID"] == DBNull.Value)

									ReleaseApplicationID = null;
								else
									ReleaseApplicationID = (int)reader["ReleaseApplicationID"];

							}
							else
							{
								// The record was not found
								isFound = false;
							}
						}
					}
					catch (Exception ex)
					{
						//Console.WriteLine("Error: " + ex.Message);
						isFound = false;
					}
					
				}

			}
			return isFound;
		}

		public static DataTable GetAllDetainedLicenses()
		{
			DataTable table = new DataTable();

			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{

				using (SqlCommand command = new SqlCommand("SP_GetAllDetainedLicenses", connection))
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
						eventLogger.Log($"LicenseData Error: {ex.Message}");
					}

				}
			}
			return table;

		}


		public static int AddNewDetainedLicense(
			int LicenseID, DateTime DetainDate,
			float FineFees, int CreatedByUserID)
		{
			int DetainID = -1;

			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{
				using (SqlCommand command = new SqlCommand("SP_AddNewDetainedLicense", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@LicenseID", LicenseID);
					command.Parameters.AddWithValue("@DetainDate", DetainDate);
					command.Parameters.AddWithValue("@FineFees", FineFees);
					command.Parameters.AddWithValue("@UserId", CreatedByUserID);

					var outputParamId = new SqlParameter("@NewDetainId", SqlDbType.Int)
					{
						Direction = ParameterDirection.Output
					};
					command.Parameters.Add(outputParamId);

					try
					{
						connection.Open();

						command.ExecuteNonQuery();
						DetainID = (int)outputParamId.Value;
					}

					catch (Exception ex)
					{

					}

				}
				
			}

			return DetainID;

		}

		public static bool UpdateDetainedLicense(int DetainID,
			int LicenseID, DateTime DetainDate,
			float FineFees, int CreatedByUserID)
		{

			int rowsAffected = 0;
			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{
				using (SqlCommand command = new SqlCommand("SP_UpdateDetainedLicense", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@DetainedLicenseID", DetainID);
					command.Parameters.AddWithValue("@LicenseID", LicenseID);
					command.Parameters.AddWithValue("@DetainDate", DetainDate);
					command.Parameters.AddWithValue("@FineFees", FineFees);
					command.Parameters.AddWithValue("@UserId", CreatedByUserID);


					try
					{
						connection.Open();
						rowsAffected =(int) command.ExecuteScalar();

					}
					catch (Exception ex)
					{
						//Console.WriteLine("Error: " + ex.Message);
						return false;
					}
				}
			}
			return (rowsAffected > 0);
		}


		public static bool ReleaseDetainedLicense(int DetainID,
				 int ReleasedByUserID, int ReleaseApplicationID)
		{

			int rowsAffected = 0;
			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{
				using (SqlCommand command = new SqlCommand("SP_ReleaseDetainedLicense", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@DetainID", DetainID);
					command.Parameters.AddWithValue("@ReleaseByUserId", ReleasedByUserID);
					command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
					try
					{
						connection.Open();
						rowsAffected = (int)  command.ExecuteScalar();

					}
					catch (Exception ex)
					{
						
						rowsAffected = 0;
					}
				}
			}
			
			return (rowsAffected > 0);
		}

		public static bool IsLicenseDetained(int LicenseID)
		{
			bool IsDetained = false;

			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
			{
				using (SqlCommand command = new SqlCommand("SP_IsLicenseDetained", connection))
				{
					command.Parameters.AddWithValue("@LicenseID", LicenseID);

					SqlParameter returnValue = new SqlParameter();
					returnValue.Direction = ParameterDirection.ReturnValue;
					command.Parameters.Add(returnValue);

					try
					{
						connection.Open();

						command.ExecuteNonQuery();
						IsDetained = (int)returnValue.Value > 0;
					}

					catch (Exception ex)
					{

					}
				}

			}
			return IsDetained;
			
		}
	}
}
