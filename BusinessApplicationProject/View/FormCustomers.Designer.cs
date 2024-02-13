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
            CmdCloseProgram = new Button();
            GrpResults = new GroupBox();
            DataGridViewCustomersResults = new DataGridView();
            CmdShowAllCustomers = new Button();
            CmdCreateEmptyCustomer = new Button();
            CmdDeleteSelectedCustomers = new Button();
            GrpInformation = new GroupBox();
            DataGridViewCustomerOrders = new DataGridView();
            LblInfoCustomerPostalCode = new Label();
            LblInfoCustomerAdress = new Label();
            LblInfoCustomerCountry = new Label();
            LblInfoCustomerLastName = new Label();
            LblInfoCustomerFirstName = new Label();
            LblInfoCustomerPassword = new Label();
            LblInfoCustomerNumber = new Label();
            CmdDeleteCustomer = new Button();
            CmdSaveChangesCustomer = new Button();
            CmdCreateNewCustomer = new Button();
            GrpSearch = new GroupBox();
            CmdResetSearchFilters = new Button();
            CmdSearchCustomers = new Button();
            label1 = new Label();
            LblInfoCustomerEmail = new Label();
            LblInfoCustomerWebsite = new Label();
            GrpNavigation.SuspendLayout();
            GrpResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCustomersResults).BeginInit();
            GrpInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCustomerOrders).BeginInit();
            GrpSearch.SuspendLayout();
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
            CmdCustomers.Click += CmdCustomers_Click;
            // 
            // CmdArticles
            // 
            CmdArticles.Location = new Point(18, 31);
            CmdArticles.Name = "CmdArticles";
            CmdArticles.Size = new Size(75, 23);
            CmdArticles.TabIndex = 0;
            CmdArticles.Text = "Articles";
            CmdArticles.UseVisualStyleBackColor = true;
            CmdArticles.Click += CmdArticles_Click;
            // 
            // CmdOrders
            // 
            CmdOrders.Location = new Point(18, 89);
            CmdOrders.Name = "CmdOrders";
            CmdOrders.Size = new Size(75, 23);
            CmdOrders.TabIndex = 0;
            CmdOrders.Text = "Orders";
            CmdOrders.UseVisualStyleBackColor = true;
            CmdOrders.Click += CmdOrders_Click;
            // 
            // GrpNavigation
            // 
            GrpNavigation.Controls.Add(CmdArticles);
            GrpNavigation.Controls.Add(CmdCloseProgram);
            GrpNavigation.Controls.Add(CmdOrders);
            GrpNavigation.Controls.Add(CmdCustomers);
            GrpNavigation.Location = new Point(12, 12);
            GrpNavigation.Name = "GrpNavigation";
            GrpNavigation.Size = new Size(110, 245);
            GrpNavigation.TabIndex = 1;
            GrpNavigation.TabStop = false;
            GrpNavigation.Text = "Navigation";
            // 
            // CmdCloseProgram
            // 
            CmdCloseProgram.Location = new Point(18, 206);
            CmdCloseProgram.Name = "CmdCloseProgram";
            CmdCloseProgram.Size = new Size(75, 23);
            CmdCloseProgram.TabIndex = 0;
            CmdCloseProgram.Text = "Exit";
            CmdCloseProgram.UseVisualStyleBackColor = true;
            CmdCloseProgram.Click += CmdCloseProgram_Click;
            // 
            // GrpResults
            // 
            GrpResults.Controls.Add(DataGridViewCustomersResults);
            GrpResults.Controls.Add(CmdShowAllCustomers);
            GrpResults.Controls.Add(CmdCreateEmptyCustomer);
            GrpResults.Controls.Add(CmdDeleteSelectedCustomers);
            GrpResults.ForeColor = SystemColors.ControlText;
            GrpResults.Location = new Point(143, 263);
            GrpResults.Name = "GrpResults";
            GrpResults.Size = new Size(528, 385);
            GrpResults.TabIndex = 2;
            GrpResults.TabStop = false;
            GrpResults.Text = "Customers";
            // 
            // DataGridViewCustomersResults
            // 
            DataGridViewCustomersResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCustomersResults.Location = new Point(6, 22);
            DataGridViewCustomersResults.Name = "DataGridViewCustomersResults";
            DataGridViewCustomersResults.Size = new Size(516, 328);
            DataGridViewCustomersResults.TabIndex = 1;
            // 
            // CmdShowAllCustomers
            // 
            CmdShowAllCustomers.Location = new Point(6, 356);
            CmdShowAllCustomers.Name = "CmdShowAllCustomers";
            CmdShowAllCustomers.Size = new Size(126, 23);
            CmdShowAllCustomers.TabIndex = 0;
            CmdShowAllCustomers.Text = "Show all Customers";
            CmdShowAllCustomers.UseVisualStyleBackColor = true;
            // 
            // CmdCreateEmptyCustomer
            // 
            CmdCreateEmptyCustomer.Location = new Point(216, 356);
            CmdCreateEmptyCustomer.Name = "CmdCreateEmptyCustomer";
            CmdCreateEmptyCustomer.Size = new Size(135, 23);
            CmdCreateEmptyCustomer.TabIndex = 0;
            CmdCreateEmptyCustomer.Text = "Create new Customer";
            CmdCreateEmptyCustomer.UseVisualStyleBackColor = true;
            // 
            // CmdDeleteSelectedCustomers
            // 
            CmdDeleteSelectedCustomers.Location = new Point(357, 356);
            CmdDeleteSelectedCustomers.Name = "CmdDeleteSelectedCustomers";
            CmdDeleteSelectedCustomers.Size = new Size(165, 23);
            CmdDeleteSelectedCustomers.TabIndex = 0;
            CmdDeleteSelectedCustomers.Text = "Delete selected Customer(s)";
            CmdDeleteSelectedCustomers.UseVisualStyleBackColor = true;
            // 
            // GrpInformation
            // 
            GrpInformation.Controls.Add(DataGridViewCustomerOrders);
            GrpInformation.Controls.Add(LblInfoCustomerPostalCode);
            GrpInformation.Controls.Add(label1);
            GrpInformation.Controls.Add(LblInfoCustomerWebsite);
            GrpInformation.Controls.Add(LblInfoCustomerEmail);
            GrpInformation.Controls.Add(LblInfoCustomerAdress);
            GrpInformation.Controls.Add(LblInfoCustomerCountry);
            GrpInformation.Controls.Add(LblInfoCustomerLastName);
            GrpInformation.Controls.Add(LblInfoCustomerFirstName);
            GrpInformation.Controls.Add(LblInfoCustomerPassword);
            GrpInformation.Controls.Add(LblInfoCustomerNumber);
            GrpInformation.Controls.Add(CmdDeleteCustomer);
            GrpInformation.Controls.Add(CmdSaveChangesCustomer);
            GrpInformation.Controls.Add(CmdCreateNewCustomer);
            GrpInformation.Location = new Point(695, 12);
            GrpInformation.Name = "GrpInformation";
            GrpInformation.Size = new Size(528, 636);
            GrpInformation.TabIndex = 2;
            GrpInformation.TabStop = false;
            GrpInformation.Text = "Information selected item";
            // 
            // DataGridViewCustomerOrders
            // 
            DataGridViewCustomerOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCustomerOrders.Location = new Point(6, 273);
            DataGridViewCustomerOrders.Name = "DataGridViewCustomerOrders";
            DataGridViewCustomerOrders.Size = new Size(516, 328);
            DataGridViewCustomerOrders.TabIndex = 1;
            // 
            // LblInfoCustomerPostalCode
            // 
            LblInfoCustomerPostalCode.AutoSize = true;
            LblInfoCustomerPostalCode.Location = new Point(21, 166);
            LblInfoCustomerPostalCode.Name = "LblInfoCustomerPostalCode";
            LblInfoCustomerPostalCode.Size = new Size(70, 15);
            LblInfoCustomerPostalCode.TabIndex = 1;
            LblInfoCustomerPostalCode.Text = "Postal Code";
            // 
            // LblInfoCustomerAdress
            // 
            LblInfoCustomerAdress.AutoSize = true;
            LblInfoCustomerAdress.Location = new Point(21, 196);
            LblInfoCustomerAdress.Name = "LblInfoCustomerAdress";
            LblInfoCustomerAdress.Size = new Size(42, 15);
            LblInfoCustomerAdress.TabIndex = 1;
            LblInfoCustomerAdress.Text = "Adress";
            // 
            // LblInfoCustomerCountry
            // 
            LblInfoCustomerCountry.AutoSize = true;
            LblInfoCustomerCountry.Location = new Point(21, 151);
            LblInfoCustomerCountry.Name = "LblInfoCustomerCountry";
            LblInfoCustomerCountry.Size = new Size(50, 15);
            LblInfoCustomerCountry.TabIndex = 1;
            LblInfoCustomerCountry.Text = "Country";
            // 
            // LblInfoCustomerLastName
            // 
            LblInfoCustomerLastName.AutoSize = true;
            LblInfoCustomerLastName.Location = new Point(21, 107);
            LblInfoCustomerLastName.Name = "LblInfoCustomerLastName";
            LblInfoCustomerLastName.Size = new Size(63, 15);
            LblInfoCustomerLastName.TabIndex = 1;
            LblInfoCustomerLastName.Text = "Last Name";
            // 
            // LblInfoCustomerFirstName
            // 
            LblInfoCustomerFirstName.AutoSize = true;
            LblInfoCustomerFirstName.Location = new Point(21, 87);
            LblInfoCustomerFirstName.Name = "LblInfoCustomerFirstName";
            LblInfoCustomerFirstName.Size = new Size(64, 15);
            LblInfoCustomerFirstName.TabIndex = 1;
            LblInfoCustomerFirstName.Text = "First Name";
            // 
            // LblInfoCustomerPassword
            // 
            LblInfoCustomerPassword.AutoSize = true;
            LblInfoCustomerPassword.Location = new Point(21, 50);
            LblInfoCustomerPassword.Name = "LblInfoCustomerPassword";
            LblInfoCustomerPassword.Size = new Size(57, 15);
            LblInfoCustomerPassword.TabIndex = 1;
            LblInfoCustomerPassword.Text = "Password";
            // 
            // LblInfoCustomerNumber
            // 
            LblInfoCustomerNumber.AutoSize = true;
            LblInfoCustomerNumber.Location = new Point(21, 30);
            LblInfoCustomerNumber.Name = "LblInfoCustomerNumber";
            LblInfoCustomerNumber.Size = new Size(106, 15);
            LblInfoCustomerNumber.TabIndex = 1;
            LblInfoCustomerNumber.Text = "Customer Number";
            // 
            // CmdDeleteCustomer
            // 
            CmdDeleteCustomer.Location = new Point(412, 607);
            CmdDeleteCustomer.Name = "CmdDeleteCustomer";
            CmdDeleteCustomer.Size = new Size(110, 23);
            CmdDeleteCustomer.TabIndex = 0;
            CmdDeleteCustomer.Text = "Delete Customer";
            CmdDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // CmdSaveChangesCustomer
            // 
            CmdSaveChangesCustomer.Location = new Point(307, 607);
            CmdSaveChangesCustomer.Name = "CmdSaveChangesCustomer";
            CmdSaveChangesCustomer.Size = new Size(99, 23);
            CmdSaveChangesCustomer.TabIndex = 0;
            CmdSaveChangesCustomer.Text = "Save changes";
            CmdSaveChangesCustomer.UseVisualStyleBackColor = true;
            // 
            // CmdCreateNewCustomer
            // 
            CmdCreateNewCustomer.Location = new Point(6, 607);
            CmdCreateNewCustomer.Name = "CmdCreateNewCustomer";
            CmdCreateNewCustomer.Size = new Size(148, 23);
            CmdCreateNewCustomer.TabIndex = 0;
            CmdCreateNewCustomer.Text = "Save as new Customer";
            CmdCreateNewCustomer.UseVisualStyleBackColor = true;
            // 
            // GrpSearch
            // 
            GrpSearch.Controls.Add(CmdResetSearchFilters);
            GrpSearch.Controls.Add(CmdSearchCustomers);
            GrpSearch.ForeColor = SystemColors.ControlText;
            GrpSearch.Location = new Point(143, 12);
            GrpSearch.Name = "GrpSearch";
            GrpSearch.Size = new Size(528, 245);
            GrpSearch.TabIndex = 2;
            GrpSearch.TabStop = false;
            GrpSearch.Text = "Search";
            // 
            // CmdResetSearchFilters
            // 
            CmdResetSearchFilters.Location = new Point(273, 216);
            CmdResetSearchFilters.Name = "CmdResetSearchFilters";
            CmdResetSearchFilters.Size = new Size(117, 23);
            CmdResetSearchFilters.TabIndex = 0;
            CmdResetSearchFilters.Text = "Reset search filters";
            CmdResetSearchFilters.UseVisualStyleBackColor = true;
            // 
            // CmdSearchCustomers
            // 
            CmdSearchCustomers.Location = new Point(396, 216);
            CmdSearchCustomers.Name = "CmdSearchCustomers";
            CmdSearchCustomers.Size = new Size(126, 23);
            CmdSearchCustomers.TabIndex = 0;
            CmdSearchCustomers.Text = "Search Customers";
            CmdSearchCustomers.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 181);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 1;
            label1.Text = "City";
            // 
            // LblInfoCustomerEmail
            // 
            LblInfoCustomerEmail.AutoSize = true;
            LblInfoCustomerEmail.Location = new Point(21, 230);
            LblInfoCustomerEmail.Name = "LblInfoCustomerEmail";
            LblInfoCustomerEmail.Size = new Size(36, 15);
            LblInfoCustomerEmail.TabIndex = 1;
            LblInfoCustomerEmail.Text = "Email";
            // 
            // LblInfoCustomerWebsite
            // 
            LblInfoCustomerWebsite.AutoSize = true;
            LblInfoCustomerWebsite.Location = new Point(21, 245);
            LblInfoCustomerWebsite.Name = "LblInfoCustomerWebsite";
            LblInfoCustomerWebsite.Size = new Size(49, 15);
            LblInfoCustomerWebsite.TabIndex = 1;
            LblInfoCustomerWebsite.Text = "Website";
            // 
            // FormCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(GrpInformation);
            Controls.Add(GrpSearch);
            Controls.Add(GrpResults);
            Controls.Add(GrpNavigation);
            Name = "FormCustomers";
            Text = "FormCustomers";
            GrpNavigation.ResumeLayout(false);
            GrpResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewCustomersResults).EndInit();
            GrpInformation.ResumeLayout(false);
            GrpInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCustomerOrders).EndInit();
            GrpSearch.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button CmdCustomers;
        private Button CmdArticles;
        private Button CmdOrders;
        private GroupBox GrpNavigation;
        private GroupBox GrpResults;
        private GroupBox GrpInformation;
        private GroupBox GrpSearch;
        private Button CmdCreateNewCustomer;
        private Button CmdCreateEmptyCustomer;
        private Button CmdDeleteSelectedCustomers;
        private Button CmdDeleteCustomer;
        private Button CmdSaveChangesCustomer;
        private DataGridView DataGridViewCustomersResults;
        private Button CmdShowAllCustomers;
        private Button CmdResetSearchFilters;
        private Button CmdSearchCustomers;
        private Button CmdCloseProgram;
        private Label LblInfoCustomerNumber;
        private Label LblInfoCustomerPassword;
        private Label LblInfoCustomerLastName;
        private Label LblInfoCustomerFirstName;
        private DataGridView DataGridViewCustomerOrders;
        private Label LblInfoCustomerPostalCode;
        private Label LblInfoCustomerAdress;
        private Label LblInfoCustomerCountry;
        private Label label1;
        private Label LblInfoCustomerEmail;
        private Label LblInfoCustomerWebsite;
    }
}
