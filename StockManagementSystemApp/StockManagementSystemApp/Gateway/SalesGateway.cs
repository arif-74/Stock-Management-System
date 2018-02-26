using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemApp.Model;
using StockManagementSystemApp.Model.View_Model;

namespace StockManagementSystemApp.Gateway
{
    class SalesGateway
    {
        private string conString = ConfigurationManager.ConnectionStrings["stockManagementSystemConnection"].ConnectionString;

        private SqlConnection connection;
        private string query;
        private SqlCommand command;
        private SqlDataReader reader;

        public SalesGateway()
        {
            connection = new SqlConnection(conString);
        }

        public int SaveIntoSales(Sales aSales)
        {
            query = "insert into sales(item_id , sales_quantity , created_at) values( @ItemId , @SalesQuantity ,'" + DateTime.Now.ToString("MM-dd-yyyy") + "')";

            command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ItemId", aSales.ItemId);
            command.Parameters.AddWithValue("@SalesQuantity", aSales.SalesQuantity);

            connection.Open();

            int rowAffect = command.ExecuteNonQuery();

            connection.Close();

            return rowAffect;
        }

        public List<SalesViewModel> GetAllSales()
        {
            query = "SELECT * FROM SalesViewModel";

            command = new SqlCommand(query, connection);


            connection.Open();

            reader = command.ExecuteReader();

            List<SalesViewModel> salesViewModel = new List<SalesViewModel>();

            while (reader.Read())
            {
                SalesViewModel aSale = new SalesViewModel();

                aSale.Id = Convert.ToInt32(reader["id"]);
                aSale.ItemName = reader["item_name"].ToString();
                aSale.SalesQuantity = Convert.ToInt32(reader["sales_quantity"]);
                aSale.CreatedAt = (DateTime) reader["created_at"];

                salesViewModel.Add(aSale);
            }

            reader.Close();

            connection.Close();


            return salesViewModel;
        }

        public List<SalesViewModel> GetSalesForDate(SalesViewModel sale)
        {
            query = "SELECT * FROM SalesViewModel WHERE created_at BETWEEN @FromDate AND @ToDate ";

            command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FromDate" , sale.FromDate);
            command.Parameters.AddWithValue("@ToDate" , sale.ToDate);

            connection.Open();

            reader = command.ExecuteReader();

            List<SalesViewModel> salesViewModel = new List<SalesViewModel>();

            while (reader.Read())
            {
                SalesViewModel aSale = new SalesViewModel();

                aSale.Id = Convert.ToInt32(reader["id"]);
                aSale.ItemName = reader["item_name"].ToString();
                aSale.SalesQuantity = Convert.ToInt32(reader["sales_quantity"]);
                aSale.CreatedAt = (DateTime)reader["created_at"];

                salesViewModel.Add(aSale);
            }

            reader.Close();

            connection.Close();


            return salesViewModel;
        }
    }
}
