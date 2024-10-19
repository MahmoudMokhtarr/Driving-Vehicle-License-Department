using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business_Layer
{
    public class clsLicenseClasses
    {
        public int LicenseClassID {  get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public byte MinimumAllowedAge { get; set; }
        public byte DefaultValidityLength { get; set; }
        public decimal ClassFees { get; set; }

        public clsLicenseClasses()
        {
            this.LicenseClassID = 0;
            this.ClassName = string.Empty;
            this.ClassDescription = string.Empty;
            this.MinimumAllowedAge = 0;
            this.DefaultValidityLength = 0;
            this.ClassFees = 0;
        }

        private clsLicenseClasses(int licenseClassID, string className, string classDescription, byte minimumAllowedAge, byte defaultValidityLength, decimal classFees)
        {
            this.LicenseClassID = licenseClassID;
            this.ClassName = className;
            this.ClassDescription = classDescription;
            this.MinimumAllowedAge = minimumAllowedAge;
            this.DefaultValidityLength = defaultValidityLength;
            this.ClassFees = classFees;
        }

        public static DataTable ListLicenseClasses()
        {
            return DVLD_Data_Access_Layer.clsLicenseClasses.ListLicenseClasses();
        }

        public static String GetLicenseClasName(int LicenseClassID)
        {
            return DVLD_Data_Access_Layer.clsLicenseClasses.GetLicenseClasName(LicenseClassID);
        }

        public static clsLicenseClasses Find(int LicenseClassID)
        {
            string ClassName = null, ClassDescription = null;
            byte MinimumAllowedAge = 0, DefaultValidityLength = 0;
            decimal ClassFees = 0;


            if (DVLD_Data_Access_Layer.clsLicenseClasses.Find(LicenseClassID,ref ClassName,ref ClassDescription,ref MinimumAllowedAge,ref DefaultValidityLength,ref ClassFees))
            {
                return new clsLicenseClasses(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            }
            else
            {
                return null;
            }
            
        }

    }
}
