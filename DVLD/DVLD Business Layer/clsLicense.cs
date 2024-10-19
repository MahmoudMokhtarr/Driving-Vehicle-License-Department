using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business_Layer
{
    public class clsLicense
    {
        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClass { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public byte IssueReason { get; set; }
        public int CreatedByUserID { get; set; }
        public string Notes { get; set; }
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public clsLicense()
        {
            this.ApplicationID = 0;
            this.DriverID = 0;
            this.LicenseClass = 0;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.PaidFees = 0;
            this.IsActive = false;
            this.IssueReason = 0;
            this.CreatedByUserID = 0;
            this.Notes = string.Empty;

            Mode = enMode.AddNew;

        }

        private clsLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate,
            DateTime ExpirationDate, decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID, string Notes)
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClass = LicenseClass;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;
            this.Notes = Notes;

            Mode = enMode.Update;

        }

        private  bool AddNewLicense()
        {
            this.LicenseID = DVLD_Data_Access_Layer.clsLicense.AddNewLicense(this.ApplicationID, this.DriverID,
            this.LicenseClass, this.IssueDate, this.ExpirationDate, this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID, this.Notes);
            return (this.LicenseID != -1);
        }
        
        private bool UpdateLicense()
        {
            return DVLD_Data_Access_Layer.clsLicense.UpdateLicense(this.LicenseID,
                this.ApplicationID, this.DriverID, this.LicenseClass, this.IssueDate,
                this.ExpirationDate, this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID,this.Notes);
        }

        public static clsLicense DriverLicenseInfo(int DriverID, int LicenseClass)
        {
            int ApplicationID = 0, CreatedByUserID = 0, LicenseID = 0;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            decimal PaidFees = 0;
            bool IsActive = false;
            byte IssueReason=0;
            string Notes = "";

            if (DVLD_Data_Access_Layer.clsLicense.DriverLicenseInfo(DriverID,LicenseClass,ref LicenseID,ref ApplicationID,ref IssueDate
            ,ref ExpirationDate,ref PaidFees,ref IsActive,ref IssueReason,ref CreatedByUserID,ref Notes))
            {
                return new clsLicense(LicenseID,ApplicationID,DriverID,LicenseClass,IssueDate,ExpirationDate,PaidFees,IsActive,IssueReason,CreatedByUserID,Notes);
            }
            return null;
        }

        public static clsLicense Find(int LicenseID)
        {
            int ApplicationID = 0, CreatedByUserID = 0, DriverID = 0, LicenseClass = 0;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            decimal PaidFees = 0;
            bool IsActive = false;
            byte IssueReason = 0;
            string Notes = "";

            if (DVLD_Data_Access_Layer.clsLicense.Find(LicenseID,ref DriverID,ref LicenseClass, ref ApplicationID, ref IssueDate
            ,ref ExpirationDate, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID, ref Notes))
            {
                return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, PaidFees, IsActive, IssueReason, CreatedByUserID, Notes);
            }
            return null;
        }

        public static DataTable GetInfoLicenseByPersonID(int PersonID)
        {
            return DVLD_Data_Access_Layer.clsLicense.GetInfoLicenseByPersonID(PersonID);
        }

        public static bool CheckDriverIfHasClasslicence3(int DriverID)
        {
            return DVLD_Data_Access_Layer.clsLicense.CheckDriverIfHasClasslicence3((int)DriverID);
        }

        public static bool IsExpiredDataForLicense(int LicenseID)
        {
            DateTime Date = DVLD_Data_Access_Layer.clsLicense.IsExpiredDataForLicense(LicenseID);
            int Result = DateTime.Compare(Date, DateTime.Now);

            if (Result < 0)  
            {
                return true;
            }

            else if (Result > 0)
            {
                return false;
            }
            else { return false; }
        }

        public static bool IsActiveLicense(int LicenseID)
        {
            return DVLD_Data_Access_Layer.clsLicense.IsActiveLicense(LicenseID);
        }
        public bool SaveData()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (AddNewLicense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return UpdateLicense();
                    }


                case enMode.Update:

                    return UpdateLicense();
            }

            return false;
        }



    }
}
