using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business_Layer
{
    public class clsApplicationTypes
    {
        public int ID { set; get; }
        public string Title { set; get; }
        public decimal Fees { set; get; }

        public clsApplicationTypes()
        {

        }

        private clsApplicationTypes(int ID, string Title, decimal Fees)
        {
            this.ID = ID;
            this.Title = Title;
            this.Fees = Fees;
        }

        public static DataTable ReturnApplicationTypesInfo()
        {
            return DVLD_Data_Access_Layer.clsApplicationTypes.ReturnApplicationTypesInfo();
        }

        public static clsApplicationTypes Find(int ID)
        {
            string Title = "";
            decimal Fees = 0;

            if (DVLD_Data_Access_Layer.clsApplicationTypes.Find(ID,ref Title,ref Fees))
            {
                return new clsApplicationTypes(ID, Title, Fees);
            }
            return null;
        }

        public  bool UpdateUser(int ID)
        {
            return DVLD_Data_Access_Layer.clsApplicationTypes.UpdateUser(ID, this.Title, this.Fees);
        }

        public static string GetApplicationTypeByID(int ApplicationTypeID)
        {
            return DVLD_Data_Access_Layer.clsApplicationTypes.GetApplicationTypeByID(ApplicationTypeID);
        }
    }
}
