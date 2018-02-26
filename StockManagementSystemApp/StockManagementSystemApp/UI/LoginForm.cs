using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystemApp.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            passwordTextBox.PasswordChar= '*';
            passwordTextBox.MaxLength = 10;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string conString =ConfigurationManager.ConnectionStrings["stockManagementSystemConnection"].ConnectionString;
            string query = "SELECT * FROM Login WHERE Username='" + usernameTextBox.Text.Trim() + "' AND Password='" + passwordTextBox.Text.Trim() + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, conString);
            DataTable dtbl = new DataTable();

            sda.Fill(dtbl);
            if (dtbl.Rows.Count >= 1)
            {
                SearchViewItemSummaryForm startForm=new SearchViewItemSummaryForm();
                //StockMenu menu = new StockMenu();
                //menu.Show();
                //this.Hide();
                startForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please, check your username and password.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
