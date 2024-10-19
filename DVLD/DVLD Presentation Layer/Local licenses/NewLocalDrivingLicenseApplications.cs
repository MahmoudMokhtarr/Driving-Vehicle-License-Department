using DVLD_Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class NewLocalDrivingLicenseApplications : Form
    {
        public NewLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }

        public int PersonID = 0;

        public enum enMode { AddNew = 0, Update = 1 };
        public static enMode Mode;
        public void ShowAllCountries()
        {
            DataTable LicenseClasse = DVLD_Business_Layer.clsLicenseClasses.ListLicenseClasses();

            foreach (DataRow Row in LicenseClasse.Rows)
            {
                cobLicenseClass.Items.Add(Row["ClassName"]);
            }
            cobLicenseClass.SelectedItem = "Class 3 - Ordinary driving license";
        }
        private void NewLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            ShowAllCountries();

            DateTime D = DateTime.Now;
            string DateTimeString = string.Format("{0:d/M/yyyy }", D);
            lblApplicationDateForLicance.Text = DateTimeString;
            lblCretatedByForLicance.Text = GlobalSettings.User.UserName;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            TcNewLocalDrivingLicenseApplication.SelectedIndex = 1;
            btnSaveDate.Enabled = true;
            PersonID = ctrPersonInfo.PersonID;
        }

        private bool ChackIsFeildsIsNull()
        {
            if (cobLicenseClass.SelectedItem == null)
            {
                return true;
            }

            if (ctrPersonInfo.PersonID == 0)
            {
                return true;
            }
            return false;
        }

        private void _SaveData()
        {

            if (ChackIsFeildsIsNull())
            {
                return;
            }

            int LicenseClassSelected = cobLicenseClass.SelectedIndex + 1;
            int ApplicationID = clsLocalDrivingLicenseApplications.IsLicenseClassDuplicatedForPerson(ctrPersonInfo.PersonID, LicenseClassSelected);
            if (ApplicationID > 0)
            {
                MessageBox.Show("The person has an active or completed request from  License Class, ID = " + ApplicationID,"Eroor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            {

            }
            if (Mode == enMode.AddNew) 
            {
                clsLocalDrivingLicenseApplications LocalDrivingLicense = new clsLocalDrivingLicenseApplications();

                LocalDrivingLicense.ApplicantPersonID = ctrPersonInfo.PersonID;
                LocalDrivingLicense.ApplicationDate = DateTime.Now;
                LocalDrivingLicense.ApplicationTypeID = 1;
                LocalDrivingLicense.ApplicationStatus = 1;
                LocalDrivingLicense.LastStatusDate = DateTime.Now;
                LocalDrivingLicense.PaidFees = 15;
                LocalDrivingLicense.CreatedByUserID = GlobalSettings.User.UserID;
                LocalDrivingLicense.LicenseClassID = cobLicenseClass.SelectedIndex + 1;

                if (LocalDrivingLicense.SaveData())
                {
                    MessageBox.Show("Data Saved Successfully");
                }

            }


        }

        private void btnSaveDate_Click(object sender, EventArgs e)
        {

            _SaveData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
