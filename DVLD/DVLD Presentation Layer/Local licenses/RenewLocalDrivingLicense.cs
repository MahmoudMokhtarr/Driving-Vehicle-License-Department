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
    public partial class RenewLocalDrivingLicense : Form
    {
        private int LicenseID = 0;
        private int PersonID = 0;
        public RenewLocalDrivingLicense()
        {
            InitializeComponent();
        }

        private void RenewLocalDrivingLicense_Load(object sender, EventArgs e)
        {

            ctrSearchForLicenseInfoByID1.buttonSearch_Click1 += btnSearch_Click_1;
            ctrSearchForLicenseInfoByID1.buttonSearch_Click1 += FillData;


        }

        private void btnSearch_Click_1(object sender)
        {
            if (clsLicense.IsExpiredDataForLicense(LicenseID))
            {
                return;
            }
            else
            {
                clsLicense clsLicense = clsLicense.Find(LicenseID);
                btnRenew.Enabled = true;
                MessageBox.Show("Selected License is not yet expiared, it will expire on "+clsLicense.ExpirationDate, "Not allowed");
            }
        }

        public void FillData(object sender)
        {

            clsLicense Licens = clsLicense.Find(int.Parse(ctrSearchForLicenseInfoByID1.txbLicenseID.Text));
            clsLicenseClasses LicenseClasse = clsLicenseClasses.Find(Licens.LicenseClass);

            LicenseID = int.Parse(ctrSearchForLicenseInfoByID1.txbLicenseID.Text);

            lblApplicationDateForApp.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblIssueDateForApp.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblApplicationFeesForApp.Text = "7";
            lblLicenseFeesForApp.Text = Convert.ToInt32(LicenseClasse.ClassFees).ToString();
            lblOldLicenseIDForApp.Text = LicenseID.ToString();
            lblExpirationDateForApp.Text = DateTime.Now.AddYears(LicenseClasse.DefaultValidityLength).ToString("dd-MM-yyyy");
            lblCreatedByForApp.Text = GlobalSettings.User.UserName;
            int TotalFees = int.Parse(lblApplicationFeesForApp.Text) + int.Parse(lblLicenseFeesForApp.Text);
            lblTotalFeesForApp.Text = TotalFees.ToString();
        }

        public void SaveData()
        {
            clsLicense OldLicense = clsLicense.Find(LicenseID);
            clsLicenseClasses LicenseClasse = clsLicenseClasses.Find(OldLicense.LicenseClass);

            DialogResult result = MessageBox.Show("Are you sure you want to Renew the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

            clsApplications Applications = new clsApplications();
            Applications.ApplicantPersonID = clsDriver.GetPersonIDByDriverID(OldLicense.DriverID);
            Applications.ApplicationDate = DateTime.Now;
            Applications.ApplicationTypeID = 2;
            Applications.ApplicationStatus = 1;
            Applications.LastStatusDate = DateTime.Now;
            Applications.PaidFees = 7;
            Applications.CreatedByUserID = GlobalSettings.User.UserID;

                if (Applications.SaveData())
                {
                    clsLicense License = new clsLicense();
                    License.ApplicationID = Applications.ApplicationID;
                    License.DriverID = OldLicense.DriverID;
                    License.LicenseClass = OldLicense.LicenseClass;
                    License.IssueDate = DateTime.Now;
                    License.ExpirationDate = License.IssueDate.AddYears(LicenseClasse.DefaultValidityLength);
                    License.Notes = txbNotes.Text;
                    License.PaidFees = LicenseClasse.ClassFees;
                    License.IsActive = true;
                    License.IssueReason = 1;
                    License.CreatedByUserID = GlobalSettings.User.UserID;

                    if (License.SaveData())
                    {

                        if (OldLicense != null)
                        {
                            OldLicense.IsActive = false;

                            if (OldLicense.SaveData())
                            {
                                lblRLApplicationIDForApp.Text = License.LicenseID.ToString();
                                lblRenewedLicenseIDForApp.Text = License.ApplicationID.ToString();
                                LicenseID = License.LicenseID;
                                lblShowLicenseinfo.Enabled = true;

                                MessageBox.Show("Licensed Renewed Successfully with ID = " + License.LicenseID, "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }

            else
            {
                return;
            }



        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void lblShowLicenseinfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LocalLicenseInfo licenseInfo = new LocalLicenseInfo(LicenseID);
            licenseInfo.ShowDialog();
        }

        private void lblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clsLicense license = clsLicense.Find(LicenseID);
            PersonID = clsDriver.GetPersonIDByDriverID(license.DriverID);
            LicenseHistory licenseHistory = new LicenseHistory(PersonID);
            licenseHistory.ShowDialog();

        }
    }
}
