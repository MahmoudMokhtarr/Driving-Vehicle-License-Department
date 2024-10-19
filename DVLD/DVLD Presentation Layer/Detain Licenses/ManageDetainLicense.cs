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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD
{
    public partial class ManageDetainLicense : Form
    {
        public ManageDetainLicense()
        {
            InitializeComponent();
        }

        private void ListDetainLicenses()
        {
            DataTable LDLicense = new DataTable();

            LDLicense = clsDetainLicense.ListDetainedLicenses();

            if (LDLicense != null)
            {
            foreach (DataRow DetainLicenseRow in LDLicense.Rows)
                {
                    DTVManageDetainLicense.Rows.Add(DetainLicenseRow["DetainID"], DetainLicenseRow["LicenseID"],
                     DetainLicenseRow["DetainDate"], DetainLicenseRow["IsReleased"], DetainLicenseRow["FineFees"],
                     DetainLicenseRow["ReleaseDate"], DetainLicenseRow["NationalNo"], DetainLicenseRow["FullName"],
                     DetainLicenseRow["ReleaseApplicationID"]);
                }
            }
        }

        private void ManageDetainLicense_Load(object sender, EventArgs e)
        {
            ListDetainLicenses();
        }

        private void showPersonDetails_Click(object sender, EventArgs e)
        {
            int PersonID = clsPeople.GetPersonIDByNationalNo(DTVManageDetainLicense.CurrentRow.Cells[6].Value.ToString());
            PersonDetails PersonDetails = new PersonDetails(PersonID);
            PersonDetails.ShowDialog();

        }

        private void showLicenseDetails_Click(object sender, EventArgs e)
        {

            LocalLicenseInfo licenseInfo = new LocalLicenseInfo(int.Parse(DTVManageDetainLicense.CurrentRow.Cells[1].Value.ToString()));

            licenseInfo.ShowDialog();

        }

        private void showPersonLicenseHistory_Click(object sender, EventArgs e)
        {

            clsLicense license = clsLicense.Find(int.Parse(DTVManageDetainLicense.CurrentRow.Cells[1].Value.ToString()));
            int PersonID = clsDriver.GetPersonIDByDriverID(license.DriverID);
            LicenseHistory licenseHistory = new LicenseHistory(PersonID);
            licenseHistory.ShowDialog();

        }

        private void ReleaseDetainedLicenses_Click(object sender, EventArgs e)
        {
            ReleaseDetainLicenses ReleaseDetain = new ReleaseDetainLicenses();
            ReleaseDetain.ctrSearchForLicenseInfoByID1.txbLicenseID.Text = DTVManageDetainLicense.CurrentRow.Cells[1].Value.ToString();
            ReleaseDetain.ctrSearchForLicenseInfoByID1.txbLicenseID.Enabled = false;
            ReleaseDetain.btnSearch_Click(sender);
            ReleaseDetain.ShowDialog();
        }

        private void DTVManageDetainLicense_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToBoolean(DTVManageDetainLicense.CurrentRow.Cells[3].Value))
            {
                ReleaseDetainedLicenses.Enabled = true;
                return;
            }
            ReleaseDetainedLicenses.Enabled = false;
        }

        private void OpenFormReleaseLicenses_Click(object sender, EventArgs e)
        {
            ReleaseDetainLicenses RDLicenses = new ReleaseDetainLicenses();
            RDLicenses.ShowDialog();
        }

        private void OpenFormDetainLicenses_Click(object sender, EventArgs e)
        {
            DetaineLicence DetaineLicence = new DetaineLicence();
            DetaineLicence.ShowDialog();
        }

        private void txbSearchByWord_TextChanged(object sender, EventArgs e)
        {
            if (txbSearchByWord.Text == "")
            {
                ListDetainLicenses();
                return;
            }

            DataTable LDLicense = clsDetainLicense.SearchByWord(cobFilterDetainLicense.Text, txbSearchByWord.Text);

            if (!LDLicense.HasErrors)
            {
                DTVManageDetainLicense.Rows.Clear();
            }

            if (LDLicense != null)
            {
                foreach (DataRow DetainLicenseRow in LDLicense.Rows)
                {
                    DTVManageDetainLicense.Rows.Add(DetainLicenseRow["DetainID"], DetainLicenseRow["LicenseID"],
                     DetainLicenseRow["DetainDate"], DetainLicenseRow["IsReleased"], DetainLicenseRow["FineFees"],
                     DetainLicenseRow["ReleaseDate"], DetainLicenseRow["NationalNo"], DetainLicenseRow["FullName"],
                     DetainLicenseRow["ReleaseApplicationID"]);
                }
            }
        }

        private void cobFilterDetainLicense_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cobFilterDetainLicense.SelectedIndex == 1) 
            {
                txbSearchByWord.Visible = false;
            }
            txbSearchByWord.Visible = true;
        }
    }
}
