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

namespace DVLD
{
    public partial class Add_Or_Edit_User : Form
    {
        public Add_Or_Edit_User()
        {
            InitializeComponent();
            cobFilterPeople.SelectedIndex = 1;
        }

        public Add_Or_Edit_User(int PersonID, int UserID)
        {
            InitializeComponent();

            _PersonID = PersonID;
            _UserID = UserID;
        }

        public enum enMode { AddNew = 0, Update = 1 };
        public static enMode Mode;

        private int _PersonID;
        private int _UserID;

        private bool _CheckPasswordMatchs()
        {
            if (txbPassword.Text == txbConfirmPassword.Text)
            {
                return true;
            }

            return false;
        }
        private bool _CheckIsUserExistsForPerson(int PersonID)
        {
            return DVLD_Business_Layer.clsUsers.CheckIsUserExistsForPerson(PersonID);
        }
        private void AddNewUser_Load(object sender, EventArgs e)
        {
            CheckIsMode();
        }
        private void btnSearchForUser_Click(object sender, EventArgs e)
        {


            if (cobFilterPeople.Text == "PersonID")
            {
                ctrlPersonInformation1.LaodDataPerson(int.Parse(txbSearchByWord.Text));
                return;
            }

            int PersonID = DVLD_Business_Layer.clsPeople.GetPersonIDByNationalNo(txbSearchByWord.Text);
            ctrlPersonInformation1.LaodDataPerson(PersonID);

        }
        private void btnNext_Click(object sender, EventArgs e)
        {

            if (_CheckIsUserExistsForPerson(ctrlPersonInformation._PersonID))
            {
                MessageBox.Show("User Exists For Person ", "Eroor");
                return;
            }


            TcUserInfo.SelectedIndex = 1;
            btnSaveDate.Enabled = true;

        }
        private void _ErrorMessage()
        {
            MessageBox.Show("There Are Some Empty Fields, Please Check Them And Try Again", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void txbUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbUserName.Text))
            {
                errorProvider.SetError(txbUserName, "UserName Is Required");

            }

            else
            {
                errorProvider.SetError(txbUserName, "");
            }
        }
        private void txbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbPassword.Text))
            {
                errorProvider.SetError(txbPassword, "Password Is Required");

            }

            else
            {
                errorProvider.SetError(txbPassword, "");
            }

        }
        private void txbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbConfirmPassword.Text))
            {
                errorProvider.SetError(txbConfirmPassword, "Confirm Password Is Required");
            }

            else
            {
                errorProvider.SetError(txbConfirmPassword, "");
            }
        }
        private void txbConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txbPassword.Text != txbConfirmPassword.Text)
            {
                errorProvider.SetError(txbConfirmPassword, "Password Does Not Match");
            }

            else
            {
                errorProvider.SetError(txbConfirmPassword, "");

            }
            btnSaveDate.Enabled = true;

        }
        private void btnSaveDate_Click(object sender, EventArgs e)
        {
            _SaveData();
        }
        private void cobFilterPeople_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cobFilterPeople.SelectedIndex == 0)
            {

                txbSearchByWord.Visible = false;
            }

            else
            {
                txbSearchByWord.Visible = true;
            }

        }
        private void txbUserName_TextChanged(object sender, EventArgs e)
        {
            if (Mode == enMode.AddNew)
            {

                if (_CheckIsUserExistsForPerson(ctrlPersonInformation._PersonID))
                {
                    MessageBox.Show("User Exists For Person ", "Eroor");
                    return;
                }
            }

            if (Mode == enMode.Update)
            {
                btnSaveDate.Enabled = true;
            }

        }
        private void txbPassword_TextChanged(object sender, EventArgs e)
        {
            btnSaveDate.Enabled = true;

        }
        private void GetDateForUser()
        {
            DVLD_Business_Layer.clsUsers User1 = DVLD_Business_Layer.clsUsers.Find(_UserID);

            lblUserIDUser.Text = User1.UserID.ToString();
            txbUserName.Text = User1.UserName;
            txbPassword.Text = User1.Password;
            txbConfirmPassword.Text = User1.Password;
            rbIsActive.Checked = User1.IsActive;

        }
        private void CheckIsMode()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        ModeIsAddNew();
                        break;
                    }

                case enMode.Update:
                    {
                        MoodIsUpdete();
                        break;
                    }
            }


        }
        public void ModeTitleNow(string Mode)
        {
            lblModeUserNow.Text = Mode;
        }
        private void ModeIsAddNew()
        {

        }
        private void MoodIsUpdete()
        {
            ctrlPersonInformation1.LaodDataPerson(_PersonID);

            cobFilterPeople.Enabled = false;
            txbSearchByWord.Visible = true;
            txbSearchByWord.Enabled = false;

            GetDateForUser();

        }
        private bool _FieldsIsNotNull()
        {
            object sender = new object();
            CancelEventArgs e = new CancelEventArgs();
            EventArgs eventArgs = new EventArgs();

            if (string.IsNullOrEmpty(txbUserName.Text))
            {
                txbUserName_Validating(sender, e);
                _ErrorMessage();
                return false;
            }
            if (string.IsNullOrEmpty(txbPassword.Text))
            {
                txbPassword_Validating(sender, e);
                _ErrorMessage();
                return false;
            }
            if (string.IsNullOrEmpty(txbConfirmPassword.Text))
            {
                txbConfirmPassword_Validating(sender, e);
                _ErrorMessage();
                return false;

            }

            if (!_CheckPasswordMatchs())
            {
                txbConfirmPassword_TextChanged(sender, eventArgs);
                return false;
            }

            return true;
        }

        private void GetPersonID(int PersonID)
        {
            txbSearchByWord.Text = PersonID.ToString();
            object sender = new Object();
            EventArgs e = new EventArgs();
            btnSearchForUser_Click(sender, e);
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Add_Or_Edit_Person Add_Or_Edit_Person1 = new Add_Or_Edit_Person();

            Add_Or_Edit_Person1.BackPersonIDdata += GetPersonID;

            Add_Or_Edit_Person1.ShowDialog();
        }

        private void _SaveData()
        {
            if (!_FieldsIsNotNull())
            {
                return;
            }

            if (Mode == enMode.AddNew)
            {

                clsUsers User = new clsUsers();

                User.PersonID = ctrlPersonInformation._PersonID;
                User.UserName = txbUserName.Text;
                User.Password = txbPassword.Text;
                User.IsActive = (rbIsActive.Checked) ? User.IsActive = true : User.IsActive = false;

                if (User.SaveData())
                {
                    lblUserIDUser.Text = User.UserID.ToString();
                    MessageBox.Show("Add User Sueccasfully", "Add User");

                }
            }

            else
            {
                DVLD_Business_Layer.clsUsers User1 = DVLD_Business_Layer.clsUsers.Find(_UserID);

                User1.PersonID = ctrlPersonInformation._PersonID;
                User1.UserName = txbUserName.Text;
                User1.Password = txbPassword.Text;
                User1.IsActive = (rbIsActive.Checked) ? User1.IsActive = true : User1.IsActive = false;

                if (User1.SaveData())
                {
                    MessageBox.Show("Update User Sueccasfully", "Add User");

                }

            }

        }
    }
}
