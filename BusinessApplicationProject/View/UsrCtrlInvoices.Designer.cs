namespace BusinessApplicationProject.View
{
    partial class UsrCtrlInvoices
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            LblNoResults = new Label();
            DataGridViewInvoices = new DataGridView();
            CmdCopyCustomerNumber = new Button();
            CmdCopyOrderNumber = new Button();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label8 = new Label();
            label10 = new Label();
            TxtStreetAddress = new TextBox();
            label6 = new Label();
            label9 = new Label();
            DatPckInvoiceDateTo = new DateTimePicker();
            TxtSearchCountry = new TextBox();
            DatPckInvoiceDateFrom = new DateTimePicker();
            TxtSearchZipCode = new TextBox();
            TxtSearchLastName = new TextBox();
            label11 = new Label();
            label7 = new Label();
            TxtSearchFirstName = new TextBox();
            label5 = new Label();
            TxtSearchOrderNumber = new TextBox();
            label3 = new Label();
            CmdResetFilters = new Button();
            TxtSearchCustomerNumber = new TextBox();
            label2 = new Label();
            TxtSearchInvoiceNumber = new TextBox();
            label1 = new Label();
            CmdSearchInvoices = new Button();
            DataGridViewOrderDetails = new DataGridView();
            DataGridViewOrderPositions = new DataGridView();
            CmdCopyArticleNumber = new Button();
            DataGridViewCustomerInformations = new DataGridView();
            label12 = new Label();
            DataGridViewBillingAddress = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewInvoices).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewOrderDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewOrderPositions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCustomerInformations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewBillingAddress).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LblNoResults);
            groupBox1.Controls.Add(DataGridViewInvoices);
            groupBox1.Location = new Point(3, 326);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(750, 694);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Results";
            // 
            // LblNoResults
            // 
            LblNoResults.AutoSize = true;
            LblNoResults.Location = new Point(261, 268);
            LblNoResults.Name = "LblNoResults";
            LblNoResults.Size = new Size(230, 25);
            LblNoResults.TabIndex = 4;
            LblNoResults.Text = "No items meet filter criteria.";
            LblNoResults.Visible = false;
            // 
            // DataGridViewInvoices
            // 
            DataGridViewInvoices.AllowUserToDeleteRows = false;
            DataGridViewInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewInvoices.Location = new Point(7, 32);
            DataGridViewInvoices.Margin = new Padding(4, 5, 4, 5);
            DataGridViewInvoices.MultiSelect = false;
            DataGridViewInvoices.Name = "DataGridViewInvoices";
            DataGridViewInvoices.ReadOnly = true;
            DataGridViewInvoices.RowHeadersWidth = 62;
            DataGridViewInvoices.Size = new Size(738, 482);
            DataGridViewInvoices.TabIndex = 2;
            DataGridViewInvoices.CellClick += DataGridViewInvoices_CellClick;
            // 
            // CmdCopyCustomerNumber
            // 
            CmdCopyCustomerNumber.Location = new Point(760, 502);
            CmdCopyCustomerNumber.Name = "CmdCopyCustomerNumber";
            CmdCopyCustomerNumber.Size = new Size(232, 34);
            CmdCopyCustomerNumber.TabIndex = 6;
            CmdCopyCustomerNumber.Text = "Copy Customer Number";
            CmdCopyCustomerNumber.UseVisualStyleBackColor = true;
            CmdCopyCustomerNumber.Click += CmdCopyCustomerNumber_Click;
            // 
            // CmdCopyOrderNumber
            // 
            CmdCopyOrderNumber.Location = new Point(760, 615);
            CmdCopyOrderNumber.Name = "CmdCopyOrderNumber";
            CmdCopyOrderNumber.Size = new Size(205, 34);
            CmdCopyOrderNumber.TabIndex = 5;
            CmdCopyOrderNumber.Text = "Copy Order Number";
            CmdCopyOrderNumber.UseVisualStyleBackColor = true;
            CmdCopyOrderNumber.Click += CmdCopyOrderNumber_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(TxtStreetAddress);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(DatPckInvoiceDateTo);
            groupBox2.Controls.Add(TxtSearchCountry);
            groupBox2.Controls.Add(DatPckInvoiceDateFrom);
            groupBox2.Controls.Add(TxtSearchZipCode);
            groupBox2.Controls.Add(TxtSearchLastName);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(TxtSearchFirstName);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(TxtSearchOrderNumber);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(CmdResetFilters);
            groupBox2.Controls.Add(TxtSearchCustomerNumber);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(TxtSearchInvoiceNumber);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(CmdSearchInvoices);
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(750, 317);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filter Invoices";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(489, 94);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(110, 25);
            label4.TabIndex = 45;
            label4.Text = "Invoice Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(489, 197);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(30, 25);
            label8.TabIndex = 44;
            label8.Text = "To";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 94);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(127, 25);
            label10.TabIndex = 26;
            label10.Text = "Street Address";
            // 
            // TxtStreetAddress
            // 
            TxtStreetAddress.Location = new Point(7, 125);
            TxtStreetAddress.Margin = new Padding(4, 5, 4, 5);
            TxtStreetAddress.Name = "TxtStreetAddress";
            TxtStreetAddress.Size = new Size(235, 31);
            TxtStreetAddress.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(489, 131);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 43;
            label6.Text = "From";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 161);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(84, 25);
            label9.TabIndex = 28;
            label9.Text = "Zip Code";
            // 
            // DatPckInvoiceDateTo
            // 
            DatPckInvoiceDateTo.Format = DateTimePickerFormat.Short;
            DatPckInvoiceDateTo.Location = new Point(551, 192);
            DatPckInvoiceDateTo.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            DatPckInvoiceDateTo.MinDate = new DateTime(1999, 1, 1, 0, 0, 0, 0);
            DatPckInvoiceDateTo.Name = "DatPckInvoiceDateTo";
            DatPckInvoiceDateTo.Size = new Size(173, 31);
            DatPckInvoiceDateTo.TabIndex = 42;
            DatPckInvoiceDateTo.Value = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            // 
            // TxtSearchCountry
            // 
            TxtSearchCountry.Location = new Point(7, 259);
            TxtSearchCountry.Margin = new Padding(4, 5, 4, 5);
            TxtSearchCountry.Name = "TxtSearchCountry";
            TxtSearchCountry.Size = new Size(235, 31);
            TxtSearchCountry.TabIndex = 31;
            // 
            // DatPckInvoiceDateFrom
            // 
            DatPckInvoiceDateFrom.Format = DateTimePickerFormat.Short;
            DatPckInvoiceDateFrom.Location = new Point(549, 125);
            DatPckInvoiceDateFrom.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            DatPckInvoiceDateFrom.MinDate = new DateTime(1999, 1, 1, 0, 0, 0, 0);
            DatPckInvoiceDateFrom.Name = "DatPckInvoiceDateFrom";
            DatPckInvoiceDateFrom.Size = new Size(174, 31);
            DatPckInvoiceDateFrom.TabIndex = 41;
            DatPckInvoiceDateFrom.Value = new DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // TxtSearchZipCode
            // 
            TxtSearchZipCode.Location = new Point(7, 192);
            TxtSearchZipCode.Margin = new Padding(4, 5, 4, 5);
            TxtSearchZipCode.Name = "TxtSearchZipCode";
            TxtSearchZipCode.Size = new Size(235, 31);
            TxtSearchZipCode.TabIndex = 29;
            // 
            // TxtSearchLastName
            // 
            TxtSearchLastName.Location = new Point(248, 192);
            TxtSearchLastName.Margin = new Padding(4, 5, 4, 5);
            TxtSearchLastName.Name = "TxtSearchLastName";
            TxtSearchLastName.Size = new Size(235, 31);
            TxtSearchLastName.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(7, 228);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(75, 25);
            label11.TabIndex = 30;
            label11.Text = "Country";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(248, 161);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(95, 25);
            label7.TabIndex = 24;
            label7.Text = "Last Name";
            // 
            // TxtSearchFirstName
            // 
            TxtSearchFirstName.Location = new Point(248, 125);
            TxtSearchFirstName.Margin = new Padding(4, 5, 4, 5);
            TxtSearchFirstName.Name = "TxtSearchFirstName";
            TxtSearchFirstName.Size = new Size(235, 31);
            TxtSearchFirstName.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(248, 94);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 22;
            label5.Text = "First Name";
            // 
            // TxtSearchOrderNumber
            // 
            TxtSearchOrderNumber.Location = new Point(489, 58);
            TxtSearchOrderNumber.Margin = new Padding(4, 5, 4, 5);
            TxtSearchOrderNumber.Name = "TxtSearchOrderNumber";
            TxtSearchOrderNumber.Size = new Size(235, 31);
            TxtSearchOrderNumber.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(489, 28);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(128, 25);
            label3.TabIndex = 8;
            label3.Text = "Order Number";
            // 
            // CmdResetFilters
            // 
            CmdResetFilters.Location = new Point(386, 259);
            CmdResetFilters.Name = "CmdResetFilters";
            CmdResetFilters.Size = new Size(97, 34);
            CmdResetFilters.TabIndex = 7;
            CmdResetFilters.Text = "Clear";
            CmdResetFilters.UseVisualStyleBackColor = true;
            CmdResetFilters.Click += CmdResetFilters_Click;
            // 
            // TxtSearchCustomerNumber
            // 
            TxtSearchCustomerNumber.Location = new Point(248, 58);
            TxtSearchCustomerNumber.Margin = new Padding(4, 5, 4, 5);
            TxtSearchCustomerNumber.Name = "TxtSearchCustomerNumber";
            TxtSearchCustomerNumber.Size = new Size(235, 31);
            TxtSearchCustomerNumber.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(248, 27);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(159, 25);
            label2.TabIndex = 5;
            label2.Text = "Customer Number";
            // 
            // TxtSearchInvoiceNumber
            // 
            TxtSearchInvoiceNumber.Location = new Point(7, 58);
            TxtSearchInvoiceNumber.Margin = new Padding(4, 5, 4, 5);
            TxtSearchInvoiceNumber.Name = "TxtSearchInvoiceNumber";
            TxtSearchInvoiceNumber.Size = new Size(235, 31);
            TxtSearchInvoiceNumber.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 3;
            label1.Text = "Invoice Number";
            // 
            // CmdSearchInvoices
            // 
            CmdSearchInvoices.Location = new Point(489, 259);
            CmdSearchInvoices.Name = "CmdSearchInvoices";
            CmdSearchInvoices.Size = new Size(235, 34);
            CmdSearchInvoices.TabIndex = 0;
            CmdSearchInvoices.Text = "Search Invoices";
            CmdSearchInvoices.UseVisualStyleBackColor = true;
            CmdSearchInvoices.Click += CmdSearchInvoices_Click;
            // 
            // DataGridViewOrderDetails
            // 
            DataGridViewOrderDetails.AllowUserToDeleteRows = false;
            DataGridViewOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewOrderDetails.Location = new Point(760, 544);
            DataGridViewOrderDetails.Margin = new Padding(4, 5, 4, 5);
            DataGridViewOrderDetails.MultiSelect = false;
            DataGridViewOrderDetails.Name = "DataGridViewOrderDetails";
            DataGridViewOrderDetails.ReadOnly = true;
            DataGridViewOrderDetails.RowHeadersWidth = 62;
            DataGridViewOrderDetails.Size = new Size(738, 63);
            DataGridViewOrderDetails.TabIndex = 7;
            // 
            // DataGridViewOrderPositions
            // 
            DataGridViewOrderPositions.AllowUserToDeleteRows = false;
            DataGridViewOrderPositions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewOrderPositions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewOrderPositions.Location = new Point(760, 657);
            DataGridViewOrderPositions.Margin = new Padding(4, 5, 4, 5);
            DataGridViewOrderPositions.MultiSelect = false;
            DataGridViewOrderPositions.Name = "DataGridViewOrderPositions";
            DataGridViewOrderPositions.ReadOnly = true;
            DataGridViewOrderPositions.RowHeadersWidth = 62;
            DataGridViewOrderPositions.Size = new Size(738, 141);
            DataGridViewOrderPositions.TabIndex = 8;
            // 
            // CmdCopyArticleNumber
            // 
            CmdCopyArticleNumber.Location = new Point(760, 806);
            CmdCopyArticleNumber.Name = "CmdCopyArticleNumber";
            CmdCopyArticleNumber.Size = new Size(205, 34);
            CmdCopyArticleNumber.TabIndex = 9;
            CmdCopyArticleNumber.Text = "Copy Article Number";
            CmdCopyArticleNumber.UseVisualStyleBackColor = true;
            CmdCopyArticleNumber.Click += CmdCopyArticleNumber_Click;
            // 
            // DataGridViewCustomerInformations
            // 
            DataGridViewCustomerInformations.AllowUserToDeleteRows = false;
            DataGridViewCustomerInformations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewCustomerInformations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCustomerInformations.Location = new Point(760, 431);
            DataGridViewCustomerInformations.Margin = new Padding(4, 5, 4, 5);
            DataGridViewCustomerInformations.MultiSelect = false;
            DataGridViewCustomerInformations.Name = "DataGridViewCustomerInformations";
            DataGridViewCustomerInformations.ReadOnly = true;
            DataGridViewCustomerInformations.RowHeadersWidth = 62;
            DataGridViewCustomerInformations.Size = new Size(738, 63);
            DataGridViewCustomerInformations.TabIndex = 10;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(760, 328);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(129, 25);
            label12.TabIndex = 47;
            label12.Text = "Billing Address";
            // 
            // DataGridViewBillingAddress
            // 
            DataGridViewBillingAddress.AllowUserToDeleteRows = false;
            DataGridViewBillingAddress.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewBillingAddress.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewBillingAddress.Location = new Point(760, 358);
            DataGridViewBillingAddress.Margin = new Padding(4, 5, 4, 5);
            DataGridViewBillingAddress.MultiSelect = false;
            DataGridViewBillingAddress.Name = "DataGridViewBillingAddress";
            DataGridViewBillingAddress.ReadOnly = true;
            DataGridViewBillingAddress.RowHeadersWidth = 62;
            DataGridViewBillingAddress.Size = new Size(738, 63);
            DataGridViewBillingAddress.TabIndex = 46;
            // 
            // UsrCtrlInvoices
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label12);
            Controls.Add(DataGridViewBillingAddress);
            Controls.Add(CmdCopyCustomerNumber);
            Controls.Add(DataGridViewCustomerInformations);
            Controls.Add(CmdCopyArticleNumber);
            Controls.Add(DataGridViewOrderPositions);
            Controls.Add(DataGridViewOrderDetails);
            Controls.Add(CmdCopyOrderNumber);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "UsrCtrlInvoices";
            Size = new Size(1589, 1020);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewInvoices).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewOrderDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewOrderPositions).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCustomerInformations).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewBillingAddress).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView DataGridViewInvoices;
        private GroupBox groupBox2;
        private Label LblNoResults;
        private Button CmdSearchInvoices;
        private TextBox TxtSearchInvoiceNumber;
        private Label label1;
        private TextBox TxtSearchCustomerNumber;
        private Label label2;
        private TextBox TxtSearchOrderNumber;
        private Label label3;
        private Button CmdResetFilters;
        private Button CmdCopyCustomerNumber;
        private Button CmdCopyOrderNumber;
        private TextBox TxtSearchFirstName;
        private Label label5;
        private TextBox TxtSearchLastName;
        private Label label7;
        private TextBox TxtSearchCountry;
        private Label label11;
        private TextBox TxtSearchZipCode;
        private Label label9;
        private TextBox TxtStreetAddress;
        private Label label10;
        private Label label4;
        private Label label8;
        private Label label6;
        private DateTimePicker DatPckInvoiceDateTo;
        private DateTimePicker DatPckInvoiceDateFrom;
        private DataGridView DataGridViewOrderDetails;
        private DataGridView DataGridViewOrderPositions;
        private Button CmdCopyArticleNumber;
        private DataGridView DataGridViewCustomerInformations;
        private Label label12;
        private DataGridView DataGridViewBillingAddress;
    }
}
