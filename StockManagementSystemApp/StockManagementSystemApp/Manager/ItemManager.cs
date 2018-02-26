using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemApp.Gateway;
using StockManagementSystemApp.Model;
using StockManagementSystemApp.Model.View_Model;

namespace StockManagementSystemApp.Manager
{
    class ItemManager
    {
        ItemGateway aItemGateway = new ItemGateway();

        public bool checkItemNameExist;


        public string SaveItemManager(Item aItem)
        {
            checkItemNameExist = aItemGateway.IsExistItemName(aItem);

            if (checkItemNameExist == true)
            {
                return ("Item Name is Already Exist");
            }


            int rowAffect = aItemGateway.SaveItem(aItem);

            if (rowAffect > 0)
            {
                return ("successfully insert");
            }
            return ("save failed");
        }

        public List<ItemViewModel> GetAllItemManager()
        {
            return aItemGateway.GetAllItems();
        }

        public List<Item> GetItemForComapnyManager(Item companyId)
        {
            return aItemGateway.GetItemForComapny(companyId);
        }

        public List<Item> GetItemForReorderQuantityManager(Item item)
        {
            return aItemGateway.GetItemForReorderQuantity(item);
        }

        public List<ItemViewModel> SearchBothItemManager(ItemViewModel item)
        {
            return aItemGateway.SearchBothItem(item);
        }

        public List<ItemViewModel> SearchItemManager(ItemViewModel item)
        {
            return aItemGateway.SearchItem(item);
        }

        public string UpdateItemManager(Item aItem)
        {
            checkItemNameExist = aItemGateway.IsExistItemName(aItem);

            if (checkItemNameExist == true)
            {
                return ("Item Name is Already Exist");
            }


            int rowAffect = aItemGateway.UpdateItem(aItem);

            if (rowAffect > 0)
            {
                return ("Updated sucessfully");
            }
            return ("Update failed");
        }

        public string UpdateItemQuantityManager(Item quantity)
        {

            int rowAffect = aItemGateway.UpdateItemQuantity(quantity);

            if (rowAffect > 0)
            {
                return ("Update quantity sucessfully");
            }
            return ("save failed");
        }

        public string UpdateItemQuantityFromDeleteManager(Item quantity)
        {

            int rowAffect = aItemGateway.UpdateItemQuantity(quantity);

            if (rowAffect > 0)
            {
                return ("Deleted sucessfully");
            }
            return ("save failed");
        }


        public String DeleteItemManager(int id)
        {
            int rowAffect = aItemGateway.DeleteItem(id);

            if (rowAffect > 0)
            {
                return ("Delete successfully");
            }
            return ("Delete failed");
        }
    }
}
