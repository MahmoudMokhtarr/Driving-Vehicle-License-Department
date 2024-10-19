using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Business_Layer
{
    public class clsTestAppointments
    {
        public int TestAppointmentID { set; get; }
        public int TestTypeID { set; get; }
        public int LocalDrivingLicenseApplicationID { set; get; }
        public DateTime AppointmentDate { set; get; }
        public decimal PaidFees { set; get; }
        public int CreatedByUserID { set; get; }
        public bool IsLocked { set; get; }
        public int RetakeTestApplicationID { set; get; }
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public clsTestAppointments()
        {
            TestAppointmentID = -1;
            TestTypeID = -1;
            LocalDrivingLicenseApplicationID = -1;
            AppointmentDate = DateTime.Now;
            PaidFees = -1;
            CreatedByUserID = -1;
            IsLocked = false;
            RetakeTestApplicationID = -1;

            this.Mode = Mode;
        }
        private clsTestAppointments(int TestAppointmentID, DateTime AppointmentDate)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.AppointmentDate = AppointmentDate;
        }
        private clsTestAppointments(int TestAppointmentID, DateTime AppointmentDate, decimal PaidFees, bool IsLocked,int CreatedByUserID)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.AppointmentDate = AppointmentDate;
            this.IsLocked = IsLocked;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;

        }
        private bool _AddNewAppointment()
        {
            this.TestAppointmentID = DVLD_Data_Access_Layer.clsTestAppointments.AddNewAppointment(this.TestTypeID,
            this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID,this.RetakeTestApplicationID);

            return (TestAppointmentID != 1);
        }

        public static clsTestAppointments GetDataAppointment(int TestAppointmentID)
        {
            int CreatedByUserID = 0;
            decimal PaidFees = 0;
            bool IsLocked = false;
            DateTime AppointmentDate = DateTime.Now;

            if (DVLD_Data_Access_Layer.clsTestAppointments.GetDataAppointment(TestAppointmentID,ref AppointmentDate,ref PaidFees,ref IsLocked,ref CreatedByUserID))
            {
                return new clsTestAppointments(TestAppointmentID, AppointmentDate, PaidFees, IsLocked, CreatedByUserID);
            }

            else
            {
                return null;
            }
        }
        public static bool IsLockedAppointment(int AppointmentID)
        {
            return DVLD_Data_Access_Layer.clsTestAppointments.IsLockedAppointment(AppointmentID);
        }
        private  bool _UpdateAppointmentDate()
        {
            return DVLD_Data_Access_Layer.clsTestAppointments.UpdateAppointmentDate(this.TestAppointmentID,this.AppointmentDate,this.IsLocked);
        }
        public bool SaveData(enMode Mode)
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewAppointment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }


                case enMode.Update:

                    return _UpdateAppointmentDate();
            }

            return false;
        }

        public static int GetRetakeTestApplicationID(int TestAppointmentID)
        {
            return DVLD_Data_Access_Layer.clsTestAppointments.GetRetakeTestApplicationID(TestAppointmentID);
        }

        public static DataTable ListAppointment(int LDLAppID, int TestTypeID)
        {
            return DVLD_Data_Access_Layer.clsTestAppointments.ListAppointment( LDLAppID,TestTypeID);
        }

        public static bool IsApplicationIsRetakeTest(int TestAppointmentID)
        {
            if (GetRetakeTestApplicationID(TestAppointmentID) > 0)
            {
                return true;
            }
            return false;
        }

        public static int CountTrialTest(int LDLAppID, int TestTypeID)
        {
            return DVLD_Data_Access_Layer.clsTestAppointments.CountFailedTests(LDLAppID, TestTypeID);
        }
    }
}
