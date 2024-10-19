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
    public partial class VisionTestAppointments : Form
    {
        int NumberCurrentTest = 0;
        int LDLAppID = 0;
        
        public VisionTestAppointments(int NumberCurrentTest, int LDLAppID = 0)
        {
            InitializeComponent();
            this.NumberCurrentTest = NumberCurrentTest;
            this.LDLAppID = LDLAppID;
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
        private void FillDataGridView()
        {
            DTGAppointments.Rows.Clear();
            
            DataTable Appointment = clsTestAppointments.ListAppointment(LDLAppID, NumberCurrentTest);

            if (Appointment == null)
            {
                return;
            }

            foreach (DataRow AppointmentRow in Appointment.Rows)
            {

                DTGAppointments.Rows.Add(AppointmentRow["TestAppointmentID"], AppointmentRow["AppointmentDate"],
                 AppointmentRow["PaidFees"], AppointmentRow["IsLocked"]);

            }
            SelectLastRow();
        }
        private void SelectLastRow()
        {
            if (DTGAppointments.Rows.Count > 0)
            {
                int lastRowIndex = DTGAppointments.Rows.Count - 1;
                DTGAppointments.Rows[lastRowIndex].Selected = true;
                DTGAppointments.CurrentCell = DTGAppointments.Rows[lastRowIndex].Cells[0];
            }
        }
        public void LoadData(int LocalDrivingLicenseApplicationID)
        {
            ctrDrivingApplicationInfo1.LoadData(LocalDrivingLicenseApplicationID);
        }
        private void VisionTestAppointments_Load(object sender, EventArgs e)
        {
            CheckModeTest();
            FillDataGridView();
        }
        private void btnAddDate_Click(object sender, EventArgs e)
        {
            int AppointmentID = 0;

            if (DTGAppointments.Rows.Count > 0)
            {
                AppointmentID = int.Parse(DTGAppointments.CurrentRow.Cells[0].Value.ToString());
                clsTestAppointments Appointment = clsTestAppointments.GetDataAppointment(AppointmentID);

                if (!clsTestAppointments.IsLockedAppointment(AppointmentID))
                {
                    MessageBox.Show("Person Already have an active appointment for this test, You cannot add new appointment", "Not allowed", MessageBoxButtons.OK);
                    return;
                }

                else
                {
                    if (clsTests.TestAppointmentResult(Appointment.TestAppointmentID))
                    {
                        MessageBox.Show("This person already passed this test before, you can only retake faild test", "Not allowed", MessageBoxButtons.OK);
                        return;
                    }

                    else
                    {
                        ScheduleTest scheduleTest1 = new ScheduleTest(NumberCurrentTest, LDLAppID, AppointmentID);
                        scheduleTest1.IsRetakeTestActive = true;
                        scheduleTest1.RetakeTest.Enabled = true;
                        scheduleTest1.ShowDialog();
                        FillDataGridView();
                        return;

                    }

                }
            }

            ScheduleTest ScheduleTest = new ScheduleTest(NumberCurrentTest, LDLAppID, AppointmentID);
            ScheduleTest.ShowDialog();
            FillDataGridView();

        }
        private void EditAppointment_Click(object sender, EventArgs e)
        {
            int AppointmentID = int.Parse(DTGAppointments.CurrentRow.Cells[0].Value.ToString());
            ScheduleTest scheduleTest = new ScheduleTest(NumberCurrentTest, LDLAppID, AppointmentID);

            scheduleTest.Mode = ScheduleTest.enMode.Update;

            if (clsTestAppointments.IsLockedAppointment(AppointmentID))
            {
                clsTestAppointments Appointment1 = clsTestAppointments.GetDataAppointment(AppointmentID);

                if (!clsTests.TestAppointmentResult(Appointment1.TestAppointmentID))
                {
                    scheduleTest.IsRetakeTestActive = true;
                    scheduleTest.RetakeTest.Enabled = true;
                }

                scheduleTest.dateTimePicker1.Visible = false;
                scheduleTest.btnSaveData.Visible = false;
                scheduleTest.lblDateForApp.Visible = true;
                scheduleTest.lblDateForApp.Text = Appointment1.AppointmentDate.ToString("dd-MM-yyyy");
                scheduleTest.ShowDialog();
                FillDataGridView();
                return;
            }

            if (clsTestAppointments.IsApplicationIsRetakeTest(AppointmentID)) 
            {
                scheduleTest.IsRetakeTestActive = true;
                scheduleTest.RetakeTest.Enabled = true;
                scheduleTest.ShowDialog();
                FillDataGridView();
                return;
            }


            else
            {
                ScheduleTest scheduleTest1 = new ScheduleTest(NumberCurrentTest, LDLAppID,AppointmentID);
                scheduleTest1.ShowDialog();
                FillDataGridView();
                return;

            }


        }
        private void TakeTest_Click(object sender, EventArgs e)
        {
            int AppointmentID = int.Parse(DTGAppointments.CurrentRow.Cells[0].Value.ToString());

            TakeTest takeTest = new TakeTest(NumberCurrentTest, LDLAppID, AppointmentID);
            takeTest.ShowDialog();
            DTGAppointments.Rows.Clear();
            FillDataGridView();
        }
    }
}
