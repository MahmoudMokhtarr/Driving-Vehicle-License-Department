using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business_Layer
{
    public class clsTestTypes
    {
        public int ID { set; get; }
        public string Title { set; get; }
        public string Description { set; get; }
        public decimal Fees { set; get; }

        public clsTestTypes()
        {

        }

        private clsTestTypes(int ID, string Title, string Description, decimal Fees)
        {
            this.ID = ID;
            this.Title = Title;
            this.Description = Description;
            this.Fees = Fees;
        }

        public static DataTable ReturnTestTypesInfo()
        {
            return DVLD_Data_Access_Layer.clsTestTypes.ReturnTestTypesInfo();
        }

        public static clsTestTypes Find(int ID)
        {
            string Title = "", Description = "";
            decimal Fees = 0;

            if (DVLD_Data_Access_Layer.clsTestTypes.Find(ID, ref Title,ref Description, ref Fees))
            {
                return new clsTestTypes(ID, Title, Description, Fees);
            }

            return null;
        }

        public bool UpdateTestType(int ID)
        {
            return DVLD_Data_Access_Layer.clsTestTypes.UpdateTestType(ID, this.Title, this.Description, this.Fees);
        }

        public static int CountTestTrial(int LDLAppID, int TestTypeID)
        {
            return DVLD_Data_Access_Layer.clsTestTypes.CountTestTrial(LDLAppID, TestTypeID);
        }

        public static decimal GetTestFeesByTestType(int TestTypeID)
        {
            return DVLD_Data_Access_Layer.clsTestTypes.GetTestFeesByTestType(TestTypeID);
        }

    }
}
