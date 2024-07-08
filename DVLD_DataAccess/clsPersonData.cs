using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsPersonData
    {
        public static bool GetPersonById(int personID,ref string nationalNo , ref string firstName
            ,ref string secondName ,ref string thirdName ,ref string lastName,
            ref DateTime DateOfBirth ,ref char gender , ref string address, ref string phone ,ref string email,
            ref int nationalityCountryID ,ref string imagePath)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * From People WHERE PersonID=@PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", personID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    nationalNo = reader["NationalNo"].ToString();
                    firstName = reader["FirstName"].ToString();
                    secondName = reader["SecondName"].ToString() ;
                    thirdName = (reader["ThirdName"] == DBNull.Value)? "":reader["ThirdName"].ToString();
                    lastName = reader["LastName"].ToString();
                    DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                    gender = (Convert.ToInt32(reader["Gendor"]) == 0) ? 'M' : 'F';
                    address = reader["Address"].ToString();
                    phone = reader["Phone"].ToString();
                    email = (reader["Email"] == DBNull.Value) ? "" : reader["Email"].ToString();
                    nationalityCountryID = Convert.ToInt32(reader["NationalityCountryID"]);
                    imagePath = (reader["ImagePath"] == DBNull.Value) ? "" : reader["ImagePath"].ToString();
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool GetPersonByNationalNo(string nationalNo, ref int personID, ref string firstName
                    , ref string secondName, ref string thirdName, ref string lastName,
                    ref DateTime DateOfBirth, ref char gender, ref string address, ref string phone, ref string email,
                    ref int nationalityCountryID, ref string imagePath)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * From People WHERE NationalNo=@NationalNo";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", nationalNo);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    personID = Convert.ToInt32(reader["PersonID"]);
                    firstName = reader["FirstName"].ToString();
                    secondName = reader["SecondName"].ToString();
                    thirdName = (reader["ThirdName"] == DBNull.Value) ? "" : reader["ThirdName"].ToString();
                    lastName = reader["LastName"].ToString();
                    DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                    gender = (Convert.ToInt32(reader["Gendor"]) == 0) ? 'M' : 'F';
                    address = reader["Address"].ToString();
                    phone = reader["Phone"].ToString();
                    email = (reader["Email"] == DBNull.Value) ? "" : reader["Email"].ToString();
                    nationalityCountryID = Convert.ToInt32(reader["NationalityCountryID"]);
                    imagePath = (reader["ImagePath"] == DBNull.Value) ? "" : reader["ImagePath"].ToString();
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }


        public static int AddNewPerson(string nationalNo, string firstName
            ,  string secondName,  string thirdName,  string lastName,
             DateTime DateOfBirth,  char gender,  string address,  string phone, string email,
             int nationalityCountryID,  string imagePath)
        {
            int personID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "INSERT INTO People(NationalNo,FirstName,SecondName,ThirdName,LastName,DateOfBirth," +
                "Gendor,Address,Phone,Email,NationalityCountryID,ImagePath) " +
                "VALUES(@NationalNo,@FirstName,@SecondName,@ThirdName,@LastName,@DateOfBirth,@Gender,@Address," +
                "@Phone,@Email,@NationalityCountryID,@ImagePath ); " +
                "SELECT SCOPE_IDENTITY(); ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", nationalNo);
            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@SecondName", secondName);
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gender", gender);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@NationalityCountryID", nationalityCountryID);
            
            if (string.IsNullOrEmpty(thirdName))
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);
            else
                command.Parameters.AddWithValue("@ThirdName", thirdName);

            if (string.IsNullOrEmpty(email))
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);
            else
                command.Parameters.AddWithValue("@Email", email);

            if (string.IsNullOrEmpty(imagePath))
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            else
                command.Parameters.AddWithValue("@ImagePath", imagePath);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if(result != null && int.TryParse(result.ToString() , out personID))
                {

                }

            }
            catch (Exception ex)
            {
                personID = -1;
            }
            finally
            {
                connection.Close();
            }

            return personID;
        }

        public static bool UpdatePerson(int personID, string nationalNo, string firstName
            , string secondName, string thirdName, string lastName,
             DateTime DateOfBirth, char gender, string address, string phone, string email,
             int nationalityCountryID, string imagePath)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Update People " +
                "SET NationalNo=@NationalNo, FirstName=@FirstName, SecondName=@SecondName, ThirdName=@ThirdName," +
                "LastName=@LastName, DateOfBirth=@DateOfBirth, Gendor=@Gender, Address=@Address," +
                "Phone=@Phone, Email=@Email, NationalityCountryID=@NationalityCountryID, ImagePath=@ImagePath " +
                "WHERE PersonID=@PersonID; ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", personID);
            command.Parameters.AddWithValue("@NationalNo", nationalNo);
            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@SecondName", secondName);
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gender", gender);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@NationalityCountryID", nationalityCountryID);

            if (string.IsNullOrEmpty(thirdName))
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);
            else
                command.Parameters.AddWithValue("@ThirdName", thirdName);

            if (string.IsNullOrEmpty(email))
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);
            else
                command.Parameters.AddWithValue("@Email", email);

            if (string.IsNullOrEmpty(imagePath))
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            else
                command.Parameters.AddWithValue("@ImagePath", imagePath);

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

        public static DataTable GetAllPeople()
        {
            DataTable table = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * From People";

            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    table.Load(reader);
                reader.Close();
                
            }
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return table;

        }

        public static bool DeletePerson(int personID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE From People WHERE PersonID=@PersonID;";
            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@PersonID", personID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch( Exception ex)
            {
                rowsAffected = 0;
            }
            finally
            {
                connection.Close();
            }

            return rowsAffected > 0;
        }

        public static bool IsPersonExist(int personID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT TOP(1) Found=1 From People WHERE PersonID=@PersonID";
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
            }
            finally
            {
                connection.Close();
            }

            return isExist;
        }

        public static bool IsPersonExist(string nationalNo)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT TOP(1) Found=1 From People WHERE NationalNo=@NationalNo";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", nationalNo);

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
            }
            finally
            {
                connection.Close();
            }

            return isExist;
        }

    }

}

