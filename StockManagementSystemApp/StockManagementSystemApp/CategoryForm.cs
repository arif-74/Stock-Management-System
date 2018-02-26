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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void companyCategoryButton_Click(object sender, EventArgs e)
        {
            CompanyForm companyForm = new CompanyForm();

            companyForm.Show();
        }

        private void itemCategoryButton_Click(object sender, EventArgs e)
        {
            ItemForm itemForm = new ItemForm();

            itemForm.Show();
        }

        private void stockInCategoryButton_Click(object sender, EventArgs e)
        {
            StockInForm stockInForm = new StockInForm();

            stockInForm.Show();
        }

        private void stockOutCategoryButton_Click(object sender, EventArgs e)
        {
            StockOutForm stockOutForm = new StockOutForm();

            stockOutForm.Show();
        }

        private void viewSummaryCategoryButton_Click(object sender, EventArgs e)
        {
            SearchViewItemSummaryForm searchViewItemSummaryForm = new SearchViewItemSummaryForm();

            searchViewItemSummaryForm.Show();
        }

        private void salesCategoryButton_Click(object sender, EventArgs e)
        {
            SalesBetweenTwoDateForm salesBetweenTwoDateForm = new SalesBetweenTwoDateForm();

            salesBetweenTwoDateForm.Show();
        }
    }
}
