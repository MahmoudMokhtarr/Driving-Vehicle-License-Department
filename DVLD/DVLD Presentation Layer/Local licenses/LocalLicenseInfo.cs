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
    public partial class LocalLicenseInfo : Form
    {
        private int LicenseID = 0;
        public LocalLicenseInfo(int LicenseID)
        {
            this.LicenseID = LicenseID;
            InitializeComponent();
        }

        private void LocalLicenseInfo_Load(object sender, EventArgs e)
        {
            clsLicense license = clsLicense.Find(LicenseID);

            string ClassName = clsLicenseClasses.GetLicenseClasName(license.LicenseClass);
            string FullName = clsPeople.GetFullNameByPersonID(clsDriver.GetPersonIDByDriverID(license.DriverID));
            int PersonID = clsDriver.GetPersonIDByDriverID(license.DriverID);
            string NationalNo = clsPeople.GetNationalNoByPersonID(PersonID);

            ctrDriverLicenseInfo1.LoadData(ClassName, FullName, NationalNo);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
