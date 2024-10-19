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
    public partial class HomeScreen : Form
    {
        LoginScreen _loginScreen;
        public HomeScreen(LoginScreen LoginScreen)
        {
            InitializeComponent();
            this._loginScreen = LoginScreen;
        }

        private void PeopleScreen_Click(object sender, EventArgs e)
        {
            PeopleScreen Form = new PeopleScreen();
            Form.ShowDialog();
        }

        private void UsersScreen_Click(object sender, EventArgs e)
        {
            UsersScreen Form = new UsersScreen();
            Form.ShowDialog();
        }

        private void signOutMenuStrip_Click(object sender, EventArgs e)
        {
            GlobalSettings.User = null;
            _loginScreen.Show();
            this.Close();

        }

        private void currentUserInfoMenuStrip_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo();
            userInfo.LoadFullData( GlobalSettings.User.PersonID, GlobalSettings.User.UserID);
            userInfo.Show();
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword ChangePassword = new ChangePassword(GlobalSettings.User.UserID);
            ChangePassword.Show();
            
        }

        private void ManageApplicationsTypes_Click(object sender, EventArgs e)
        {
            ManageApplicationTypes manageApplicationTypes = new ManageApplicationTypes();
            manageApplicationTypes.Show();
        }

        private void ManageTestTyeps_Click(object sender, EventArgs e)
        {
            TestTypes testTypes = new TestTypes();
            testTypes.ShowDialog();
        }

        private void LocalDriverLicence_Click(object sender, EventArgs e)
        {
            NewLocalDrivingLicenseApplications Frm = new NewLocalDrivingLicenseApplications();
            Frm.ShowDialog();

        }

        private void ManageLocalDriverLicence_Click(object sender, EventArgs e)
        {
            ManageLocalDriverLicence localDriverLicence = new ManageLocalDriverLicence();
            localDriverLicence.ShowDialog();
        }

        private void Drivers_Click(object sender, EventArgs e)
        {
            Drivers drivers = new Drivers();
            drivers.ShowDialog();
        }

        private void internationalDriverLicence_Click(object sender, EventArgs e)
        {
            NewInternationalLicenseApplicaiton ILApplicaiton = new NewInternationalLicenseApplicaiton();
            ILApplicaiton.ShowDialog();
        }

        private void ManageinternationalDriverLicence_Click(object sender, EventArgs e)
        {
            ManageInternationalLicenseApplication ManageInternationalLicense = new ManageInternationalLicenseApplication();
            ManageInternationalLicense.ShowDialog();
        }

        private void RenewDriverLicence_Click(object sender, EventArgs e)
        {
            RenewLocalDrivingLicense RenewLocalDriving = new RenewLocalDrivingLicense();
            RenewLocalDriving.ShowDialog();
        }

        private void replacementForLostOrDamaged_Click(object sender, EventArgs e)
        {
            ReplacementForDamagedOrLostLicenses replacementForDamagedOrLostLicenses = new ReplacementForDamagedOrLostLicenses();
            replacementForDamagedOrLostLicenses.ShowDialog();
        }

        private void DetaineLicence_Click(object sender, EventArgs e)
        {
            DetaineLicence DetaineLicence = new DetaineLicence();
            DetaineLicence.ShowDialog();
        }

        private void ReleaseDetaineLicence_Click(object sender, EventArgs e)
        {
            ReleaseDetainLicenses ReleaseLicenses = new ReleaseDetainLicenses();
            ReleaseLicenses.ShowDialog();
        }

        private void ManageDetainedLicence_Click(object sender, EventArgs e)
        {
            ManageDetainLicense manageDetainLicense = new ManageDetainLicense();
            manageDetainLicense.ShowDialog();
        }
    }
}
