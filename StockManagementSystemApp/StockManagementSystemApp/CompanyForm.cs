﻿using System;
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
    public partial class CompanyForm : Form
    {
        public CompanyForm()
        {
            InitializeComponent();
        }
  
        private void categoryCompanyButton_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();

            categoryForm.Show();
        }

        private void itemCompanyButton_Click(object sender, EventArgs e)
        {
            ItemForm itemForm = new ItemForm();

            itemForm.Show();
        }

        private void stockInCompanyButton_Click(object sender, EventArgs e)
        {
            StockInForm stockInForm = new StockInForm();

            stockInForm.Show();
        }

        private void stockOutCompanyButton_Click(object sender, EventArgs e)
        {
            StockOutForm stockOutForm = new StockOutForm();

            stockOutForm.Show();
        }

        private void viewSummaryCompanyButton_Click(object sender, EventArgs e)
        {
            SearchViewItemSummaryForm searchViewItemSummaryForm = new SearchViewItemSummaryForm();

            searchViewItemSummaryForm.Show();
        }

        private void salesCompanyButton_Click(object sender, EventArgs e)
        {
            SalesBetweenTwoDateForm salesBetweenTwoDateForm = new SalesBetweenTwoDateForm();

            salesBetweenTwoDateForm.Show();
        }
    }
}
