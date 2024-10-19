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
    public partial class ctrSearchForLicenseInfoByID : UserControl
    {
        public delegate void SearchForLicenseByIDEventHandler(object sender);
        public event SearchForLicenseByIDEventHandler buttonSearch_Click1;

        public ctrSearchForLicenseInfoByID()
        {
            InitializeComponent();
        }

        public  void FillData()
        {

            clsLicense license = clsLicense.Find(int.Parse(txbLicenseID.Text));

            string ClassName = clsLicenseClasses.GetLicenseClasName(license.LicenseClass);
            string FullName = clsPeople.GetFullNameByPersonID(clsDriver.GetPersonIDByDriverID(license.DriverID));
            int PersonID = clsDriver.GetPersonIDByDriverID(license.DriverID);
            string NationalNo = clsPeople.GetNationalNoByPersonID(PersonID);

            ctrDriverLicenseInfo1.LoadData(ClassName, FullName, NationalNo);


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FillData();

            buttonSearch_Click1?.Invoke(this);

        }


    }
}
