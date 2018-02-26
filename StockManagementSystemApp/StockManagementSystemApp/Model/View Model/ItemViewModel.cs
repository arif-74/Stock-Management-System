using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystemApp.Model.View_Model
{
    public class ItemViewModel
    {
        public int Id { get; set; }

        public string ItemName { get; set; }

        public int CategoryId { get; set; }

        public int CompanyId { get; set; }

        public int ItemReorderLevel { get; set; }

        public int ItemQuantity { get; set; }

        public int UserId { get; set; }

        public string CategoryName { get; set; }

        public string CompanyName { get; set; }
    }
}
