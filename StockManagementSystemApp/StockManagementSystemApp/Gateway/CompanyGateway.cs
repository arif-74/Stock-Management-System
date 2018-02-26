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
    class CompanyGateway
    {
        private string conString = ConfigurationManager.ConnectionStrings["stockManagementSystemConnection"].ConnectionString;

        private SqlConnection connection;
        private string query;
        private SqlCommand command;
        private SqlDataReader reader;

        public CompanyGateway()
        {
            connection = new SqlConnection(conString);
        }

        public int SaveCompany(Company aCompany)
        {
            query = "insert into company(company_name , created_at) values( @CompanyName , '" + DateTime.Now.ToString("MM-dd-yyyy") + "')";

            command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CompanyName", aCompany.CompanyName);

            connection.Open();

            int rowAffect = command.ExecuteNonQuery();

            connection.Close();

            return rowAffect;
        }


        public bool IsExistCompanyName(Company aCompany)
        {
            query = "SELECT * FROM company WHERE company_name = @CompanyName AND id <> @Id ";

            command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CompanyName", aCompany.CompanyName);
            command.Parameters.AddWithValue("@Id", aCompany.Id);

            connection.Open();


            reader = command.ExecuteReader();

            bool isExist = reader.HasRows;

            reader.Close();


            connection.Close();

            return isExist;
        }


        public List<Company> GetAllCompanys()
        {
            query = "SELECT * FROM company";

            command = new SqlCommand(query, connection);


            connection.Open();

            reader = command.ExecuteReader();

            List<Company> companys = new List<Company>();

            while (reader.Read())
            {
                Company aCompany = new Company();

                aCompany.Id = Convert.ToInt32(reader["id"]);
                aCompany.CompanyName = reader["company_name"].ToString();

                companys.Add(aCompany);
            }

            reader.Close();

            connection.Close();


            return companys;
        }


        public int UpdateCompany(Company aCompany)
        {
            query = "UPDATE company SET company_name = @CompanyName , updated_at = '" + DateTime.Now.ToString("MM-dd-yyyy") + "' WHERE id = @Id ";

            command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CompanyName", aCompany.CompanyName);
            command.Parameters.AddWithValue("@Id", aCompany.Id);

            connection.Open();

            int rowAffect = command.ExecuteNonQuery();

            connection.Close();

            return rowAffect;
        }


        public int DeleteCompany(int id)
        {
            query = "DELETE FROM company WHERE id = '" + id + "' ";

            command = new SqlCommand(query, connection);

            connection.Open();

            int rowAffect = command.ExecuteNonQuery();

            connection.Close();

            return rowAffect;
        }
    }
}
