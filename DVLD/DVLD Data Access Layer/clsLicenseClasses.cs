using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Data_Access_Layer
{
    public class clsLicenseClasses
    {

        public static DataTable ListLicenseClasses()
        {
            DataTable DtTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "select * from LicenseClasses";

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

        public static String GetLicenseClasName(int LicenseClassID)
        {
            string LicenseClasName = "";

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select ClassName from LicenseClasses where LicenseClassID = @LicenseClassID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null)
                {
                    LicenseClasName = (string)Result;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
              Connection.Close(); 
            }

            return LicenseClasName;
        }
        public static bool Find(int LicenseClassID,ref string ClassName, ref string ClassDescription
        ,ref byte MinimumAllowedAge, ref byte DefaultValidityLength, ref decimal ClassFees)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from LicenseClasses where LicenseClassID = @LicenseClassID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {

                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    IsFound = true;

                    ClassName = (string)Reader["ClassName"];
                    ClassDescription = (string)Reader["ClassDescription"];
                    MinimumAllowedAge = (byte)Reader["MinimumAllowedAge"];
                    DefaultValidityLength = (byte)Reader["DefaultValidityLength"];
                    ClassFees = (decimal)Reader["ClassFees"];
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
