using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Data_Access_Layer
{
    public class clsApplicationTypes
    {
        public static DataTable ReturnApplicationTypesInfo()
        {
            DataTable Dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from ApplicationTypes";
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

        public static bool Find(int ID,ref string Title,ref decimal Fees)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from ApplicationTypes where ApplicationTypeID = @ID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ID", ID);

            try
            {

                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    IsFound = true;

                    ID = (int)Reader["ApplicationTypeID"];
                    Title = (string)Reader["ApplicationTypeTitle"];
                    Fees = (decimal)Reader["ApplicationFees"];
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
        public static bool UpdateUser(int ID,  string Title,  decimal Fees)
        {

            int RowsAfected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"update ApplicationTypes set
            ApplicationTypeTitle = @Title,
            ApplicationFees = @Fees
            where ApplicationTypeID = @ID";

            SqlCommand Command = new SqlCommand(Query, Connection);


            Command.Parameters.AddWithValue("@ID", ID);
            Command.Parameters.AddWithValue("@Title", Title);
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
        public static string GetApplicationTypeByID(int ApplicationTypeID)
        {
            string ApplicationTypeTitle = "";

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select ApplicationTypeTitle from ApplicationTypes where ApplicationTypeID = @ApplicationTypeID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                Connection.Open();
                object result = Command.ExecuteScalar();

                if (result != null)
                {
                    ApplicationTypeTitle = result.ToString();
                }

            }

            catch (Exception ex)
            {
                
            }
            finally
            {
                Connection.Close();
            }
            return ApplicationTypeTitle;
        }
    }
}
