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
    public partial class ReplacementForDamagedOrLostLicenses : Form
    {
        private int LicenseID = 0;
        private int NewLicenseID = 0;
        public ReplacementForDamagedOrLostLicenses()
        {
            InitializeComponent();
        }
        private void ReplacementForDamagedOrLostLicenses_Load(object sender, EventArgs e)
        {
            ctrSearchForLicenseInfoByID1.buttonSearch_Click1 += btnSearch_Click;

        }

        private void FillData()
        {
            lblApplicationDateForApp.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblOldLicenseIDForApp.Text = LicenseID.ToString();
            lblCreatedByForApp.Text = GlobalSettings.User.UserName.ToString();
        }
        private void btnSearch_Click(object sender)
        {
            LicenseID = int.Parse(ctrSearchForLicenseInfoByID1.txbLicenseID.Text);

            if (!DVLD_Business_Layer.clsLicense.IsActiveLicense(LicenseID))
            {
                MessageBox.Show("Selected License is not Not Active, choose an active license", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                FillData();
            }
        }

        private void SaveData()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Replace the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {


                clsLicense OldLicense = clsLicense.Find(LicenseID);
                clsLicenseClasses LicenseClasse = clsLicenseClasses.Find(OldLicense.LicenseClass);
                clsLicense NewLicense = new clsLicense();
                clsApplications Application = new clsApplications();

                Application.ApplicantPersonID = clsDriver.GetPersonIDByDriverID(OldLicense.DriverID);
                Application.ApplicationDate = DateTime.Now;
                Application.ApplicationStatus = 1;
                Application.LastStatusDate = DateTime.Now;
                Application.CreatedByUserID = GlobalSettings.User.UserID;

                if (rbDamagedLicenses.Checked)
                {
                    Application.ApplicationTypeID = 3;
                    Application.PaidFees = clsApplicationTypes.Find(4).Fees;
                    NewLicense.IssueReason = 3;
                    btnReplacement.Enabled = true;
                }

                else if (rbLostLicenses.Checked)
                {
                    Application.ApplicationTypeID = 4;
                    Application.PaidFees = clsApplicationTypes.Find(3).Fees;
                    NewLicense.IssueReason = 4;

                    btnReplacement.Enabled = true;

                }

                if (Application.SaveData())
                {
                    NewLicense.ApplicationID = Application.ApplicationID;
                    NewLicense.DriverID = OldLicense.DriverID;
                    NewLicense.LicenseClass = OldLicense.LicenseClass;
                    NewLicense.IssueDate = DateTime.Now;
                    NewLicense.ExpirationDate = NewLicense.IssueDate.AddYears(LicenseClasse.DefaultValidityLength);
                    NewLicense.Notes = OldLicense.Notes;
                    NewLicense.PaidFees = LicenseClasse.ClassFees;
                    NewLicense.IsActive = true;
                    NewLicense.CreatedByUserID = GlobalSettings.User.UserID;

                    if (NewLicense.SaveData())
                    {
                        OldLicense.IsActive = false;

                        if (OldLicense.SaveData())
                        {
                            lblLRApplicationIDForApp.Text = Application.ApplicationID.ToString();
                            lblReplacedLicenseIDForApp.Text = NewLicense.LicenseID.ToString();
                            ctrSearchForLicenseInfoByID1.txbLicenseID.Enabled = false;
                            lblShowLicenseinfo.Enabled = true;
                            NewLicenseID = NewLicense.LicenseID;
                            MessageBox.Show("Licensed Replaced Successfully with ID = " + NewLicense.LicenseID, "License Replaced", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }
                }

            }
        }

        private void btnReplacement_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void rbDamagedLicenses_CheckedChanged(object sender, EventArgs e)
        {
            lblApplicationFeesForApp.Text = clsApplicationTypes.Find(4).Fees.ToString();
            btnReplacement.Enabled = true;

        }

        private void rbLostLicenses_CheckedChanged(object sender, EventArgs e)
        {
            lblApplicationFeesForApp.Text = clsApplicationTypes.Find(3).Fees.ToString();
            btnReplacement.Enabled = true;

        }

        private void lblShowLicenseinfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LocalLicenseInfo licenseInfo = new LocalLicenseInfo(NewLicenseID);
            licenseInfo.ShowDialog();

        }

        private void lblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clsLicense license = clsLicense.Find(NewLicenseID);
           int PersonID = clsDriver.GetPersonIDByDriverID(license.DriverID);
            LicenseHistory licenseHistory = new LicenseHistory(PersonID);
            licenseHistory.ShowDialog();

        }
    }
}
