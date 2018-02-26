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
    public partial class SalesBetweenTwoDateForm : Form
    {
        public SalesBetweenTwoDateForm()
        {
            InitializeComponent();
        }

        private void categorySalesButton_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();

            categoryForm.Show();
        }

        private void companySalesButton_Click(object sender, EventArgs e)
        {
            CompanyForm companyForm = new CompanyForm();

            companyForm.Show();
        }

        private void itemSalesButton_Click(object sender, EventArgs e)
        {
            ItemForm itemForm = new ItemForm();

            itemForm.Show();
        }

        private void stockInSalesButton_Click(object sender, EventArgs e)
        {
            StockInForm stockInForm = new StockInForm();

            stockInForm.Show();
        }

        private void stockOutSalesButton_Click(object sender, EventArgs e)
        {
            StockOutForm stockOutForm = new StockOutForm();

            stockOutForm.Show();
        }

        private void viewSummarySalesButton_Click(object sender, EventArgs e)
        {
            SearchViewItemSummaryForm searchViewItemSummaryForm = new SearchViewItemSummaryForm();

            searchViewItemSummaryForm.Show();
        }
    }
}
