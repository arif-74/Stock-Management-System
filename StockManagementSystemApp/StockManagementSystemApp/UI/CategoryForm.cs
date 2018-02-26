using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;
using StockManagementSystemApp.Manager;
using StockManagementSystemApp.Model;

namespace StockManagementSystemApp.UI
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private Thread thread;

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

        private void OpenSalesForm()
        {
            Application.Run(new SalesBetweenTwoDateForm());
        }

        private void companyCategoryButton_Click(object sender, EventArgs e)
        {
            CompanyForm companyForm = new CompanyForm();

            this.Close();
            thread = new Thread(OpenCompanyForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void itemCategoryButton_Click(object sender, EventArgs e)
        {
            ItemForm itemForm = new ItemForm();

            this.Close();
            thread = new Thread(OpenItemForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void stockInCategoryButton_Click(object sender, EventArgs e)
        {
            StockInForm stockInForm = new StockInForm();

            this.Close();
            thread = new Thread(OpenStockInForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void stockOutCategoryButton_Click(object sender, EventArgs e)
        {
            StockOutForm stockOutForm = new StockOutForm();

            this.Close();
            thread = new Thread(OpenStockOutForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void viewSummaryCategoryButton_Click(object sender, EventArgs e)
        {
            SearchViewItemSummaryForm searchViewItemSummaryForm = new SearchViewItemSummaryForm();

            this.Close();
            thread = new Thread(OpenViewSummaryForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void salesCategoryButton_Click(object sender, EventArgs e)
        {
            SalesBetweenTwoDateForm salesBetweenTwoDateForm = new SalesBetweenTwoDateForm();

            this.Close();
            thread = new Thread(OpenSalesForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }


        private CategoryManager aCategoryManager = new CategoryManager();

        private void saveCategoryButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(categoryNameCategoryTextBox.Text))                                 // checking is nametextbox is empty or not
            {
                MessageBox.Show("first write category name please");
                return;                                                                 // when we write return it go out from the method without executing further.
            }
            
            Category aCategory = new Category();

            aCategory.CategoryName = categoryNameCategoryTextBox.Text;
            
            if (saveCategoryButton.Text == "Save")
            {
                string message = aCategoryManager.SaveCategoryManager(aCategory);

                MessageBox.Show(message);
            }
            else
            {
                aCategory.Id = Convert.ToInt32(hiddenIdCategory.Text);

                string message = aCategoryManager.UpdateCategoryManager(aCategory);

                MessageBox.Show(message);

                saveCategoryButton.Text = "Save";
                //deleteCategoryButton.Enabled = false;
            }

            PopulateAllCategory();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            PopulateAllCategory();
        }

        private void PopulateAllCategory()
        {
            categoryListView.Items.Clear();

            int count = 0;

            List<Category> categories = aCategoryManager.GetAllCategoriesManager();

            foreach (Category category in categories)
            {
                count++;

                ListViewItem item = new ListViewItem(count.ToString());
                item.SubItems.Add(category.CategoryName);

                item.Tag = category;

                categoryListView.Items.Add(item);
            }
        }

        private void categoryListView_DoubleClick(object sender, EventArgs e)
        {
            Category aCategory = categoryListView.SelectedItems[0].Tag as Category;

            if (aCategory != null)
            {
                hiddenIdCategory.Text = aCategory.Id.ToString();
                categoryNameCategoryTextBox.Text = aCategory.CategoryName;

                saveCategoryButton.Text = "Edit";

                saveCategoryButton.Enabled = true;
                //deleteCategoryButton.Enabled = true;

            }
        }

        private void deleteCategoryButton_Click(object sender, EventArgs e)
        {
            int deletedId = Convert.ToInt32(hiddenIdCategory.Text);

            string message = aCategoryManager.DeleteCategoryManager(deletedId);

            MessageBox.Show(message);


            categoryNameCategoryTextBox.Clear();
            hiddenIdCategory.Text = String.Empty;

            PopulateAllCategory();

            saveCategoryButton.Text = "save";
            //deleteCategoryButton.Enabled = false;
        }

        private void resetCategoryButton_Click(object sender, EventArgs e)
        {
            categoryNameCategoryTextBox.Clear();

            hiddenIdCategory.Text = String.Empty;

            saveCategoryButton.Text = "save";
            //deleteCategoryButton.Enabled = false;
        }

        private void searchCategoryButton_Click(object sender, EventArgs e)
        {


        //string strConn = ConfigurationManager.ConnectionStrings["stockManagementSystemConnection"].ConnectionString;
        //SqlConnection conn = new SqlConnection(strConn);
        //conn.Open();
        //SqlCommand cmd = new SqlCommand("Select * FROM category WHERE category_name=@categoryname", conn);

        //try
        //{

        //    SqlParameter search = new SqlParameter();
        //    search.ParameterName = "@categoryname";
        //    search.Value = searchCategoryButton.Text.Trim();

        //    cmd.Parameters.Add(search);
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    DataTable dt = new DataTable();
        //    dt.Load(dr);

          
        //    //gvPatients.DataSource = dt;
        //    //gvPatients.DataBind();
        //}
        //catch (Exception ex)
        //{
        //    //Response.Write(ex.Message);
        //}
        //finally
        //{
        //    //Connection Object Closed
        //    conn.Close();
        //}
    

        }


    }
}
