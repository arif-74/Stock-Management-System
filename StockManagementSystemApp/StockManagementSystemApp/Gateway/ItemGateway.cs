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
    class ItemGateway
    {
        private string conString = ConfigurationManager.ConnectionStrings["stockManagementSystemConnection"].ConnectionString;

        private SqlConnection connection;
        private string query;
        private SqlCommand command;
        private SqlDataReader reader;

        public ItemGateway()
        {
            connection = new SqlConnection(conString);
        }


        public int SaveItem(Item aItem)
        {
            query = "insert into item(item_name , category_id , company_id , reorder_level , quantity , created_at) values( @ItemName , @CategoryId , @CompanyId , @ReorderLevel , 0 ,'" + DateTime.Now.ToString("MM-dd-yyyy") + "')";

            command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ItemName", aItem.ItemName);
            command.Parameters.AddWithValue("@CategoryId", aItem.CategoryId);
            command.Parameters.AddWithValue("@CompanyId", aItem.CompanyId);
            command.Parameters.AddWithValue("@ReorderLevel", aItem.ItemReorderLevel);

            connection.Open();

            int rowAffect = command.ExecuteNonQuery();

            connection.Close();

            return rowAffect;
        }

        public bool IsExistItemName(Item aItem)
        {
            query = "SELECT * FROM item WHERE item_name = @ItemName AND id <> @Id ";

            command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ItemName", aItem.ItemName);
            command.Parameters.AddWithValue("@Id", aItem.Id);

            connection.Open();


            reader = command.ExecuteReader();

            bool isExist = reader.HasRows;

            reader.Close();


            connection.Close();

            return isExist;
        }


        public List<ItemViewModel> GetAllItems()
        {
            query = "SELECT * FROM ItemViewModel";

            command = new SqlCommand(query,connection);


            connection.Open();

            reader = command.ExecuteReader();

            List<ItemViewModel> items = new List<ItemViewModel>();

            while (reader.Read())
            {
                ItemViewModel aItem = new ItemViewModel();

                aItem.Id = Convert.ToInt32(reader["id"]);
                aItem.CategoryId = Convert.ToInt32(reader["categoryId"]);
                aItem.CompanyId = Convert.ToInt32(reader["companyId"]);
                aItem.ItemName = reader["item_name"].ToString();
                aItem.CategoryName = reader["category_name"].ToString();
                aItem.CompanyName = reader["company_name"].ToString();
                aItem.ItemReorderLevel = Convert.ToInt32(reader["reorder_level"]);
                aItem.ItemQuantity = Convert.ToInt32(reader["quantity"]);

                items.Add(aItem);
            }

            reader.Close();

            connection.Close();


            return items;
        }

        public List<Item> GetItemForComapny(Item item)
        {
            query = "SELECT * FROM item WHERE company_id = @CompanyId ";

            command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CompanyId", item.CompanyId);

            connection.Open();

            reader = command.ExecuteReader();

            List<Item> items = new List<Item>();

            while (reader.Read())
            {
                Item aItem = new Item();

                aItem.Id = Convert.ToInt32(reader["id"]);
                aItem.ItemName = reader["item_name"].ToString();

                items.Add(aItem);
            }

            reader.Close();

            connection.Close();


            return items;
        }

        public List<Item> GetItemForReorderQuantity(Item item)
        {
            query = "SELECT * FROM item WHERE company_id = @CompanyId AND id = @Id ";

            command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CompanyId", item.CompanyId);
            command.Parameters.AddWithValue("@Id", item.Id);

            connection.Open();

            reader = command.ExecuteReader();

            List<Item> items = new List<Item>();

            while (reader.Read())
            {
                Item aItem = new Item();

                aItem.Id = Convert.ToInt32(reader["id"]);
                aItem.ItemReorderLevel = (int)reader["reorder_level"];
                aItem.ItemQuantity = (int)reader["quantity"];

                items.Add(aItem);
            }

            reader.Close();

            connection.Close();


            return items;
        }


        public List<ItemViewModel> SearchBothItem(ItemViewModel item)
        {
            query = "SELECT * FROM ItemViewModel WHERE company_id = @CompanyId AND category_id = @CategoryId ";

            command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CompanyId", item.CompanyId);
            command.Parameters.AddWithValue("@CategoryId", item.CategoryId);

            connection.Open();

            reader = command.ExecuteReader();

            List<ItemViewModel> items = new List<ItemViewModel>();

            while (reader.Read())
            {
                ItemViewModel aItem = new ItemViewModel();

                aItem.Id = Convert.ToInt32(reader["id"]);
                aItem.ItemName = reader["item_name"].ToString();
                aItem.CompanyName = reader["company_name"].ToString();
                aItem.CategoryName = reader["category_name"].ToString();
                aItem.ItemReorderLevel = Convert.ToInt32(reader["reorder_level"]);
                aItem.ItemQuantity = Convert.ToInt32(reader["quantity"]);

                items.Add(aItem);
            }

            reader.Close();

            connection.Close();


            return items;
        }

        public List<ItemViewModel> SearchItem(ItemViewModel item)
        {
            query = "SELECT * FROM ItemViewModel WHERE company_id = @CompanyId OR category_id = @CategoryId ";

            command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CompanyId", item.CompanyId);
            command.Parameters.AddWithValue("@CategoryId", item.CategoryId);

            connection.Open();

            reader = command.ExecuteReader();

            List<ItemViewModel> items = new List<ItemViewModel>();

            while (reader.Read())
            {
                ItemViewModel aItem = new ItemViewModel();

                aItem.Id = Convert.ToInt32(reader["id"]);
                aItem.ItemName = reader["item_name"].ToString();
                aItem.CompanyName = reader["company_name"].ToString();
                aItem.CategoryName = reader["category_name"].ToString();
                aItem.ItemReorderLevel = Convert.ToInt32(reader["reorder_level"]);
                aItem.ItemQuantity = Convert.ToInt32(reader["quantity"]);

                items.Add(aItem);
            }

            reader.Close();

            connection.Close();


            return items;
        }


        public int UpdateItem(Item aItem)
        {
            query = "UPDATE item SET item_name = @ItemName, category_id = @CategoryId, company_id = @CompanyId , reorder_level = @ReorderLevel , updated_at = '" + DateTime.Now.ToString("MM-dd-yyyy") + "' WHERE id = @Id ";

            command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ItemName", aItem.ItemName);
            command.Parameters.AddWithValue("@CategoryId", aItem.CategoryId);
            command.Parameters.AddWithValue("@CompanyId", aItem.CompanyId);
            command.Parameters.AddWithValue("@ReorderLevel", aItem.ItemReorderLevel);
            command.Parameters.AddWithValue("@Id", aItem.Id);


            connection.Open();

            int rowAffect = command.ExecuteNonQuery();

            connection.Close();

            return rowAffect;
        }

        public int UpdateItemQuantity(Item quantity)
        {
            query = "UPDATE item SET quantity = @ItemQuantity , updated_at = '" + DateTime.Now.ToString("MM-dd-yyyy") + "' WHERE id = @Id ";

            command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ItemQuantity", quantity.ItemQuantity);
            command.Parameters.AddWithValue("@Id", quantity.Id);

            connection.Open();

            int rowAffect = command.ExecuteNonQuery();

            connection.Close();

            return rowAffect;
        }


        public int DeleteItem(int id)
        {
            query = "DELETE FROM item WHERE id = '" + id + "' ";

            command = new SqlCommand(query, connection);

            connection.Open();

            int rowAffect = command.ExecuteNonQuery();

            connection.Close();

            return rowAffect;
        }
    }
}
