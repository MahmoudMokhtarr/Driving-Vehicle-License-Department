using System;
using DVLD_Business_Layer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Properties;

namespace DVLD
{
    public partial class ScheduleTest : Form
    {
        int LDLAppID = 0;
        int NumberCurrentTest = 0;
        int AppointmentID = 0;
        public  bool IsRetakeTestActive = false;

        private void CheckModeTest()
        {
            switch (this.NumberCurrentTest)
            {
                case 1:
                    {
                        lblModeTestApplication.Text = "Vision Test Appointments";
                        imageTest.BackgroundImage = Resources.ImageVisionTest1;
                        imageTest.BackgroundImageLayout = ImageLayout.Center;
                        break;
                    }

                case 2:
                    {
                        lblModeTestApplication.Text = "Written Test Appointments";
                        imageTest.BackgroundImage = Resources.ImageWriteTest;
                        imageTest.BackgroundImageLayout = ImageLayout.Center;
                        break;
                    }
                case 3:
                    {
                        lblModeTestApplication.Text = "Street Test Appointments";
                        imageTest.BackgroundImage = Resources.Imagestreettest;
                        imageTest.BackgroundImageLayout = ImageLayout.Center;
                        break;
                    }
            }
        }
        private void ModeForm()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        FillDate(enMode.AddNew);
                        break;
                    }

                case enMode.Update:
                    {

                        FillDate(enMode.Update);
                        break;

                    }
            }

        }

        private void CheckIsRetakeTestActive()
        {
            if (IsRetakeTestActive)
            {
                clsTestAppointments Appointment = clsTestAppointments.GetDataAppointment(AppointmentID);
                int RetakeTestApplicationID = clsTestAppointments.GetRetakeTestApplicationID(Appointment.TestAppointmentID);

                lblRTestAppIDForApp.Text = RetakeTestApplicationID.ToString();

                lblRAppFeesForApp.Text = 5.ToString();

                double TotalFees = Convert.ToDouble(lblRAppFeesForApp.Text);
                TotalFees += Convert.ToDouble(lblFeesForApp.Text);
                
                lblTotalFeesForApp.Text = TotalFees.ToString();

            }
        }

        private void FillDate(enMode Mode)
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        clsLocalDrivingLicenseApplications LDLAppliciton = clsLocalDrivingLicenseApplications.Find(LDLAppID);
                        lblDLAppIDForApp.Text = LDLAppID.ToString();
                        lblDClassForApp.Text = clsLicenseClasses.GetLicenseClasName(LDLAppliciton.LicenseClassID);
                        lblNameForApp.Text = clsPeople.GetFullNameByPersonID(LDLAppliciton.ApplicantPersonID);
                        lblTrialForApp.Text = clsTestAppointments.CountTrialTest(LDLAppID, NumberCurrentTest).ToString();
                        lblFeesForApp.Text = Convert.ToInt32( clsTestTypes.GetTestFeesByTestType(NumberCurrentTest)).ToString();

                        if (IsRetakeTestActive)
                        {
                            CheckIsRetakeTestActive();
                        }

                        break;
                    }

                case enMode.Update:
                    {

                        clsLocalDrivingLicenseApplications LDLAppliciton = clsLocalDrivingLicenseApplications.Find(LDLAppID);
                        dateTimePicker1.Value = LDLAppliciton.ApplicationDate;
                        lblDLAppIDForApp.Text = LDLAppID.ToString();
                        lblDClassForApp.Text = clsLicenseClasses.GetLicenseClasName(LDLAppliciton.LicenseClassID);
                        lblNameForApp.Text = clsPeople.GetFullNameByPersonID(LDLAppliciton.ApplicantPersonID);
                        lblTrialForApp.Text = clsTestAppointments.CountTrialTest(LDLAppID, NumberCurrentTest).ToString();
                        lblFeesForApp.Text = clsTestTypes.GetTestFeesByTestType(NumberCurrentTest).ToString();

                        clsTestAppointments Appointment = clsTestAppointments.GetDataAppointment(AppointmentID);

                        dateTimePicker1.Value = Appointment.AppointmentDate;

                        if (IsRetakeTestActive)
                        {
                            CheckIsRetakeTestActive();
                        }

                        break;

                    }
            }



        }
        private void SaveData(enMode Mode)
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        if (IsRetakeTestActive)
                        {
                            clsApplications Application = new clsApplications();
                            Application.ApplicantPersonID = clsLocalDrivingLicenseApplications.GetPersonIDByLocalDrivingLicenseID(LDLAppID);
                            Application.ApplicationDate = DateTime.Now;
                            Application.ApplicationTypeID = 7;
                            Application.ApplicationStatus = 1;
                            Application.LastStatusDate = DateTime.Now;
                            Application.PaidFees = 5;
                            Application.CreatedByUserID = GlobalSettings.User.UserID;

                            if (Application.SaveData())
                            {
                                clsTestAppointments Appointment = new clsTestAppointments();
                                Appointment.TestTypeID = NumberCurrentTest;
                                Appointment.LocalDrivingLicenseApplicationID = LDLAppID;
                                Appointment.AppointmentDate = dateTimePicker1.Value;
                                Appointment.PaidFees = decimal.Parse(lblFeesForApp.Text);
                                Appointment.CreatedByUserID = GlobalSettings.User.UserID;
                                Appointment.RetakeTestApplicationID = Application.ApplicationID;

                                if (Appointment.SaveData(clsTestAppointments.enMode.AddNew))
                                {
                                    DialogResult Result = MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK);

                                    if (Result == DialogResult.OK)
                                    {
                                        this.Close();
                                        return;
                                    }
                                }

                            }
                        }


                        clsTestAppointments Appointment1 = new clsTestAppointments();
                        Appointment1.TestTypeID = NumberCurrentTest;
                        Appointment1.LocalDrivingLicenseApplicationID = LDLAppID;
                        Appointment1.AppointmentDate = dateTimePicker1.Value;
                        Appointment1.PaidFees = decimal.Parse(lblFeesForApp.Text);
                        Appointment1.CreatedByUserID = GlobalSettings.User.UserID;

                        if (Appointment1.SaveData(clsTestAppointments.enMode.AddNew))
                        {
                            DialogResult Result = MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK);

                            if (Result == DialogResult.OK)
                            {
                                this.Close();
                            }
                        }

                        break;
                    }

                case enMode.Update:
                    {
                        clsTestAppointments Appointment = clsTestAppointments.GetDataAppointment(AppointmentID);

                        Appointment.AppointmentDate = dateTimePicker1.Value;

                        dateTimePicker1.Text = Appointment.AppointmentDate.ToString();


                        if (Appointment.SaveData(clsTestAppointments.enMode.Update))
                        {
                            DialogResult Result = MessageBox.Show("Data Update Successfully", "Saved", MessageBoxButtons.OK);

                            if (Result == DialogResult.OK)
                            {
                                this.Close();
                            }
                        }


                        break;

                    }
            }

        }
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public ScheduleTest(int NumberCurrentTest, int LDLAppID, int AppointmentID)
        {
            InitializeComponent();
            this.LDLAppID = LDLAppID;
            this.NumberCurrentTest = NumberCurrentTest;
            this.AppointmentID = AppointmentID;
        }
        private void ScheduleTest_Load(object sender, EventArgs e)
        {
            ModeForm();
            CheckModeTest();
        }
        private void btnSaveData_Click(object sender, EventArgs e)
        {

            SaveData(Mode);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
