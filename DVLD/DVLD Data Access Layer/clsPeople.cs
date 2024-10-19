using System;
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
    public class clsPeople
    {
        private static string _GetEndQuery(string FilterBy, string Word)
        {
            string Query = "";

            if (FilterBy== "PersonID")
            {
                Query = "select * from People Where PersonID = @Word";
                return Query;
            }

            else if (FilterBy== "NationalNo")
            {
                Query = "select * from People Where NationalNo = @Word";
                return Query;

            }

            else if (FilterBy == "FirstName")
            {
                Query = "select * from People Where FirstName = @Word";
                return Query;

            }

            else if (FilterBy == "SecondName")
            {
                Query = "select * from People Where SecondName = @Word";
                return Query;

            }

            else if (FilterBy == "ThirdName")
            {
                Query = "select * from People Where ThirdName = @Word";
                return Query;

            }

            else if (FilterBy == "LastName")
            {
                Query = "select * from People Where LastName = @Word";
                return Query;

            }

            else if (FilterBy == "Nationality")
            {
                Query = "select * from People Where Nationality = @Word";
                return Query;

            }

            else if (FilterBy == "Gendor")
            {
                Query = "select * from People Where Gendor = @Word";
                return Query;

            }

            else if (FilterBy == "Phone")
            {
                Query = "select * from People Where Phone = @Word";
                return Query;

            }

            else
            {
                Query = "select * from People Where Email = @Word";
                return Query;

            }

        }

        public static bool Find(int PersonID, ref string NationalNo, ref string FirstName,
        ref string SecondName, ref string ThirdName, ref string LastName, ref string Gendor, ref DateTime DateOfBirth,
        ref string Nationality, ref string Phone, ref string Email, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from People where PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {

                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)Reader["PersonID"];
                    NationalNo = (string)Reader["NationalNo"];
                    FirstName = (string)Reader["FirstName"];
                    SecondName = (string)Reader["SecondName"];
                    ThirdName = (string)Reader["ThirdName"];
                    LastName = (string)Reader["LastName"];
                    Gendor = (string)Reader["Gendor"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];
                    Nationality = (string)Reader["Address"];
                    Phone = (string)Reader["Phone"];
                    Email = (string)Reader["Email"];
                    if (Reader["ImagePath"]!=DBNull.Value)
                    {
                        ImagePath = (string)Reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }
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

        public static DataTable ReturnPersonsInfo()
        {
            DataTable Dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from People";
            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {

                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

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
                Connection.Close();
            }

            return Dt;

        }

        public static int AddNewPerson( string NationalNo,  string FirstName,
        string SecondName,  string ThirdName,  string LastName, string Gendor,  DateTime DateOfBirth,
        string Address,  string Phone,  string Email, string ImagePath)
        {
            int PersonId = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO People (NationalNo, FirstName,SecondName,ThirdName,LastName,Gendor,DateOfBirth,Address,Phone,Email,ImagePath)
            VALUES (@NationalNo,@FirstName,@SecondName,@ThirdName,@LastName,@Gendor,@DateOfBirth,@Address,@Phone,@Email,@ImagePath);
            SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);

           // command.Parameters.AddWithValue("@Address", Address);


            try
            {
                Connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PersonId = insertedID;
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                Connection.Close();
            }


            return PersonId;
        }

        public static DataTable ReturnAllCountries()
        {
            DataTable Dt = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from Countries";
            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {

                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

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
                Connection.Close();
            }
            return Dt;

        }

        public static bool CheckNationalNumberIsDuplicate(string NationalNumber)
        {
            bool IsDuplicate = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select NationalNo from People where NationalNo = @NationalNumber";
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@NationalNumber", NationalNumber);

            try
            {
                Connection.Open();

                object result = command.ExecuteScalar();

                if (result != null )
                {
                    IsDuplicate = true;
                }

            }

            catch (Exception ex)
            {

            }

            finally
            {
                Connection.Close();
            }


            return IsDuplicate;


        }

        public static DataTable SearchByWord(string FilterBy, string Word)
        {
            DataTable Dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = _GetEndQuery(FilterBy,Word);
            SqlCommand command = new SqlCommand(query, connection);

            //command.Parameters.AddWithValue("@FilterBy", FilterBy);
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

        public static String GetImagePathPerson(int PersonID)
        {
            string ImagePath = "";

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select ImagePath from People where PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null)
                {
                    ImagePath = Result.ToString();
                }

                else
                {
                    ImagePath = null;
                }

            }
            catch
            {

            }
            finally
            {
                Connection.Close ();
            }
            return ImagePath;

        }

        public static bool UpdatePerson(int PersonID, string NationalNo, string FirstName,
        string SecondName, string ThirdName, string LastName, string Gendor, DateTime DateOfBirth,
        string Address, string Phone, string Email, string ImagePath)

        {
            int RowsAfected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"update People set
            NationalNo= @NationalNo,
            FirstName = @FirstName,
            SecondName = @SecondName,
            ThirdName = @ThirdName,
            LastName = @LastName,
            Gendor = @Gendor,
            DateOfBirth = @DateOfBirth,
            Address = @Address,
            Phone = @Phone,
            Email = @Email,
            ImagePath = @ImagePath
            where PersonID= @PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@SecondName", SecondName);
            Command.Parameters.AddWithValue("@ThirdName", ThirdName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@Gendor", Gendor);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@ImagePath", ImagePath);
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

        public static bool DeletePerson(int PersonID)
        {
            int ReowsAfected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "delete People where PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open ();
                ReowsAfected = Command.ExecuteNonQuery();
            }
            catch 
            {

            }
            finally
            {
                Connection.Close (); 
            }

            return (ReowsAfected > 0);
        }
        public static int GetPersonIDByNationalNo(string NationalNo)
        {
            int PersonID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select PersonID from People where NationalNo = @NationalNo";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                Connection.Open();

                object result = Command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PersonID = insertedID;
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                Connection.Close();
            }


            return PersonID;


        }

        public static string GetNationalNoByPersonID(int PersonID)
        {
            string NationalNo = "";

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select NationalNo from People where PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();

                object result = Command.ExecuteScalar();


                if (result != null )
                {
                    NationalNo = result.ToString();
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                Connection.Close();
            }


            return NationalNo;


        }
        public static string GetGendorByPersonID(int PersonID)
        {
            string Gender = "";

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select Gendor from People where PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();

                object result = Command.ExecuteScalar();


                if (result != null)
                {
                    Gender = result.ToString();
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                Connection.Close();
            }


            return Gender;

        }
        public static string GetDateOfBirthByPersonID(int PersonID)
        {
            string DateOfBirth = "";

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select DateOfBirth from People where PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();

                object result = Command.ExecuteScalar();


                if (result != null)
                {
                     DateOfBirth = result.ToString();
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                Connection.Close();
            }
            return DateOfBirth;
        }
        public static string GetFullNameByPersonID(int PersonID)
        {
            string FullName = "";

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select People.FirstName + ' ' + People.SecondName + ' ' + ISNULL(People.ThirdName,'') + ' ' + People.LastName FROM People where PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {

                Connection.Open();
                object result = Command.ExecuteScalar();

                if (result != null) 
                {
                    FullName = result.ToString();
                }

            }
            catch
            {

            }
            finally
            {
                Connection.Close() ;
            }

            return FullName;
        }
    }

}

