using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;
using System.Security.Policy;

namespace DVLD_Data_Access_Layer
{
    public class clsLocalDrivingLicenseApplications
    {
        // CURD

        private static string _GetEndQuery(string FilterBy, string Word)
        {
            string Query = "";

            if (FilterBy == "L.D.L.AppID")
            {
                Query = "select * from LocalDrivingLicenseApplications_View where LocalDrivingLicenseApplicationID = @Word";
                return Query;
            }

            else if (FilterBy == "NationalNo")
            {
                Query = "select * from LocalDrivingLicenseApplications_View Where NationalNo = @Word";
                return Query;
            }

            else if (FilterBy == "FullName")
            {
                Query = "select * from LocalDrivingLicenseApplications_View Where FullName = @Word";
                return Query;
            }

            else if (FilterBy == "Status")
            {
                Query = "select * from LocalDrivingLicenseApplications_View Where Status = @Word";
                return Query;
            }

            return Query;

        }

        public static int AddNewLocalDrivingLicenseApplication(int ApplicationID, int LicenseClassID)
        {

            int LocalDrivingLicenseApplicationID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO LocalDrivingLicenseApplications (ApplicationID,LicenseClassID)
            VALUES (@ApplicationID,@LicenseClassID)
               SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(Query, Connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                Connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LocalDrivingLicenseApplicationID = insertedID;
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                Connection.Close();
            }


            return LocalDrivingLicenseApplicationID;

        }
        public static bool UpdateLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {
            int RowsAfected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"update LocalDrivingLicenseApplications set
            ApplicationID = @ApplicationID,
            LicenseClassID = @LicenseClassID
            where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

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
        public static DataTable ListLocalDrivingLicenseApplication()
        {
            DataTable DtTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "select * from LocalDrivingLicenseApplications";

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
        public static bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            int ReowsAfected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "delete LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

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
        public static int IsLicenseClassDuplicatedForPerson(int PersonID, int LicenseClassID)
        {
            int ApplicationIDClass = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = " SELECT DISTINCT Applications.ApplicationID FROM Applications INNER JOIN LocalDrivingLicenseApplications on" +
            " Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID" +
            " where ApplicantPersonID = @PersonID and ApplicationTypeID = 1 " +
            "and LicenseClassID = @LicenseClassID and  ApplicationStatus IN (1,3)";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                Connection.Open();

                object result = Command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int ApplicationID))
                {
                    ApplicationIDClass = ApplicationID;
                }
            }
            catch
            {

            }
            finally
            {
                Connection.Close();
            }


            return ApplicationIDClass;



        }
        public static DataTable LocalDrivingLicenseApplications_View()
        {
            DataTable DtTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "select * from LocalDrivingLicenseApplications_View";

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
        public static bool Find(ref int LocalDrivingLicenseApplicationID, ref int LicenseClassID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {

                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    IsFound = true;
                    LocalDrivingLicenseApplicationID = (int)Reader["LocalDrivingLicenseApplicationID"];
                    LicenseClassID = (int)Reader["LicenseClassID"];

                }

                Reader.Close();

            } catch (Exception ex)

            {

            }
            finally
            {
                Connection.Close();
            }

            return IsFound;
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

        public static int GetPersonIDByLocalDrivingLicenseID(int LocalDrivingLicenseApplicationID)
        {
            int PersonID = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select ApplicantPersonID FROM Applications WHERE ApplicationID = (select ApplicationID from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID)";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                Connection.Open();

                object result = Command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int PersonIDInserted))
                {
                    PersonID = PersonIDInserted;
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

    }

}
