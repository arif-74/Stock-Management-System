using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystemApp.Reporting
{
    public partial class SalesPrintForm : Form
    {
        public SalesPrintForm()
        {
            InitializeComponent();
        }

        private void SalesPrintForm_Load(object sender, EventArgs e)
        {
            
        }

        private void showSalesButton_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockManagementDataSet.SalesViewModel' table. You can move, or remove it, as needed.
            this.salesViewModelTableAdapter.Fill(this.stockManagementDataSet.SalesViewModel);
            this.reportViewer1.RefreshReport();
        }
    }
}
