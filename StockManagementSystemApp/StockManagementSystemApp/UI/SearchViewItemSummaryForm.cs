using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using StockManagementSystemApp.Manager;
using StockManagementSystemApp.Model;
using StockManagementSystemApp.Model.View_Model;
using iTextSharp.text;

using iTextSharp.text.pdf;

using iTextSharp.text.html;

using iTextSharp.text.html.simpleparser;


using iTextSharp.text;                  // for generating pdf
using iTextSharp.text.pdf;
using System.IO;
using StockManagementSystemApp.Reporting;

namespace StockManagementSystemApp.UI
{
    public partial class SearchViewItemSummaryForm : Form
    {
        public SearchViewItemSummaryForm()
        {
            InitializeComponent();
        }

        private Thread thread;

        private void OpenCategoryForm()
        {
            Application.Run(new CategoryForm() );
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

        private void OpenSalesForm()
        {
            Application.Run(new SalesBetweenTwoDateForm());
        }

        private void categorySummaryButton_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();

            this.Close();
            thread = new Thread(OpenCategoryForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void companySummaryButton_Click(object sender, EventArgs e)
        {
            CompanyForm companyForm = new CompanyForm();

            this.Close();
            thread = new Thread(OpenCompanyForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void itemSummaryButton_Click(object sender, EventArgs e)
        {
            ItemForm itemForm = new ItemForm();

            this.Close();
            thread = new Thread(OpenItemForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void stockInSummaryButton_Click(object sender, EventArgs e)
        {
            StockInForm stockInForm = new StockInForm();

            this.Close();
            thread = new Thread(OpenStockInForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void stockOutSummaryButton_Click(object sender, EventArgs e)
        {
            StockOutForm stockOutForm = new StockOutForm();

            this.Close();
            thread = new Thread(OpenStockOutForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void salesSummaryButton_Click(object sender, EventArgs e)
        {
            SalesBetweenTwoDateForm salesBetweenTwoDateForm = new SalesBetweenTwoDateForm();

            this.Close();
            thread = new Thread(OpenSalesForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }


        private CategoryManager aCategoryManager = new CategoryManager();
        private CompanyManager aCompanyManager = new CompanyManager();
        private ItemManager aItemManager = new ItemManager();

        private void searchViewSummaryButton_Click(object sender, EventArgs e)
        {
            ItemViewModel aItem = new ItemViewModel();

            aItem.CompanyId = Convert.ToInt32(companyViewSummaryComboBox.SelectedValue);
            aItem.CategoryId = Convert.ToInt32(categoryViewSummaryComboBox.SelectedValue);

            viewSummaryListView.Items.Clear();
            
            int count = 0;

            List<ItemViewModel> items = new List<ItemViewModel>();


            if(aItem.CompanyId == -1 && aItem.CategoryId == -1)
            {
                PopulateItems();
            }
            else if (aItem.CompanyId == -1)
            {
                items = aItemManager.SearchItemManager(aItem);
            }
            else if (aItem.CategoryId == -1)
            {
                items = aItemManager.SearchItemManager(aItem);
            }
            else if (aItem.CompanyId != -1 && aItem.CategoryId != -1)
            {
                items = aItemManager.SearchBothItemManager(aItem);
            }
            

            foreach (ItemViewModel item in items)
            {
                count++;

                ListViewItem itemList = new ListViewItem(count.ToString());
                itemList.SubItems.Add(item.ItemName);
                itemList.SubItems.Add(item.CompanyName);
                itemList.SubItems.Add(item.CategoryName);
                itemList.SubItems.Add(item.ItemQuantity.ToString());
                itemList.SubItems.Add(item.ItemReorderLevel.ToString());

                viewSummaryListView.Items.Add(itemList);
            }
           
            //companyViewSummaryComboBox.SelectedValue = -1;
            //categoryViewSummaryComboBox.SelectedValue = -1;
        }

        private void SearchViewItemSummaryForm_Load(object sender, EventArgs e)
        {
            Company defaultCompany = new Company();

            defaultCompany.CompanyName = "--Select Company--";
            defaultCompany.Id = -1;

            List<Company> companys = new List<Company>();

            companys.Add(defaultCompany);
            companys.AddRange(aCompanyManager.GetAllCompanysManager());

            companyViewSummaryComboBox.DisplayMember = "CompanyName";
            companyViewSummaryComboBox.ValueMember = "Id";
            companyViewSummaryComboBox.DataSource = companys;


            Category defaultCategory = new Category();

            defaultCategory.CategoryName = "--Select Category--";
            defaultCategory.Id = -1;

            List<Category> categories = new List<Category>();

            categories.Add(defaultCategory);
            categories.AddRange(aCategoryManager.GetAllCategoriesManager());

            categoryViewSummaryComboBox.DisplayMember = "CategoryName";
            categoryViewSummaryComboBox.ValueMember = "Id";
            categoryViewSummaryComboBox.DataSource = categories;


            PopulateItems();
        }

        private void PopulateItems()
        {
            viewSummaryListView.Items.Clear();

            int count = 0;

            List<ItemViewModel> items = aItemManager.GetAllItemManager();

            foreach (ItemViewModel item in items)
            {
                count++;

                ListViewItem itemList = new ListViewItem(count.ToString());
                itemList.SubItems.Add(item.ItemName);
                itemList.SubItems.Add(item.CompanyName);
                itemList.SubItems.Add(item.CategoryName);
                itemList.SubItems.Add(item.ItemQuantity.ToString());
                itemList.SubItems.Add(item.ItemReorderLevel.ToString());

                viewSummaryListView.Items.Add(itemList);
            }
        }

        private void pdfReportButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockPrintForm aStockPrintForm= new StockPrintForm();
            aStockPrintForm.Show();
        }

    }
}
