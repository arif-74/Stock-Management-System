namespace StockManagementSystemApp.Reporting
{
    partial class StockPrintForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.showallButton = new System.Windows.Forms.Button();
            this.stockManagementDataSet = new StockManagementSystemApp.StockManagementDataSet();
            this.itemViewModelTableAdapter = new StockManagementSystemApp.StockManagementDataSetTableAdapters.ItemViewModelTableAdapter();
            this.ItemViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.showallButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(798, 449);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "StockItemDataSet";
            reportDataSource2.Value = this.ItemViewModelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "StockManagementSystemApp.Reporting.StockItemReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(614, 449);
            this.reportViewer1.TabIndex = 0;
            // 
            // showallButton
            // 
            this.showallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showallButton.Location = new System.Drawing.Point(23, 188);
            this.showallButton.Name = "showallButton";
            this.showallButton.Size = new System.Drawing.Size(133, 45);
            this.showallButton.TabIndex = 0;
            this.showallButton.Text = "Show All";
            this.showallButton.UseVisualStyleBackColor = true;
            this.showallButton.Click += new System.EventHandler(this.showallButton_Click);
            // 
            // stockManagementDataSet
            // 
            this.stockManagementDataSet.DataSetName = "StockManagementDataSet";
            this.stockManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemViewModelTableAdapter
            // 
            this.itemViewModelTableAdapter.ClearBeforeFill = true;
            // 
            // ItemViewModelBindingSource
            // 
            this.ItemViewModelBindingSource.DataMember = "ItemViewModel";
            this.ItemViewModelBindingSource.DataSource = this.stockManagementDataSet;
            // 
            // StockPrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 449);
            this.Controls.Add(this.splitContainer1);
            this.Name = "StockPrintForm";
            this.Text = "StockPrintForm";
            this.Load += new System.EventHandler(this.StockPrintForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button showallButton;
        private StockManagementDataSet stockManagementDataSet;
        private StockManagementDataSetTableAdapters.ItemViewModelTableAdapter itemViewModelTableAdapter;
        private System.Windows.Forms.BindingSource ItemViewModelBindingSource;
    }
}