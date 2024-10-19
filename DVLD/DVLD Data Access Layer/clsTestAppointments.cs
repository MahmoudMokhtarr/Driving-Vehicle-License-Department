using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Data_Access_Layer
{
    public class clsTestAppointments
    {
        public static int AddNewAppointment(int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, int RetakeTestApplicationID = 0)
        {
            int TestAppointmentID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO TestAppointments (TestTypeID,LocalDrivingLicenseApplicationID,AppointmentDate,PaidFees,CreatedByUserID)
            VALUES (@TestTypeID,@LocalDrivingLicenseApplicationID,@AppointmentDate,@PaidFees,@CreatedByUserID)
            SELECT SCOPE_IDENTITY()";

            if (RetakeTestApplicationID > 0)
            {
                Query = @"INSERT INTO TestAppointments (TestTypeID,LocalDrivingLicenseApplicationID,AppointmentDate,PaidFees,CreatedByUserID,RetakeTestApplicationID)
            VALUES (@TestTypeID,@LocalDrivingLicenseApplicationID,@AppointmentDate,@PaidFees,@CreatedByUserID,@RetakeTestApplicationID)
            SELECT SCOPE_IDENTITY()";
            }

            else if (RetakeTestApplicationID < 0)
            {
                Query = @"INSERT INTO TestAppointments (TestTypeID,LocalDrivingLicenseApplicationID,AppointmentDate,PaidFees,CreatedByUserID)
            VALUES (@TestTypeID,@LocalDrivingLicenseApplicationID,@AppointmentDate,@PaidFees,@CreatedByUserID)
            SELECT SCOPE_IDENTITY()";
            }

            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            if (RetakeTestApplicationID > 0)
            {
                command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
            }


            try
            {

                Connection.Open();



                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    TestAppointmentID = insertedID;
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                Connection.Close();
            }

            return TestAppointmentID;

        }

        public static bool GetDataAppointment(int TestAppointmentID,ref DateTime AppointmentDate,ref decimal PaidFees,ref bool IsLocked,ref int CreatedByUserID)
        {
            bool IsFuond = false;
            string Query = "select TestAppointmentID,AppointmentDate,PaidFees,IsLocked,CreatedByUserID from TestAppointments where TestAppointmentID = @TestAppointmentID";

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(Query, Connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);


            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFuond = true;
                    TestAppointmentID = (int)Reader["TestAppointmentID"];
                    AppointmentDate = (DateTime)Reader["AppointmentDate"];
                    PaidFees = (decimal)Reader["PaidFees"];
                    IsLocked = (bool)Reader["IsLocked"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                }

            }

            catch (Exception ex)
            {

            }

            finally
            {
                Connection.Close();
            }

            return IsFuond;
        }

        public static bool IsLockedAppointment(int TestAppointmentID)
        {
            bool IsLocked = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select IsLocked from TestAppointments where TestAppointmentID = @TestAppointmentID";
            SqlCommand command = new SqlCommand(Query, Connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                Connection.Open();

                object result = command.ExecuteScalar();


                if (result != null )
                {
                    IsLocked = (bool) result;
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                Connection.Close();
            }

           return IsLocked ;
        }

        public static bool UpdateAppointmentDate(int TestAppointmentID, DateTime AppointmentDate,bool IsLocked)
        {
            int RowsAfected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"update TestAppointments set AppointmentDate = @AppointmentDate,IsLocked = @IsLocked where TestAppointmentID = @TestAppointmentID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            Command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            Command.Parameters.AddWithValue("@IsLocked", IsLocked);

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
        public static int GetRetakeTestApplicationID(int TestAppointmentID)
        {
            int RetakeTestApplicationID = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select RetakeTestApplicationID from TestAppointments where TestAppointmentID = @TestAppointmentID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                Connection.Open();

                object result = Command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    RetakeTestApplicationID = insertedID;
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                Connection.Close();
            }

            return RetakeTestApplicationID;
        }
        public static DataTable ListAppointment(int LDLAppID, int TestTypeID)
        {
            DataTable DtTable = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select TestAppointmentID,AppointmentDate,PaidFees,IsLocked,CreatedByUserID from TestAppointments where LocalDrivingLicenseApplicationID = @LDLAppID and TestTypeID = @TestTypeID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@LDLAppID", LDLAppID);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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
        public static int CountFailedTests(int LDLAppID, int TestTypeID)
        {
            int Count = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select count(*)TestAppointmentID from TestAppointments join Tests on TestAppointments.TestAppointmentID = Tests.TestAppointmentID where TestTypeID = @TestTypeID and LocalDrivingLicenseApplicationID = @LDLAppID and TestResult = 'false'";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@LDLAppID", LDLAppID);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                Connection.Open();
                object result = Command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedCount))
                {
                    Count = insertedCount;
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                Connection.Close();
            }

            return Count;

        }


    }
}
