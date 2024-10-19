using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business_Layer
{
    public class clsInternationalDrivingLicense
    {
        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public clsInternationalDrivingLicense()
        {
            this.InternationalLicenseID = 0;
            this.ApplicationID = 0;
            this.DriverID = 0;
            this.IssuedUsingLocalLicenseID = 0;
            this.IssueDate= DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.IsActive = false;
            this.CreatedByUserID = 0;

        }

        private clsInternationalDrivingLicense(int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate,
        DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;
        }

        private bool _AddNewLicense()
        {
            this.InternationalLicenseID = DVLD_Data_Access_Layer.clsInternationalDrivingLicense.AddNewLicense(
            this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);

            return (this.InternationalLicenseID != -1);

        }

        public static bool IsDriverHasInternationalLicense(int DriverID)
        {
            return DVLD_Data_Access_Layer.clsInternationalDrivingLicense.IsDriverHasInternationalLicense(DriverID);
        }
        public static DataTable GetInfoLicenseByPersonID(int PersonID)
        {
            return DVLD_Data_Access_Layer.clsInternationalDrivingLicense.GetInfoLicenseByPersonID(PersonID);
        }

        public static clsInternationalDrivingLicense Find(int InternationalLicenseID)
        {
            int ApplicationID = 0, CreatedByUserID = 0, DriverID = 0, IssuedUsingLocalLicenseID = 0;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            bool IsActive = false;

            if (DVLD_Data_Access_Layer.clsInternationalDrivingLicense.Find(InternationalLicenseID, ref ApplicationID
                ,ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {


                return new clsInternationalDrivingLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID
                    , IssueDate, ExpirationDate, IsActive, CreatedByUserID);
              }

            return null;

        }

        public static DataTable ListInternationalLicense()
        {
            return DVLD_Data_Access_Layer.clsInternationalDrivingLicense.ListInternationalLicense();
        }

        public bool SaveData()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewLicense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }


                case enMode.Update:

                    {
                        break;
                    }
            }

            return false;
        }




    }
}
