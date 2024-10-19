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
    public class clsTests
    {
        public static int AddNewTest(int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            int TestID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO Tests (TestAppointmentID,TestResult,Notes,CreatedByUserID)
            VALUES (@TestAppointmentID,@TestResult,@Notes,@CreatedByUserID)
            SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(Query, Connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                Connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    TestID = insertedID;
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                Connection.Close();
            }


            return TestID;

        }

        public static bool TestAppointmentResult(int TestAppointmentID)
        {
            bool TestResult = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"select TestResult from Tests where TestAppointmentID = @TestAppointmentID";
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                Connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    TestResult = (bool)result;
                }

            }

            catch (Exception ex)
            {

            }

            finally
            {
                Connection.Close();
            }

            return TestResult;
        }


        public static int GetPassedTest(int LocalDrivingLicenseApplicationID)
        {
            int NumberPassedTest = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT COUNT(TestAppointments.TestTypeID) AS PassedTestCount FROM Tests INNER JOIN TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID WHERE (TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) AND (Tests.TestResult = 1)";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int insertedNumberPassedTest))
                {
                    NumberPassedTest = insertedNumberPassedTest;
                }


            }
            catch (Exception ex)
            {

            }

            finally
            {
                Connection.Close();
            }

            return NumberPassedTest;
        }



    }
}
