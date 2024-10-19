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
using System.Web.UI.WebControls;

namespace DVLD
{
    public partial class ctrDriverLicenses : UserControl
    {
        public ctrDriverLicenses()
        {
            InitializeComponent();
            
        }

        public void ListLocalLicense(int PersonID)
        {
            DataTable License = clsLicense.GetInfoLicenseByPersonID(PersonID);

            foreach (DataRow LicenseRow in License.Rows)
            {
                string ClassName = clsLicenseClasses.GetLicenseClasName((int)LicenseRow["LicenseClass"]);

                DGVLocalLicenseHistory.Rows.Add(LicenseRow["LicenseID"], LicenseRow["ApplicationID"], ClassName,
                LicenseRow["IssueDate"], LicenseRow["ExpirationDate"], LicenseRow["IsActive"]);

            }
        }

        public void ListInternationalLicense(int PersonID)
        {
            DataTable License = clsInternationalDrivingLicense.GetInfoLicenseByPersonID(PersonID);

            foreach (DataRow LicenseRow in License.Rows)
            {

                DGViLicenseHistory.Rows.Add(LicenseRow["InternationalLicenseID"], LicenseRow["ApplicationID"],
                LicenseRow["IssuedUsingLocalLicenseID"], LicenseRow["IssueDate"], LicenseRow["ExpirationDate"], LicenseRow["IsActive"]);

            }


        }
    }
}
