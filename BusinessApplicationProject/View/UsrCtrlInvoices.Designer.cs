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
            groupBox2 = new GroupBox();
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
            groupBox1.Controls.Add(LblNoResults);
            groupBox1.Controls.Add(DataGridViewInvoices);
            groupBox1.Location = new Point(3, 485);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(750, 535);
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
            DataGridViewInvoices.Name = "DataGridViewInvoices";
            DataGridViewInvoices.ReadOnly = true;
            DataGridViewInvoices.RowHeadersWidth = 62;
            DataGridViewInvoices.Size = new Size(738, 497);
            DataGridViewInvoices.TabIndex = 2;
            // 
            // groupBox2
            // 
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
            groupBox2.Size = new Size(750, 198);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filter Invoices";
            // 
            // TxtSearchOrderNumber
            // 
            TxtSearchOrderNumber.Location = new Point(432, 58);
            TxtSearchOrderNumber.Margin = new Padding(4, 5, 4, 5);
            TxtSearchOrderNumber.Name = "TxtSearchOrderNumber";
            TxtSearchOrderNumber.Size = new Size(205, 31);
            TxtSearchOrderNumber.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(433, 27);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(128, 25);
            label3.TabIndex = 8;
            label3.Text = "Order Number";
            // 
            // CmdResetFilters
            // 
            CmdResetFilters.Location = new Point(327, 97);
            CmdResetFilters.Name = "CmdResetFilters";
            CmdResetFilters.Size = new Size(152, 34);
            CmdResetFilters.TabIndex = 7;
            CmdResetFilters.Text = "Clear Filters";
            CmdResetFilters.UseVisualStyleBackColor = true;
            CmdResetFilters.Click += CmdResetFilters_Click;
            // 
            // TxtSearchCustomerNumber
            // 
            TxtSearchCustomerNumber.Location = new Point(219, 58);
            TxtSearchCustomerNumber.Margin = new Padding(4, 5, 4, 5);
            TxtSearchCustomerNumber.Name = "TxtSearchCustomerNumber";
            TxtSearchCustomerNumber.Size = new Size(205, 31);
            TxtSearchCustomerNumber.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220, 27);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(159, 25);
            label2.TabIndex = 5;
            label2.Text = "Customer Number";
            // 
            // TxtSearchInvoiceNumber
            // 
            TxtSearchInvoiceNumber.Location = new Point(6, 58);
            TxtSearchInvoiceNumber.Margin = new Padding(4, 5, 4, 5);
            TxtSearchInvoiceNumber.Name = "TxtSearchInvoiceNumber";
            TxtSearchInvoiceNumber.Size = new Size(205, 31);
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
            CmdSearchInvoices.Location = new Point(485, 97);
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
    }
}
