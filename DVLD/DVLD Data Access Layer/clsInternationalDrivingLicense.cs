using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Data_Access_Layer
{
    public class clsInternationalDrivingLicense
    {
        public static int AddNewLicense(int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate,
        DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            int InternationalLicenseID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "INSERT INTO InternationalLicenses " +
            "(ApplicationID,DriverID,IssuedUsingLocalLicenseID,IssueDate,ExpirationDate,IsActive,CreatedByUserID) " +
            "VALUES (@ApplicationID,@DriverID,@IssuedUsingLocalLicenseID,@IssueDate,@ExpirationDate,@IsActive,@CreatedByUserID) " +
            "SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(Query, Connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                Connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    InternationalLicenseID = insertedID;
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                Connection.Close();
            }

            return InternationalLicenseID;

        }
        public static DataTable GetInfoLicenseByPersonID(int PersonID)
        {
            DataTable DT = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "select InternationalLicenseID,ApplicationID,InternationalLicenses.DriverID, " +
            "IssuedUsingLocalLicenseID,IssueDate,ExpirationDate,IsActive from InternationalLicenses " +
            "join Drivers on InternationalLicenses.DriverID = Drivers.DriverID " +
            "where InternationalLicenses.DriverID = (select Drivers.DriverID WHERE Drivers.PersonID = @PersonID)";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {

                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

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
                Connection.Close();
            }
            return DT;
        }
        public static bool IsDriverHasInternationalLicense(int DriverID)
        {

            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from InternationalLicenses where DriverID = @DriverID";
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                Connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null) 
                {
                    IsFound = true;
                }
            }
            catch
            {
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsFound;

        }
        public static bool Find(int InternationalLicenseID, ref int ApplicationID, ref int DriverID, ref int IssuedUsingLocalLicenseID,
        ref DateTime IssueDate, ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)

        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from InternationalLicenses where InternationalLicenseID = @InternationalLicenseID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);


            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    ApplicationID = (int)Reader["ApplicationID"];
                    DriverID = (int)Reader["DriverID"];
                    IssuedUsingLocalLicenseID = (int)Reader["IssuedUsingLocalLicenseID"];
                    IssueDate = (DateTime)Reader["IssueDate"];
                    ExpirationDate = (DateTime)Reader["ExpirationDate"];
                    IsActive = (bool)Reader["IsActive"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];

                }


            }

            catch
            {
                IsFound = false;

            }
            finally
            {
                Connection.Close();

            }

            return IsFound;
        }
        public static DataTable ListInternationalLicense()
        {
            DataTable DtTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "select * from InternationalLicenses";

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
    }
}
