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
            CmdCopyCustomerNumber = new Button();
            CmdCopyOrderNumber = new Button();
            LblNoResults = new Label();
            DataGridViewInvoices = new DataGridView();
            groupBox2 = new GroupBox();
            CmbDateProperty = new ComboBox();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            ChkListBoxPaymentStatus = new CheckedListBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            ChkListBoxPaymentMethod = new CheckedListBox();
            TxtSearchOrderNumber = new TextBox();
            label3 = new Label();
            CmdResetFilters = new Button();
            TxtSearchCustomerNumber = new TextBox();
            label2 = new Label();
            TxtSearchInvoiceNumber = new TextBox();
            label1 = new Label();
            CmdSearchInvoices = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewInvoices).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CmdCopyCustomerNumber);
            groupBox1.Controls.Add(CmdCopyOrderNumber);
            groupBox1.Controls.Add(LblNoResults);
            groupBox1.Controls.Add(DataGridViewInvoices);
            groupBox1.Location = new Point(3, 285);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(750, 735);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Results";
            // 
            // CmdCopyCustomerNumber
            // 
            CmdCopyCustomerNumber.Location = new Point(218, 491);
            CmdCopyCustomerNumber.Name = "CmdCopyCustomerNumber";
            CmdCopyCustomerNumber.Size = new Size(232, 34);
            CmdCopyCustomerNumber.TabIndex = 6;
            CmdCopyCustomerNumber.Text = "Copy Customer Number";
            CmdCopyCustomerNumber.UseVisualStyleBackColor = true;
            CmdCopyCustomerNumber.Click += CmdCopyCustomerNumber_Click;
            // 
            // CmdCopyOrderNumber
            // 
            CmdCopyOrderNumber.Location = new Point(7, 491);
            CmdCopyOrderNumber.Name = "CmdCopyOrderNumber";
            CmdCopyOrderNumber.Size = new Size(205, 34);
            CmdCopyOrderNumber.TabIndex = 5;
            CmdCopyOrderNumber.Text = "Copy Order Number";
            CmdCopyOrderNumber.UseVisualStyleBackColor = true;
            CmdCopyOrderNumber.Click += CmdCopyOrderNumber_Click;
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
            DataGridViewInvoices.AutoGenerateColumns = false;
            DataGridViewInvoices.AllowUserToDeleteRows = false;
            DataGridViewInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewInvoices.Location = new Point(7, 32);
            DataGridViewInvoices.Margin = new Padding(4, 5, 4, 5);
            DataGridViewInvoices.MultiSelect = false;
            DataGridViewInvoices.Name = "DataGridViewInvoices";
            DataGridViewInvoices.ReadOnly = true;
            DataGridViewInvoices.RowHeadersWidth = 62;
            DataGridViewInvoices.Size = new Size(738, 451);
            DataGridViewInvoices.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(CmbDateProperty);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(ChkListBoxPaymentStatus);
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(ChkListBoxPaymentMethod);
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
            groupBox2.Size = new Size(750, 276);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filter Invoices";
            // 
            // CmbDateProperty
            // 
            CmbDateProperty.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbDateProperty.FormattingEnabled = true;
            CmbDateProperty.Items.AddRange(new object[] { "Due Date", "Order Date" });
            CmbDateProperty.Location = new Point(490, 122);
            CmbDateProperty.Name = "CmbDateProperty";
            CmbDateProperty.Size = new Size(252, 33);
            CmbDateProperty.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(490, 200);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(30, 25);
            label8.TabIndex = 20;
            label8.Text = "To";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(489, 166);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 19;
            label6.Text = "From";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(248, 94);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(133, 25);
            label7.TabIndex = 18;
            label7.Text = "Payment Status";
            // 
            // ChkListBoxPaymentStatus
            // 
            ChkListBoxPaymentStatus.FormattingEnabled = true;
            ChkListBoxPaymentStatus.Location = new Point(248, 122);
            ChkListBoxPaymentStatus.Name = "ChkListBoxPaymentStatus";
            ChkListBoxPaymentStatus.Size = new Size(235, 144);
            ChkListBoxPaymentStatus.TabIndex = 17;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(550, 195);
            dateTimePicker2.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(192, 31);
            dateTimePicker2.TabIndex = 16;
            dateTimePicker2.Value = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(550, 161);
            dateTimePicker1.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(192, 31);
            dateTimePicker1.TabIndex = 14;
            dateTimePicker1.Value = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 94);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(156, 25);
            label4.TabIndex = 12;
            label4.Text = "Payment Methods";
            // 
            // ChkListBoxPaymentMethod
            // 
            ChkListBoxPaymentMethod.FormattingEnabled = true;
            ChkListBoxPaymentMethod.Location = new Point(7, 122);
            ChkListBoxPaymentMethod.Name = "ChkListBoxPaymentMethod";
            ChkListBoxPaymentMethod.Size = new Size(235, 144);
            ChkListBoxPaymentMethod.TabIndex = 11;
            // 
            // TxtSearchOrderNumber
            // 
            TxtSearchOrderNumber.Location = new Point(489, 58);
            TxtSearchOrderNumber.Margin = new Padding(4, 5, 4, 5);
            TxtSearchOrderNumber.Name = "TxtSearchOrderNumber";
            TxtSearchOrderNumber.Size = new Size(253, 31);
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
            CmdResetFilters.Location = new Point(489, 232);
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
            CmdSearchInvoices.Location = new Point(593, 232);
            CmdSearchInvoices.Name = "CmdSearchInvoices";
            CmdSearchInvoices.Size = new Size(152, 34);
            CmdSearchInvoices.TabIndex = 0;
            CmdSearchInvoices.Text = "Search Invoices";
            CmdSearchInvoices.UseVisualStyleBackColor = true;
            CmdSearchInvoices.Click += CmdSearchInvoices_Click;
            // 
            // UsrCtrlInvoices
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "UsrCtrlInvoices";
            Size = new Size(1589, 1020);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewInvoices).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private Label label4;
        private CheckedListBox ChkListBoxPaymentMethod;
        private Label label7;
        private CheckedListBox ChkListBoxPaymentStatus;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private Label label6;
        private ComboBox CmbDateProperty;
    }
}
