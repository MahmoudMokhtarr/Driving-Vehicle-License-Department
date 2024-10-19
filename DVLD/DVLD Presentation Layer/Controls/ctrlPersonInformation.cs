using DVLD.Properties;
using DVLD_Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrlPersonInformation : UserControl
    {
        public static int _PersonID;

        public ctrlPersonInformation()
        {
            InitializeComponent();
            
        }

        public void GetImagePathPerson(int PersonID)
        {
            string ImagePath = clsPeople.GetImagePathPerson(PersonID);

            if (ImagePath=="")
            {
                ImageForPerson.Image = Resources.تصميم_بدون_عنوان__19_;
            }

            else
            {
                this.Controls.Remove(ImageForPerson);

                System.Drawing.Image image = System.Drawing.Image.FromFile(ImagePath);
                this.Controls.Remove(ImageForPerson);

                ImageForPerson.Image = image;

            }

        }
        private void _FillPersonData(int PersonID)
        {


            clsPeople Person = clsPeople.Find(PersonID);

            if (Person != null)
            {
                PresonIDForPerson.Text = Person.PersonID.ToString();
                NameForPerson.Text = string.Format("{0} {1} {2} {3}", Person.FirstName, Person.SecondName, Person.ThirdName, Person.LastName);
                NationalNoForPerson.Text = Person.NationalNo;
                GendorForPerson.Text = Person.Gendor;
                EmailForPerson.Text = Person.Email;
                AddressForPerson.Text = Person.Nationality;
                DateOfBirthForPerson.Text = Person.DateOfBirth.ToString();
                PhoneForPerson.Text = Person.Phone;
                CountryForPerson.Text = Person.Nationality;
                GetImagePathPerson(PersonID);
            }


        }

        public void LaodDataPerson(int PersonID)
        {
            _PersonID = PersonID;
            _FillPersonData(PersonID);
        }

        private void lblEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PeopleScreen Frm1 = new PeopleScreen();
            Frm1.ModeIsUpdete(_PersonID);
        }
    }
}
