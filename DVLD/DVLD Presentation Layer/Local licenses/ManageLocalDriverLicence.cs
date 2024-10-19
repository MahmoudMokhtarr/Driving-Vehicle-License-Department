using DVLD_Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ManageLocalDriverLicence : Form
    {
        private int NumberCurrentTest = 0;

        public ManageLocalDriverLicence()
        {
            InitializeComponent();
            DTVLocalDrivingApplication.ClearSelection();

        }
        private void _ListLocalDriverLicence()
        {

            DTVLocalDrivingApplication.Rows.Clear();

            DataTable LDApplication = new DataTable();

            LDApplication = clsLocalDrivingLicenseApplications.LocalDrivingLicenseApplications_View();

            foreach (DataRow ApplicationRow in LDApplication.Rows)

            {
                DTVLocalDrivingApplication.Rows.Add(ApplicationRow["LocalDrivingLicenseApplicationID"],
                ApplicationRow["ClassName"], ApplicationRow["NationalNo"], ApplicationRow["FullName"],
                ApplicationRow["ApplicationDate"], ApplicationRow["PassedTestCount"], ApplicationRow["Status"]);
            }

        }
        private void _OpenFormTestAppointment()
        {
            int LDLAppID = int.Parse(DTVLocalDrivingApplication.CurrentRow.Cells[0].Value.ToString());
            VisionTestAppointments visionTest = new VisionTestAppointments(NumberCurrentTest, LDLAppID);
            visionTest.LoadData(LDLAppID);

            visionTest.ShowDialog();

        }
        private void LocalDriverLicence_Load(object sender, EventArgs e)
        {
            _ListLocalDriverLicence();
            
        }
        private void ScheduleVisionTest_Click(object sender, EventArgs e)
        {
            _OpenFormTestAppointment();
            _ListLocalDriverLicence();
        }
        private void ScheduleWrittenTest_Click(object sender, EventArgs e)
        {
            _OpenFormTestAppointment();
            _ListLocalDriverLicence();
        }
        private void ScheduleStreetTest_Click(object sender, EventArgs e)
        {
            _OpenFormTestAppointment();
            _ListLocalDriverLicence();
        }
        private void txbSearchByWord_TextChanged(object sender, EventArgs e)
        {
            if (txbSearchByWord.Text == "")
            {
                _ListLocalDriverLicence();
                return;
            }

            DataTable Licence = clsLocalDrivingLicenseApplications.SearchByWord(cobFilterLicence.Text, txbSearchByWord.Text);

            if (!Licence.HasErrors)
            {
                DTVLocalDrivingApplication.Rows.Clear();
            }

            foreach (DataRow Row in Licence.Rows)
            {

                DTVLocalDrivingApplication.Rows.Add(Row["LocalDrivingLicenseApplicationID"],
                Row["ClassName"], Row["NationalNo"], Row["FullName"],
                Row["ApplicationDate"], Row["PassedTestCount"], Row["Status"]);

            }
        }

        private void issueDrivingLicense_Click(object sender, EventArgs e)
        {

            int LDLAppID = int.Parse(DTVLocalDrivingApplication.CurrentRow.Cells[0].Value.ToString());
            string NationalNo = DTVLocalDrivingApplication.CurrentRow.Cells[2].Value.ToString();
            IssueDrivingLicenseFirstTime IssueDrivingLicense = new IssueDrivingLicenseFirstTime(LDLAppID, NationalNo);
            IssueDrivingLicense.LoadData();


            IssueDrivingLicense.ShowDialog();
            _ListLocalDriverLicence();

            if (DTVLocalDrivingApplication.CurrentRow.Cells[6].Value.ToString() == "Completed")
            {
                editApplication.Enabled = false;
                DeleteApplication.Enabled = false;
                cancelApplication.Enabled = false;
                SechduleTests.Enabled = false;

                ShowLinse.Enabled = true;
            }

        }

        private void btnAddNewLocalDrivingLicense_Click(object sender, EventArgs e)
        {
             NewLocalDrivingLicenseApplications LocalDrivingLicense = new NewLocalDrivingLicenseApplications();
            LocalDrivingLicense.ShowDialog();
            _ListLocalDriverLicence();
            this.Close();
        }

        private void ShowLinse_Click(object sender, EventArgs e)
        {
            string ClassName, FullName, NationalNo;

            ClassName = DTVLocalDrivingApplication.CurrentRow.Cells[1].Value.ToString();
            FullName = DTVLocalDrivingApplication.CurrentRow.Cells[3].Value.ToString();
            NationalNo = DTVLocalDrivingApplication.CurrentRow.Cells[2].Value.ToString();

            DriverLicenseInfo DriverLicense = new DriverLicenseInfo(ClassName, FullName, NationalNo);
            DriverLicense.ShowDialog();
        }

        private void DeleteApplication_Click(object sender, EventArgs e)
        {

            DialogResult Result = MessageBox.Show("Are You Sure You Want to Delete this Application?", "Confirm", MessageBoxButtons.YesNo);

            if (Result == DialogResult.Yes)
            {
                int LDLAppID = int.Parse(DTVLocalDrivingApplication.CurrentRow.Cells[0].Value.ToString());

                if (clsLocalDrivingLicenseApplications.DeleteLocalDrivingLicenseApplication(LDLAppID)) 
                {
                    MessageBox.Show("Application Delete Successfully", "Deleted", MessageBoxButtons.OK);
                    _ListLocalDriverLicence();

                }
            }

            }

        private void cancelApplication_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Are You Sure You Want to Cancel this Application?", "Confirm", MessageBoxButtons.YesNo);

            if (Result == DialogResult.Yes)
            {
                int LDLAppID = int.Parse(DTVLocalDrivingApplication.CurrentRow.Cells[0].Value.ToString());

                clsLocalDrivingLicenseApplications LocalDrivingLicense = clsLocalDrivingLicenseApplications.Find(LDLAppID);
                LocalDrivingLicense.ApplicationStatus = 2;
                LocalDrivingLicense.SaveData();

                MessageBox.Show("Application Cancelled Successfully", "Cancelled", MessageBoxButtons.OK);
                _ListLocalDriverLicence();

            }

        }

        private void DTVLocalDrivingApplication_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int Poos = clsTests.GetPassedTest(int.Parse(DTVLocalDrivingApplication.CurrentRow.Cells[0].Value.ToString()));

            if (Poos >= 3)
            {
                if (DTVLocalDrivingApplication.CurrentRow.Cells[6].Value.ToString() == "Completed")
                {

                    issueDrivingLicense.Enabled = true;
                    SechduleTests.Enabled = false;
                    editApplication.Enabled = false;
                    DeleteApplication.Enabled = false;
                    cancelApplication.Enabled = false;
                    ShowLinse.Enabled = true;

                }

                else
                {

                    editApplication.Enabled = true;
                    DeleteApplication.Enabled = true;
                    cancelApplication.Enabled = true;
                    SechduleTests.Enabled = true;

                    issueDrivingLicense.Enabled = false;
                    ShowLinse.Enabled = false;
                    showPersonLicenseHistory.Enabled = false;


                }


            }

            else
            {
                SechduleTests.Enabled = true;
                editApplication.Enabled = true;
                DeleteApplication.Enabled = true;
                cancelApplication.Enabled = true;

                ScheduleWrittenTest.Enabled = false;
                ScheduleStreetTest.Enabled = false;
                issueDrivingLicense.Enabled = false;
                ShowLinse.Enabled = false;
            }

            string NationalNo = DTVLocalDrivingApplication.CurrentRow.Cells[2].Value.ToString();
            int PersonID = clsPeople.GetPersonIDByNationalNo(NationalNo);
            if (clsDriver.IsLocalDrivingLicenseForDriverActive(PersonID))
            {

                issueDrivingLicense.Enabled = false;
            }

            switch (Poos)
            {
                case 0:
                    {
                        ScheduleWrittenTest.Enabled = false;
                        ScheduleStreetTest.Enabled = false;
                        ScheduleVisionTest.Enabled = true;
                        NumberCurrentTest = 1;
                        break;
                    }

                case 1:
                    {
                        ScheduleVisionTest.Enabled = false;
                        ScheduleStreetTest.Enabled = false;
                        NumberCurrentTest = 2;
                        ScheduleWrittenTest.Enabled = true;

                        break;
                    }

                case 2:
                    {
                        ScheduleWrittenTest.Enabled = false;
                        ScheduleVisionTest.Enabled = false;
                        NumberCurrentTest = 3;
                        ScheduleStreetTest.Enabled = true;


                        break;
                    }

                case 3:
                    {
                        ScheduleStreetTest.Enabled = false;
                        ScheduleWrittenTest.Enabled = false;
                        ScheduleVisionTest.Enabled = false;
                        issueDrivingLicense.Enabled = true;
                        break;

                    }

                default:

                    break;

            }

        }

        private void showPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            string NationalNo = DTVLocalDrivingApplication.CurrentRow.Cells[2].Value.ToString();
            int PersonID = clsPeople.GetPersonIDByNationalNo(NationalNo);

            LicenseHistory licenseHistory = new LicenseHistory(PersonID);
            licenseHistory.ShowDialog();
        }

        private void editApplication_Click(object sender, EventArgs e)
        {

        }

        private void ShowApplicationDetails_Click(object sender, EventArgs e)
        {
            int LDLAppID = int.Parse(DTVLocalDrivingApplication.CurrentRow.Cells[0].Value.ToString());
            ShowApplicationDetails showApplicationDetails = new ShowApplicationDetails(LDLAppID);
            showApplicationDetails.ShowDialog();

        }
    }
}
