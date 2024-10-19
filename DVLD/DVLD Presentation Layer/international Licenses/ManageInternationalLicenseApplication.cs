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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD
{
    public partial class ManageInternationalLicenseApplication : Form
    {
        public ManageInternationalLicenseApplication()
        {
            InitializeComponent();
        }

        private void _ListInternationalDriverLicence()
        {
            DataTable IDApplication = new DataTable();
            IDApplication = clsInternationalDrivingLicense.ListInternationalLicense();

            foreach (DataRow ApplicationRow in IDApplication.Rows)
            {
                DTVInternationalDrivingApplication.Rows.Add(ApplicationRow["InternationalLicenseID"],
                ApplicationRow["ApplicationID"], ApplicationRow["DriverID"], ApplicationRow["IssuedUsingLocalLicenseID"],
                ApplicationRow["IssueDate"], ApplicationRow["ExpirationDate"], ApplicationRow["IsActive"]);
            }

        }

        private void ManageInternationalLicenseApplication_Load(object sender, EventArgs e)
        {
            _ListInternationalDriverLicence();
        }

        private void showPersonDetails_Click(object sender, EventArgs e)
        {
            int PersonID = clsDriver.GetPersonIDByDriverID(int.Parse(DTVInternationalDrivingApplication.CurrentRow.Cells[2].Value.ToString()));
            PersonDetails personDetails = new PersonDetails(PersonID);
            personDetails.ShowDialog();
        }

        private void showLicenseDetails_Click(object sender, EventArgs e)
        {
            int InternationalLicenseID = int.Parse(DTVInternationalDrivingApplication.CurrentRow.Cells[0].Value.ToString());
            InternationalLicenseInfo licenseInfo = new InternationalLicenseInfo(InternationalLicenseID);
            licenseInfo.ShowDialog();
        }

        private void showPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            int PersonID = clsDriver.GetPersonIDByDriverID(int.Parse(DTVInternationalDrivingApplication.CurrentRow.Cells[2].Value.ToString()));
            LicenseHistory licenseHistory = new LicenseHistory(PersonID);
            licenseHistory.ShowDialog();
        }
    }
}
