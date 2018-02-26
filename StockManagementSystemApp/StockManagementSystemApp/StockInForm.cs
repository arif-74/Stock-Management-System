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
    public partial class StockInForm : Form
    {
        public StockInForm()
        {
            InitializeComponent();
        }

        private void categoryStockInButton_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();

            categoryForm.Show();
        }

        private void companyStockInButton_Click(object sender, EventArgs e)
        {
            CompanyForm companyForm = new CompanyForm();

            companyForm.Show();
        }

        private void itemStockInButton_Click(object sender, EventArgs e)
        {
            ItemForm itemForm = new ItemForm();

            itemForm.Show();
        }

        private void stockOutStockInButton_Click(object sender, EventArgs e)
        {
            StockOutForm stockOutForm = new StockOutForm();

            stockOutForm.Show();
        }

        private void viewSummaryStockInButton_Click(object sender, EventArgs e)
        {
            SearchViewItemSummaryForm searchViewItemSummaryForm = new SearchViewItemSummaryForm();

            searchViewItemSummaryForm.Show();
        }

        private void salesStockInButton_Click(object sender, EventArgs e)
        {
            SalesBetweenTwoDateForm salesBetweenTwoDateForm = new SalesBetweenTwoDateForm();

            salesBetweenTwoDateForm.Show();
        }


    }
}
