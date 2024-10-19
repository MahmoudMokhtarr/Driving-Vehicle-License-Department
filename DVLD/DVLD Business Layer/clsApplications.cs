using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DVLD_Business_Layer
{
    public class clsApplications
    {
        public int ApplicationID { set; get; }
        public int ApplicantPersonID { set; get; }
        public DateTime ApplicationDate { set; get; }
        public int ApplicationTypeID { set; get; }
        public byte ApplicationStatus { set; get; }
        public DateTime LastStatusDate { set; get; }
        public decimal PaidFees{ set; get; }
        public int CreatedByUserID { set; get; }
        public  enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public clsApplications()
        {
            ApplicationID = -1;
            ApplicantPersonID = -1;
            ApplicationDate = DateTime.Now;
            ApplicationTypeID = -1;
            ApplicationStatus = 0;
            LastStatusDate = DateTime.Now;
            PaidFees = -1;

            Mode = enMode.AddNew;

        }
        public clsApplications(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;

            Mode = enMode.Update;
        }
        private bool _AddNewApplication()
        {
            this.ApplicationID = DVLD_Data_Access_Layer.clsApplications.AddNewApplication(this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID, this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);

            return (ApplicationID != -1);
        }
        public static DataTable ListApplications()
        {
            return DVLD_Data_Access_Layer.clsApplications.ListApplications();
        }
        public static bool DeleteApplication(int ApplicationID)
        {
            return DVLD_Data_Access_Layer.clsApplications.DeleteApplication(ApplicationID);
        }
        private bool _UpdateApplication()
        {
            return DVLD_Data_Access_Layer.clsApplications.UpdateApplication(this.ApplicationID,this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID, this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);

        }

        public static clsApplications Find(int ApplicationID)
        {
            int ApplicantPersonID = 0, ApplicationTypeID = 0, CreatedByUserID = 0;
            DateTime ApplicationDate = DateTime.Now, LastStatusDate = DateTime.Now;
            byte ApplicationStatus=0;
            decimal PaidFees = 0;

            if (DVLD_Data_Access_Layer.clsApplications.Find(ApplicationID,ref ApplicantPersonID, ref ApplicationDate,ref ApplicationTypeID,ref ApplicationStatus,ref LastStatusDate,ref PaidFees,ref CreatedByUserID))
            {
                return new clsApplications(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            }

            return null;
        }

        public bool SaveData()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }


                case enMode.Update:

                    return _UpdateApplication();
            }

            return false;
        }


    }
}
