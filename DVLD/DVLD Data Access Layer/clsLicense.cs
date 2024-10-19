using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;
using System.Net;

namespace DVLD_Data_Access_Layer
{
    public class clsLicense
    {
        public static int AddNewLicense(int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate,
        DateTime ExpirationDate, decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID, string Notes = null)
        {
            int LicenseID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "";

            if (Notes != null)
            {
                Query = @"INSERT INTO Licenses (ApplicationID,DriverID,LicenseClass,IssueDate,ExpirationDate,
            Notes,PaidFees,IsActive,IssueReason,CreatedByUserID)
            VALUES (@ApplicationID,@DriverID,@LicenseClass,@IssueDate,@ExpirationDate,
            @Notes,@PaidFees,@IsActive,@IssueReason,@CreatedByUserID)
            SELECT SCOPE_IDENTITY()";

            }

            else
            {
                Query = @"INSERT INTO Licenses (ApplicationID,DriverID,LicenseClass,IssueDate,ExpirationDate,
            PaidFees,IsActive,IssueReason,CreatedByUserID)
            VALUES (@ApplicationID,@DriverID,@LicenseClass,@IssueDate,@ExpirationDate,
            @PaidFees,@IsActive,@IssueReason,@CreatedByUserID)
            SELECT SCOPE_IDENTITY()";
            }

            SqlCommand command = new SqlCommand(Query, Connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@Notes", Notes);

            try
            {
                Connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LicenseID = insertedID;
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                Connection.Close();
            }

            return LicenseID;
        }

        public static bool UpdateLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate,
        DateTime ExpirationDate, decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID, string Notes = null)
        {
            int RowsAfected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"Update Licenses set
        ApplicationID = @ApplicationID,
        DriverID = @DriverID,
        LicenseClass = @LicenseClass,
        IssueDate = @IssueDate,
        ExpirationDate = @ExpirationDate,
        PaidFees = @PaidFees,
        IsActive = @IsActive,
        IssueReason = @IssueReason,
        CreatedByUserID = @CreatedByUserID,
        Notes = @Notes
        where LicenseID = @LicenseID";
            SqlCommand command = new SqlCommand(Query, Connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@Notes", Notes);

            try
            {
                Connection.Open();

                RowsAfected = command.ExecuteNonQuery();
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

        public static bool DriverLicenseInfo(int DriverID, int LicenseClass,ref int LicenseID, ref int ApplicationID, ref DateTime IssueDate, ref
        DateTime ExpirationDate, ref decimal PaidFees, ref bool IsActive, ref byte IssueReason, ref int CreatedByUserID, ref string Notes)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from Licenses where LicenseClass = @LicenseClass and DriverID = @DriverID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            Command.Parameters.AddWithValue("@DriverID", DriverID);


            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    LicenseID = (int)Reader["LicenseID"];
                    ApplicationID = (int)Reader["ApplicationID"];
                    IssueDate = (DateTime)Reader["IssueDate"];
                    ExpirationDate = (DateTime)Reader["ExpirationDate"];
                    PaidFees = (decimal)Reader["PaidFees"];
                    IsActive = (bool)Reader["IsActive"];
                    IssueReason = (byte)Reader["IssueReason"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];

                    if (Reader["Notes"] != null) 
                    {
                        Notes = (string)Reader["Notes"];

                    }




                }

                else
                {
                    IsFound = false;
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

        public static DataTable GetInfoLicenseByPersonID(int PersonID)
        {
            DataTable DT = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select LicenseID,ApplicationID,LicenseClass,IssueDate,ExpirationDate,IsActive " +
                " from Licenses join Drivers on Licenses.DriverID = Drivers.DriverID " +
                " where Licenses.DriverID = (select Drivers.DriverID WHERE Drivers.PersonID = @PersonID)";
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

        public static bool Find(int LicenseID, ref int DriverID, ref int LicenseClass, ref int ApplicationID, ref DateTime IssueDate, ref
        DateTime ExpirationDate, ref decimal PaidFees, ref bool IsActive, ref byte IssueReason, ref int CreatedByUserID, ref string Notes)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from Licenses where LicenseID = @LicenseID ";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@LicenseID", LicenseID);


            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    LicenseID = (int)Reader["LicenseID"];
                    ApplicationID = (int)Reader["ApplicationID"];
                    DriverID = (int)Reader["DriverID"];
                    LicenseClass = (int)Reader["LicenseClass"];
                    IssueDate = (DateTime)Reader["IssueDate"];
                    ExpirationDate = (DateTime)Reader["ExpirationDate"];
                    PaidFees = (decimal)Reader["PaidFees"];
                    IsActive = (bool)Reader["IsActive"];
                    IssueReason = (byte)Reader["IssueReason"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];

                    if (Reader["Notes"] != null)
                    {
                        Notes = (string)Reader["Notes"];

                    }




                }

                else
                {
                    IsFound = false;
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

        public static bool CheckDriverIfHasClasslicence3(int LicenseID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select Licenses.LicenseClass from Licenses where LicenseID = @LicenseID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {

                Connection.Open();

                object result = Command.ExecuteScalar();

                if (result != null && int.Parse(result.ToString()) == 3) 
                {
                    IsFound = true;
                }
                else
                {
                    IsFound = false;
                }

            }

            catch (Exception ex)
            {

            }
            finally
            {
                Connection.Close();
            }

            return IsFound;

        }

        public static DateTime IsExpiredDataForLicense(int LicenseID)
        {
            DateTime ExpiredData = DateTime.MinValue;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select ExpirationDate from Licenses where LicenseID = @LicenseID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {

                Connection.Open();

                object result = Command.ExecuteScalar();

                if (result != null)
                {
                    ExpiredData = (DateTime)result;
                }
                else
                {
                    
                }

            }

            catch (Exception ex)
            {

            }
            finally
            {
                Connection.Close();
            }
            return ExpiredData;
        }

        public static bool IsActiveLicense(int LicenseID)
        {
            bool IsActive = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select IsActive from Licenses where LicenseID = @LicenseID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                Connection.Open();

                object result = Command.ExecuteScalar();


                if (result != null)  
                {
                    IsActive = (bool)result;
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
    }
}
