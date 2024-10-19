using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Data_Access_Layer
{
    public class clsDriver
    {

        private static string _GetEndQuery(string FilterBy, string Word)
        {
            string Query = "";

            if (FilterBy == "PersonID")
            {
                Query = "select * from Drivers_View where PersonID LIKE  @Word";
                return Query;
            }

            else if (FilterBy == "DriverID")
            {
                Query = "select * from Drivers_View where DriverID  like  @Word";
                return Query;

            }

            else if (FilterBy == "FullName")
            {
                Query = "SELECT * FROM Drivers_View WHERE FullName LIKE @Word";
                return Query;

            }

            else 
            {
                Query = "select * from Drivers_View where NationalNo like @Word";
                return Query;

            }

        }

        public static int AddNewDriver(int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            int DriverID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"INSERT INTO Drivers (PersonID,CreatedByUserID,CreatedDate)
            VALUES (@PersonID,@CreatedByUserID,@CreatedDate)
            SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(Query, Connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);


            try
            {
                Connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    DriverID = insertedID;
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                Connection.Close();
            }

            return DriverID;
        }
        public static int GetDriverIDByPersonID(int PersonID)
        {
            int DriverID = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select DriverID from Drivers where PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();

                object result = Command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    DriverID = insertedID;
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                Connection.Close();
            }


            return DriverID;


        }

        public static int GetPersonIDByDriverID(int DriverID)
        {
            int PersonID = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select PersonID from Drivers where DriverID = @DriverID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@DriverID", DriverID);

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

        public static bool IsLocalDrivingLicenseForDriverActive(int PersonID)
        {
            bool IsActive = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "select IsActive from Licenses join Drivers on Licenses.DriverID = Drivers.DriverID " +
            "where Drivers.DriverID = (select Drivers.DriverID WHERE Drivers.PersonID = @PersonID)";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();

                object result = Command.ExecuteScalar();


                if (result != null)
                {
                    IsActive = true;
                }
            }

            catch (Exception ex)
            {
                IsActive = false;
            }

            finally
            {
                Connection.Close();
            }

            return IsActive;

        }
        public static DataTable ListDrivers()
        {
            DataTable DtTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT * from Drivers_View";
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
        public static DataTable SearchByWord(string FilterBy, string Word)
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = _GetEndQuery(FilterBy, Word);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Word",  Word + "%");

            try
            {

                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                {
                    DT.Load(Reader);
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

            return DT;


        }
        public static bool IsDriverExistByPersonID(int PersonID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select PersonID from Drivers where PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();

                object result = Command.ExecuteScalar();

                if (result != null)
                {
                    IsFound = true;
                }
            }

            catch (Exception ex)
            {
                return false;
            }

            finally
            {
                Connection.Close();
            }

            return IsFound;
        }

        public static bool Find(int PersonID, ref int DriverID, ref int CreatedByUserID,ref DateTime CreatedDate)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from Drivers where PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {

                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    IsFound = true;

                    DriverID = (int)Reader["DriverID"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    CreatedDate = (DateTime)Reader["CreatedDate"];
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

    }
}
