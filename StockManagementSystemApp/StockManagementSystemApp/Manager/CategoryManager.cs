using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemApp.Gateway;
using StockManagementSystemApp.Model;

namespace StockManagementSystemApp.Manager
{
    class CategoryManager
    {
        CategoryGateway aCategoryGateway = new CategoryGateway();

        public bool checkCategoryNameExist;


        public string SaveCategoryManager(Category aCategory)
        {
            checkCategoryNameExist = aCategoryGateway.IsExistCategoryName(aCategory);

            if (checkCategoryNameExist == true)
            {
                return ("Category Name is Already Exist");
            }


            int rowAffect = aCategoryGateway.SaveCategory(aCategory);

            if (rowAffect > 0)
            {
                return ("successfully insert");
            }
            return ("save failed");
        }


        public List<Category> GetAllCategoriesManager()
        {
            return aCategoryGateway.GetAllCategories();
        }


        public string UpdateCategoryManager(Category aCategory)
        {
            checkCategoryNameExist = aCategoryGateway.IsExistCategoryName(aCategory);

            if (checkCategoryNameExist == true)
            {
                return ("Category Name is Already Exist");
            }


            int rowAffect = aCategoryGateway.UpdateCategory(aCategory);

            if (rowAffect > 0)
            {
                return ("Updated sucessfully");
            }
            return ("Update failed");
        }


        public String DeleteCategoryManager(int id)
        {
            int rowAffect = aCategoryGateway.DeleteCategory(id);

            if (rowAffect > 0)
            {
                return ("Delete successfully");
            }
            return ("Delete failed");
        }
    }
}
