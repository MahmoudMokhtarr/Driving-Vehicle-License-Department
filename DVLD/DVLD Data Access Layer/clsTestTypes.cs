using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Data_Access_Layer
{
    public class clsTestTypes
    {
        public static DataTable ReturnTestTypesInfo()
        {
            DataTable Dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from TestTypes";
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

        public static bool Find(int ID, ref string Title,ref string Description, ref decimal Fees)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from TestTypes where TestTypeID = @ID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ID", ID);

            try
            {

                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    
                    IsFound = true;

                    ID = (int)Reader["TestTypeID"];
                    Title = (string)Reader["TestTypeTitle"];
                    Description = (string)Reader["TestTypeDescription"];
                    Fees = (decimal)Reader["TestTypeFees"];
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

        public static bool UpdateTestType(int ID, string Title, string Description, decimal Fees)
        {

            int RowsAfected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"update TestTypes set
            TestTypeTitle = @Title,
            TestTypeDescription = @Description,
            TestTypeFees = @Fees
            where TestTypeID = @ID";

            SqlCommand Command = new SqlCommand(Query, Connection);


            Command.Parameters.AddWithValue("@ID", ID);
            Command.Parameters.AddWithValue("@Title", Title);
            Command.Parameters.AddWithValue("@Description", Description);
            Command.Parameters.AddWithValue("@Fees", Fees);


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

        public static int CountTestTrial(int LDLAppID, int TestTypeID)
        {
            int NumTestTrial = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select count (TestAppointmentID) FROM TestAppointments Where LocalDrivingLicenseApplicationID = @LDLAppID And TestTypeID = @TestTypeID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@LDLAppID", LDLAppID);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                Connection.Open();

                object result = Command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedNumTestTrial))
                {
                    NumTestTrial = insertedNumTestTrial;
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                Connection.Close();
            }

            return NumTestTrial;

        }
        public static decimal GetTestFeesByTestType(int TestTypeID)
        {
            decimal TestFees = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select TestTypeFees from TestTypes where TestTypeID = @TestTypeID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                Connection.Open();

                object result = Command.ExecuteScalar();


                if (result != null )
                {
                    TestFees = (decimal)result;
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                Connection.Close();
            }
            return TestFees;
        }


    }
}
