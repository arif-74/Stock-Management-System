namespace StockManagementSystemApp.Reporting
{
    partial class SalesPrintForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SalesViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockManagementDataSet = new StockManagementSystemApp.StockManagementDataSet();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.showSalesButton = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.salesViewModelTableAdapter = new StockManagementSystemApp.StockManagementDataSetTableAdapters.SalesViewModelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SalesViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalesViewModelBindingSource
            // 
            this.SalesViewModelBindingSource.DataMember = "SalesViewModel";
            this.SalesViewModelBindingSource.DataSource = this.stockManagementDataSet;
            // 
            // stockManagementDataSet
            // 
            this.stockManagementDataSet.DataSetName = "StockManagementDataSet";
            this.stockManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.showSalesButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(641, 473);
            this.splitContainer1.SplitterDistance = 151;
            this.splitContainer1.TabIndex = 0;
            // 
            // showSalesButton
            // 
            this.showSalesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showSalesButton.Location = new System.Drawing.Point(33, 178);
            this.showSalesButton.Name = "showSalesButton";
            this.showSalesButton.Size = new System.Drawing.Size(94, 40);
            this.showSalesButton.TabIndex = 0;
            this.showSalesButton.Text = "Show Sales";
            this.showSalesButton.UseVisualStyleBackColor = true;
            this.showSalesButton.Click += new System.EventHandler(this.showSalesButton_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "SalesViewDataSet";
            reportDataSource1.Value = this.SalesViewModelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "StockManagementSystemApp.Reporting.SalesReportForm.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(486, 473);
            this.reportViewer1.TabIndex = 0;
            // 
            // salesViewModelTableAdapter
            // 
            this.salesViewModelTableAdapter.ClearBeforeFill = true;
            // 
            // SalesPrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 473);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SalesPrintForm";
            this.Text = "Sales Print Form";
            this.Load += new System.EventHandler(this.SalesPrintForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementDataSet)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button showSalesButton;
        private StockManagementDataSet stockManagementDataSet;
        private StockManagementDataSetTableAdapters.SalesViewModelTableAdapter salesViewModelTableAdapter;
        private System.Windows.Forms.BindingSource SalesViewModelBindingSource;
    }
}