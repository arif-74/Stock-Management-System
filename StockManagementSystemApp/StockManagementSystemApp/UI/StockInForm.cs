using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using StockManagementSystemApp.Manager;
using StockManagementSystemApp.Model;

namespace StockManagementSystemApp.UI
{
    public partial class StockInForm : Form
    {
        public StockInForm()
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

        private void OpenStockOutForm()
        {
            Application.Run(new StockOutForm());
        }
        private void OpenViewSummaryForm()
        {
            Application.Run(new SearchViewItemSummaryForm());
        }

        private void OpenSalesForm()
        {
            Application.Run(new SalesBetweenTwoDateForm());
        }

        private void categoryStockInButton_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();

            this.Close();
            thread = new Thread(OpenCategoryForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void companyStockInButton_Click(object sender, EventArgs e)
        {
            CompanyForm companyForm = new CompanyForm();

            this.Close();
            thread = new Thread(OpenCompanyForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void itemStockInButton_Click(object sender, EventArgs e)
        {
            ItemForm itemForm = new ItemForm();

            this.Close();
            thread = new Thread(OpenItemForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void stockOutStockInButton_Click(object sender, EventArgs e)
        {
            StockOutForm stockOutForm = new StockOutForm();

            this.Close();
            thread = new Thread(OpenStockOutForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void viewSummaryStockInButton_Click(object sender, EventArgs e)
        {
            SearchViewItemSummaryForm searchViewItemSummaryForm = new SearchViewItemSummaryForm();

            this.Close();
            thread = new Thread(OpenViewSummaryForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void salesStockInButton_Click(object sender, EventArgs e)
        {
            SalesBetweenTwoDateForm salesBetweenTwoDateForm = new SalesBetweenTwoDateForm();

            this.Close();
            thread = new Thread(OpenSalesForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void addCompanyStockInButton_Click(object sender, EventArgs e)
        {
            CompanyForm companyForm = new CompanyForm();

            this.Close();
            thread = new Thread(OpenCompanyForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void addItemStockInButton_Click(object sender, EventArgs e)
        {
            ItemForm itemForm = new ItemForm();

            this.Close();
            thread = new Thread(OpenItemForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }


        private CompanyManager aCompanyManager = new CompanyManager();
        private ItemManager aItemManager = new ItemManager();

        private void saveStockInButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(companyStockInComboBox.SelectedValue) == -1)
            {
                MessageBox.Show("please select a Company");
                return;
            }

            if (Convert.ToInt32(itemStockInComboBox.SelectedValue) == -1)
            {
                MessageBox.Show("please select a Item");
                return;
            }

            if (string.IsNullOrEmpty(quantityStockInTextBox.Text) || quantityStockInTextBox.Text == 0.ToString())
            {
                MessageBox.Show("give quantity please");
                return;
            }


            Item aItem = new Item();

            aItem.Id = Convert.ToInt32(itemStockInComboBox.SelectedValue);
           
            aItem.GetQuantityUpdate(Convert.ToInt32(availableQuantityStockInTextBox.Text),Convert.ToInt32(quantityStockInTextBox.Text));
           
            
            string message = aItemManager.UpdateItemQuantityManager(aItem);

            MessageBox.Show(message);

            companyStockInComboBox.SelectedValue = -1;
            itemStockInComboBox.SelectedValue = -1;
            reorderLevelStockInTextBox.Clear();
            availableQuantityStockInTextBox.Clear();
            quantityStockInTextBox.Clear();
        }

        private void StockInForm_Load(object sender, EventArgs e)
        {
            Company defaultCompany = new Company();

            defaultCompany.CompanyName = "--Select Company--";
            defaultCompany.Id = -1;

            List<Company> companys = new List<Company>();

            companys.Add(defaultCompany);
            companys.AddRange(aCompanyManager.GetAllCompanysManager());

            companyStockInComboBox.DisplayMember = "CompanyName";
            companyStockInComboBox.ValueMember = "Id";
            companyStockInComboBox.DataSource = companys;
        }

        private void companyStockInComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item aItem = new Item();

            aItem.CompanyId = (int)companyStockInComboBox.SelectedValue;

            Item defaultItem = new Item();

            defaultItem.ItemName = "--Select Item--";
            defaultItem.Id = -1;

            List<Item> items = new List<Item>();

            items.Add(defaultItem);
            items.AddRange(aItemManager.GetItemForComapnyManager(aItem));

            itemStockInComboBox.DisplayMember = "ItemName";
            itemStockInComboBox.ValueMember = "Id";
            itemStockInComboBox.DataSource = items;
        }

        private void itemStockInComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item aItem = new Item();

            aItem.CompanyId = (int)companyStockInComboBox.SelectedValue;
            aItem.Id = (int)itemStockInComboBox.SelectedValue;


            List<Item> items = new List<Item>();

            items = aItemManager.GetItemForReorderQuantityManager(aItem);

            foreach (Item item in items)
            {
                reorderLevelStockInTextBox.Text = item.ItemReorderLevel.ToString();
                availableQuantityStockInTextBox.Text = item.ItemQuantity.ToString();
            }
        }


    }
}
