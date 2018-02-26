using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using StockManagementSystemApp.Manager;
using StockManagementSystemApp.Model;

namespace StockManagementSystemApp.UI
{
    public partial class CompanyForm : Form
    {
        public CompanyForm()
        {
            InitializeComponent();
        }

        private Thread thread;

        private void OpenCategoryForm()
        {
            Application.Run(new CategoryForm());
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

        private void OpenSalesForm()
        {
            Application.Run(new SalesBetweenTwoDateForm());
        }

        private void categoryCompanyButton_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();

            this.Close();
            thread = new Thread(OpenCategoryForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void itemCompanyButton_Click(object sender, EventArgs e)
        {
            ItemForm itemForm = new ItemForm();

            this.Close();
            thread = new Thread(OpenItemForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void stockInCompanyButton_Click(object sender, EventArgs e)
        {
            StockInForm stockInForm = new StockInForm();

            this.Close();
            thread = new Thread(OpenStockInForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void stockOutCompanyButton_Click(object sender, EventArgs e)
        {
            StockOutForm stockOutForm = new StockOutForm();

            this.Close();
            thread = new Thread(OpenStockOutForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void viewSummaryCompanyButton_Click(object sender, EventArgs e)
        {
            SearchViewItemSummaryForm searchViewItemSummaryForm = new SearchViewItemSummaryForm();

            this.Close();
            thread = new Thread(OpenViewSummaryForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void salesCompanyButton_Click(object sender, EventArgs e)
        {
            SalesBetweenTwoDateForm salesBetweenTwoDateForm = new SalesBetweenTwoDateForm();

            this.Close();
            thread = new Thread(OpenSalesForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }


        private CompanyManager aCompanyManager = new CompanyManager();

        private void saveCompanyButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(companyNameCompanyTextBox.Text))                                 // checking is nametextbox is empty or not
            {
                MessageBox.Show("first write Company name please");
                return;                                                                 // when we write return it go out from the method without executing further.
            }

            Company aCompany = new Company();

            aCompany.CompanyName = companyNameCompanyTextBox.Text;

            if (saveCompanyButton.Text == "Save")
            {
                string message = aCompanyManager.SaveCompanyManager(aCompany);

                MessageBox.Show(message);
            }
            else
            {
                aCompany.Id = Convert.ToInt32(hiddenIdCompany.Text);

                string message = aCompanyManager.UpdateCompanyManager(aCompany);

                MessageBox.Show(message);

                saveCompanyButton.Text = "Save";
                //deleteCompanyButton.Enabled = false;
            }

            PopulateAllCompany();
        }

        private void CompanyForm_Load(object sender, EventArgs e)
        {
            PopulateAllCompany();
        }

        private void PopulateAllCompany()
        {
            companyListView.Items.Clear();

            int count = 0;

            List<Company> companys = aCompanyManager.GetAllCompanysManager();

            foreach (Company company in companys)
            {
                count++;

                ListViewItem item = new ListViewItem(count.ToString());
                item.SubItems.Add(company.CompanyName);

                item.Tag = company;

                companyListView.Items.Add(item);
            }
        }


        private void companyListView_DoubleClick(object sender, EventArgs e)
        {
            Company aCompany = companyListView.SelectedItems[0].Tag as Company;

            if (aCompany != null)
            {
                hiddenIdCompany.Text = aCompany.Id.ToString();
                companyNameCompanyTextBox.Text = aCompany.CompanyName;

                saveCompanyButton.Text = "Edit";

                saveCompanyButton.Enabled = true;
               // deleteCompanyButton.Enabled = true;

            }
        }

        private void deleteCompanyButton_Click(object sender, EventArgs e)
        {
            int deletedId = Convert.ToInt32(hiddenIdCompany.Text);

            string message = aCompanyManager.DeleteCompanyManager(deletedId);

            MessageBox.Show(message);


            companyNameCompanyTextBox.Clear();
            hiddenIdCompany.Text = String.Empty;

            PopulateAllCompany();

            saveCompanyButton.Text = "save";
            //deleteCompanyButton.Enabled = false;
        }

        private void resetCompanyButton_Click(object sender, EventArgs e)
        {
            companyNameCompanyTextBox.Clear();

            hiddenIdCompany.Text = String.Empty;

            saveCompanyButton.Text = "Save";
            //deleteCompanyButton.Enabled = false;
        }



    }
}
