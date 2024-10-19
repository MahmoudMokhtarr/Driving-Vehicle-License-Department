using System;
using DVLD_Business_Layer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DVLD
{
   
    public partial class NewInternationalLicenseApplicaiton : Form
    {
        int InternationalLicenseID = 0;
        string NationalNo = "";

        public static NewInternationalLicenseApplicaiton ILicenseApplicaiton;
        public NewInternationalLicenseApplicaiton()
        {
            InitializeComponent();
            ILicenseApplicaiton = this;
        }

        private bool VerifyingConditionsForIssuingInternationalLicence()
        {

            InternationalLicenseID = int.Parse(ctrSearchForLicenseInfoByID1.txbLicenseID.Text);

            clsLicense license = clsLicense.Find(InternationalLicenseID);

            if (clsInternationalDrivingLicense.IsDriverHasInternationalLicense(license.DriverID))
            {
                MessageBox.Show("Driver Has International License Active","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (license.LicenseClass != 3) 
            {
                MessageBox.Show("The local license must be category 3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!license.IsActive)
            {
                MessageBox.Show("local license Is Not Active", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            int result = DateTime.Compare(license.ExpirationDate, DateTime.Now);

            if (result < 0)
            {
                MessageBox.Show("The local license has expired. Please renew it and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        public void FillData(object sender)
        {

            clsApplicationTypes Application = clsApplicationTypes.Find(6);


            lblApplicationDateForApp.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblIssueDateForApp.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblFeesForApp.Text = Application.Fees.ToString();
            lblLocalLicenseIDForApp.Text = ctrSearchForLicenseInfoByID1.txbLicenseID.Text;
            lblExpirationDateForApp.Text = DateTime.Now.AddYears(1).ToString();
            lblCreatedByForApp.Text = GlobalSettings.User.UserID.ToString();

            
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you Sure You Want to Issue The License", "Confirm", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                if (VerifyingConditionsForIssuingInternationalLicence())
                {
                    clsApplications Application = new clsApplications();
                    Application.ApplicantPersonID = clsPeople.GetPersonIDByNationalNo(NationalNo);
                    Application.ApplicationDate = DateTime.Now;
                    Application.ApplicationTypeID = 6;
                    Application.ApplicationStatus = 1;
                    Application.LastStatusDate = DateTime.Now;
                    Application.PaidFees = clsApplicationTypes.Find(6).Fees;
                    Application.CreatedByUserID = GlobalSettings.User.UserID;

                    if (Application.SaveData())
                    {
                        lblILApplicationIDForApp.Text = Application.ApplicationID.ToString();

                        clsInternationalDrivingLicense IDrivingLicense = new clsInternationalDrivingLicense();
                        IDrivingLicense.ApplicationID = Application.ApplicationID;
                        IDrivingLicense.DriverID = clsDriver.GetDriverIDByPersonID(Application.ApplicantPersonID);
                        IDrivingLicense.IssuedUsingLocalLicenseID = InternationalLicenseID;
                        IDrivingLicense.IssueDate = DateTime.Now;
                        IDrivingLicense.ExpirationDate = DateTime.Now.AddYears(1);
                        IDrivingLicense.IsActive = true;
                        IDrivingLicense.CreatedByUserID = GlobalSettings.User.UserID;

                        if (IDrivingLicense.SaveData())
                        {
                            lblILLicenseIDForApp.Text = IDrivingLicense.InternationalLicenseID.ToString();

                            MessageBox.Show("International License Issued Successfully with ID = "+ IDrivingLicense.InternationalLicenseID, "License Issued", MessageBoxButtons.OK);

                            lblShowLicenseinfo.Enabled = true;
                        }

                    }
                }
            }


        }

        private void lblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clsLicense license = clsLicense.Find(int.Parse(ctrSearchForLicenseInfoByID1.txbLicenseID.Text));
           int PersonID = clsDriver.GetPersonIDByDriverID(license.DriverID);


            LicenseHistory licenseHistory = new LicenseHistory(PersonID);
            licenseHistory.ShowDialog();

        }

        private void lblShowLicenseinfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InternationalLicenseInfo licenseInfo = new InternationalLicenseInfo(int.Parse(lblILLicenseIDForApp.Text));
            licenseInfo.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewInternationalLicenseApplicaiton_Load(object sender, EventArgs e)
        {
            ctrSearchForLicenseInfoByID1.buttonSearch_Click1 += FillData;
            
        }
    }
}
