using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using StockManagementSystemApp.Manager;
using StockManagementSystemApp.Model;
using StockManagementSystemApp.Model.View_Model;
using StockManagementSystemApp.Reporting;

namespace StockManagementSystemApp.UI
{
    public partial class SalesBetweenTwoDateForm : Form
    {
        public SalesBetweenTwoDateForm()
        {
            InitializeComponent();
        }


        private Thread thread;

        private void OpenCategoryForm()
        {
            Application.Run(new CategoryForm());
        }

        private void OpenCompanyForm()
        {
            Application.Run(new CompanyForm());
        }

        private void OpenItemForm()
        {
            Application.Run(new ItemForm());
        }

        private void OpenStockInForm()
        {
            Application.Run(new StockInForm());
        }

        private void OpenStockOutForm()
        {
            Application.Run(new StockOutForm());
        }

        private void OpenViewSummaryForm()
        {
            Application.Run(new SearchViewItemSummaryForm());
        }

        private void categorySalesButton_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();

            this.Close();
            thread = new Thread(OpenCategoryForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void companySalesButton_Click(object sender, EventArgs e)
        {
            CompanyForm companyForm = new CompanyForm();

            this.Close();
            thread = new Thread(OpenCompanyForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void itemSalesButton_Click(object sender, EventArgs e)
        {
            ItemForm itemForm = new ItemForm();

            this.Close();
            thread = new Thread(OpenItemForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void stockInSalesButton_Click(object sender, EventArgs e)
        {
            StockInForm stockInForm = new StockInForm();

            this.Close();
            thread = new Thread(OpenStockInForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void stockOutSalesButton_Click(object sender, EventArgs e)
        {
            StockOutForm stockOutForm = new StockOutForm();

            this.Close();
            thread = new Thread(OpenStockOutForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void viewSummarySalesButton_Click(object sender, EventArgs e)
        {
            SearchViewItemSummaryForm searchViewItemSummaryForm = new SearchViewItemSummaryForm();

            this.Close();
            thread = new Thread(OpenViewSummaryForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }


        SalesManager aSalesManager = new SalesManager();

        private void searchSalesButton_Click(object sender, EventArgs e)
        {
            SalesViewModel aSale = new SalesViewModel();

            aSale.FromDate = fromDateDateTimePicker.Value;
            aSale.ToDate = toDateDateTimePicker.Value;


            salesListView.Items.Clear();

            int count = 0;

            List<SalesViewModel> allSales = aSalesManager.GetSalesForDateManager(aSale);

            foreach (SalesViewModel sale in allSales)
            {
                count++;

                ListViewItem salesList = new ListViewItem(count.ToString());
                salesList.SubItems.Add(sale.ItemName);
                salesList.SubItems.Add(sale.SalesQuantity.ToString());
                salesList.SubItems.Add(sale.CreatedAt.ToLongDateString());

                salesListView.Items.Add(salesList);
            }
           
        }

        private void SalesBetweenTwoDateForm_Load(object sender, EventArgs e)
        {
            //salesListView.Items.Clear();

            //int count = 0;

            //List<SalesViewModel> allSales = aSalesManager.GetAllSalesManager();

            //foreach (SalesViewModel aSale in allSales)
            //{
            //    count++;

            //    ListViewItem salesList = new ListViewItem(count.ToString());
            //    salesList.SubItems.Add(aSale.ItemName);
            //    salesList.SubItems.Add(aSale.SalesQuantity.ToString());
            //    salesList.SubItems.Add(aSale.CreatedAt.ToLongDateString());

            //    salesListView.Items.Add(salesList);
            //}
        }

        private void pdfSalesReportButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesPrintForm aSalesPrintForm = new SalesPrintForm();
            aSalesPrintForm.Show();
        }
    }
}
