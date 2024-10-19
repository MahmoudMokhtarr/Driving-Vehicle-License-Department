using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using DVLD_Data_Access_Layer;
using System.Data.SqlClient;

namespace DVLD_Business_Layer
{
    public class clsLocalDrivingLicenseApplications : clsApplications
    {
        public int LocalDrivingLicenseApplicationID { set; get; }
        public int  LicenseClassID { set; get; }
        public enum enMode { AddNew = 0, Update = 1 };
        enMode Mode = enMode.AddNew;

        public clsLocalDrivingLicenseApplications()
        {
            LocalDrivingLicenseApplicationID = -1;
            LicenseClassID = -1;
            Mode = enMode.AddNew;
        }
        private clsLocalDrivingLicenseApplications(int LocalDrivingLicenseApplicationID,int LicenseClassID,
        int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
        byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID):base(ApplicationID, ApplicantPersonID,
         ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID)
        {
            this.LicenseClassID = LicenseClassID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            base.ApplicationID = ApplicationID;
            base.ApplicantPersonID = ApplicantPersonID;
            base.ApplicationDate = ApplicationDate;
            base.ApplicationTypeID = ApplicationTypeID;
            base.ApplicationStatus = ApplicationStatus;
            base.LastStatusDate = LastStatusDate;
            base.PaidFees = PaidFees;
            base.CreatedByUserID = CreatedByUserID;

            Mode = enMode.Update;
        }
        private bool _AddNewLocalDrivingLicenseApplication()
        {
            this.LocalDrivingLicenseApplicationID = DVLD_Data_Access_Layer.clsLocalDrivingLicenseApplications.AddNewLocalDrivingLicenseApplication(ApplicationID, LicenseClassID);

            return (ApplicationID != -1);

        }
        public static DataTable ListLocalDrivingLicenseApplication()
        {
            return DVLD_Data_Access_Layer.clsLocalDrivingLicenseApplications.ListLocalDrivingLicenseApplication();
        }
        public static bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            return DVLD_Data_Access_Layer.clsLocalDrivingLicenseApplications.DeleteLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID);
        }
        public bool UpdateLocalDrivingLicenseApplication ()
        {
            return DVLD_Data_Access_Layer.clsLocalDrivingLicenseApplications.UpdateLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID,this.ApplicationID,this.LicenseClassID);
        }
        public static int IsLicenseClassDuplicatedForPerson(int PersonID, int LicenseClassID)
        {
            return DVLD_Data_Access_Layer.clsLocalDrivingLicenseApplications.IsLicenseClassDuplicatedForPerson(PersonID, LicenseClassID);
        }
        public static DataTable LocalDrivingLicenseApplications_View()
        {
            return DVLD_Data_Access_Layer.clsLocalDrivingLicenseApplications.LocalDrivingLicenseApplications_View();
        }
        public static clsLocalDrivingLicenseApplications Find(int LDLAppID)
        {
            int  LocalDrivingLicenseApplicationID = 0, LicenseClassID = 0 ;

            int ApplicationID = DVLD_Data_Access_Layer.clsApplications.GetApplicitonIDByLocalLicenseApplicationID(LDLAppID);
            clsApplications Applications = clsApplications.Find(ApplicationID);

            if (DVLD_Data_Access_Layer.clsLocalDrivingLicenseApplications.Find(ref LDLAppID, ref LicenseClassID))
            {
                return new clsLocalDrivingLicenseApplications(LDLAppID, LicenseClassID, Applications.ApplicationID,
               Applications.ApplicantPersonID, Applications.ApplicationDate, Applications.ApplicationTypeID, Applications.ApplicationStatus, Applications.LastStatusDate, Applications.PaidFees, Applications.CreatedByUserID);
            }

            return null;
        }
        public static DataTable SearchByWord(string FilterBy, string Word)
        {
            return DVLD_Data_Access_Layer.clsLocalDrivingLicenseApplications.SearchByWord(FilterBy, Word);
        }
        public static int GetPersonIDByLocalDrivingLicenseID(int LocalDrivingLicenseApplicationID)
        {
            return DVLD_Data_Access_Layer.clsLocalDrivingLicenseApplications.GetPersonIDByLocalDrivingLicenseID(LocalDrivingLicenseApplicationID);
        }
        public bool SaveData()
        {
            base.Mode = (clsApplications.enMode)Mode;

            if (!base.SaveData())
                return false;

            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewLocalDrivingLicenseApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }


                case enMode.Update:

                    return UpdateLocalDrivingLicenseApplication();
            }

            return false;
        }


    }
}
