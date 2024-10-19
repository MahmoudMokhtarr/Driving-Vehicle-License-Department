using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using DVLD_Data_Access_Layer;

namespace DVLD_Data_Access_Layer
{
    public class clsUsers
    {

        private static string _GetQueryActivityModeInTableUsers(string Value)
        {
            string Query = "";

            if (Value == "Yes")
            {
                Query = "select * from Users where IsActive = 'true'";
            }

            else if (Value == "No")
            {
                Query = "select * from Users where IsActive = 'false'";
            }
            else
            {
                Query = "select * from Users";
            }

            return Query;
        }
        private static string _GetEndQuery(string FilterBy, string Word)
        {
            string Query = "";

            if (FilterBy == "PersonID")
            {
                Query = "select * from Users Where PersonID = @Word";
                return Query;
            }

            else if (FilterBy == "UserID")
            {
                Query = "select * from Users Where UserID = @Word";
                return Query;

            }

            else if (FilterBy == "UserName")
            {
                Query = "select * from Users Where UserName = @Word";
                return Query;

            }

            else if (FilterBy == "FullName")
            {
                Query = "select * from Users Where FullName = @Word";
                return Query;

            }

            else
            {
                Query = "select * from Users Where Email = @IsActive";
                return Query;

            }

        }

        public static int AddNewUser(int PersonID, string UserName, string Password, bool IsActive)
        {
            int UserID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Users (PersonID,UserName,Password,IsActive)
            VALUES (@PersonID,@UserName,@Password,@IsActive);
            SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                Connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    UserID = insertedID;
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                Connection.Close();
            }

            return UserID;

        }

        public static DataTable ListUsers()
        {
            DataTable DtTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from Users";
            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {

                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    DtTable.Load(Reader);
                }

                Reader.Close();

            }
            catch (Exception ex)
            {
            }
            finally
            {
                Connection.Close();
            }

            return DtTable;

        }

        public static bool DeleteUser(int UserID)
        {
            int ReowsAfected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "delete Users where UserID = @UserID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                Connection.Open();
                ReowsAfected = Command.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                Connection.Close();
            }

            return (ReowsAfected > 0);
        }

        public static bool UpdateUser( int UserID, int  PersonID,  string UserName,  string Password, bool IsActive)
        {

            int RowsAfected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"update Users set
            PersonID= @PersonID,
            UserName = @UserName,
            Password = @Password,
            IsActive = @IsActive
            where UserID= @UserID";        
            SqlCommand Command = new SqlCommand(Query, Connection);


            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@IsActive", IsActive);


            try
            {
                Connection.Open();
                RowsAfected = Command.ExecuteNonQuery();
            }

            catch
            {
                return false; 
            }

            finally

            {
                Connection.Close(); 
            } 

            return (RowsAfected > 0);
        }

        public static bool Find(int UserID,ref int PersonID, ref string UserName, ref string Password, ref bool IsActive)
        {
                bool IsFound = false;

                SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
                string Query = "select * from Users where UserID = @UserID";
                SqlCommand Command = new SqlCommand(Query, Connection);

                Command.Parameters.AddWithValue("@UserID", UserID);

            try
            {

            Connection.Open();
            SqlDataReader Reader = Command.ExecuteReader();

            if (Reader.Read())
                {

                    IsFound = true;

                    UserID = (int)Reader["UserID"];
                    PersonID = (int)Reader["PersonID"];
                    UserName = (string)Reader["UserName"];
                    Password = (string)Reader["Password"];
                    IsActive = (bool)Reader["IsActive"];
                }

            else
                {
                    IsFound = false;
                }

             Reader.Close();
                
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsFound;
            
        }

        public static bool CheckIsUserExistsForPerson (int PersonID)
        {
            int Personid = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select PersonID from Users where PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null)
                {
                    Personid = (int)Result;
                }
               

            }
            catch
            {
                return false;            }

            finally
            {
                Connection.Close(); 
            }

            return (Personid > 0);
        }

        public static string GetFullNameUser(int PersonID)
        {
            string FullName = "";

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select CONCAT (FirstName,' ',SecondName,' ',ThirdName,' ',LastName) AS FullName from People where PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null)
                {
                    FullName = (string)Result;
                }


            }
            catch
            {
                return null;
            }

            finally
            {
                Connection.Close();
            }

            return FullName;
        }

        public static DataTable SearchByWord(string FilterBy, string Word)
        {
            DataTable Dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = _GetEndQuery(FilterBy, Word);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Word", Word);

            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                {
                    Dt.Load(Reader);
                }
                Reader.Close();
            }


            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return Dt;
        }

        public static DataTable GetAListUsersWhereActivityStatus(string Value)
        {
            DataTable Dt = new DataTable();


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = _GetQueryActivityModeInTableUsers(Value);
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                {
                    Dt.Load(Reader);
                }
                Reader.Close();
            }


            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return Dt;


        }

        public static bool UpdatePasswordUser(int UserID,int NewPassword)
        {

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "update Users set Password = @NewPassword Where @UserID = UserID";
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@NewPassword", NewPassword);
            Command.Parameters.AddWithValue("@UserID", UserID);

            int RowsAfected = 0;

            try
            {
                Connection.Open();
                RowsAfected = Command.ExecuteNonQuery();
            }

            catch
            {
                return false;
            }

            finally

            {
                Connection.Close();
            }

            return (RowsAfected > 0);


        }

        public static string GetPasswordUserByUserID(int UserID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select Password from Users where @UserID = UserID";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);

            string Password = "";

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null)
                {
                    Password = Result.ToString();
                }


            }
            catch
            {
            }

            finally
            {
                Connection.Close();
            }

            return Password;
        }

        public static int GetPersonIDUserByUserID(int UserID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select PersonID from Users where @UserID = UserID";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);

            int PersonID = 0; 

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null)
                {
                    PersonID = (int) Result;
                }


            }
            catch
            {
            }

            finally
            {
                Connection.Close();
            }

            return PersonID;
        }

        public static int GetUserIDByUserName(string UserName)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select UserID from Users where @UserName = UserName";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);

            int UserID = 0;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null)
                {
                    UserID = (int)Result;
                }


            }
            catch
            {
            }

            finally
            {
                Connection.Close();
            }

            return UserID;
        }


    }
}
