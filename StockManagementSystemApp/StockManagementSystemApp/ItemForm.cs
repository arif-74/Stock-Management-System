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
    public partial class ItemForm : Form
    {
        public ItemForm()
        {
            InitializeComponent();
        }

        private void categoryItemButton_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();

            categoryForm.Show();
        }

        private void companyItemButton_Click(object sender, EventArgs e)
        {
            CompanyForm companyForm = new CompanyForm();

            companyForm.Show();
        }

        private void stockInItemButton_Click(object sender, EventArgs e)
        {
            StockInForm stockInForm = new StockInForm();

            stockInForm.Show();
        }

        private void stockOutItemButton_Click(object sender, EventArgs e)
        {
            StockOutForm stockOutForm = new StockOutForm();

            stockOutForm.Show();
        }

        private void viewSummaryItemButton_Click(object sender, EventArgs e)
        {
            SearchViewItemSummaryForm searchViewItemSummaryForm = new SearchViewItemSummaryForm();

            searchViewItemSummaryForm.Show();
        }

        private void salesItemButton_Click(object sender, EventArgs e)
        {
            SalesBetweenTwoDateForm salesBetweenTwoDateForm = new SalesBetweenTwoDateForm();

            salesBetweenTwoDateForm.Show();
        }
    }
}
