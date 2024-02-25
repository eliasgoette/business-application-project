namespace BusinessApplicationProject.View
{
    partial class FormMain
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
            GrpNavigation = new GroupBox();
            CmdInvoices = new Button();
            CmdArticles = new Button();
            CmdCloseProgram = new Button();
            CmdOrders = new Button();
            CmdCustomers = new Button();
            PnlMainView = new Panel();
            GrpNavigation.SuspendLayout();
            SuspendLayout();
            // 
            // GrpNavigation
            // 
            GrpNavigation.Controls.Add(CmdInvoices);
            GrpNavigation.Controls.Add(CmdArticles);
            GrpNavigation.Controls.Add(CmdCloseProgram);
            GrpNavigation.Controls.Add(CmdOrders);
            GrpNavigation.Controls.Add(CmdCustomers);
            GrpNavigation.Location = new Point(13, 14);
            GrpNavigation.Margin = new Padding(4, 5, 4, 5);
            GrpNavigation.Name = "GrpNavigation";
            GrpNavigation.Padding = new Padding(4, 5, 4, 5);
            GrpNavigation.Size = new Size(157, 1016);
            GrpNavigation.TabIndex = 2;
            GrpNavigation.TabStop = false;
            GrpNavigation.Text = "Navigation";
            // 
            // CmdInvoices
            // 
            CmdInvoices.Location = new Point(8, 178);
            CmdInvoices.Margin = new Padding(4, 5, 4, 5);
            CmdInvoices.Name = "CmdInvoices";
            CmdInvoices.Size = new Size(141, 38);
            CmdInvoices.TabIndex = 1;
            CmdInvoices.Text = "Invoices";
            CmdInvoices.UseVisualStyleBackColor = true;
            CmdInvoices.Click += CmdInvoices_Click;
            // 
            // CmdArticles
            // 
            CmdArticles.Location = new Point(8, 34);
            CmdArticles.Margin = new Padding(4, 5, 4, 5);
            CmdArticles.Name = "CmdArticles";
            CmdArticles.Size = new Size(141, 38);
            CmdArticles.TabIndex = 0;
            CmdArticles.Text = "Articles";
            CmdArticles.UseVisualStyleBackColor = true;
            CmdArticles.Click += CmdArticles_Click;
            // 
            // CmdCloseProgram
            // 
            CmdCloseProgram.Location = new Point(8, 274);
            CmdCloseProgram.Margin = new Padding(4, 5, 4, 5);
            CmdCloseProgram.Name = "CmdCloseProgram";
            CmdCloseProgram.Size = new Size(141, 38);
            CmdCloseProgram.TabIndex = 0;
            CmdCloseProgram.Text = "Exit";
            CmdCloseProgram.UseVisualStyleBackColor = true;
            CmdCloseProgram.Click += CmdCloseProgram_Click;
            // 
            // CmdOrders
            // 
            CmdOrders.Location = new Point(8, 130);
            CmdOrders.Margin = new Padding(4, 5, 4, 5);
            CmdOrders.Name = "CmdOrders";
            CmdOrders.Size = new Size(141, 38);
            CmdOrders.TabIndex = 0;
            CmdOrders.Text = "Orders";
            CmdOrders.UseVisualStyleBackColor = true;
            CmdOrders.Click += CmdOrders_Click;
            // 
            // CmdCustomers
            // 
            CmdCustomers.Location = new Point(8, 82);
            CmdCustomers.Margin = new Padding(4, 5, 4, 5);
            CmdCustomers.Name = "CmdCustomers";
            CmdCustomers.Size = new Size(141, 38);
            CmdCustomers.TabIndex = 0;
            CmdCustomers.Text = "Customers";
            CmdCustomers.UseVisualStyleBackColor = true;
            CmdCustomers.Click += CmdCustomers_Click;
            // 
            // PnlMainView
            // 
            PnlMainView.Location = new Point(177, 12);
            PnlMainView.Name = "PnlMainView";
            PnlMainView.Size = new Size(1589, 1020);
            PnlMainView.TabIndex = 3;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1778, 1044);
            Controls.Add(PnlMainView);
            Controls.Add(GrpNavigation);
            Name = "FormMain";
            Text = "FormMain";
            GrpNavigation.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GrpNavigation;
        private Button CmdInvoices;
        private Button CmdArticles;
        private Button CmdCloseProgram;
        private Button CmdOrders;
        private Button CmdCustomers;
        private Panel PnlMainView;
    }
}