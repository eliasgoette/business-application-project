namespace BusinessApplicationProject
{
    partial class FormCustomers
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CmdCustomers = new Button();
            CmdArticles = new Button();
            CmdOrders = new Button();
            GrpNavigation = new GroupBox();
            GrpSearch = new GroupBox();
            GrpInformation = new GroupBox();
            GrpNavigation.SuspendLayout();
            SuspendLayout();
            // 
            // CmdCustomers
            // 
            CmdCustomers.Location = new Point(18, 60);
            CmdCustomers.Name = "CmdCustomers";
            CmdCustomers.Size = new Size(75, 23);
            CmdCustomers.TabIndex = 0;
            CmdCustomers.Text = "Customers";
            CmdCustomers.UseVisualStyleBackColor = true;
            // 
            // CmdArticles
            // 
            CmdArticles.Location = new Point(18, 31);
            CmdArticles.Name = "CmdArticles";
            CmdArticles.Size = new Size(75, 23);
            CmdArticles.TabIndex = 0;
            CmdArticles.Text = "Articles";
            CmdArticles.UseVisualStyleBackColor = true;
            // 
            // CmdOrders
            // 
            CmdOrders.Location = new Point(18, 89);
            CmdOrders.Name = "CmdOrders";
            CmdOrders.Size = new Size(75, 23);
            CmdOrders.TabIndex = 0;
            CmdOrders.Text = "Orders";
            CmdOrders.UseVisualStyleBackColor = true;
            // 
            // GrpNavigation
            // 
            GrpNavigation.Controls.Add(CmdArticles);
            GrpNavigation.Controls.Add(CmdOrders);
            GrpNavigation.Controls.Add(CmdCustomers);
            GrpNavigation.Location = new Point(12, 12);
            GrpNavigation.Name = "GrpNavigation";
            GrpNavigation.Size = new Size(110, 221);
            GrpNavigation.TabIndex = 1;
            GrpNavigation.TabStop = false;
            GrpNavigation.Text = "Navigation";
            // 
            // GrpSearch
            // 
            GrpSearch.Location = new Point(143, 12);
            GrpSearch.Name = "GrpSearch";
            GrpSearch.Size = new Size(528, 636);
            GrpSearch.TabIndex = 2;
            GrpSearch.TabStop = false;
            GrpSearch.Text = "Search";
            // 
            // GrpInformation
            // 
            GrpInformation.Location = new Point(695, 12);
            GrpInformation.Name = "GrpInformation";
            GrpInformation.Size = new Size(528, 636);
            GrpInformation.TabIndex = 2;
            GrpInformation.TabStop = false;
            GrpInformation.Text = "Information selected item";
            // 
            // FormCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(GrpInformation);
            Controls.Add(GrpSearch);
            Controls.Add(GrpNavigation);
            Name = "FormCustomers";
            Text = "FormCustomers";
            GrpNavigation.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button CmdCustomers;
        private Button CmdArticles;
        private Button CmdOrders;
        private GroupBox GrpNavigation;
        private GroupBox GrpSearch;
        private GroupBox GrpInformation;
    }
}
