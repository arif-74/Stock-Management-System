using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemApp.Model;

namespace StockManagementSystemApp.Gateway
{
    class CategoryGateway
    {
        private string conString = ConfigurationManager.ConnectionStrings["stockManagementSystemConnection"].ConnectionString;

        private SqlConnection connection;
        private string query;
        private SqlCommand command;
        private SqlDataReader reader;

        public CategoryGateway()
        {
            connection = new SqlConnection(conString);
        }

        public int SaveCategory(Category aCategory)
        {
            query = "insert into category(category_name , created_at) values( @CategoryName , '" + DateTime.Now.ToString("MM-dd-yyyy") + "')";

            command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CategoryName", aCategory.CategoryName);

            connection.Open();

            int rowAffect = command.ExecuteNonQuery();

            connection.Close();

            return rowAffect;
        }


        public bool IsExistCategoryName(Category aCategory)
        {
            query = "SELECT * FROM category WHERE category_name = @CategoryName AND id <> @ID ";

            command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CategoryName", aCategory.CategoryName);
            command.Parameters.AddWithValue("@ID", aCategory.Id);

            connection.Open();


            reader = command.ExecuteReader();

            bool isExist = reader.HasRows;

            reader.Close();


            connection.Close();

            return isExist;
        }


        public List<Category> GetAllCategories()
        {
            query = "SELECT * FROM category";

            command = new SqlCommand(query, connection);


            connection.Open();

            reader = command.ExecuteReader();

            List<Category> categories = new List<Category>();

            while (reader.Read())
            {
                Category aCategory = new Category();

                aCategory.Id = Convert.ToInt32(reader["id"]);
                aCategory.CategoryName = reader["category_name"].ToString();

                categories.Add(aCategory);
            }

            reader.Close();

            connection.Close();


            return categories;
        }


        public int UpdateCategory(Category aCategory)
        {
            query = "UPDATE category SET category_name = @CategoryName , updated_at = '" + DateTime.Now.ToString("MM-dd-yyyy") + "' WHERE id = @ID ";

            command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CategoryName", aCategory.CategoryName);
            command.Parameters.AddWithValue("@ID", aCategory.Id);

            connection.Open();

            int rowAffect = command.ExecuteNonQuery();

            connection.Close();

            return rowAffect;
        }


        public int DeleteCategory(int id)
        {
            query = "DELETE FROM category WHERE id = @ID";

            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID",id);

            connection.Open();

            int rowAffect = command.ExecuteNonQuery();

            connection.Close();

            return rowAffect;
        }
    }
}
