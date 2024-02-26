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
            groupBox2.Controls.Add(CmdSearchInvoices);
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(750, 476);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filter Invoices";
            // 
            // CmdSearchInvoices
            // 
            CmdSearchInvoices.Location = new Point(7, 436);
            CmdSearchInvoices.Name = "CmdSearchInvoices";
            CmdSearchInvoices.Size = new Size(112, 34);
            CmdSearchInvoices.TabIndex = 0;
            CmdSearchInvoices.Text = "Search";
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
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView DataGridViewInvoices;
        private GroupBox groupBox2;
        private Label LblNoResults;
        private Button CmdSearchInvoices;
    }
}
