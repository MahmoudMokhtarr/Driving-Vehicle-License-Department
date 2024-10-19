using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Properties;
using DVLD_Business_Layer;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace DVLD
{
    public partial class Add_Or_Edit_Person : Form
    {
        public Add_Or_Edit_Person()
        {
            InitializeComponent();

        }

        public Add_Or_Edit_Person(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;
        }

        public delegate bool DataBackEvent(object sender, string NationalNo, string FirstName,
        string SecondName, string ThirdName, string LastName, string Gendor, DateTime DateOfBirth,
        string Nationality, string Phone, string Email, string ImagePath);
        public event DataBackEvent DataBack;

        public delegate void PersonIDdataBack(int PersonID);
        public event PersonIDdataBack BackPersonIDdata;


        public enum enMode { AddNew = 0, Update = 1 };
        public static enMode Mode;

        private int _PersonID;

        private void Add_Or_Edit_Person_Load(object sender, EventArgs e)
        {
            CheckIsMode();

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

        private void ModeIsAddNew()
        {
            ShowAllCountries();

        }

        private void MoodIsUpdete()
        {
            ShowAllCountries();

            clsPeople Person = clsPeople.Find(_PersonID);
            lblNewPersonID.Text = Person.PersonID.ToString();
            txbFirstName.Text = Person.FirstName;
            txbSecondName.Text = Person.SecondName;
            txbThirdName.Text = Person.ThirdName;
            txbLastName.Text = Person.LastName;
            txbNationalNo.Text = Person.NationalNo;
            dateTimePicker1.Text = Person.DateOfBirth.ToString();
            if (Person.Gendor == "Female")
            {
                rabFemale.Checked = true;
            }
            else
            {
                rabMale.Checked = true;
            }
            txbPhone.Text = Person.Phone;
            txbEmail.Text = Person.Email;
            cobCountry.Text = Person.Nationality;
            txbAddress.Text = Person.Address;
            GetImagePerson();

        }

        private string GetImagePerson()
        {
            string ImagePath = clsPeople.GetImagePathPerson(_PersonID);

            if (ImagePath == "")
            {
                ImagePerson.Image = Resources.تصميم_بدون_عنوان__19_;
            }

            else
            {

                System.Drawing.Image image = System.Drawing.Image.FromFile(ImagePath);
                ImagePerson.Image = image;

            }
            return ImagePath;
        }

        private void _SaveData()
         {
            if (FieldsisNotNull() != true)
            {
                return;
            }

            if (Mode == enMode.AddNew)
            {

                clsPeople Person = new clsPeople();

                Person.NationalNo = txbNationalNo.Text;
                Person.FirstName = txbFirstName.Text;
                Person.SecondName = txbSecondName.Text;
                Person.ThirdName = txbThirdName.Text;
                Person.LastName = txbLastName.Text;
                Person.Gendor = (rabFemale.Checked) ? Person.Gendor = rabFemale.Text : Person.Gendor = rabMale.Text;
                Person.DateOfBirth = dateTimePicker1.Value;
                Person.Address = txbAddress.Text;
                Person.Nationality = cobCountry.Text;
                Person.Phone = txbPhone.Text;
                Person.Email = txbEmail.Text;
                Person.ImagePath = ImagePerson.ImageLocation;

                if (Person.SaveData())
                {
                    MessageBox.Show("Add Person Sueccasfully -_- ", "Add Person");
                    _PersonID = Person.PersonID;
                    lblNewPersonID.Text= _PersonID.ToString();

                }
            }

            else
            {
                clsPeople Person1 = clsPeople.Find(_PersonID);

                Person1.FirstName = txbFirstName.Text;
                Person1.SecondName = txbSecondName.Text;
                Person1.ThirdName = txbThirdName.Text;
                Person1.LastName = txbLastName.Text;
                Person1.Gendor = (rabFemale.Checked) ? Person1.Gendor = rabFemale.Text : Person1.Gendor = rabMale.Text;
                Person1.NationalNo = txbNationalNo.Text;
                Person1.Email = txbEmail.Text;
                Person1.Address = txbAddress.Text;
                Person1.Phone = txbPhone.Text;
                Person1.Nationality = cobCountry.Text;
                Person1.ImagePath = ImagePerson.ImageLocation;


                if (Person1.SaveData())
                {

                 MessageBox.Show("Update Person Sueccasfully -_- ", "Update Person");
                    
                }
            }
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {

         _SaveData();
                    
        }

        public void ShowAllCountries()
        {
            DataTable Country = clsPeople.GetAllCountries();
            foreach (DataRow Row in Country.Rows)
            {
                cobCountry.Items.Add(Row["CountryName"]);
            }
            cobCountry.SelectedItem ="Egypt";
        }

        public  void ModeAddOrEditPersonNow(string Mode)
        {
            lblModePerson.Text = Mode;
        }

        public void SelactImagePerson()
        {

            System.Drawing.Image image = System.Drawing.Image.FromFile(OFDSetImage.FileName);
            ImagePerson.ImageLocation = OFDSetImage.FileName;
            ImagePerson.Image = image;
        }

        private void btnSelactImagePerson_Click(object sender, EventArgs e)
        {
            OFDSetImage.ShowDialog();
            SelactImagePerson();

        }

        private void txbFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbFirstName.Text))
            {
                errorProvider.SetError(txbFirstName, "First Name Is Required");
            }
            else
            {
                errorProvider.SetError(txbFirstName, "");
            }

        }

        private void txbSecondName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbSecondName.Text))
            {
                errorProvider.SetError(txbSecondName, "First Name Is Required");
            }
            else
            {
                errorProvider.SetError(txbSecondName, "");
            }

        }

        private void txbThirdName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbThirdName.Text))
            {
                errorProvider.SetError(txbThirdName, "Third Name Is Required");
            }
            else
            {
                errorProvider.SetError(txbThirdName, "");
            }

        }

        private void txbLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbLastName.Text))
            {
                errorProvider.SetError(txbLastName, "Last Name Is Required");
            }
            else
            {
                errorProvider.SetError(txbLastName, "");
            }

        }

        private void txbNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbNationalNo.Text))
            {
                errorProvider.SetError(txbNationalNo, "National No Is Required");
            }
            else
            {
                errorProvider.SetError(txbNationalNo, "");
            }

            if (clsPeople.CheckNationalNumberIsDuplicate(txbNationalNo.Text)==true)
            {
                errorProvider.SetError(txbNationalNo, "National No IS Duplicate");

            }

        }

        private void txbPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbPhone.Text))
            {
                errorProvider.SetError(txbPhone, "Phone Is Required");
            }
            else
            {
                errorProvider.SetError(txbPhone, "");
            }

        }

        private void txbEmail_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txbEmail.Text))
            {
                errorProvider.SetError(txbEmail, "Email Is Required");
            }
            else
            {
                errorProvider.SetError(txbEmail, "");
            }

        }

        private void txbAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbAddress.Text))
            {
                errorProvider.SetError(txbAddress, "Address Is Required");
            }
            else
            {
                errorProvider.SetError(txbAddress, "");
            }

        }

        private void ErrorMessage()
        {
            MessageBox.Show("There Are Some Empty Fields, Please Check Them And Try Again", "Empty Fields",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        private bool FieldsisNotNull()
        {
            object sender = new object();
            CancelEventArgs e = new CancelEventArgs();

            if (Mode == enMode.AddNew)
            {

                if (clsPeople.CheckNationalNumberIsDuplicate(txbNationalNo.Text))
                {
                    txbNationalNo_Validating(sender, e);
                    ErrorMessage();
                    return false;
                }

                if (string.IsNullOrEmpty(txbAddress.Text))
                {
                    txbAddress_Validating(sender, e);
                    ErrorMessage();
                    return false;
                }

                else if (string.IsNullOrEmpty(txbEmail.Text))
                {
                    txbEmail_Validating(sender, e);
                    ErrorMessage();
                    return false;

                }

                else if (string.IsNullOrEmpty(txbPhone.Text))
                {
                    txbPhone_Validating(sender, e);
                    ErrorMessage();
                    return false;

                }

                else if (string.IsNullOrEmpty(txbNationalNo.Text))
                {
                    txbNationalNo_Validating(sender, e);
                    ErrorMessage();
                    return false;

                }

                else if (string.IsNullOrEmpty(txbLastName.Text))
                {
                    txbLastName_Validating(sender, e);
                    ErrorMessage();
                    return false;

                }

                else if (string.IsNullOrEmpty(txbThirdName.Text))
                {

                    txbThirdName_Validating(sender, e);
                    ErrorMessage();
                    return false;

                }

                else if (string.IsNullOrEmpty(txbSecondName.Text))
                {
                    txbSecondName_Validating(sender, e);
                    ErrorMessage();
                    return false;

                }

                else if (string.IsNullOrEmpty(txbFirstName.Text))
                {
                    txbFirstName_Validating(sender, e);
                    ErrorMessage();
                    return false;

                }

                return true;
            }

            else
            {
                if (string.IsNullOrEmpty(txbAddress.Text))
                {
                    txbAddress_Validating(sender, e);
                    ErrorMessage();
                    return false;
                }

                else if (string.IsNullOrEmpty(txbEmail.Text))
                {
                    txbEmail_Validating(sender, e);
                    ErrorMessage();
                    return false;

                }

                else if (string.IsNullOrEmpty(txbPhone.Text))
                {
                    txbPhone_Validating(sender, e);
                    ErrorMessage();
                    return false;

                }

                else if (string.IsNullOrEmpty(txbNationalNo.Text))
                {
                    txbNationalNo_Validating(sender, e);
                    ErrorMessage();
                    return false;

                }

                else if (string.IsNullOrEmpty(txbLastName.Text))
                {
                    txbLastName_Validating(sender, e);
                    ErrorMessage();
                    return false;

                }

                else if (string.IsNullOrEmpty(txbThirdName.Text))
                {

                    txbThirdName_Validating(sender, e);
                    ErrorMessage();
                    return false;

                }

                else if (string.IsNullOrEmpty(txbSecondName.Text))
                {
                    txbSecondName_Validating(sender, e);
                    ErrorMessage();
                    return false;

                }

                else if (string.IsNullOrEmpty(txbFirstName.Text))
                {
                    txbFirstName_Validating(sender, e);
                    ErrorMessage();
                    return false;

                }


            }

            return true;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            BackPersonIDdata?.Invoke(_PersonID);

            this.Close();


        }

    }
}
