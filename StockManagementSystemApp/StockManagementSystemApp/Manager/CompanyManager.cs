using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemApp.Gateway;
using StockManagementSystemApp.Model;

namespace StockManagementSystemApp.Manager
{
    class CompanyManager
    {
        CompanyGateway aCompanyGateway = new CompanyGateway();

        public bool checkCompanyNameExist;


        public string SaveCompanyManager(Company aCompany)
        {
            checkCompanyNameExist = aCompanyGateway.IsExistCompanyName(aCompany);

            if (checkCompanyNameExist == true)
            {
                return ("Company Name is Already Exist");
            }


            int rowAffect = aCompanyGateway.SaveCompany(aCompany);

            if (rowAffect > 0)
            {
                return ("successfully insert");
            }
            return ("save failed");
        }


        public List<Company> GetAllCompanysManager()
        {
            return aCompanyGateway.GetAllCompanys();
        }


        public string UpdateCompanyManager(Company aCompany)
        {
            checkCompanyNameExist = aCompanyGateway.IsExistCompanyName(aCompany);

            if (checkCompanyNameExist == true)
            {
                return ("Company Name is Already Exist");
            }


            int rowAffect = aCompanyGateway.UpdateCompany(aCompany);

            if (rowAffect > 0)
            {
                return ("Updated sucessfully");
            }
            return ("Update failed");
        }


        public String DeleteCompanyManager(int id)
        {
            int rowAffect = aCompanyGateway.DeleteCompany(id);

            if (rowAffect > 0)
            {
                return ("Delete successfully");
            }
            return ("Delete failed");
        }
    }
}
