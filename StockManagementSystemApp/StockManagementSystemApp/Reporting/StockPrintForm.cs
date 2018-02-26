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
    public partial class StockPrintForm : Form
    {
        public StockPrintForm()
        {
            InitializeComponent();
        }

        private void StockPrintForm_Load(object sender, EventArgs e)
        {

        }

        private void showallButton_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockManagementDataSet.ItemViewModel' table. You can move, or remove it, as needed.
            this.itemViewModelTableAdapter.Fill(this.stockManagementDataSet.ItemViewModel);

            this.reportViewer1.RefreshReport();
        }
    }
}
