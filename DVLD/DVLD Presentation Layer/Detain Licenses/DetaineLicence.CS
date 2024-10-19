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
    public partial class DetaineLicence : Form
    {
        public int LicenseID = 0;
        public DetaineLicence()
        {
            InitializeComponent();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            LicenseID = int.Parse(ctrSearchForLicenseInfoByID1.txbLicenseID.Text);

            DialogResult result=MessageBox.Show("Are you sure you want to detain this license? ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                if (!clsDetainLicense.IsReleasedLicenses(LicenseID))
                {
                    MessageBox.Show("Selected License i already detained, choose another one", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                clsDetainLicense DetainLicense = new clsDetainLicense();

                DetainLicense.LicenseID = LicenseID;
                DetainLicense.DetainDate = DateTime.Now;

                if (string.IsNullOrWhiteSpace(txbApplicationFeesForApp.Text))
                {
                    return;
                }

                DetainLicense.FineFees = decimal.Parse(txbApplicationFeesForApp.Text);
                DetainLicense.CreatedByUserID = GlobalSettings.User.UserID;
                DetainLicense.IsReleased = false;


                if (DetainLicense.SaveData() )
                {
                    MessageBox.Show("License Detained Successfully with ID " + DetainLicense.DetainID.ToString(), "License Detained", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblShowLicenseinfo.Enabled = true;
                }
            }

        }

        private void txbApplicationFeesForApp_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbApplicationFeesForApp.Text))
            {
                errorProvider.SetError(txbApplicationFeesForApp, "Field Fees Is Required");
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
