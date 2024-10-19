using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Data_Access_Layer
{
    public class clsApplications
    {
        // CURD

        public static int AddNewApplication(int ApplicantPersonID,DateTime ApplicationDate,int ApplicationTypeID,byte ApplicationStatus,DateTime LastStatusDate,decimal PaidFees,int CreatedByUserID)
        {

            int ApplicationID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO Applications (ApplicantPersonID,ApplicationDate,ApplicationTypeID,ApplicationStatus,LastStatusDate,PaidFees,CreatedByUserID)
            VALUES (@ApplicantPersonID,@ApplicationDate,@ApplicationTypeID,@ApplicationStatus,@LastStatusDate,@PaidFees,@CreatedByUserID)
            SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(Query, Connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                Connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ApplicationID = insertedID;
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                Connection.Close();
            }


            return ApplicationID;

        }
        public static bool UpdateApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            int RowsAfected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"update Applications set
            ApplicantPersonID= @ApplicantPersonID,
            ApplicationDate = @ApplicationDate,
            ApplicationTypeID = @ApplicationTypeID,
            ApplicationStatus = @ApplicationStatus,
            LastStatusDate = @LastStatusDate,
            PaidFees = @PaidFees,
            CreatedByUserID = @CreatedByUserID
            where ApplicationID= @ApplicationID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            Command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            Command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            Command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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
        public static DataTable ListApplications()
        {
            DataTable DtTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "select * from Applications";

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
        public static bool DeleteApplication(int ApplicationID)
        {
            int ReowsAfected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "delete Applications where ApplicationID = @ApplicationID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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
        public static int GetApplicitonIDByLocalLicenseApplicationID(int LDLAppID)
        {
            int ApplicitonID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select ApplicationID FROM LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID =@LDLAppID ";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LDLAppID", LDLAppID);

            try
            {
                Connection.Open();

                object result = Command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int LocalApplicationID))
                {
                    ApplicitonID = LocalApplicationID;
                }
            }
            catch
            {

            }
            finally
            {
                Connection.Close();
            }

            return ApplicitonID;
        }

        public static bool Find(int ApplicationID, ref int ApplicantPersonID, ref DateTime ApplicationDate, ref int ApplicationTypeID, ref byte ApplicationStatus, ref DateTime LastStatusDate, ref decimal PaidFees, ref int CreatedByUserID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from Applications where ApplicationID = @ApplicationID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {

                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    ApplicationID = (int)Reader["ApplicationID"];
                    ApplicantPersonID = (int)Reader["ApplicantPersonID"];
                    ApplicationDate = (DateTime)Reader["ApplicationDate"];
                    ApplicationTypeID = (int)Reader["ApplicationTypeID"];
                    ApplicationStatus = (byte)Reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)Reader["LastStatusDate"];
                    PaidFees = (decimal)Reader["PaidFees"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
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
