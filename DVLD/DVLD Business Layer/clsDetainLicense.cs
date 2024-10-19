using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Business_Layer
{
    public class clsDetainLicense
    {
       public int  DetainID { set; get; }
        public int LicenseID { set; get; }
        public DateTime DetainDate { set; get; }
        public decimal FineFees { set; get; }
        public int  CreatedByUserID { set; get; }
        public bool IsReleased { set; get; }
        public DateTime ReleaseDate { set; get; }
        public int ReleasedByUserID { set; get; }
        public int ReleaseApplicationID { set; get; }

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public clsDetainLicense()
        {
            this.DetainID = 0;
            this.LicenseID = 0;
            this.DetainDate = DateTime.Now;
            this.FineFees = 0;
            this.CreatedByUserID = 0;
            this.IsReleased = false;
            this.ReleaseDate = DateTime.Now;
            this.ReleasedByUserID = 0;
            this.ReleaseApplicationID = 0;

            this.Mode = enMode.AddNew;
        }

        private clsDetainLicense(int DetainID, int LicenseID, DateTime DetainDate, decimal FineFees,
           int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;

            this.Mode = enMode.Update;

        }

        private bool AddNewDetainLicense()
        {
            this.DetainID = DVLD_Data_Access_Layer.clsDetainLicense.AddNewDetainLicense(
              this.LicenseID,this.DetainDate,this.FineFees,this.CreatedByUserID,this.IsReleased,
              this.ReleaseDate,this.ReleasedByUserID,this.ReleaseApplicationID);

            return (DetainID != -1);

        }

        private  bool UpdateApplication()
        {
            return DVLD_Data_Access_Layer.clsDetainLicense.UpdateDetainLicense(this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID, this.IsReleased,
              this.ReleaseDate, this.ReleasedByUserID, this.ReleaseApplicationID);
        }

        public static DataTable ListDetainedLicenses()
        {
            return DVLD_Data_Access_Layer.clsDetainLicense.ListDetainedLicenses();
        }
        public static bool DeleteDetainLicens(int LicenseID)
        {
            return DVLD_Data_Access_Layer.clsDetainLicense.DeleteDetainLicens(LicenseID);
        }

        public static bool IsReleasedLicenses(int LicenseID)
        {
            return DVLD_Data_Access_Layer.clsDetainLicense.IsReleasedLicenses(LicenseID);
        }

        public static clsDetainLicense Find(int LicenseID)
        {
            int DetainID = 0, CreatedByUserID = 0, ReleasedByUserID = 0, ReleaseApplicationID = 0;
            decimal FineFees=0;
            DateTime DetainDate = DateTime.Now, ReleaseDate =  DateTime.Now;
            bool IsReleased = false;

            if (DVLD_Data_Access_Layer.clsDetainLicense.Find(LicenseID,ref DetainID,ref DetainDate,
                ref FineFees,ref CreatedByUserID,ref IsReleased,ref ReleaseDate,ref ReleasedByUserID,ref ReleaseApplicationID))
            {
                return new clsDetainLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            }
            return null;
        }
        public static DataTable SearchByWord(string FilterBy, string Word)
        {
            return DVLD_Data_Access_Layer.clsDetainLicense.SearchByWord(FilterBy, Word);
        }
        public bool SaveData()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (AddNewDetainLicense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }


                case enMode.Update:

                    return UpdateApplication();
            }

            return false;
        }

    }
}
