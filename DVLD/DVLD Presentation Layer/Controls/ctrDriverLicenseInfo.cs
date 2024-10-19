using DVLD.Properties;
using DVLD_Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrDriverLicenseInfo : UserControl
    {
        public string ClassName, FullName, NationalNo;
        public int DriverID;

        public ctrDriverLicenseInfo()
        {
            InitializeComponent();


        }

        public void GetImagePathPerson(int PersonID)
        {
            string ImagePath = clsPeople.GetImagePathPerson(PersonID);

            if (ImagePath == "")
            {
                PBDriverImage.Image = Resources.تصميم_بدون_عنوان__19_;
            }

            else
            {
                this.Controls.Remove(PBDriverImage);

                System.Drawing.Image image = System.Drawing.Image.FromFile(ImagePath);
                PBDriverImage.Image = image;

            }

        }

        private void _FillData()
        {
            int PersonID = clsPeople.GetPersonIDByNationalNo(NationalNo);
            string outputNumbers = Regex.Replace(ClassName, "[^0-9]", "");
            int LicenseClassID = int.Parse(outputNumbers);
            DriverID = clsDriver.GetDriverIDByPersonID(PersonID);
            clsLicense License = clsLicense.DriverLicenseInfo(DriverID, LicenseClassID);

            lblClassForApp.Text = ClassName;
            lblNameForApp.Text = FullName;
            lblLicenseIDForApp.Text = License.LicenseID.ToString();
            lblNationalNoForApp.Text = NationalNo;
            lblGendorForApp.Text = clsPeople.Find(PersonID).Gendor;
            lblIssueDateForApp.Text = License.IssueDate.ToString("dd/M/yyyy");
            switch (License.IssueReason)
            {
                case 1:
                    lblIssueReasonForApp.Text = "FirstTime";
                    break;

                case 2:
                    lblIssueReasonForApp.Text = "Renew";
                    break;

                case 3:
                    lblIssueReasonForApp.Text = "Replacement for Damaged";
                    break;

                case 4:
                    lblIssueReasonForApp.Text = "Replacement for Lost";
                    break;


            }
            lblNotesForApp.Text = (License.Notes == "") ? lblNotesForApp.Text = "No Nots" : License.Notes;
            lblIsActiveForApp.Text = (License.IsActive == true) ? lblIsActiveForApp.Text = "Yes" : lblIsActiveForApp.Text = "No";
            lblDateOfBirthForApp.Text = clsPeople.Find(PersonID).DateOfBirth.ToString("dd/M/yyyy");
            lblDriverIDForApp.Text = License.DriverID.ToString();
            lblExpirationDateForApp.Text = License.ExpirationDate.ToString("dd/M/yyyy");
            lblIsDetainedForApp.Text = (clsDetainLicense.Find(License.LicenseID).IsReleased == true) ? lblIsDetainedForApp.Text = "No" : lblIsDetainedForApp.Text = "Yes";

            GetImagePathPerson(PersonID);

        }

        public void LoadData(string ClassName,string FullName,string NationalNo)
        {
            this.ClassName = ClassName;
            this.FullName = FullName;
            this.NationalNo = NationalNo;

            _FillData();
        }

    }
}
