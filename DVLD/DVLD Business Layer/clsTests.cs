using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business_Layer
{
    public class clsTests
    {
        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }
        public enum enMode { AddNew = 0, Update = 1 };
        enMode Mode = enMode.AddNew;

        public clsTests ()
        {
            this.TestID = 1;
            this.TestAppointmentID = 1;
            this.TestResult = false;
            this.Notes = string.Empty;
            this.CreatedByUserID = -1;

            this.Mode = enMode.AddNew;
        }

        private bool _AddNewTest()
        {
            this.TestID = DVLD_Data_Access_Layer.clsTests.AddNewTest(this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);

            return (this.TestID != -1);
        }

        public static bool TestAppointmentResult(int TestAppointmentID)
        {
            return DVLD_Data_Access_Layer.clsTests.TestAppointmentResult(TestAppointmentID);
        }

        public static int GetPassedTest(int LocalDrivingLicenseApplicationID)
        {
            return DVLD_Data_Access_Layer.clsTests.GetPassedTest(LocalDrivingLicenseApplicationID);
        }

        public bool SaveData()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewTest())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }


                case enMode.Update:

                    return _AddNewTest();
            }

            return false;

        }

    }
}
