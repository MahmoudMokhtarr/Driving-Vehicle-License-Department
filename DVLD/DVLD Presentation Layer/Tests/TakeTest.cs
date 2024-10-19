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

namespace DVLD
{
    public partial class TakeTest : Form
    {
        int LDLAppID = 0;
        int NumberCurrentTest = 0;
        int  AppointmentID = 0;

        public TakeTest(int NumberCurrentTest, int LDLAppID, int AppointmentID)
        {
            InitializeComponent();

            this.LDLAppID = LDLAppID;
            this.NumberCurrentTest = NumberCurrentTest;
            this.AppointmentID = AppointmentID;

        }

        public void FillData()
        {

            clsLocalDrivingLicenseApplications LDLAppliciton = clsLocalDrivingLicenseApplications.Find(LDLAppID);
            lblDLAppIDForApp.Text = LDLAppID.ToString();
            lblDClassForApp.Text = clsLicenseClasses.GetLicenseClasName(LDLAppliciton.LicenseClassID);
            lblNameForApp.Text = clsPeople.GetFullNameByPersonID(LDLAppliciton.ApplicantPersonID);
            lblTrialForApp.Text  = clsTestAppointments.CountTrialTest(LDLAppID, NumberCurrentTest).ToString();
            lblFeesForApp.Text = Convert.ToInt32(clsTestTypes.GetTestFeesByTestType(NumberCurrentTest)).ToString();

            clsTestAppointments Appointment = clsTestAppointments.GetDataAppointment( AppointmentID);

            lblDateForApp.Text = Appointment.AppointmentDate.ToString("dd-MM-yyyy");

        }
        private void CheckModeTest()
        {
            switch (this.NumberCurrentTest)
            {
                case 1:
                    {
                        lblModeTestApplication.Text = "Vision Test Appointments";
                        break;
                    }

                case 2:
                    {
                        lblModeTestApplication.Text = "Written Test Appointments";
                        break;
                    }
                case 3:
                    {
                        lblModeTestApplication.Text = "Street Test Appointments";
                        break;
                    }
            }
        }

        private void TakeTest_Load(object sender, EventArgs e)
        {
            FillData();
            CheckModeTest();
        }

        private void SaveData()
        {
            if (RBPass.Checked == true || RBFail.Checked == true)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to save? After that you cannot change the Pass/Fail results after you save?", "Confirm", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    clsTests tests = new clsTests();
                    clsTestAppointments Appointment =  clsTestAppointments.GetDataAppointment(AppointmentID);

                    Appointment.IsLocked = true;

                    tests.TestAppointmentID = Appointment.TestAppointmentID;
                    tests.Notes = txbNots.Text;
                    tests.CreatedByUserID = Appointment.CreatedByUserID;

                    tests.TestResult = (RBPass.Checked == true) ? tests.TestResult = true : tests.TestResult = false;

                    if (tests.SaveData() && Appointment.SaveData(clsTestAppointments.enMode.Update))
                    {
                        MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK);
                        this.Close();
                    }
                }

                else
                {
                    return;
                }

            }

        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {


            SaveData();



        }
    }
}
