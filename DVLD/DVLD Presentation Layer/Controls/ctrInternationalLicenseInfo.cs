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
    public partial class ctrInternationalLicenseInfo : UserControl
    {
        public ctrInternationalLicenseInfo()
        {
            InitializeComponent();
        }

        public void FillData(int InternationalLicenseID)
        {
            clsInternationalDrivingLicense IDLicense = clsInternationalDrivingLicense.Find(InternationalLicenseID);

            int PersonID = clsDriver.GetPersonIDByDriverID(IDLicense.DriverID);


            lblNameForApp.Text = clsPeople.GetFullNameByPersonID(PersonID);
            lblntLLicenseIDForApp.Text = IDLicense.InternationalLicenseID.ToString();
            lblLocalLicenseIDForApp.Text = IDLicense.IssuedUsingLocalLicenseID.ToString();
            lblNationalForApp.Text = clsPeople.GetNationalNoByPersonID(PersonID);
            lblGendorForApp.Text = clsPeople.GetGendorByPersonID(PersonID).ToString();
            lblIssueDateForApp.Text = IDLicense.IssueDate.ToString();
            lblApplicationIDForApp.Text = IDLicense.ApplicationID.ToString();
            lblIsActiveForApp.Text = IDLicense.IsActive == true ? lblIsActiveForApp.Text = "Yes" : "No";
            lblExpirationDateForApp.Text = IDLicense.ExpirationDate.ToString();
            lblDateOfBirthForApp.Text = clsPeople.GetDateOfBirthByPersonID(PersonID);
            lblDriverIDForApp.Text= IDLicense.DriverID.ToString();
        }


    }
}
