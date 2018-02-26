using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystemApp.Model.View_Model
{
    public class SalesViewModel
    {
        public int Id { get; set; }

        public int ItemId { get; set; }

        public int SalesQuantity { get; set; }

        public int UserId { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public string ItemName { get; set; }
    }
}
