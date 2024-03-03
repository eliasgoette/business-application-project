namespace BusinessApplicationProject
{
    partial class FormOrders
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
            DataGridViewOrdersResults = new DataGridView();
            CmdShowAllOrders = new Button();
            CmdCreateEmptyArticle = new Button();
            CmdDeleteSelectedObject = new Button();
            GrpInformationArticle = new GroupBox();
            TxtInputArticleNumber = new TextBox();
            TxtInputArticlePrice = new TextBox();
            TxtInputArticleName = new TextBox();
            LblInfoArticlePrice = new Label();
            LblInfoArticleName = new Label();
            LblInfoArticleNumber = new Label();
            LblInfoArticleGroup = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            CmbInputArticleGroup = new ComboBox();
            GrpSearch = new GroupBox();
            TxtSearchArticleNumber = new TextBox();
            TxtSearchArticleName = new TextBox();
            TxtSearchArticleGroup = new TextBox();
            CmdResetSearchFilters = new Button();
            CmdSearchArticles = new Button();
            LblInfoSearchOrdersCustomerLastName = new Label();
            LblInfoSearchOrdersCustomerFirstName = new Label();
            LblInfoSearchOrdersCustomerNumber = new Label();
            GrpInformationArticleGroup = new GroupBox();
            TxtInputArticleGroupName = new TextBox();
            GrpInformationArticleGroupName = new Label();
            GrpInformationArticleGroupParent = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            TxtSearchCustomerAdress = new TextBox();
            TxtSearchCustomerCity = new TextBox();
            TxtSearchCustomerCountry = new TextBox();
            LblInfoSearchCustomerAdress = new Label();
            LblInfoSearchCustomerCity = new Label();
            LblInfoSearchCustomerCountry = new Label();
            CmbInputArticleGroupParent = new ComboBox();
            GrpNavigation.SuspendLayout();
            GrpResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewOrdersResults).BeginInit();
            GrpInformationArticle.SuspendLayout();
            GrpSearch.SuspendLayout();
            GrpInformationArticleGroup.SuspendLayout();
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
            CmdOrders.Enabled = false;
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
            GrpResults.Controls.Add(DataGridViewOrdersResults);
            GrpResults.Controls.Add(CmdShowAllOrders);
            GrpResults.Controls.Add(CmdCreateEmptyArticle);
            GrpResults.Controls.Add(CmdDeleteSelectedObject);
            GrpResults.ForeColor = SystemColors.ControlText;
            GrpResults.Location = new Point(143, 263);
            GrpResults.Name = "GrpResults";
            GrpResults.Size = new Size(528, 385);
            GrpResults.TabIndex = 2;
            GrpResults.TabStop = false;
            GrpResults.Text = "Orders";
            // 
            // DataGridViewOrdersResults
            // 
            DataGridViewOrdersResults.AllowUserToDeleteRows = false;
            DataGridViewOrdersResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewOrdersResults.Location = new Point(7, 22);
            DataGridViewOrdersResults.Name = "DataGridViewOrdersResults";
            DataGridViewOrdersResults.Size = new Size(516, 328);
            DataGridViewOrdersResults.TabIndex = 2;
            // 
            // CmdShowAllOrders
            // 
            CmdShowAllOrders.Location = new Point(7, 356);
            CmdShowAllOrders.Name = "CmdShowAllOrders";
            CmdShowAllOrders.Size = new Size(126, 23);
            CmdShowAllOrders.TabIndex = 0;
            CmdShowAllOrders.Text = "Show all Orders";
            CmdShowAllOrders.UseVisualStyleBackColor = true;
            CmdShowAllOrders.Click += CmdShowAllCustomers_Click;
            // 
            // CmdCreateEmptyArticle
            // 
            CmdCreateEmptyArticle.Location = new Point(217, 356);
            CmdCreateEmptyArticle.Name = "CmdCreateEmptyArticle";
            CmdCreateEmptyArticle.Size = new Size(135, 23);
            CmdCreateEmptyArticle.TabIndex = 0;
            CmdCreateEmptyArticle.Text = "Create new Order";
            CmdCreateEmptyArticle.UseVisualStyleBackColor = true;
            CmdCreateEmptyArticle.Click += CmdCreateEmptyCustomer_Click;
            // 
            // CmdDeleteSelectedObject
            // 
            CmdDeleteSelectedObject.Location = new Point(358, 356);
            CmdDeleteSelectedObject.Name = "CmdDeleteSelectedObject";
            CmdDeleteSelectedObject.Size = new Size(165, 23);
            CmdDeleteSelectedObject.TabIndex = 0;
            CmdDeleteSelectedObject.Text = "Delete selected Object";
            CmdDeleteSelectedObject.UseVisualStyleBackColor = true;
            CmdDeleteSelectedObject.Click += CmdDeleteSelectedCustomers_Click;
            // 
            // GrpInformationArticle
            // 
            GrpInformationArticle.Controls.Add(TxtInputArticleNumber);
            GrpInformationArticle.Controls.Add(TxtInputArticlePrice);
            GrpInformationArticle.Controls.Add(TxtInputArticleName);
            GrpInformationArticle.Controls.Add(LblInfoArticlePrice);
            GrpInformationArticle.Controls.Add(LblInfoArticleName);
            GrpInformationArticle.Controls.Add(LblInfoArticleNumber);
            GrpInformationArticle.Controls.Add(LblInfoArticleGroup);
            GrpInformationArticle.Controls.Add(button3);
            GrpInformationArticle.Controls.Add(button2);
            GrpInformationArticle.Controls.Add(button1);
            GrpInformationArticle.Controls.Add(CmbInputArticleGroup);
            GrpInformationArticle.Location = new Point(695, 12);
            GrpInformationArticle.Name = "GrpInformationArticle";
            GrpInformationArticle.Size = new Size(528, 123);
            GrpInformationArticle.TabIndex = 2;
            GrpInformationArticle.TabStop = false;
            GrpInformationArticle.Text = "Information selected Article";
            // 
            // TxtInputArticleNumber
            // 
            TxtInputArticleNumber.BackColor = SystemColors.ScrollBar;
            TxtInputArticleNumber.BorderStyle = BorderStyle.None;
            TxtInputArticleNumber.Cursor = Cursors.IBeam;
            TxtInputArticleNumber.Location = new Point(374, 30);
            TxtInputArticleNumber.Name = "TxtInputArticleNumber";
            TxtInputArticleNumber.ReadOnly = true;
            TxtInputArticleNumber.Size = new Size(133, 16);
            TxtInputArticleNumber.TabIndex = 2;
            // 
            // TxtInputArticlePrice
            // 
            TxtInputArticlePrice.BackColor = SystemColors.Window;
            TxtInputArticlePrice.BorderStyle = BorderStyle.None;
            TxtInputArticlePrice.Cursor = Cursors.IBeam;
            TxtInputArticlePrice.Location = new Point(374, 57);
            TxtInputArticlePrice.Name = "TxtInputArticlePrice";
            TxtInputArticlePrice.Size = new Size(133, 16);
            TxtInputArticlePrice.TabIndex = 2;
            // 
            // TxtInputArticleName
            // 
            TxtInputArticleName.BackColor = SystemColors.Window;
            TxtInputArticleName.BorderStyle = BorderStyle.None;
            TxtInputArticleName.Cursor = Cursors.IBeam;
            TxtInputArticleName.Location = new Point(120, 57);
            TxtInputArticleName.Name = "TxtInputArticleName";
            TxtInputArticleName.Size = new Size(133, 16);
            TxtInputArticleName.TabIndex = 2;
            // 
            // LblInfoArticlePrice
            // 
            LblInfoArticlePrice.AutoSize = true;
            LblInfoArticlePrice.Location = new Point(275, 58);
            LblInfoArticlePrice.Name = "LblInfoArticlePrice";
            LblInfoArticlePrice.Size = new Size(70, 15);
            LblInfoArticlePrice.TabIndex = 1;
            LblInfoArticlePrice.Text = "Article Price";
            // 
            // LblInfoArticleName
            // 
            LblInfoArticleName.AutoSize = true;
            LblInfoArticleName.Location = new Point(21, 58);
            LblInfoArticleName.Name = "LblInfoArticleName";
            LblInfoArticleName.Size = new Size(76, 15);
            LblInfoArticleName.TabIndex = 1;
            LblInfoArticleName.Text = "Article Name";
            // 
            // LblInfoArticleNumber
            // 
            LblInfoArticleNumber.AutoSize = true;
            LblInfoArticleNumber.Location = new Point(275, 30);
            LblInfoArticleNumber.Name = "LblInfoArticleNumber";
            LblInfoArticleNumber.Size = new Size(88, 15);
            LblInfoArticleNumber.TabIndex = 1;
            LblInfoArticleNumber.Text = "Article Number";
            // 
            // LblInfoArticleGroup
            // 
            LblInfoArticleGroup.AutoSize = true;
            LblInfoArticleGroup.Location = new Point(21, 30);
            LblInfoArticleGroup.Name = "LblInfoArticleGroup";
            LblInfoArticleGroup.Size = new Size(77, 15);
            LblInfoArticleGroup.TabIndex = 1;
            LblInfoArticleGroup.Text = "Article Group";
            // 
            // button3
            // 
            button3.Location = new Point(412, 89);
            button3.Name = "button3";
            button3.Size = new Size(110, 23);
            button3.TabIndex = 0;
            button3.Text = "Delete Article";
            button3.UseVisualStyleBackColor = true;
            button3.Click += CmdDeleteCustomer_Click;
            // 
            // button2
            // 
            button2.Location = new Point(307, 89);
            button2.Name = "button2";
            button2.Size = new Size(99, 23);
            button2.TabIndex = 0;
            button2.Text = "Save changes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += CmdSaveChangesCustomer_Click;
            // 
            // button1
            // 
            button1.Location = new Point(6, 89);
            button1.Name = "button1";
            button1.Size = new Size(156, 23);
            button1.TabIndex = 0;
            button1.Text = "Save as new Article";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CmdCreateNewCustomer_Click;
            // 
            // CmbInputArticleGroup
            // 
            CmbInputArticleGroup.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbInputArticleGroup.BackColor = SystemColors.Window;
            CmbInputArticleGroup.FormattingEnabled = true;
            CmbInputArticleGroup.ItemHeight = 15;
            CmbInputArticleGroup.Items.AddRange(new object[] { "Fahrzeuge", "Lebensmittel" });
            CmbInputArticleGroup.Location = new Point(120, 27);
            CmbInputArticleGroup.Name = "CmbInputArticleGroup";
            CmbInputArticleGroup.Size = new Size(133, 23);
            CmbInputArticleGroup.Sorted = true;
            CmbInputArticleGroup.TabIndex = 3;
            // 
            // GrpSearch
            // 
            GrpSearch.Controls.Add(TxtSearchCustomerAdress);
            GrpSearch.Controls.Add(TxtSearchCustomerCity);
            GrpSearch.Controls.Add(TxtSearchCustomerCountry);
            GrpSearch.Controls.Add(LblInfoSearchCustomerAdress);
            GrpSearch.Controls.Add(LblInfoSearchCustomerCity);
            GrpSearch.Controls.Add(LblInfoSearchCustomerCountry);
            GrpSearch.Controls.Add(TxtSearchArticleNumber);
            GrpSearch.Controls.Add(TxtSearchArticleName);
            GrpSearch.Controls.Add(TxtSearchArticleGroup);
            GrpSearch.Controls.Add(CmdResetSearchFilters);
            GrpSearch.Controls.Add(CmdSearchArticles);
            GrpSearch.Controls.Add(LblInfoSearchOrdersCustomerLastName);
            GrpSearch.Controls.Add(LblInfoSearchOrdersCustomerFirstName);
            GrpSearch.Controls.Add(LblInfoSearchOrdersCustomerNumber);
            GrpSearch.ForeColor = SystemColors.ControlText;
            GrpSearch.Location = new Point(143, 12);
            GrpSearch.Name = "GrpSearch";
            GrpSearch.Size = new Size(528, 245);
            GrpSearch.TabIndex = 2;
            GrpSearch.TabStop = false;
            GrpSearch.Text = "Search";
            // 
            // TxtSearchArticleNumber
            // 
            TxtSearchArticleNumber.BackColor = SystemColors.ScrollBar;
            TxtSearchArticleNumber.BorderStyle = BorderStyle.FixedSingle;
            TxtSearchArticleNumber.Location = new Point(357, 50);
            TxtSearchArticleNumber.Name = "TxtSearchArticleNumber";
            TxtSearchArticleNumber.Size = new Size(145, 23);
            TxtSearchArticleNumber.TabIndex = 2;
            // 
            // TxtSearchArticleName
            // 
            TxtSearchArticleName.BackColor = SystemColors.ScrollBar;
            TxtSearchArticleName.BorderStyle = BorderStyle.FixedSingle;
            TxtSearchArticleName.Location = new Point(192, 50);
            TxtSearchArticleName.Name = "TxtSearchArticleName";
            TxtSearchArticleName.Size = new Size(145, 23);
            TxtSearchArticleName.TabIndex = 2;
            // 
            // TxtSearchArticleGroup
            // 
            TxtSearchArticleGroup.Location = new Point(26, 50);
            TxtSearchArticleGroup.Name = "TxtSearchArticleGroup";
            TxtSearchArticleGroup.Size = new Size(145, 23);
            TxtSearchArticleGroup.TabIndex = 2;
            // 
            // CmdResetSearchFilters
            // 
            CmdResetSearchFilters.Location = new Point(273, 216);
            CmdResetSearchFilters.Name = "CmdResetSearchFilters";
            CmdResetSearchFilters.Size = new Size(117, 23);
            CmdResetSearchFilters.TabIndex = 0;
            CmdResetSearchFilters.Text = "Reset search filters";
            CmdResetSearchFilters.UseVisualStyleBackColor = true;
            CmdResetSearchFilters.Click += CmdResetSearchFilters_Click;
            // 
            // CmdSearchArticles
            // 
            CmdSearchArticles.Location = new Point(396, 216);
            CmdSearchArticles.Name = "CmdSearchArticles";
            CmdSearchArticles.Size = new Size(126, 23);
            CmdSearchArticles.TabIndex = 0;
            CmdSearchArticles.Text = "Search Articles";
            CmdSearchArticles.UseVisualStyleBackColor = true;
            CmdSearchArticles.Click += CmdSearchCustomers_Click;
            // 
            // LblInfoSearchOrdersCustomerLastName
            // 
            LblInfoSearchOrdersCustomerLastName.AutoSize = true;
            LblInfoSearchOrdersCustomerLastName.Location = new Point(357, 30);
            LblInfoSearchOrdersCustomerLastName.Name = "LblInfoSearchOrdersCustomerLastName";
            LblInfoSearchOrdersCustomerLastName.Size = new Size(75, 15);
            LblInfoSearchOrdersCustomerLastName.TabIndex = 1;
            LblInfoSearchOrdersCustomerLastName.Text = "Last Number";
            // 
            // LblInfoSearchOrdersCustomerFirstName
            // 
            LblInfoSearchOrdersCustomerFirstName.AutoSize = true;
            LblInfoSearchOrdersCustomerFirstName.Location = new Point(192, 30);
            LblInfoSearchOrdersCustomerFirstName.Name = "LblInfoSearchOrdersCustomerFirstName";
            LblInfoSearchOrdersCustomerFirstName.Size = new Size(64, 15);
            LblInfoSearchOrdersCustomerFirstName.TabIndex = 1;
            LblInfoSearchOrdersCustomerFirstName.Text = "First Name";
            // 
            // LblInfoSearchOrdersCustomerNumber
            // 
            LblInfoSearchOrdersCustomerNumber.AutoSize = true;
            LblInfoSearchOrdersCustomerNumber.Location = new Point(26, 30);
            LblInfoSearchOrdersCustomerNumber.Name = "LblInfoSearchOrdersCustomerNumber";
            LblInfoSearchOrdersCustomerNumber.Size = new Size(106, 15);
            LblInfoSearchOrdersCustomerNumber.TabIndex = 1;
            LblInfoSearchOrdersCustomerNumber.Text = "Customer Number";
            // 
            // GrpInformationArticleGroup
            // 
            GrpInformationArticleGroup.Controls.Add(TxtInputArticleGroupName);
            GrpInformationArticleGroup.Controls.Add(GrpInformationArticleGroupName);
            GrpInformationArticleGroup.Controls.Add(GrpInformationArticleGroupParent);
            GrpInformationArticleGroup.Controls.Add(button4);
            GrpInformationArticleGroup.Controls.Add(button5);
            GrpInformationArticleGroup.Controls.Add(button6);
            GrpInformationArticleGroup.Controls.Add(CmbInputArticleGroupParent);
            GrpInformationArticleGroup.Location = new Point(695, 141);
            GrpInformationArticleGroup.Name = "GrpInformationArticleGroup";
            GrpInformationArticleGroup.Size = new Size(528, 123);
            GrpInformationArticleGroup.TabIndex = 2;
            GrpInformationArticleGroup.TabStop = false;
            GrpInformationArticleGroup.Text = "Information selected Article Group";
            // 
            // TxtInputArticleGroupName
            // 
            TxtInputArticleGroupName.BackColor = SystemColors.Window;
            TxtInputArticleGroupName.BorderStyle = BorderStyle.None;
            TxtInputArticleGroupName.Cursor = Cursors.IBeam;
            TxtInputArticleGroupName.Location = new Point(120, 54);
            TxtInputArticleGroupName.Name = "TxtInputArticleGroupName";
            TxtInputArticleGroupName.Size = new Size(133, 16);
            TxtInputArticleGroupName.TabIndex = 2;
            // 
            // GrpInformationArticleGroupName
            // 
            GrpInformationArticleGroupName.AutoSize = true;
            GrpInformationArticleGroupName.Location = new Point(21, 55);
            GrpInformationArticleGroupName.Name = "GrpInformationArticleGroupName";
            GrpInformationArticleGroupName.Size = new Size(75, 15);
            GrpInformationArticleGroupName.TabIndex = 1;
            GrpInformationArticleGroupName.Text = "Group Name";
            // 
            // GrpInformationArticleGroupParent
            // 
            GrpInformationArticleGroupParent.AutoSize = true;
            GrpInformationArticleGroupParent.Location = new Point(21, 30);
            GrpInformationArticleGroupParent.Name = "GrpInformationArticleGroupParent";
            GrpInformationArticleGroupParent.Size = new Size(77, 15);
            GrpInformationArticleGroupParent.TabIndex = 1;
            GrpInformationArticleGroupParent.Text = "Group Parent";
            // 
            // button4
            // 
            button4.Location = new Point(412, 89);
            button4.Name = "button4";
            button4.Size = new Size(110, 23);
            button4.TabIndex = 0;
            button4.Text = "Delete Group";
            button4.UseVisualStyleBackColor = true;
            button4.Click += CmdDeleteCustomer_Click;
            // 
            // button5
            // 
            button5.Location = new Point(307, 89);
            button5.Name = "button5";
            button5.Size = new Size(99, 23);
            button5.TabIndex = 0;
            button5.Text = "Save changes";
            button5.UseVisualStyleBackColor = true;
            button5.Click += CmdSaveChangesCustomer_Click;
            // 
            // button6
            // 
            button6.Location = new Point(6, 89);
            button6.Name = "button6";
            button6.Size = new Size(156, 23);
            button6.TabIndex = 0;
            button6.Text = "Save as new Article Group";
            button6.UseVisualStyleBackColor = true;
            button6.Click += CmdCreateNewCustomer_Click;
            // 
            // TxtSearchCustomerAdress
            // 
            TxtSearchCustomerAdress.Location = new Point(357, 107);
            TxtSearchCustomerAdress.Name = "TxtSearchCustomerAdress";
            TxtSearchCustomerAdress.Size = new Size(145, 23);
            TxtSearchCustomerAdress.TabIndex = 6;
            // 
            // TxtSearchCustomerCity
            // 
            TxtSearchCustomerCity.Location = new Point(192, 107);
            TxtSearchCustomerCity.Name = "TxtSearchCustomerCity";
            TxtSearchCustomerCity.Size = new Size(145, 23);
            TxtSearchCustomerCity.TabIndex = 7;
            // 
            // TxtSearchCustomerCountry
            // 
            TxtSearchCustomerCountry.Location = new Point(26, 107);
            TxtSearchCustomerCountry.Name = "TxtSearchCustomerCountry";
            TxtSearchCustomerCountry.Size = new Size(145, 23);
            TxtSearchCustomerCountry.TabIndex = 8;
            // 
            // LblInfoSearchCustomerAdress
            // 
            LblInfoSearchCustomerAdress.AutoSize = true;
            LblInfoSearchCustomerAdress.Location = new Point(357, 89);
            LblInfoSearchCustomerAdress.Name = "LblInfoSearchCustomerAdress";
            LblInfoSearchCustomerAdress.Size = new Size(42, 15);
            LblInfoSearchCustomerAdress.TabIndex = 3;
            LblInfoSearchCustomerAdress.Text = "Adress";
            // 
            // LblInfoSearchCustomerCity
            // 
            LblInfoSearchCustomerCity.AutoSize = true;
            LblInfoSearchCustomerCity.Location = new Point(192, 89);
            LblInfoSearchCustomerCity.Name = "LblInfoSearchCustomerCity";
            LblInfoSearchCustomerCity.Size = new Size(28, 15);
            LblInfoSearchCustomerCity.TabIndex = 4;
            LblInfoSearchCustomerCity.Text = "City";
            // 
            // LblInfoSearchCustomerCountry
            // 
            LblInfoSearchCustomerCountry.AutoSize = true;
            LblInfoSearchCustomerCountry.Location = new Point(26, 89);
            LblInfoSearchCustomerCountry.Name = "LblInfoSearchCustomerCountry";
            LblInfoSearchCustomerCountry.Size = new Size(50, 15);
            LblInfoSearchCustomerCountry.TabIndex = 5;
            LblInfoSearchCustomerCountry.Text = "Country";
            // 
            // CmbInputArticleGroupParent
            // 
            CmbInputArticleGroupParent.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbInputArticleGroupParent.BackColor = SystemColors.Window;
            CmbInputArticleGroupParent.FormattingEnabled = true;
            CmbInputArticleGroupParent.ItemHeight = 15;
            CmbInputArticleGroupParent.Items.AddRange(new object[] { "Fahrzeuge", "Lebensmittel" });
            CmbInputArticleGroupParent.Location = new Point(120, 25);
            CmbInputArticleGroupParent.Name = "CmbInputArticleGroupParent";
            CmbInputArticleGroupParent.Size = new Size(133, 23);
            CmbInputArticleGroupParent.Sorted = true;
            CmbInputArticleGroupParent.TabIndex = 3;
            // 
            // FormOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(GrpInformationArticleGroup);
            Controls.Add(GrpInformationArticle);
            Controls.Add(GrpSearch);
            Controls.Add(GrpResults);
            Controls.Add(GrpNavigation);
            Name = "FormOrders";
            Text = "FormArticles";
            GrpNavigation.ResumeLayout(false);
            GrpResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewOrdersResults).EndInit();
            GrpInformationArticle.ResumeLayout(false);
            GrpInformationArticle.PerformLayout();
            GrpSearch.ResumeLayout(false);
            GrpSearch.PerformLayout();
            GrpInformationArticleGroup.ResumeLayout(false);
            GrpInformationArticleGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button CmdCustomers;
        private Button CmdArticles;
        private Button CmdOrders;
        private GroupBox GrpNavigation;
        private GroupBox GrpResults;
        private GroupBox GrpInformationArticle;
        private GroupBox GrpSearch;
        private Button CmdCreateEmptyArticle;
        private Button CmdDeleteSelectedObject;
        private Button CmdShowAllOrders;
        private Button CmdResetSearchFilters;
        private Button CmdSearchArticles;
        private Button CmdCloseProgram;
        private Label LblInfoArticleGroup;
        private Label LblInfoArticleName;
        private Label LblInfoSearchOrdersCustomerNumber;
        private Label LblInfoSearchOrdersCustomerLastName;
        private Label LblInfoSearchOrdersCustomerFirstName;
        private TextBox TxtSearchArticleNumber;
        private TextBox TxtSearchArticleName;
        private TextBox TxtSearchArticleGroup;
        private TextBox TxtInputArticleName;
        private TextBox TxtInputArticleNumber;
        private TextBox TxtInputArticlePrice;
        private Label LblInfoArticlePrice;
        private Label LblInfoArticleNumber;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox GrpInformationArticleGroup;
        private TextBox TxtInputArticleGroupParent;
        private Label GrpInformationArticleGroupParent;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox TxtInputArticleGroupName;
        private Label GrpInformationArticleGroupName;
        private ComboBox CmbInputArticleGroup;
        private DataGridView DataGridViewOrdersResults;
        private TextBox TxtSearchCustomerAdress;
        private TextBox TxtSearchCustomerCity;
        private TextBox TxtSearchCustomerCountry;
        private Label LblInfoSearchCustomerAdress;
        private Label LblInfoSearchCustomerCity;
        private Label LblInfoSearchCustomerCountry;
        private ComboBox CmbInputArticleGroupParent;
    }
}