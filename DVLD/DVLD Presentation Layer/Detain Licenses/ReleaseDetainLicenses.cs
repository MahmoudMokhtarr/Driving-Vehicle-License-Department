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
    public partial class ReleaseDetainLicenses : Form
    {
        public int LicenseID = 0;

        public ReleaseDetainLicenses()
        {
            InitializeComponent();
        }

        private void ReleaseDetainLicenses_Load(object sender, EventArgs e)
        {
            ctrSearchForLicenseInfoByID1.buttonSearch_Click1 += btnSearch_Click;
        }

        public void btnSearch_Click(object sender)
        {
            LicenseID = int.Parse(ctrSearchForLicenseInfoByID1.txbLicenseID.Text);

            if (clsDetainLicense.IsReleasedLicenses(LicenseID))
            {
                MessageBox.Show("Selected License Is Not Detain, choose another one", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FillData();
        }

        private void FillData()
        {
            clsDetainLicense DetainLicense = clsDetainLicense.Find(LicenseID);
            if (DetainLicense != null)
            {
                int FeesForApp = decimal.ToInt32(clsApplicationTypes.Find(5).Fees);
                int DetainFineFees = decimal.ToInt32(DetainLicense.FineFees);        
                int TotalFees = FeesForApp + DetainFineFees;
                
                lblDetainIDForApp.Text = DetainLicense.DetainID.ToString();
                lblDatineDateForApp.Text= DetainLicense.DetainDate.ToString();
                lblApplicationFeesForApp.Text = FeesForApp.ToString();
                lblILLicenseIDForApp.Text = LicenseID.ToString();
                lblCreatedByForApp.Text = GlobalSettings.User.UserID.ToString();
                lblDatineFeesForApp.Text = DetainFineFees.ToString();
                lblTotalFeesForApp.Text = TotalFees.ToString();

            }
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {

            DialogResult Result = MessageBox.Show("Are you sure you want to release this detained license?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (Result == DialogResult.OK)
            {
            int PersonID = clsDriver.GetPersonIDByDriverID(clsLicense.Find(LicenseID).DriverID);

            clsApplications Application = new clsApplications();

            Application.ApplicantPersonID = PersonID;
            Application.ApplicationDate = DateTime.Now;
            Application.ApplicationTypeID = 5;
            Application.ApplicationStatus = 1;
            Application.LastStatusDate = DateTime.Now;
            Application.PaidFees = clsApplicationTypes.Find(5).Fees;
            Application.CreatedByUserID = GlobalSettings.User.UserID;

                if (Application.SaveData())
                {
                    clsDetainLicense DetainLicense = clsDetainLicense.Find(LicenseID);
                    DetainLicense.IsReleased = true;
                    DetainLicense.ReleaseDate = DateTime.Now;
                    DetainLicense.ReleasedByUserID = GlobalSettings.User.UserID;
                    DetainLicense.ReleaseApplicationID = Application.ApplicationID;

                    if (DetainLicense.SaveData())
                    {
                        MessageBox.Show("Detained License released Successfully", "Detained License Released", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblShowLicenseinfo.Enabled = true;
                        lblApplicationIDForApp.Text = Application.ApplicationID.ToString();
                    }
                }
            }
        }

        private void lblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clsLicense license = clsLicense.Find(LicenseID);
            int PersonID = clsDriver.GetPersonIDByDriverID(license.DriverID);

            LicenseHistory licenseHistory = new LicenseHistory(PersonID);
            licenseHistory.ShowDialog();

        }

        private void lblShowLicenseinfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LocalLicenseInfo licenseInfo = new LocalLicenseInfo(LicenseID);
            licenseInfo.ShowDialog();

        }
    }
}

