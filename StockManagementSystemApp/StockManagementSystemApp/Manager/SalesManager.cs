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
    class SalesManager
    {
        SalesGateway aSalesGateway = new SalesGateway();

        public string SaveIntoSalesManager(Sales aSales)
        {
            int rowAffect = aSalesGateway.SaveIntoSales(aSales);

            if (rowAffect > 0)
            {
                return ("successfully insert into sales");
            }
            return ("save failed");
        }

        public List<SalesViewModel> GetAllSalesManager()
        {
            return aSalesGateway.GetAllSales();
        }

        public List<SalesViewModel> GetSalesForDateManager(SalesViewModel aSales)
        {
            return aSalesGateway.GetSalesForDate(aSales);
        }
    }
}
