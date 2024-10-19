using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Data_Access_Layer
{
    public class clsDetainLicense
    {

        private static string _GetEndQuery(string FilterBy, string Word)
        {
            string Query = "";

            if (FilterBy == "DetainID")
            {
                Query = "select * from DetainedLicenses_View where DetainID LIKE @Word";
                return Query;
            }

            else if (FilterBy == "IsReleased")
            {
                Query = "select * from DetainedLicenses_View where IsReleased ";
                return Query;

            }

            else if (FilterBy == "NationalNo")
            {
                Query = "SELECT * FROM DetainedLicenses_View WHERE NationalNo LIKE @Word";
                return Query;

            }

            else if (FilterBy == "FullName")
            {
                Query = "SELECT * FROM DetainedLicenses_View WHERE FullName LIKE @Word";
                return Query;

            }
            else
            {
                Query = "select * from DetainedLicenses_View where ReleaseApplicationID like @Word";
                return Query;

            }

        }


        public static int AddNewDetainLicense(int LicenseID, DateTime DetainDate, decimal FineFees,
            int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            int DetainID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO DetainedLicenses (LicenseID,DetainDate,FineFees,CreatedByUserID,IsReleased,ReleaseDate,ReleasedByUserID,ReleaseApplicationID) 
            VALUES (@LicenseID,@DetainDate,@FineFees,@CreatedByUserID,@IsReleased,@ReleaseDate,@ReleasedByUserID,@ReleaseApplicationID)
            SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(Query, Connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            if (IsReleased == false)
            {
                command.Parameters.AddWithValue("@IsReleased", IsReleased);
                command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
                command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
                command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@IsReleased", IsReleased);
                command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
                command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
                command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            }
            try
            {
                Connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    DetainID = insertedID;
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                Connection.Close();
            }


            return DetainID;

        }

        public static bool UpdateDetainLicense(int LicenseID, DateTime DetainDate, decimal FineFees,
            int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            int RowsAfected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"update DetainedLicenses set
            DetainDate = @DetainDate,
            FineFees = @FineFees,
            CreatedByUserID = @CreatedByUserID,
            IsReleased = @IsReleased,
            ReleaseDate = @ReleaseDate,
            ReleasedByUserID = @ReleasedByUserID,
            ReleaseApplicationID = @ReleaseApplicationID
            where LicenseID= @LicenseID";

            SqlCommand command = new SqlCommand(Query, Connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);
            command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);

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

        public static DataTable ListDetainedLicenses()
        {
            DataTable DtTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "select * from DetainedLicenses_View";

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

        public static bool DeleteDetainLicens(int LicenseID)
        {
            int ReowsAfected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "delete DetainedLicenses where LicenseID = @LicenseID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@LicenseID", LicenseID);

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

        public static bool IsReleasedLicenses(int LicenseID)
        {
            bool IsDetain = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select IsReleased from DetainedLicenses where LicenseID = @LicenseID";
            SqlCommand command = new SqlCommand(Query, Connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                Connection.Open();

                object result = command.ExecuteScalar();

                IsDetain = (result == null || DBNull.Value == result) ? false : (bool)result;

                if (result == null)
                {
                    IsDetain = true;
                }



            }

            catch (Exception ex)
            {

            }

            finally
            {
                Connection.Close();
            }

            return IsDetain;
        }

        public static bool Find(int LicenseID,ref int DetainID, ref DateTime DetainDate, ref decimal FineFees, ref
            int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from DetainedLicenses where LicenseID = @LicenseID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {

                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    DetainID = (int)Reader["DetainID"];
                    DetainDate = (DateTime)Reader["DetainDate"];
                    FineFees = (decimal)Reader["FineFees"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    IsReleased = (bool)Reader["IsReleased"];

                    if (IsReleased)
                    {
                        ReleaseDate = (DateTime)Reader["ReleaseDate"];
                        ReleasedByUserID = (int)Reader["ReleasedByUserID"];
                        ReleaseApplicationID = (int)Reader["ReleaseApplicationID"];

                    }

                }

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

        public static DataTable SearchByWord(string FilterBy, string Word)
        {
            DataTable DT = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = _GetEndQuery(FilterBy, Word);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Word", Word + "%");

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



    }
    }