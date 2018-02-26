namespace StockManagementSystemApp.UI
{
    partial class SearchViewItemSummaryForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.salesSummaryButton = new System.Windows.Forms.Button();
            this.viewSummaryButton = new System.Windows.Forms.Button();
            this.stockOutSummaryButton = new System.Windows.Forms.Button();
            this.stockInSummaryButton = new System.Windows.Forms.Button();
            this.itemSummaryButton = new System.Windows.Forms.Button();
            this.companySummaryButton = new System.Windows.Forms.Button();
            this.categorySummaryButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.viewSummaryListView = new System.Windows.Forms.ListView();
            this.serialNumberColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.companyColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoryColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.availableQuantityColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reorderLevelColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.companyViewSummaryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryViewSummaryComboBox = new System.Windows.Forms.ComboBox();
            this.searchViewSummaryButton = new System.Windows.Forms.Button();
            this.pdfReportButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.salesSummaryButton);
            this.panel1.Controls.Add(this.viewSummaryButton);
            this.panel1.Controls.Add(this.stockOutSummaryButton);
            this.panel1.Controls.Add(this.stockInSummaryButton);
            this.panel1.Controls.Add(this.itemSummaryButton);
            this.panel1.Controls.Add(this.companySummaryButton);
            this.panel1.Controls.Add(this.categorySummaryButton);
            this.panel1.Location = new System.Drawing.Point(2, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 441);
            this.panel1.TabIndex = 0;
            // 
            // salesSummaryButton
            // 
            this.salesSummaryButton.BackColor = System.Drawing.Color.Gray;
            this.salesSummaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesSummaryButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesSummaryButton.ForeColor = System.Drawing.Color.White;
            this.salesSummaryButton.Location = new System.Drawing.Point(0, 229);
            this.salesSummaryButton.Name = "salesSummaryButton";
            this.salesSummaryButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.salesSummaryButton.Size = new System.Drawing.Size(146, 40);
            this.salesSummaryButton.TabIndex = 0;
            this.salesSummaryButton.Text = "Sales";
            this.salesSummaryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesSummaryButton.UseVisualStyleBackColor = false;
            this.salesSummaryButton.Click += new System.EventHandler(this.salesSummaryButton_Click);
            // 
            // viewSummaryButton
            // 
            this.viewSummaryButton.BackColor = System.Drawing.Color.Gray;
            this.viewSummaryButton.Enabled = false;
            this.viewSummaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewSummaryButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSummaryButton.ForeColor = System.Drawing.Color.White;
            this.viewSummaryButton.Location = new System.Drawing.Point(0, 191);
            this.viewSummaryButton.Name = "viewSummaryButton";
            this.viewSummaryButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.viewSummaryButton.Size = new System.Drawing.Size(146, 40);
            this.viewSummaryButton.TabIndex = 1;
            this.viewSummaryButton.Text = "View Summary";
            this.viewSummaryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewSummaryButton.UseVisualStyleBackColor = false;
            // 
            // stockOutSummaryButton
            // 
            this.stockOutSummaryButton.BackColor = System.Drawing.Color.Gray;
            this.stockOutSummaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockOutSummaryButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockOutSummaryButton.ForeColor = System.Drawing.Color.White;
            this.stockOutSummaryButton.Location = new System.Drawing.Point(0, 153);
            this.stockOutSummaryButton.Name = "stockOutSummaryButton";
            this.stockOutSummaryButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.stockOutSummaryButton.Size = new System.Drawing.Size(146, 40);
            this.stockOutSummaryButton.TabIndex = 2;
            this.stockOutSummaryButton.Text = "Stock Out";
            this.stockOutSummaryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockOutSummaryButton.UseVisualStyleBackColor = false;
            this.stockOutSummaryButton.Click += new System.EventHandler(this.stockOutSummaryButton_Click);
            // 
            // stockInSummaryButton
            // 
            this.stockInSummaryButton.BackColor = System.Drawing.Color.Gray;
            this.stockInSummaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockInSummaryButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockInSummaryButton.ForeColor = System.Drawing.Color.White;
            this.stockInSummaryButton.Location = new System.Drawing.Point(0, 114);
            this.stockInSummaryButton.Name = "stockInSummaryButton";
            this.stockInSummaryButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.stockInSummaryButton.Size = new System.Drawing.Size(146, 40);
            this.stockInSummaryButton.TabIndex = 3;
            this.stockInSummaryButton.Text = "Stock In";
            this.stockInSummaryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockInSummaryButton.UseVisualStyleBackColor = false;
            this.stockInSummaryButton.Click += new System.EventHandler(this.stockInSummaryButton_Click);
            // 
            // itemSummaryButton
            // 
            this.itemSummaryButton.BackColor = System.Drawing.Color.Gray;
            this.itemSummaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemSummaryButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemSummaryButton.ForeColor = System.Drawing.Color.White;
            this.itemSummaryButton.Location = new System.Drawing.Point(0, 76);
            this.itemSummaryButton.Name = "itemSummaryButton";
            this.itemSummaryButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.itemSummaryButton.Size = new System.Drawing.Size(146, 40);
            this.itemSummaryButton.TabIndex = 4;
            this.itemSummaryButton.Text = "Item";
            this.itemSummaryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemSummaryButton.UseVisualStyleBackColor = false;
            this.itemSummaryButton.Click += new System.EventHandler(this.itemSummaryButton_Click);
            // 
            // companySummaryButton
            // 
            this.companySummaryButton.BackColor = System.Drawing.Color.Gray;
            this.companySummaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.companySummaryButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companySummaryButton.ForeColor = System.Drawing.Color.White;
            this.companySummaryButton.Location = new System.Drawing.Point(0, 38);
            this.companySummaryButton.Name = "companySummaryButton";
            this.companySummaryButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.companySummaryButton.Size = new System.Drawing.Size(146, 40);
            this.companySummaryButton.TabIndex = 5;
            this.companySummaryButton.Text = "Company";
            this.companySummaryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.companySummaryButton.UseVisualStyleBackColor = false;
            this.companySummaryButton.Click += new System.EventHandler(this.companySummaryButton_Click);
            // 
            // categorySummaryButton
            // 
            this.categorySummaryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categorySummaryButton.BackColor = System.Drawing.Color.Gray;
            this.categorySummaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categorySummaryButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorySummaryButton.ForeColor = System.Drawing.Color.White;
            this.categorySummaryButton.Location = new System.Drawing.Point(0, 1);
            this.categorySummaryButton.Name = "categorySummaryButton";
            this.categorySummaryButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.categorySummaryButton.Size = new System.Drawing.Size(146, 40);
            this.categorySummaryButton.TabIndex = 6;
            this.categorySummaryButton.Text = "Category";
            this.categorySummaryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categorySummaryButton.UseVisualStyleBackColor = false;
            this.categorySummaryButton.Click += new System.EventHandler(this.categorySummaryButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 45);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Management System Dashboard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(165, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Company";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(165, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // viewSummaryListView
            // 
            this.viewSummaryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serialNumberColumnHeader,
            this.itemNameColumnHeader,
            this.companyColumnHeader,
            this.categoryColumnHeader,
            this.availableQuantityColumnHeader,
            this.reorderLevelColumnHeader});
            this.viewSummaryListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSummaryListView.FullRowSelect = true;
            this.viewSummaryListView.GridLines = true;
            this.viewSummaryListView.Location = new System.Drawing.Point(154, 139);
            this.viewSummaryListView.Name = "viewSummaryListView";
            this.viewSummaryListView.Size = new System.Drawing.Size(627, 333);
            this.viewSummaryListView.TabIndex = 3;
            this.viewSummaryListView.UseCompatibleStateImageBehavior = false;
            this.viewSummaryListView.View = System.Windows.Forms.View.Details;
            // 
            // serialNumberColumnHeader
            // 
            this.serialNumberColumnHeader.Text = "Serial Number";
            this.serialNumberColumnHeader.Width = 78;
            // 
            // itemNameColumnHeader
            // 
            this.itemNameColumnHeader.Text = "Item Name";
            this.itemNameColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.itemNameColumnHeader.Width = 107;
            // 
            // companyColumnHeader
            // 
            this.companyColumnHeader.Text = "Company";
            this.companyColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.companyColumnHeader.Width = 122;
            // 
            // categoryColumnHeader
            // 
            this.categoryColumnHeader.Text = "Category";
            this.categoryColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.categoryColumnHeader.Width = 114;
            // 
            // availableQuantityColumnHeader
            // 
            this.availableQuantityColumnHeader.Text = "Available Quantity";
            this.availableQuantityColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.availableQuantityColumnHeader.Width = 109;
            // 
            // reorderLevelColumnHeader
            // 
            this.reorderLevelColumnHeader.Text = "Reorder Level";
            this.reorderLevelColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.reorderLevelColumnHeader.Width = 93;
            // 
            // companyViewSummaryComboBox
            // 
            this.companyViewSummaryComboBox.FormattingEnabled = true;
            this.companyViewSummaryComboBox.Location = new System.Drawing.Point(254, 60);
            this.companyViewSummaryComboBox.Name = "companyViewSummaryComboBox";
            this.companyViewSummaryComboBox.Size = new System.Drawing.Size(234, 21);
            this.companyViewSummaryComboBox.TabIndex = 0;
            // 
            // categoryViewSummaryComboBox
            // 
            this.categoryViewSummaryComboBox.FormattingEnabled = true;
            this.categoryViewSummaryComboBox.Location = new System.Drawing.Point(254, 101);
            this.categoryViewSummaryComboBox.Name = "categoryViewSummaryComboBox";
            this.categoryViewSummaryComboBox.Size = new System.Drawing.Size(234, 21);
            this.categoryViewSummaryComboBox.TabIndex = 1;
            // 
            // searchViewSummaryButton
            // 
            this.searchViewSummaryButton.BackColor = System.Drawing.Color.Gray;
            this.searchViewSummaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchViewSummaryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchViewSummaryButton.Location = new System.Drawing.Point(507, 101);
            this.searchViewSummaryButton.Name = "searchViewSummaryButton";
            this.searchViewSummaryButton.Size = new System.Drawing.Size(75, 23);
            this.searchViewSummaryButton.TabIndex = 2;
            this.searchViewSummaryButton.Text = "Search";
            this.searchViewSummaryButton.UseVisualStyleBackColor = false;
            this.searchViewSummaryButton.Click += new System.EventHandler(this.searchViewSummaryButton_Click);
            // 
            // pdfReportButton
            // 
            this.pdfReportButton.BackColor = System.Drawing.Color.Gray;
            this.pdfReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pdfReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdfReportButton.Location = new System.Drawing.Point(594, 101);
            this.pdfReportButton.Name = "pdfReportButton";
            this.pdfReportButton.Size = new System.Drawing.Size(75, 23);
            this.pdfReportButton.TabIndex = 4;
            this.pdfReportButton.Text = "Report";
            this.pdfReportButton.UseVisualStyleBackColor = false;
            this.pdfReportButton.Click += new System.EventHandler(this.pdfReportButton_Click);
            // 
            // SearchViewItemSummaryForm
            // 
            this.AcceptButton = this.searchViewSummaryButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 484);
            this.Controls.Add(this.pdfReportButton);
            this.Controls.Add(this.searchViewSummaryButton);
            this.Controls.Add(this.categoryViewSummaryComboBox);
            this.Controls.Add(this.companyViewSummaryComboBox);
            this.Controls.Add(this.viewSummaryListView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SearchViewItemSummaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search & View Item Summary";
            this.Load += new System.EventHandler(this.SearchViewItemSummaryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button salesSummaryButton;
        private System.Windows.Forms.Button viewSummaryButton;
        private System.Windows.Forms.Button stockOutSummaryButton;
        private System.Windows.Forms.Button stockInSummaryButton;
        private System.Windows.Forms.Button itemSummaryButton;
        private System.Windows.Forms.Button companySummaryButton;
        private System.Windows.Forms.Button categorySummaryButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView viewSummaryListView;
        private System.Windows.Forms.ColumnHeader serialNumberColumnHeader;
        private System.Windows.Forms.ColumnHeader itemNameColumnHeader;
        private System.Windows.Forms.ColumnHeader companyColumnHeader;
        private System.Windows.Forms.ColumnHeader categoryColumnHeader;
        private System.Windows.Forms.ColumnHeader availableQuantityColumnHeader;
        private System.Windows.Forms.ColumnHeader reorderLevelColumnHeader;
        private System.Windows.Forms.ComboBox companyViewSummaryComboBox;
        private System.Windows.Forms.ComboBox categoryViewSummaryComboBox;
        private System.Windows.Forms.Button searchViewSummaryButton;
        private System.Windows.Forms.Button pdfReportButton;

    }
}

