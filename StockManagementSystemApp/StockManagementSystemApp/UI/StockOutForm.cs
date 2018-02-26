using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using StockManagementSystemApp.Manager;
using StockManagementSystemApp.Model;

namespace StockManagementSystemApp.UI
{
    public partial class StockOutForm : Form
    {
        public StockOutForm()
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

        private void OpenViewSummaryForm()
        {
            Application.Run(new SearchViewItemSummaryForm());
        }

        private void OpenSalesForm()
        {
            Application.Run(new SalesBetweenTwoDateForm());
        }

        private void categoryStockOutButton_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();

            this.Close();
            thread = new Thread(OpenCategoryForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void companyStockOutButton_Click(object sender, EventArgs e)
        {
            CompanyForm companyForm = new CompanyForm();

            this.Close();
            thread = new Thread(OpenCompanyForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void itemStockOutButton_Click(object sender, EventArgs e)
        {
            ItemForm itemForm = new ItemForm();

            this.Close();
            thread = new Thread(OpenItemForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void stockInStockOutButton_Click(object sender, EventArgs e)
        {
            StockInForm stockInForm = new StockInForm();

            this.Close();
            thread = new Thread(OpenStockInForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void viewSummaryStockOutButton_Click(object sender, EventArgs e)
        {
            SearchViewItemSummaryForm searchViewItemSummaryForm = new SearchViewItemSummaryForm();

            this.Close();
            thread = new Thread(OpenViewSummaryForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void salesStockOutButton_Click(object sender, EventArgs e)
        {
            SalesBetweenTwoDateForm salesBetweenTwoDateForm = new SalesBetweenTwoDateForm();

            this.Close();
            thread = new Thread(OpenSalesForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void addCompanyStockOutButton_Click(object sender, EventArgs e)
        {
            CompanyForm companyForm = new CompanyForm();

            this.Close();
            thread = new Thread(OpenCompanyForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void addItemStockOutButton_Click(object sender, EventArgs e)
        {
            ItemForm itemForm = new ItemForm();

            this.Close();
            thread = new Thread(OpenItemForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }


        private CompanyManager aCompanyManager = new CompanyManager();
        private ItemManager aItemManager = new ItemManager();
        private  SalesManager aSalesManager = new SalesManager();
        private int count;

        private void saveStockOutButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(companyStockOutComboBox.SelectedValue) == -1)
            {
                MessageBox.Show("please select a Company");
                return;
            }

            if (Convert.ToInt32(itemStockOutComboBox.SelectedValue) == -1)
            {
                MessageBox.Show("please select a Item");
                return;
            }

            if (string.IsNullOrEmpty(quantityStockOutTextBox.Text) || quantityStockOutTextBox.Text == 0.ToString())
            {
                MessageBox.Show("give quantity please");
                return;
            }


            Item aItem = new Item();
            
            aItem.Id = Convert.ToInt32(itemStockOutComboBox.SelectedValue);
            aItem.ItemName = itemStockOutComboBox.Text;

            Sales aSales = new Sales();

            aSales.ItemId = Convert.ToInt32(itemStockOutComboBox.SelectedValue);
            aSales.SalesQuantity = Convert.ToInt32(quantityStockOutTextBox.Text);

            aItem.SalesList.Add(aSales);

            if (saveStockOutButton.Text == "save")
            {
                aItem.CompanyId = (int)companyStockOutComboBox.SelectedValue;

                int updatedAvailableQuantity = Convert.ToInt32(availableQuantityStockOutTextBox.Text);
                int outQuantity = Convert.ToInt32(quantityStockOutTextBox.Text);


                if (updatedAvailableQuantity < outQuantity)
                {
                    MessageBox.Show("You dont have sufficient Available Quantity");
                    return;
                }
                else if (updatedAvailableQuantity <= 0)
                {
                    MessageBox.Show("Insufficient Available Quantity");
                    return;
                }
                else if (outQuantity <= 0)
                {
                    MessageBox.Show("Give some Proper Qunatity");
                    return;
                }
                else
                {
                    aItem.ItemQuantity = aItem.GetAvailableQuantity(updatedAvailableQuantity, outQuantity);
                }
                

                aItemManager.UpdateItemQuantityManager(aItem);
                                               
            }
            else
            {
                aItem.Id = Convert.ToInt32(hiddenItemIdForEdit.Text);
                aItem.CompanyId = Convert.ToInt32(companyStockOutComboBox.SelectedValue);
                aItem.outQuantity = Convert.ToInt32(quantityStockOutTextBox.Text);

                int previousQuantity = Convert.ToInt32(hiddenQuantityForEdit.Text);
                int availableQuatity = Convert.ToInt32(availableQuantityStockOutTextBox.Text);
                int newQuantity = Convert.ToInt32(quantityStockOutTextBox.Text);


                if (availableQuatity < newQuantity && previousQuantity < newQuantity)
                {
                    MessageBox.Show("You dont have sufficient Available Quantity");
                    return;
                }
                else if (availableQuatity <= 0 && previousQuantity < newQuantity)
                {
                    MessageBox.Show("Insufficient Available Quantity");
                    return;
                }
                else if (newQuantity <= 0)
                {
                    MessageBox.Show("Give some Proper Qunatity");
                    return;
                }
                else
                {
                    aItem.ItemQuantity = aItem.GetQuantityAfterEdit(previousQuantity, availableQuatity, newQuantity);
                }



                string message = aItemManager.UpdateItemQuantityManager(aItem);
               
                MessageBox.Show(message);

                saveStockOutButton.Text = "Save";
                deleteStockOutButton.Enabled = false;
            }

            List<Item> items = aItem.GetAllItems();

            foreach (Item item in items)
            {
                count += 1;

                ListViewItem itemList = new ListViewItem(count.ToString());
                itemList.SubItems.Add(item.ItemName);
                itemList.SubItems.Add(item.outQuantity.ToString());
                itemList.SubItems.Add(item.CompanyId.ToString());
                itemList.SubItems.Add(item.Id.ToString());

                itemList.Tag = item;

                stockOutListView.Items.Add(itemList);
            }

            companyStockOutComboBox.SelectedValue = -1;
            itemStockOutComboBox.SelectedValue = -1;
            reorderLevelStockOutTextBox.Clear();
            availableQuantityStockOutTextBox.Clear();
            quantityStockOutTextBox.Clear();
        }

        private void StockOutForm_Load(object sender, EventArgs e)
        {
            Company defaultCompany = new Company();

            defaultCompany.CompanyName = "--Select Company--";
            defaultCompany.Id = -1;

            List<Company> companys = new List<Company>();

            companys.Add(defaultCompany);
            companys.AddRange(aCompanyManager.GetAllCompanysManager());

            companyStockOutComboBox.DisplayMember = "CompanyName";
            companyStockOutComboBox.ValueMember = "Id";
            companyStockOutComboBox.DataSource = companys;
        }

        private void companyStockOutComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            availableQuantityStockOutTextBox.Clear();
            reorderLevelStockOutTextBox.Clear();
            quantityStockOutTextBox.Text = String.Empty;

            saveStockOutButton.Text = "save";
            deleteStockOutButton.Enabled = false;


            Item aItem = new Item();

            aItem.CompanyId = (int)companyStockOutComboBox.SelectedValue;

            Item defaultItem = new Item();

            defaultItem.ItemName = "--Select Item--";
            defaultItem.Id = -1;

            List<Item> items = new List<Item>();

            items.Add(defaultItem);
            items.AddRange(aItemManager.GetItemForComapnyManager(aItem));

            itemStockOutComboBox.DisplayMember = "ItemName";
            itemStockOutComboBox.ValueMember = "Id";
            itemStockOutComboBox.DataSource = items;
        }

        private void itemStockOutComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item aItem = new Item();

            aItem.CompanyId = (int)companyStockOutComboBox.SelectedValue;
            aItem.Id = (int)itemStockOutComboBox.SelectedValue;


            List<Item> items = new List<Item>();

            items = aItemManager.GetItemForReorderQuantityManager(aItem);

            foreach (Item item in items)
            {
                reorderLevelStockOutTextBox.Text = item.ItemReorderLevel.ToString();
                availableQuantityStockOutTextBox.Text = item.ItemQuantity.ToString();
            }
        }

        private void stockOutListView_DoubleClick(object sender, EventArgs e)
        {
            Item aItem = stockOutListView.SelectedItems[0].Tag as Item;

            stockOutListView.Items[0].Remove();

            if (aItem != null)
            {
                hiddenItemIdForEdit.Text = aItem.Id.ToString();
                hiddenQuantityForEdit.Text = aItem.outQuantity.ToString();

                companyStockOutComboBox.SelectedValue = aItem.CompanyId;
                itemStockOutComboBox.SelectedValue = aItem.Id;
                availableQuantityStockOutTextBox.Text = aItem.ItemQuantity.ToString();
                reorderLevelStockOutTextBox.Text = aItem.ItemReorderLevel.ToString();
                quantityStockOutTextBox.Text = aItem.outQuantity.ToString();

                saveStockOutButton.Text = "Edit";

                saveStockOutButton.Enabled = true;
                deleteStockOutButton.Enabled = true;
            }
        }


        private void resetStockOutButton_Click(object sender, EventArgs e)
        {
            companyStockOutComboBox.SelectedValue = -1;
            itemStockOutComboBox.SelectedValue = -1;
            availableQuantityStockOutTextBox.Clear();
            reorderLevelStockOutTextBox.Clear();
            quantityStockOutTextBox.Text = String.Empty;
            hiddenQuantityForEdit.Text = String.Empty;

            saveStockOutButton.Text = "save";
            deleteStockOutButton.Enabled = false;
        }

        private void deleteStockOutButton_Click(object sender, EventArgs e)
        {
            Item aItem = new Item();

            aItem.Id = Convert.ToInt32(itemStockOutComboBox.SelectedValue);

            aItem.GetQuantityUpdate(Convert.ToInt32(availableQuantityStockOutTextBox.Text), Convert.ToInt32(quantityStockOutTextBox.Text));


            string message = aItemManager.UpdateItemQuantityFromDeleteManager(aItem);

            MessageBox.Show(message);

            companyStockOutComboBox.SelectedValue = -1;
            itemStockOutComboBox.SelectedValue = -1;
            reorderLevelStockOutTextBox.Clear();
            availableQuantityStockOutTextBox.Clear();
            quantityStockOutTextBox.Clear();
        }


        private void sellStockOutButton_Click(object sender, EventArgs e)
        {
            string message="";
            for (int i = 0; i < stockOutListView.Items.Count; i++)
            {
                Sales aSale = new Sales();

                aSale.ItemId = Convert.ToInt32(stockOutListView.Items[i].SubItems[4].Text);
                aSale.SalesQuantity = Convert.ToInt32(stockOutListView.Items[i].SubItems[2].Text);

                message = aSalesManager.SaveIntoSalesManager(aSale);
            }

            MessageBox.Show(message);

            stockOutListView.Items.Clear();
        }

        private void damageStockOutButton_Click(object sender, EventArgs e)
        {
            stockOutListView.Items.Clear();
            MessageBox.Show("Count the Damage Quantity");
        }

        private void lostStockOutButton_Click(object sender, EventArgs e)
        {
            stockOutListView.Items.Clear();
            MessageBox.Show("Count the Lost Quantity");
        }


        

        
    }
}
