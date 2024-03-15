namespace BusinessApplicationProject.View
{
    partial class UsrCtrlCustomers
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
            LblInfoCustomerCity = new Label();
            LblInfoCustomerWebsite = new Label();
            LblInfoCustomerEmail = new Label();
            LblInfoCustomerAdress = new Label();
            LblInfoSearchCustomerCountry = new Label();
            GrpSearch = new GroupBox();
            TxtSearchCustomerLastName = new TextBox();
            TxtSearchCustomerFirstName = new TextBox();
            TxtSearchCustomerAdress = new TextBox();
            TxtSearchCustomerCity = new TextBox();
            TxtSearchCustomerEmail = new TextBox();
            TxtSearchCustomerCountry = new TextBox();
            TxtSearchCustomerNumber = new TextBox();
            CmdResetSearchFilters = new Button();
            CmdSearchCustomers = new Button();
            LblInfoSearchCustomerLastName = new Label();
            LblInfoSearchCustomerFirstName = new Label();
            LblInfoSearchCustomerAdress = new Label();
            LblInfoSearchCustomerCity = new Label();
            LblInfoSearchCustomerEmail = new Label();
            LblInfoSearchCustomerNumber = new Label();
            LblInfoCustomerPostalCode = new Label();
            GrpOrders = new GroupBox();
            DataGridViewCustomerOrders = new DataGridView();
            orderNumber = new DataGridViewTextBoxColumn();
            dateOfOrder = new DataGridViewTextBoxColumn();
            totalPriceOrder = new DataGridViewTextBoxColumn();
            CmdOpenSelectedOrder = new Button();
            CmdCreateNewOrder = new Button();
            CmdDeleteSelectedOrders = new Button();
            TxtInputCustomerNumber = new TextBox();
            TxtInputCustomerAdress = new TextBox();
            TxtInputCustomerPostalCode = new TextBox();
            TxtInputCustomerCity = new TextBox();
            TxtInputCustomerCountry = new TextBox();
            GrpResults = new GroupBox();
            LblDataGridCustomersNoResults = new Label();
            DataGridViewCustomersResults = new DataGridView();
            CmdShowAllCustomers = new Button();
            CmdCreateEmptyCustomer = new Button();
            CmdDeleteSelectedCustomers = new Button();
            GrpInformation = new GroupBox();
            TxtInputCustomerWebsite = new TextBox();
            TxtInputCustomerEmail = new TextBox();
            TxtInputCustomerLastName = new TextBox();
            TxtInputCustomerFirstName = new TextBox();
            TxtInputCustomerPassword = new TextBox();
            LblInfoCustomerCountry = new Label();
            LblInfoCustomerLastName = new Label();
            LblInfoCustomerFirstName = new Label();
            LblInfoCustomerPassword = new Label();
            LblInfoCustomerNumber = new Label();
            CmdDeleteCustomer = new Button();
            CmdSaveChangesCustomer = new Button();
            CmdCreateNewCustomer = new Button();
            GrpSearch.SuspendLayout();
            GrpOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCustomerOrders).BeginInit();
            GrpResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCustomersResults).BeginInit();
            GrpInformation.SuspendLayout();
            SuspendLayout();
            // 
            // LblInfoCustomerCity
            // 
            LblInfoCustomerCity.AutoSize = true;
            LblInfoCustomerCity.Location = new Point(206, 160);
            LblInfoCustomerCity.Name = "LblInfoCustomerCity";
            LblInfoCustomerCity.Size = new Size(28, 15);
            LblInfoCustomerCity.TabIndex = 1;
            LblInfoCustomerCity.Text = "City";
            // 
            // LblInfoCustomerWebsite
            // 
            LblInfoCustomerWebsite.AutoSize = true;
            LblInfoCustomerWebsite.Location = new Point(256, 107);
            LblInfoCustomerWebsite.Name = "LblInfoCustomerWebsite";
            LblInfoCustomerWebsite.Size = new Size(49, 15);
            LblInfoCustomerWebsite.TabIndex = 1;
            LblInfoCustomerWebsite.Text = "Website";
            // 
            // LblInfoCustomerEmail
            // 
            LblInfoCustomerEmail.AutoSize = true;
            LblInfoCustomerEmail.Location = new Point(256, 87);
            LblInfoCustomerEmail.Name = "LblInfoCustomerEmail";
            LblInfoCustomerEmail.Size = new Size(36, 15);
            LblInfoCustomerEmail.TabIndex = 1;
            LblInfoCustomerEmail.Text = "Email";
            // 
            // LblInfoCustomerAdress
            // 
            LblInfoCustomerAdress.AutoSize = true;
            LblInfoCustomerAdress.Location = new Point(21, 180);
            LblInfoCustomerAdress.Name = "LblInfoCustomerAdress";
            LblInfoCustomerAdress.Size = new Size(42, 15);
            LblInfoCustomerAdress.TabIndex = 1;
            LblInfoCustomerAdress.Text = "Adress";
            // 
            // LblInfoSearchCustomerCountry
            // 
            LblInfoSearchCustomerCountry.AutoSize = true;
            LblInfoSearchCustomerCountry.Location = new Point(26, 89);
            LblInfoSearchCustomerCountry.Name = "LblInfoSearchCustomerCountry";
            LblInfoSearchCustomerCountry.Size = new Size(50, 15);
            LblInfoSearchCustomerCountry.TabIndex = 1;
            LblInfoSearchCustomerCountry.Text = "Country";
            // 
            // GrpSearch
            // 
            GrpSearch.Controls.Add(TxtSearchCustomerLastName);
            GrpSearch.Controls.Add(TxtSearchCustomerFirstName);
            GrpSearch.Controls.Add(TxtSearchCustomerAdress);
            GrpSearch.Controls.Add(TxtSearchCustomerCity);
            GrpSearch.Controls.Add(TxtSearchCustomerEmail);
            GrpSearch.Controls.Add(TxtSearchCustomerCountry);
            GrpSearch.Controls.Add(TxtSearchCustomerNumber);
            GrpSearch.Controls.Add(CmdResetSearchFilters);
            GrpSearch.Controls.Add(CmdSearchCustomers);
            GrpSearch.Controls.Add(LblInfoSearchCustomerLastName);
            GrpSearch.Controls.Add(LblInfoSearchCustomerFirstName);
            GrpSearch.Controls.Add(LblInfoSearchCustomerAdress);
            GrpSearch.Controls.Add(LblInfoSearchCustomerCity);
            GrpSearch.Controls.Add(LblInfoSearchCustomerEmail);
            GrpSearch.Controls.Add(LblInfoSearchCustomerCountry);
            GrpSearch.Controls.Add(LblInfoSearchCustomerNumber);
            GrpSearch.ForeColor = SystemColors.ControlText;
            GrpSearch.Location = new Point(3, 0);
            GrpSearch.Name = "GrpSearch";
            GrpSearch.Size = new Size(528, 245);
            GrpSearch.TabIndex = 4;
            GrpSearch.TabStop = false;
            GrpSearch.Text = "Search";
            // 
            // TxtSearchCustomerLastName
            // 
            TxtSearchCustomerLastName.Location = new Point(357, 50);
            TxtSearchCustomerLastName.Name = "TxtSearchCustomerLastName";
            TxtSearchCustomerLastName.Size = new Size(145, 23);
            TxtSearchCustomerLastName.TabIndex = 2;
            // 
            // TxtSearchCustomerFirstName
            // 
            TxtSearchCustomerFirstName.Location = new Point(192, 50);
            TxtSearchCustomerFirstName.Name = "TxtSearchCustomerFirstName";
            TxtSearchCustomerFirstName.Size = new Size(145, 23);
            TxtSearchCustomerFirstName.TabIndex = 2;
            // 
            // TxtSearchCustomerAdress
            // 
            TxtSearchCustomerAdress.Location = new Point(357, 107);
            TxtSearchCustomerAdress.Name = "TxtSearchCustomerAdress";
            TxtSearchCustomerAdress.Size = new Size(145, 23);
            TxtSearchCustomerAdress.TabIndex = 2;
            // 
            // TxtSearchCustomerCity
            // 
            TxtSearchCustomerCity.Location = new Point(192, 107);
            TxtSearchCustomerCity.Name = "TxtSearchCustomerCity";
            TxtSearchCustomerCity.Size = new Size(145, 23);
            TxtSearchCustomerCity.TabIndex = 2;
            // 
            // TxtSearchCustomerEmail
            // 
            TxtSearchCustomerEmail.Location = new Point(26, 164);
            TxtSearchCustomerEmail.Name = "TxtSearchCustomerEmail";
            TxtSearchCustomerEmail.Size = new Size(145, 23);
            TxtSearchCustomerEmail.TabIndex = 2;
            // 
            // TxtSearchCustomerCountry
            // 
            TxtSearchCustomerCountry.Location = new Point(26, 107);
            TxtSearchCustomerCountry.Name = "TxtSearchCustomerCountry";
            TxtSearchCustomerCountry.Size = new Size(145, 23);
            TxtSearchCustomerCountry.TabIndex = 2;
            // 
            // TxtSearchCustomerNumber
            // 
            TxtSearchCustomerNumber.Location = new Point(26, 50);
            TxtSearchCustomerNumber.Name = "TxtSearchCustomerNumber";
            TxtSearchCustomerNumber.Size = new Size(145, 23);
            TxtSearchCustomerNumber.TabIndex = 2;
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
            // LblInfoSearchCustomerLastName
            // 
            LblInfoSearchCustomerLastName.AutoSize = true;
            LblInfoSearchCustomerLastName.Location = new Point(357, 30);
            LblInfoSearchCustomerLastName.Name = "LblInfoSearchCustomerLastName";
            LblInfoSearchCustomerLastName.Size = new Size(63, 15);
            LblInfoSearchCustomerLastName.TabIndex = 1;
            LblInfoSearchCustomerLastName.Text = "Last Name";
            // 
            // LblInfoSearchCustomerFirstName
            // 
            LblInfoSearchCustomerFirstName.AutoSize = true;
            LblInfoSearchCustomerFirstName.Location = new Point(192, 30);
            LblInfoSearchCustomerFirstName.Name = "LblInfoSearchCustomerFirstName";
            LblInfoSearchCustomerFirstName.Size = new Size(64, 15);
            LblInfoSearchCustomerFirstName.TabIndex = 1;
            LblInfoSearchCustomerFirstName.Text = "First Name";
            // 
            // LblInfoSearchCustomerAdress
            // 
            LblInfoSearchCustomerAdress.AutoSize = true;
            LblInfoSearchCustomerAdress.Location = new Point(357, 89);
            LblInfoSearchCustomerAdress.Name = "LblInfoSearchCustomerAdress";
            LblInfoSearchCustomerAdress.Size = new Size(42, 15);
            LblInfoSearchCustomerAdress.TabIndex = 1;
            LblInfoSearchCustomerAdress.Text = "Adress";
            // 
            // LblInfoSearchCustomerCity
            // 
            LblInfoSearchCustomerCity.AutoSize = true;
            LblInfoSearchCustomerCity.Location = new Point(192, 89);
            LblInfoSearchCustomerCity.Name = "LblInfoSearchCustomerCity";
            LblInfoSearchCustomerCity.Size = new Size(28, 15);
            LblInfoSearchCustomerCity.TabIndex = 1;
            LblInfoSearchCustomerCity.Text = "City";
            // 
            // LblInfoSearchCustomerEmail
            // 
            LblInfoSearchCustomerEmail.AutoSize = true;
            LblInfoSearchCustomerEmail.Location = new Point(26, 146);
            LblInfoSearchCustomerEmail.Name = "LblInfoSearchCustomerEmail";
            LblInfoSearchCustomerEmail.Size = new Size(36, 15);
            LblInfoSearchCustomerEmail.TabIndex = 1;
            LblInfoSearchCustomerEmail.Text = "Email";
            // 
            // LblInfoSearchCustomerNumber
            // 
            LblInfoSearchCustomerNumber.AutoSize = true;
            LblInfoSearchCustomerNumber.Location = new Point(26, 30);
            LblInfoSearchCustomerNumber.Name = "LblInfoSearchCustomerNumber";
            LblInfoSearchCustomerNumber.Size = new Size(106, 15);
            LblInfoSearchCustomerNumber.TabIndex = 1;
            LblInfoSearchCustomerNumber.Text = "Customer Number";
            // 
            // LblInfoCustomerPostalCode
            // 
            LblInfoCustomerPostalCode.AutoSize = true;
            LblInfoCustomerPostalCode.Location = new Point(21, 160);
            LblInfoCustomerPostalCode.Name = "LblInfoCustomerPostalCode";
            LblInfoCustomerPostalCode.Size = new Size(70, 15);
            LblInfoCustomerPostalCode.TabIndex = 1;
            LblInfoCustomerPostalCode.Text = "Postal Code";
            // 
            // GrpOrders
            // 
            GrpOrders.Controls.Add(DataGridViewCustomerOrders);
            GrpOrders.Controls.Add(CmdOpenSelectedOrder);
            GrpOrders.Controls.Add(CmdCreateNewOrder);
            GrpOrders.Controls.Add(CmdDeleteSelectedOrders);
            GrpOrders.ForeColor = SystemColors.ControlText;
            GrpOrders.Location = new Point(0, 251);
            GrpOrders.Name = "GrpOrders";
            GrpOrders.Size = new Size(528, 385);
            GrpOrders.TabIndex = 2;
            GrpOrders.TabStop = false;
            GrpOrders.Text = "Orders";
            // 
            // DataGridViewCustomerOrders
            // 
            DataGridViewCustomerOrders.AllowUserToAddRows = false;
            DataGridViewCustomerOrders.AllowUserToDeleteRows = false;
            DataGridViewCustomerOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCustomerOrders.Columns.AddRange(new DataGridViewColumn[] { orderNumber, dateOfOrder, totalPriceOrder });
            DataGridViewCustomerOrders.Location = new Point(6, 22);
            DataGridViewCustomerOrders.Name = "DataGridViewCustomerOrders";
            DataGridViewCustomerOrders.ReadOnly = true;
            DataGridViewCustomerOrders.Size = new Size(516, 328);
            DataGridViewCustomerOrders.TabIndex = 1;
            // 
            // orderNumber
            // 
            orderNumber.HeaderText = "Order Number";
            orderNumber.Name = "orderNumber";
            orderNumber.ReadOnly = true;
            orderNumber.Width = 150;
            // 
            // dateOfOrder
            // 
            dateOfOrder.HeaderText = "Date of Order";
            dateOfOrder.Name = "dateOfOrder";
            dateOfOrder.ReadOnly = true;
            dateOfOrder.Width = 150;
            // 
            // totalPriceOrder
            // 
            totalPriceOrder.HeaderText = "Total Price";
            totalPriceOrder.Name = "totalPriceOrder";
            totalPriceOrder.ReadOnly = true;
            totalPriceOrder.Width = 150;
            // 
            // CmdOpenSelectedOrder
            // 
            CmdOpenSelectedOrder.Location = new Point(6, 356);
            CmdOpenSelectedOrder.Name = "CmdOpenSelectedOrder";
            CmdOpenSelectedOrder.Size = new Size(132, 23);
            CmdOpenSelectedOrder.TabIndex = 0;
            CmdOpenSelectedOrder.Text = "Open selected Order";
            CmdOpenSelectedOrder.UseVisualStyleBackColor = true;
            // 
            // CmdCreateNewOrder
            // 
            CmdCreateNewOrder.Location = new Point(256, 356);
            CmdCreateNewOrder.Name = "CmdCreateNewOrder";
            CmdCreateNewOrder.Size = new Size(114, 23);
            CmdCreateNewOrder.TabIndex = 0;
            CmdCreateNewOrder.Text = "Create new Order";
            CmdCreateNewOrder.UseVisualStyleBackColor = true;
            // 
            // CmdDeleteSelectedOrders
            // 
            CmdDeleteSelectedOrders.Location = new Point(376, 356);
            CmdDeleteSelectedOrders.Name = "CmdDeleteSelectedOrders";
            CmdDeleteSelectedOrders.Size = new Size(146, 23);
            CmdDeleteSelectedOrders.TabIndex = 0;
            CmdDeleteSelectedOrders.Text = "Delete selected Order(s)";
            CmdDeleteSelectedOrders.UseVisualStyleBackColor = true;
            // 
            // TxtInputCustomerNumber
            // 
            TxtInputCustomerNumber.BackColor = SystemColors.ScrollBar;
            TxtInputCustomerNumber.BorderStyle = BorderStyle.None;
            TxtInputCustomerNumber.Cursor = Cursors.IBeam;
            TxtInputCustomerNumber.Location = new Point(139, 30);
            TxtInputCustomerNumber.Name = "TxtInputCustomerNumber";
            TxtInputCustomerNumber.ReadOnly = true;
            TxtInputCustomerNumber.Size = new Size(133, 16);
            TxtInputCustomerNumber.TabIndex = 2;
            // 
            // TxtInputCustomerAdress
            // 
            TxtInputCustomerAdress.BackColor = SystemColors.Window;
            TxtInputCustomerAdress.BorderStyle = BorderStyle.None;
            TxtInputCustomerAdress.Cursor = Cursors.IBeam;
            TxtInputCustomerAdress.Location = new Point(109, 180);
            TxtInputCustomerAdress.Name = "TxtInputCustomerAdress";
            TxtInputCustomerAdress.Size = new Size(133, 16);
            TxtInputCustomerAdress.TabIndex = 2;
            // 
            // TxtInputCustomerPostalCode
            // 
            TxtInputCustomerPostalCode.BackColor = SystemColors.Window;
            TxtInputCustomerPostalCode.BorderStyle = BorderStyle.None;
            TxtInputCustomerPostalCode.Cursor = Cursors.IBeam;
            TxtInputCustomerPostalCode.Location = new Point(109, 159);
            TxtInputCustomerPostalCode.Name = "TxtInputCustomerPostalCode";
            TxtInputCustomerPostalCode.Size = new Size(78, 16);
            TxtInputCustomerPostalCode.TabIndex = 2;
            // 
            // TxtInputCustomerCity
            // 
            TxtInputCustomerCity.BackColor = SystemColors.Window;
            TxtInputCustomerCity.BorderStyle = BorderStyle.None;
            TxtInputCustomerCity.Cursor = Cursors.IBeam;
            TxtInputCustomerCity.Location = new Point(256, 160);
            TxtInputCustomerCity.Name = "TxtInputCustomerCity";
            TxtInputCustomerCity.Size = new Size(133, 16);
            TxtInputCustomerCity.TabIndex = 2;
            // 
            // TxtInputCustomerCountry
            // 
            TxtInputCustomerCountry.BackColor = SystemColors.Window;
            TxtInputCustomerCountry.BorderStyle = BorderStyle.None;
            TxtInputCustomerCountry.Cursor = Cursors.IBeam;
            TxtInputCustomerCountry.Location = new Point(109, 139);
            TxtInputCustomerCountry.Name = "TxtInputCustomerCountry";
            TxtInputCustomerCountry.Size = new Size(133, 16);
            TxtInputCustomerCountry.TabIndex = 2;
            // 
            // GrpResults
            // 
            GrpResults.Controls.Add(LblDataGridCustomersNoResults);
            GrpResults.Controls.Add(DataGridViewCustomersResults);
            GrpResults.Controls.Add(CmdShowAllCustomers);
            GrpResults.Controls.Add(CmdCreateEmptyCustomer);
            GrpResults.Controls.Add(CmdDeleteSelectedCustomers);
            GrpResults.ForeColor = SystemColors.ControlText;
            GrpResults.Location = new Point(3, 251);
            GrpResults.Name = "GrpResults";
            GrpResults.Size = new Size(528, 385);
            GrpResults.TabIndex = 5;
            GrpResults.TabStop = false;
            GrpResults.Text = "Customers";
            // 
            // LblDataGridCustomersNoResults
            // 
            LblDataGridCustomersNoResults.AutoSize = true;
            LblDataGridCustomersNoResults.Location = new Point(233, 181);
            LblDataGridCustomersNoResults.Name = "LblDataGridCustomersNoResults";
            LblDataGridCustomersNoResults.Size = new Size(63, 15);
            LblDataGridCustomersNoResults.TabIndex = 1;
            LblDataGridCustomersNoResults.Text = "No Results";
            // 
            // DataGridViewCustomersResults
            // 
            DataGridViewCustomersResults.AllowUserToDeleteRows = false;
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
            GrpInformation.Controls.Add(LblInfoCustomerPostalCode);
            GrpInformation.Controls.Add(LblInfoCustomerCity);
            GrpInformation.Controls.Add(GrpOrders);
            GrpInformation.Controls.Add(LblInfoCustomerWebsite);
            GrpInformation.Controls.Add(LblInfoCustomerEmail);
            GrpInformation.Controls.Add(LblInfoCustomerAdress);
            GrpInformation.Controls.Add(TxtInputCustomerNumber);
            GrpInformation.Controls.Add(TxtInputCustomerAdress);
            GrpInformation.Controls.Add(TxtInputCustomerPostalCode);
            GrpInformation.Controls.Add(TxtInputCustomerCity);
            GrpInformation.Controls.Add(TxtInputCustomerCountry);
            GrpInformation.Controls.Add(TxtInputCustomerWebsite);
            GrpInformation.Controls.Add(TxtInputCustomerEmail);
            GrpInformation.Controls.Add(TxtInputCustomerLastName);
            GrpInformation.Controls.Add(TxtInputCustomerFirstName);
            GrpInformation.Controls.Add(TxtInputCustomerPassword);
            GrpInformation.Controls.Add(LblInfoCustomerCountry);
            GrpInformation.Controls.Add(LblInfoCustomerLastName);
            GrpInformation.Controls.Add(LblInfoCustomerFirstName);
            GrpInformation.Controls.Add(LblInfoCustomerPassword);
            GrpInformation.Controls.Add(LblInfoCustomerNumber);
            GrpInformation.Controls.Add(CmdDeleteCustomer);
            GrpInformation.Controls.Add(CmdSaveChangesCustomer);
            GrpInformation.Controls.Add(CmdCreateNewCustomer);
            GrpInformation.Location = new Point(555, 0);
            GrpInformation.Name = "GrpInformation";
            GrpInformation.Size = new Size(528, 636);
            GrpInformation.TabIndex = 6;
            GrpInformation.TabStop = false;
            GrpInformation.Text = "Information selected item";
            GrpInformation.Visible = false;
            // 
            // TxtInputCustomerWebsite
            // 
            TxtInputCustomerWebsite.BackColor = SystemColors.Window;
            TxtInputCustomerWebsite.BorderStyle = BorderStyle.None;
            TxtInputCustomerWebsite.Cursor = Cursors.IBeam;
            TxtInputCustomerWebsite.Location = new Point(330, 107);
            TxtInputCustomerWebsite.Name = "TxtInputCustomerWebsite";
            TxtInputCustomerWebsite.Size = new Size(177, 16);
            TxtInputCustomerWebsite.TabIndex = 2;
            // 
            // TxtInputCustomerEmail
            // 
            TxtInputCustomerEmail.BackColor = SystemColors.Window;
            TxtInputCustomerEmail.BorderStyle = BorderStyle.None;
            TxtInputCustomerEmail.Cursor = Cursors.IBeam;
            TxtInputCustomerEmail.Location = new Point(330, 87);
            TxtInputCustomerEmail.Name = "TxtInputCustomerEmail";
            TxtInputCustomerEmail.Size = new Size(177, 16);
            TxtInputCustomerEmail.TabIndex = 2;
            // 
            // TxtInputCustomerLastName
            // 
            TxtInputCustomerLastName.BackColor = SystemColors.Window;
            TxtInputCustomerLastName.BorderStyle = BorderStyle.None;
            TxtInputCustomerLastName.Cursor = Cursors.IBeam;
            TxtInputCustomerLastName.Location = new Point(109, 106);
            TxtInputCustomerLastName.Name = "TxtInputCustomerLastName";
            TxtInputCustomerLastName.Size = new Size(133, 16);
            TxtInputCustomerLastName.TabIndex = 2;
            // 
            // TxtInputCustomerFirstName
            // 
            TxtInputCustomerFirstName.BackColor = SystemColors.Window;
            TxtInputCustomerFirstName.BorderStyle = BorderStyle.None;
            TxtInputCustomerFirstName.Cursor = Cursors.IBeam;
            TxtInputCustomerFirstName.Location = new Point(109, 86);
            TxtInputCustomerFirstName.Name = "TxtInputCustomerFirstName";
            TxtInputCustomerFirstName.Size = new Size(133, 16);
            TxtInputCustomerFirstName.TabIndex = 2;
            // 
            // TxtInputCustomerPassword
            // 
            TxtInputCustomerPassword.BackColor = SystemColors.Window;
            TxtInputCustomerPassword.BorderStyle = BorderStyle.None;
            TxtInputCustomerPassword.Cursor = Cursors.IBeam;
            TxtInputCustomerPassword.Location = new Point(139, 49);
            TxtInputCustomerPassword.Name = "TxtInputCustomerPassword";
            TxtInputCustomerPassword.Size = new Size(133, 16);
            TxtInputCustomerPassword.TabIndex = 2;
            // 
            // LblInfoCustomerCountry
            // 
            LblInfoCustomerCountry.AutoSize = true;
            LblInfoCustomerCountry.Location = new Point(21, 140);
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
            CmdDeleteCustomer.Location = new Point(412, 216);
            CmdDeleteCustomer.Name = "CmdDeleteCustomer";
            CmdDeleteCustomer.Size = new Size(110, 23);
            CmdDeleteCustomer.TabIndex = 0;
            CmdDeleteCustomer.Text = "Delete Customer";
            CmdDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // CmdSaveChangesCustomer
            // 
            CmdSaveChangesCustomer.Location = new Point(307, 216);
            CmdSaveChangesCustomer.Name = "CmdSaveChangesCustomer";
            CmdSaveChangesCustomer.Size = new Size(99, 23);
            CmdSaveChangesCustomer.TabIndex = 0;
            CmdSaveChangesCustomer.Text = "Save changes";
            CmdSaveChangesCustomer.UseVisualStyleBackColor = true;
            // 
            // CmdCreateNewCustomer
            // 
            CmdCreateNewCustomer.Location = new Point(6, 216);
            CmdCreateNewCustomer.Name = "CmdCreateNewCustomer";
            CmdCreateNewCustomer.Size = new Size(148, 23);
            CmdCreateNewCustomer.TabIndex = 0;
            CmdCreateNewCustomer.Text = "Save as new Customer";
            CmdCreateNewCustomer.UseVisualStyleBackColor = true;
            // 
            // UsrCtrlCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(GrpSearch);
            Controls.Add(GrpResults);
            Controls.Add(GrpInformation);
            Margin = new Padding(2);
            Name = "UsrCtrlCustomers";
            Size = new Size(1085, 640);
            GrpSearch.ResumeLayout(false);
            GrpSearch.PerformLayout();
            GrpOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewCustomerOrders).EndInit();
            GrpResults.ResumeLayout(false);
            GrpResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCustomersResults).EndInit();
            GrpInformation.ResumeLayout(false);
            GrpInformation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label LblInfoCustomerCity;
        private Label LblInfoCustomerWebsite;
        private Label LblInfoCustomerEmail;
        private Label LblInfoCustomerAdress;
        private Label LblInfoSearchCustomerCountry;
        private GroupBox GrpSearch;
        private TextBox TxtSearchCustomerLastName;
        private TextBox TxtSearchCustomerFirstName;
        private TextBox TxtSearchCustomerAdress;
        private TextBox TxtSearchCustomerCity;
        private TextBox TxtSearchCustomerEmail;
        private TextBox TxtSearchCustomerCountry;
        private TextBox TxtSearchCustomerNumber;
        private Button CmdResetSearchFilters;
        private Button CmdSearchCustomers;
        private Label LblInfoSearchCustomerLastName;
        private Label LblInfoSearchCustomerFirstName;
        private Label LblInfoSearchCustomerAdress;
        private Label LblInfoSearchCustomerCity;
        private Label LblInfoSearchCustomerEmail;
        private Label LblInfoSearchCustomerNumber;
        private Label LblInfoCustomerPostalCode;
        private GroupBox GrpOrders;
        private DataGridView DataGridViewCustomerOrders;
        private DataGridViewTextBoxColumn orderNumber;
        private DataGridViewTextBoxColumn dateOfOrder;
        private DataGridViewTextBoxColumn totalPriceOrder;
        private Button CmdOpenSelectedOrder;
        private Button CmdCreateNewOrder;
        private Button CmdDeleteSelectedOrders;
        private TextBox TxtInputCustomerNumber;
        private TextBox TxtInputCustomerAdress;
        private TextBox TxtInputCustomerPostalCode;
        private TextBox TxtInputCustomerCity;
        private TextBox TxtInputCustomerCountry;
        private GroupBox GrpResults;
        private Label LblDataGridCustomersNoResults;
        private DataGridView DataGridViewCustomersResults;
        private Button CmdShowAllCustomers;
        private Button CmdCreateEmptyCustomer;
        private Button CmdDeleteSelectedCustomers;
        private GroupBox GrpInformation;
        private TextBox TxtInputCustomerWebsite;
        private TextBox TxtInputCustomerEmail;
        private TextBox TxtInputCustomerLastName;
        private TextBox TxtInputCustomerFirstName;
        private TextBox TxtInputCustomerPassword;
        private Label LblInfoCustomerCountry;
        private Label LblInfoCustomerLastName;
        private Label LblInfoCustomerFirstName;
        private Label LblInfoCustomerPassword;
        private Label LblInfoCustomerNumber;
        private Button CmdDeleteCustomer;
        private Button CmdSaveChangesCustomer;
        private Button CmdCreateNewCustomer;
    }
}
