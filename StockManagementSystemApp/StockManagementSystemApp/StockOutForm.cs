using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystemApp
{
    public partial class StockOutForm : Form
    {
        public StockOutForm()
        {
            InitializeComponent();
        }

        private void categoryStockOutButton_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();

            categoryForm.Show();
        }

        private void companyStockOutButton_Click(object sender, EventArgs e)
        {
            CompanyForm companyForm = new CompanyForm();

            companyForm.Show();
        }

        private void itemStockOutButton_Click(object sender, EventArgs e)
        {
            ItemForm itemForm = new ItemForm();

            itemForm.Show();
        }

        private void stockInStockOutButton_Click(object sender, EventArgs e)
        {
            StockInForm stockInForm = new StockInForm();

            stockInForm.Show();
        }

        private void viewSummaryStockOutButton_Click(object sender, EventArgs e)
        {
            SearchViewItemSummaryForm searchViewItemSummaryForm = new SearchViewItemSummaryForm();

            searchViewItemSummaryForm.Show();
        }

        private void salesStockOutButton_Click(object sender, EventArgs e)
        {
            SalesBetweenTwoDateForm salesBetweenTwoDateForm = new SalesBetweenTwoDateForm();

            salesBetweenTwoDateForm.Show();
        }

        
    }
}
