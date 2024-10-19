using DVLD_Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class IssueDrivingLicenseFirstTime : Form
    {
        int LocalDrivingLicenseApplicationID = 0;
        string NationalNo = "";

        public IssueDrivingLicenseFirstTime(int LDLAppID,string NationalNo="")
        {
            InitializeComponent();
            this.LocalDrivingLicenseApplicationID= LDLAppID;
            this.NationalNo = NationalNo;
        }

        public void LoadData()
        {
            ctrDrivingApplicationInfo1.LoadData(LocalDrivingLicenseApplicationID);

        }

        private void SaveData()
        {
            clsLocalDrivingLicenseApplications LocalDrivingLicense = clsLocalDrivingLicenseApplications.Find(LocalDrivingLicenseApplicationID);
            clsLicenseClasses LicenseClasse = clsLicenseClasses.Find(LocalDrivingLicense.LicenseClassID);

            clsPeople Person = clsPeople.Find(clsPeople.GetPersonIDByNationalNo(NationalNo));
            int Age = DateTime.Now.Year - Person.DateOfBirth.Year;

            if (Age < LicenseClasse.DefaultValidityLength)
            {
                MessageBox.Show("The age of this person is younger than the permissible limit for issuing licenses", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsDriver.IsDriverExistByPersonID(clsPeople.GetPersonIDByNationalNo(NationalNo)))
            {
                clsDriver driver = clsDriver.Find(clsPeople.GetPersonIDByNationalNo(NationalNo));
                clsLicense License = new clsLicense();
                License.ApplicationID = LocalDrivingLicense.ApplicationID;
                License.DriverID = driver.DriverID;
                License.LicenseClass = LocalDrivingLicense.LicenseClassID;
                License.IssueDate = DateTime.Now;
                License.ExpirationDate = License.IssueDate.AddYears(LicenseClasse.DefaultValidityLength);
                License.Notes = txbNotes.Text;
                License.PaidFees = LicenseClasse.ClassFees;
                License.IsActive = true;
                License.IssueReason = 1;
                License.CreatedByUserID = GlobalSettings.User.UserID;

                if (License.SaveData())
                {
                    clsApplications Application = new clsApplications(LocalDrivingLicense.ApplicationID, LocalDrivingLicense.ApplicantPersonID,
                    LocalDrivingLicense.ApplicationDate, LocalDrivingLicense.ApplicationTypeID, 3, DateTime.Now, LocalDrivingLicense.PaidFees, LocalDrivingLicense.CreatedByUserID);

                    if (Application.SaveData())
                    {
                        MessageBox.Show("License Issued Successfully with License ID = " + License.LicenseID, "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                return;
            }

            clsDriver Driver = new clsDriver();

            Driver.PersonID = LocalDrivingLicense.ApplicantPersonID;
            Driver.CreatedDate = DateTime.Now;
            Driver.CreatedByUserID = GlobalSettings.User.UserID;

            if (Driver.SaveData())
            {
                clsLicense License = new clsLicense();
                License.ApplicationID = LocalDrivingLicense.ApplicationID;
                License.DriverID = Driver.DriverID;
                License.LicenseClass = LocalDrivingLicense.LicenseClassID;
                License.IssueDate = DateTime.Now;
                License.ExpirationDate = License.IssueDate.AddYears(LicenseClasse.DefaultValidityLength);
                License.Notes = txbNotes.Text;
                License.PaidFees = LicenseClasse.ClassFees;
                License.IsActive = true;
                License.IssueReason = 1;
                License.CreatedByUserID = GlobalSettings.User.UserID;

                if (License.SaveData())
                {
                    clsApplications Application = new clsApplications(LocalDrivingLicense.ApplicationID, LocalDrivingLicense.ApplicantPersonID,
                    LocalDrivingLicense.ApplicationDate, LocalDrivingLicense.ApplicationTypeID, 3, DateTime.Now, LocalDrivingLicense.PaidFees, LocalDrivingLicense.CreatedByUserID);

                    if (Application.SaveData())
                    {
                        MessageBox.Show("Succeeded", "License Issued Successfully with License ID = " + License.LicenseID, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }

        }
        private void btnIssueDrivingLicense_Click(object sender, EventArgs e)
        {

            SaveData();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
