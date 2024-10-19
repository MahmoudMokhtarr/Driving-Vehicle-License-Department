using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using DVLD_Data_Access_Layer;
using System.Data.SqlClient;

namespace DVLD_Business_Layer
{
    public class clsUsers
    {
        public int UserID { set; get; }
        public int PersonID { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public bool IsActive { set; get; }
        public enum enMode { AddNew = 0, Update = 1 };

        enMode Mode = enMode.AddNew;

        private clsUsers (int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;


            Mode = enMode.Update;
        }

        public clsUsers ()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = true;

            Mode = enMode.AddNew;

        }

        private bool _AddNewPerson()
        {
            this.UserID = DVLD_Data_Access_Layer.clsUsers.AddNewUser(this.PersonID, this.UserName, this.Password, this.IsActive);

            return (UserID != -1);
        }

        public static DataTable ListUsers()
        {
            return DVLD_Data_Access_Layer. clsUsers.ListUsers();
        }

        public static bool DeleteUser(int UserID)
        {
            return DVLD_Data_Access_Layer.clsUsers.DeleteUser(UserID);
        }

        private bool _UpdateUser ()
        {
            return DVLD_Data_Access_Layer.clsUsers.UpdateUser( this.UserID, this.PersonID, this.UserName, this.Password,this.IsActive);
        }

        public static clsUsers Find (int UserID)
        {
            int PersonID = 0;
            string UserName = "", Password = "";
            bool IsActive = false;

            if (DVLD_Data_Access_Layer.clsUsers.Find(UserID, ref PersonID, ref UserName, ref Password, ref IsActive))
            {
                return new clsUsers(UserID, PersonID, UserName, Password, IsActive);
            }

            else
            {
                return null;
            }
        }

        public static bool CheckIsUserExistsForPerson(int PersonID)
        {
            return DVLD_Data_Access_Layer.clsUsers.CheckIsUserExistsForPerson(PersonID);
        }

        public static string GetFullNameUser(int PersonID)
        {
            return DVLD_Data_Access_Layer.clsUsers.GetFullNameUser(PersonID);
        }

        public static DataTable SearchByWord(string FilterBy, string Word)
        {
            return DVLD_Data_Access_Layer.clsUsers.SearchByWord(FilterBy, Word);
        }

        public static DataTable GetAListUsersWhereActivityStatus(string Value)
        {
            return DVLD_Data_Access_Layer.clsUsers.GetAListUsersWhereActivityStatus(Value);
        }

        public static bool UpdatePasswordUser(int UserID, int NewPassword)
        {
            return DVLD_Data_Access_Layer.clsUsers.UpdatePasswordUser(UserID, NewPassword);
        }

        public static string GetPasswordUserByUserID(int UserID)
        {
            return DVLD_Data_Access_Layer.clsUsers.GetPasswordUserByUserID(UserID);
        }

        public static int GetPersonIDUserByUserID(int UserID)
        {
           return DVLD_Data_Access_Layer.clsUsers.GetPersonIDUserByUserID(UserID);
        }

        public static int GetUserIDByUserName(string UserName)
        {
            return DVLD_Data_Access_Layer.clsUsers.GetUserIDByUserName(UserName);
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

                    return _UpdateUser();
            }

            return false;
        }

    }
}
