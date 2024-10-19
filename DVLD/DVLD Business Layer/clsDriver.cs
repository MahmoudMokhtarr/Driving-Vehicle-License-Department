using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business_Layer
{
    public class clsDriver
    {
        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }
        public enum enMode { AddNew = 0, Update = 1 };
        enMode Mode = enMode.AddNew;

        public clsDriver()
        {
            this.DriverID = 0;
            this.PersonID = 0;
            this.CreatedByUserID = 0;
            this.CreatedDate = DateTime.Now;
            this.Mode = enMode.AddNew;

        }

        private clsDriver(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;
        }

        public static int GetDriverIDByPersonID(int PersonID)
        {
            return DVLD_Data_Access_Layer.clsDriver.GetDriverIDByPersonID(PersonID);
        }

        public static int GetPersonIDByDriverID(int DriverID)
        {
            return DVLD_Data_Access_Layer.clsDriver.GetPersonIDByDriverID(DriverID);
        }
        public static bool IsLocalDrivingLicenseForDriverActive(int PersonID)
        {
            return DVLD_Data_Access_Layer.clsDriver.IsLocalDrivingLicenseForDriverActive(PersonID);
        }
        private bool _AddNewDriver()
        {
            this.DriverID = DVLD_Data_Access_Layer.clsDriver.AddNewDriver(this.PersonID, this.CreatedByUserID, this.CreatedDate);
            return (this.DriverID != -1);
        }
        public static DataTable ListDrivers()
        {
            return DVLD_Data_Access_Layer.clsDriver.ListDrivers();
        }
        public static DataTable SearchByWord(string FilterBy, string Word)
        {
            return DVLD_Data_Access_Layer.clsDriver.SearchByWord(FilterBy, Word);
        }

        public static bool IsDriverExistByPersonID(int PersonID)
        {
            return DVLD_Data_Access_Layer. clsDriver.IsDriverExistByPersonID(PersonID);
        }

        public static clsDriver Find(int PersonID)
        {
            int DriverID = 0, CreatedByUserID = 0;
            DateTime CreatedDate=DateTime.Now;

            if (DVLD_Data_Access_Layer.clsDriver.Find(PersonID, ref DriverID, ref CreatedByUserID, ref CreatedDate))
            {
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            }

            return null;

        }

        public bool SaveData()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewDriver())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }


                case enMode.Update:

                    return _AddNewDriver();
            }

            return false;

        }




    }
}
