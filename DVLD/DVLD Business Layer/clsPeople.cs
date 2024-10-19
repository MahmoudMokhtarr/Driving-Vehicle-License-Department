using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Data_Access_Layer;

namespace DVLD_Business_Layer
{
    public class clsPeople
    {
        public enum enMode { AddNew = 0, Update = 1 };
        enMode Mode = enMode.AddNew;

        public int PersonID { set; get; }
        public string NationalNo { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public string Gendor { set; get; }
        public DateTime DateOfBirth { set; get; }
        public string Nationality { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public string ImagePath { set; get; }

        private clsPeople(int PersonID, string NationalNo,string FirstName,
         string SecondName, string ThirdName, string LastName, string Gendor, DateTime DateOfBirth,
         string Nationality, string Phone, string Email, string imagePath)

        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.Gendor = Gendor;
            this.DateOfBirth = DateOfBirth;
            this.Nationality = Nationality;
            this.Phone = Phone;
            this.Email = Email;
            ImagePath = imagePath;

            Mode = enMode.Update;
        }

        public clsPeople()
        {

            Mode = enMode.AddNew;
        }


        private bool _AddNewPerson()
        {
            this.PersonID = DVLD_Data_Access_Layer.clsPeople.AddNewPerson(this.NationalNo, this.FirstName, this.SecondName, this.ThirdName,
            this.LastName, this.Gendor, this.DateOfBirth, this.Nationality, this.Phone, this.Email,this.ImagePath);

            return (this.PersonID != -1);
        }

        public static DataTable GetAllPersonsInfo()
        {
            return DVLD_Data_Access_Layer.clsPeople.ReturnPersonsInfo();
        }

        public static DataTable GetAllCountries ()
        {
            return DVLD_Data_Access_Layer.clsPeople.ReturnAllCountries();
        }

        public static bool CheckNationalNumberIsDuplicate(string NationalNumber)
        {
            return DVLD_Data_Access_Layer.clsPeople.CheckNationalNumberIsDuplicate(NationalNumber);
        }

        public static DataTable SearchByWord(string FilterBy, string Word)
        {
            return DVLD_Data_Access_Layer.clsPeople.SearchByWord( FilterBy, Word);
        }

        public static clsPeople Find(int PersonID)
        {
            string NationalNo = "", FirstName = "", SecondName = "", ThirdName = "", LastName = "", Gendor = "",
            Nationality = "", Phone = "", Email = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;

            if (DVLD_Data_Access_Layer.clsPeople.Find(PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
            ref Gendor, ref DateOfBirth, ref Nationality, ref Phone, ref Email, ref ImagePath))
            {
                return new clsPeople(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, Gendor, DateOfBirth, Nationality, Phone, Email, ImagePath);
            }

            else 
            {
              return null; 
            }
        }

        public static String GetImagePathPerson(int PersonID)
        {
            return DVLD_Data_Access_Layer.clsPeople.GetImagePathPerson(PersonID);
        }

        public static bool DeletePerson(int PersonID)
        {
            return DVLD_Data_Access_Layer.clsPeople.DeletePerson(PersonID);
        }

        private bool UpdatePerson()
        {
            return DVLD_Data_Access_Layer.clsPeople.UpdatePerson(this.PersonID,this.NationalNo, this.FirstName, this.SecondName, this.ThirdName,
            this.LastName, this.Gendor, this.DateOfBirth, this.Nationality, this.Phone, this.Email, this.ImagePath);
        }

        public static int GetPersonIDByNationalNo(string NationalNo)
        {
            return DVLD_Data_Access_Layer.clsPeople.GetPersonIDByNationalNo(NationalNo);
        }

        public static string GetNationalNoByPersonID(int PersonID)
        {
            return DVLD_Data_Access_Layer.clsPeople.GetNationalNoByPersonID(PersonID);
        }
        public  int ReturnPersonID()
        {
            return this.PersonID;
        }
        public static string GetGendorByPersonID(int PersonID)
        {
            return DVLD_Data_Access_Layer.clsPeople.GetGendorByPersonID(PersonID);
        }

        public static string GetDateOfBirthByPersonID(int PersonID)
        {
            return DVLD_Data_Access_Layer.clsPeople.GetDateOfBirthByPersonID(PersonID);
        }
        public static string GetFullNameByPersonID(int PersonID)
        {
            return DVLD_Data_Access_Layer.clsPeople.GetFullNameByPersonID(PersonID);
        }
        public bool SaveData()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                   
                  if (_AddNewPerson())
                {
                            Mode = enMode.Update;
                            return true;
                }
                else
                {
                        return false;
                } 
                  

                case enMode.Update:

                return UpdatePerson();
            }
            return false;
        }

    }
}
