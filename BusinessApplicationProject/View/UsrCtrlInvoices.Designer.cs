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
            label12 = new Label();
            DataGridViewBillingAddress = new DataGridView();
            DataGridViewInvoices = new DataGridView();
            CmdCopyCustomerNumber = new Button();
            CmdCopyOrderNumber = new Button();
            DataGridViewCustomerInformations = new DataGridView();
            DataGridViewOrderDetails = new DataGridView();
            CmdCopyArticleNumber = new Button();
            DataGridViewOrderPositions = new DataGridView();
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
            groupBox3 = new GroupBox();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            label16 = new Label();
            label19 = new Label();
            label14 = new Label();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label13 = new Label();
            label15 = new Label();
            textBox1 = new TextBox();
            label17 = new Label();
            textBox2 = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            textBox3 = new TextBox();
            label18 = new Label();
            textBox6 = new TextBox();
            label21 = new Label();
            button1 = new Button();
            textBox7 = new TextBox();
            label22 = new Label();
            textBox8 = new TextBox();
            label23 = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewBillingAddress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewInvoices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCustomerInformations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewOrderDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewOrderPositions).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LblNoResults);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(DataGridViewBillingAddress);
            groupBox1.Controls.Add(DataGridViewInvoices);
            groupBox1.Controls.Add(CmdCopyCustomerNumber);
            groupBox1.Controls.Add(CmdCopyOrderNumber);
            groupBox1.Controls.Add(DataGridViewCustomerInformations);
            groupBox1.Controls.Add(DataGridViewOrderDetails);
            groupBox1.Controls.Add(CmdCopyArticleNumber);
            groupBox1.Controls.Add(DataGridViewOrderPositions);
            groupBox1.Location = new Point(3, 436);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1507, 560);
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
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(768, 32);
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
            DataGridViewBillingAddress.Location = new Point(768, 62);
            DataGridViewBillingAddress.Margin = new Padding(4, 5, 4, 5);
            DataGridViewBillingAddress.MultiSelect = false;
            DataGridViewBillingAddress.Name = "DataGridViewBillingAddress";
            DataGridViewBillingAddress.ReadOnly = true;
            DataGridViewBillingAddress.RowHeadersWidth = 62;
            DataGridViewBillingAddress.Size = new Size(713, 63);
            DataGridViewBillingAddress.TabIndex = 46;
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
            DataGridViewInvoices.Size = new Size(738, 512);
            DataGridViewInvoices.TabIndex = 2;
            DataGridViewInvoices.CellClick += DataGridViewInvoices_CellClick;
            // 
            // CmdCopyCustomerNumber
            // 
            CmdCopyCustomerNumber.Location = new Point(768, 206);
            CmdCopyCustomerNumber.Name = "CmdCopyCustomerNumber";
            CmdCopyCustomerNumber.Size = new Size(232, 34);
            CmdCopyCustomerNumber.TabIndex = 6;
            CmdCopyCustomerNumber.Text = "Copy Customer Number";
            CmdCopyCustomerNumber.UseVisualStyleBackColor = true;
            CmdCopyCustomerNumber.Click += CmdCopyCustomerNumber_Click;
            // 
            // CmdCopyOrderNumber
            // 
            CmdCopyOrderNumber.Location = new Point(768, 319);
            CmdCopyOrderNumber.Name = "CmdCopyOrderNumber";
            CmdCopyOrderNumber.Size = new Size(205, 34);
            CmdCopyOrderNumber.TabIndex = 5;
            CmdCopyOrderNumber.Text = "Copy Order Number";
            CmdCopyOrderNumber.UseVisualStyleBackColor = true;
            CmdCopyOrderNumber.Click += CmdCopyOrderNumber_Click;
            // 
            // DataGridViewCustomerInformations
            // 
            DataGridViewCustomerInformations.AllowUserToDeleteRows = false;
            DataGridViewCustomerInformations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewCustomerInformations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCustomerInformations.Location = new Point(768, 135);
            DataGridViewCustomerInformations.Margin = new Padding(4, 5, 4, 5);
            DataGridViewCustomerInformations.MultiSelect = false;
            DataGridViewCustomerInformations.Name = "DataGridViewCustomerInformations";
            DataGridViewCustomerInformations.ReadOnly = true;
            DataGridViewCustomerInformations.RowHeadersWidth = 62;
            DataGridViewCustomerInformations.Size = new Size(713, 63);
            DataGridViewCustomerInformations.TabIndex = 10;
            // 
            // DataGridViewOrderDetails
            // 
            DataGridViewOrderDetails.AllowUserToDeleteRows = false;
            DataGridViewOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewOrderDetails.Location = new Point(768, 248);
            DataGridViewOrderDetails.Margin = new Padding(4, 5, 4, 5);
            DataGridViewOrderDetails.MultiSelect = false;
            DataGridViewOrderDetails.Name = "DataGridViewOrderDetails";
            DataGridViewOrderDetails.ReadOnly = true;
            DataGridViewOrderDetails.RowHeadersWidth = 62;
            DataGridViewOrderDetails.Size = new Size(713, 63);
            DataGridViewOrderDetails.TabIndex = 7;
            // 
            // CmdCopyArticleNumber
            // 
            CmdCopyArticleNumber.Location = new Point(768, 510);
            CmdCopyArticleNumber.Name = "CmdCopyArticleNumber";
            CmdCopyArticleNumber.Size = new Size(205, 34);
            CmdCopyArticleNumber.TabIndex = 9;
            CmdCopyArticleNumber.Text = "Copy Article Number";
            CmdCopyArticleNumber.UseVisualStyleBackColor = true;
            CmdCopyArticleNumber.Click += CmdCopyArticleNumber_Click;
            // 
            // DataGridViewOrderPositions
            // 
            DataGridViewOrderPositions.AllowUserToDeleteRows = false;
            DataGridViewOrderPositions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewOrderPositions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewOrderPositions.Location = new Point(768, 361);
            DataGridViewOrderPositions.Margin = new Padding(4, 5, 4, 5);
            DataGridViewOrderPositions.MultiSelect = false;
            DataGridViewOrderPositions.Name = "DataGridViewOrderPositions";
            DataGridViewOrderPositions.ReadOnly = true;
            DataGridViewOrderPositions.RowHeadersWidth = 62;
            DataGridViewOrderPositions.Size = new Size(713, 141);
            DataGridViewOrderPositions.TabIndex = 8;
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
            // groupBox3
            // 
            groupBox3.Controls.Add(numericUpDown2);
            groupBox3.Controls.Add(numericUpDown1);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(checkBox2);
            groupBox3.Controls.Add(checkBox1);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(dateTimePicker2);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(label21);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(label22);
            groupBox3.Controls.Add(textBox8);
            groupBox3.Controls.Add(label23);
            groupBox3.Controls.Add(button2);
            groupBox3.Location = new Point(760, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(750, 420);
            groupBox3.TabIndex = 48;
            groupBox3.TabStop = false;
            groupBox3.Text = "Edit / Create Invoice";
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            numericUpDown2.Location = new Point(489, 268);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(235, 31);
            numericUpDown2.TabIndex = 54;
            numericUpDown2.Value = new decimal(new int[] { 81, 0, 0, 65536 });
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDown1.Location = new Point(489, 201);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(235, 31);
            numericUpDown1.TabIndex = 53;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(490, 169);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(82, 25);
            label16.TabIndex = 51;
            label16.Text = "Discount";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(490, 236);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(83, 25);
            label19.TabIndex = 52;
            label19.Text = "Taxes [%]";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(11, 97);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(129, 25);
            label14.TabIndex = 48;
            label14.Text = "Billing Address";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(250, 135);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(208, 29);
            checkBox2.TabIndex = 47;
            checkBox2.Text = "Set today as inv. date";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(11, 131);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(194, 29);
            checkBox1.TabIndex = 46;
            checkBox1.Text = "Billing to cust. addr.";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(250, 102);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(110, 25);
            label13.TabIndex = 45;
            label13.Text = "Invoice Date";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(11, 169);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(127, 25);
            label15.TabIndex = 26;
            label15.Text = "Street Address";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(11, 200);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 31);
            textBox1.TabIndex = 27;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(11, 236);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(84, 25);
            label17.TabIndex = 28;
            label17.Text = "Zip Code";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(11, 334);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(231, 31);
            textBox2.TabIndex = 31;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(248, 200);
            dateTimePicker2.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            dateTimePicker2.MinDate = new DateTime(1999, 1, 1, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(234, 31);
            dateTimePicker2.TabIndex = 41;
            dateTimePicker2.Value = new DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // textBox3
            // 
            textBox3.Location = new Point(11, 267);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(231, 31);
            textBox3.TabIndex = 29;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(11, 303);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(75, 25);
            label18.TabIndex = 30;
            label18.Text = "Country";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(489, 58);
            textBox6.Margin = new Padding(4, 5, 4, 5);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(235, 31);
            textBox6.TabIndex = 9;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(489, 28);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(128, 25);
            label21.TabIndex = 8;
            label21.Text = "Order Number";
            // 
            // button1
            // 
            button1.Location = new Point(489, 331);
            button1.Name = "button1";
            button1.Size = new Size(97, 34);
            button1.TabIndex = 7;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(248, 58);
            textBox7.Margin = new Padding(4, 5, 4, 5);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(235, 31);
            textBox7.TabIndex = 6;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(248, 27);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(159, 25);
            label22.TabIndex = 5;
            label22.Text = "Customer Number";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(7, 58);
            textBox8.Margin = new Padding(4, 5, 4, 5);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(235, 31);
            textBox8.TabIndex = 4;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(7, 27);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(138, 25);
            label23.TabIndex = 3;
            label23.Text = "Invoice Number";
            // 
            // button2
            // 
            button2.Location = new Point(592, 331);
            button2.Name = "button2";
            button2.Size = new Size(132, 34);
            button2.TabIndex = 0;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            // 
            // UsrCtrlInvoices
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "UsrCtrlInvoices";
            Size = new Size(1589, 1020);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewBillingAddress).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewInvoices).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCustomerInformations).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewOrderDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewOrderPositions).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
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
        private GroupBox groupBox3;
        private Label label13;
        private Label label15;
        private TextBox textBox1;
        private Label label17;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox3;
        private Label label18;
        private TextBox textBox6;
        private Label label21;
        private Button button1;
        private TextBox textBox7;
        private Label label22;
        private TextBox textBox8;
        private Label label23;
        private Button button2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label14;
        private Label label16;
        private Label label19;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
    }
}
