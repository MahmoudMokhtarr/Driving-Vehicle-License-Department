using DVLD.Properties;
using DVLD_Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrDrivingApplicationInfo : UserControl
    {
        private int _LDLAppID = 0;
        private int _PersonID = 0;
        public ctrDrivingApplicationInfo()
        {
            InitializeComponent();
        }

        public void LoadData(int LocalDrivingLicenseApplicationID)
        {
            _LDLAppID = LocalDrivingLicenseApplicationID;
        }

        private void FillData()
        {
            DVLD_Business_Layer.clsLocalDrivingLicenseApplications LDLAppliciton =  DVLD_Business_Layer.clsLocalDrivingLicenseApplications.Find(_LDLAppID);
            lblDLAppIDForApp.Text = LDLAppliciton.LocalDrivingLicenseApplicationID.ToString();
            lblAppliedForLicenceForApp.Text = clsLicenseClasses.GetLicenseClasName(LDLAppliciton.LicenseClassID);
            lblPaseedTestForApp.Text = clsTests.GetPassedTest(_LDLAppID).ToString() + "/3";
            lblIDForApp.Text = LDLAppliciton.ApplicationID.ToString();
            lblStatusForApp.Text = (LDLAppliciton.ApplicationStatus == 1) ? lblStatusForApp.Text = "New" : ((LDLAppliciton.ApplicationStatus == 2) ? lblStatusForApp.Text = "Cancelled" : lblStatusForApp.Text = "Completed");
            lblFeesForApp.Text = LDLAppliciton.PaidFees.ToString();
            lblTypeForApp.Text = clsApplicationTypes.GetApplicationTypeByID(LDLAppliciton.ApplicationTypeID);
            lblApplicantForApp.Text = clsPeople.GetFullNameByPersonID(LDLAppliciton.ApplicantPersonID);
            lblDateForApp.Text = LDLAppliciton.ApplicationDate.ToString();
            lblStatusDateForApp.Text = LDLAppliciton.LastStatusDate.ToString();
            lblCreatedByForApp.Text = LDLAppliciton.CreatedByUserID.ToString();


            _PersonID = LDLAppliciton.ApplicantPersonID;

        }

        private void ViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonDetails personDetails = new PersonDetails(_PersonID);
            personDetails.ShowDialog();
        }

        private void ctrDrivingApplicationInfo_Load(object sender, EventArgs e)
        {

            if (!this.DesignMode)
            {
                FillData();
            }
            
        }
    }
}
