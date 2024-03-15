using BusinessApplicationProject.Controller;
using BusinessApplicationProject.Model;
using BusinessApplicationProject.Repository;
using System.Linq.Expressions;

namespace BusinessApplicationProject.View
{
    public partial class UsrCtrlCustomers : UserControl
    {
        public static UsrCtrlCustomers instance = new();

        public UsrCtrlCustomers()
        {
            InitializeComponent();
        }

        #region Search
        private void CmdSearchCustomers_Click(object sender, EventArgs e)
        {
            UpdateSearchResults();
        }

        private void CmdResetSearchFilters_Click(object sender, EventArgs e)
        {
            //Empty fields
            TxtSearchCustomerAdress.Text = string.Empty;
            TxtSearchCustomerCity.Text = string.Empty;
            TxtSearchCustomerCountry.Text = string.Empty;
            TxtSearchCustomerEmail.Text = string.Empty;
            TxtSearchCustomerFirstName.Text = string.Empty;
            TxtSearchCustomerLastName.Text = string.Empty;
            TxtSearchCustomerNumber.Text = string.Empty;
        }
        #endregion

        #region SearchUpdate
        public void UpdateSearchResults()
        {
            DataGridViewCustomersResults.AutoGenerateColumns = false;
            LblDataGridCustomersNoResults.Visible = false;
            DataGridViewCustomersResults.DataSource = null;
            DataGridViewCustomersResults.Columns.Clear();

            try
            {
                List<Customer> customers = [];
                var filter = CreateFilterFunction();
                //customers = invoiceController.Find(filter);

                if (true /*customers.Count > 0*/)
                {
                    DataGridViewTextBoxColumn customerNumberColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "customerNumberColumn",
                        HeaderText = "Customer Number",
                        DataPropertyName = "CustomerNumber"
                    };

                    DataGridViewTextBoxColumn firstNameColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "firstNameColumn",
                        HeaderText = "First Name",
                        DataPropertyName = "FirstName"
                    };

                    DataGridViewTextBoxColumn lastNameColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "lastNameColumn",
                        HeaderText = "Last Name",
                        DataPropertyName = "LastName"
                    };

                    DataGridViewTextBoxColumn countryColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "countryColumn",
                        HeaderText = "Country",
                        DataPropertyName = "Country"
                    };

                    DataGridViewTextBoxColumn cityColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "cityColumn",
                        HeaderText = "City",
                        DataPropertyName = "City"
                    };

                    DataGridViewTextBoxColumn adressColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "adressColumn",
                        HeaderText = "Adress",
                        DataPropertyName = "Adress"
                    };

                    DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "emailColumn",
                        HeaderText = "Email",
                        DataPropertyName = "Email"
                    };


                    DataGridViewCustomersResults.Columns.Add(customerNumberColumn);
                    DataGridViewCustomersResults.Columns.Add(firstNameColumn);
                    DataGridViewCustomersResults.Columns.Add(lastNameColumn);
                    DataGridViewCustomersResults.Columns.Add(countryColumn);
                    DataGridViewCustomersResults.Columns.Add(cityColumn);
                    DataGridViewCustomersResults.Columns.Add(adressColumn);
                    DataGridViewCustomersResults.Columns.Add(emailColumn);

                    DataGridViewCustomersResults.DataSource = customers;
                }
                else
                {
                    LblDataGridCustomersNoResults.Visible = true;
                }
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Database connection failed. Connection timed out.");
            }
            catch
            {
                MessageBox.Show("An error occured.");
            }
        }

        private Expression<Func<Customer, bool>> CreateFilterFunction()
        {
            /*
            return customer =>
                (string.IsNullOrEmpty(TxtSearchInvoiceNumber.Text) || customer.InvoiceNumber.Contains(TxtSearchInvoiceNumber.Text)) &&
                (string.IsNullOrEmpty(TxtSearchCustomerNumber.Text) || customer.OrderInformations.CustomerDetails.CustomerNumber.Contains(TxtSearchCustomerNumber.Text)) &&
                (string.IsNullOrEmpty(TxtSearchOrderNumber.Text) || customer.OrderInformations.OrderNumber.Contains(TxtSearchOrderNumber.Text)) &&
                (string.IsNullOrEmpty(TxtSearchFirstName.Text) || customer.OrderInformations.CustomerDetails.FirstName.Contains(TxtSearchFirstName.Text)) &&
                (string.IsNullOrEmpty(TxtSearchLastName.Text) || customer.OrderInformations.CustomerDetails.LastName.Contains(TxtSearchLastName.Text)) &&
                (string.IsNullOrEmpty(TxtStreetAddress.Text) || customer.BillingAddress.StreetAddress.Contains(TxtStreetAddress.Text)) &&
                (string.IsNullOrEmpty(TxtSearchZipCode.Text) || customer.BillingAddress.ZipCode.Contains(TxtSearchZipCode.Text)) &&
                (string.IsNullOrEmpty(TxtSearchCountry.Text) || customer.BillingAddress.Country.Contains(TxtSearchCountry.Text)) &&
                (DatPckInvoiceDateFrom.Value == DatPckInvoiceDateFrom.MinDate || customer.OrderInformations.Date >= DatPckInvoiceDateFrom.Value) &&
                (DatPckInvoiceDateTo.Value == DatPckInvoiceDateTo.MaxDate || customer.OrderInformations.Date <= DatPckInvoiceDateTo.Value);
            */

            return null;
        }

        #endregion


        #region Customers

        private void CmdShowAllCustomers_Click(object sender, EventArgs e)
        {
            //Load all Customers into Grid
        }

        private void CmdCreateEmptyCustomer_Click(object sender, EventArgs e)
        {
            //Create Empty Customer
            GrpInformation.Visible = true;
            EmptyFieldsCustomers();
            GenerateNewCustomerNumber();
        }


        private void CmdDeleteSelectedCustomers_Click(object sender, EventArgs e)
        {
            //Throw warning
            if (WarningDeletedObject())
            {
                //delete all selected Objects
            }
        }

        /*-----*/


        private void EmptyFieldsCustomers()
        {
            TxtInputCustomerAdress.Text = string.Empty;
            TxtInputCustomerCity.Text = string.Empty;
            TxtInputCustomerCountry.Text = string.Empty;
            TxtInputCustomerEmail.Text = string.Empty;
            TxtInputCustomerFirstName.Text = string.Empty;
            TxtInputCustomerLastName.Text = string.Empty;
            TxtInputCustomerNumber.Text = string.Empty;
            TxtInputCustomerPassword.Text = string.Empty;
            TxtInputCustomerPostalCode.Text = string.Empty;
            TxtInputCustomerWebsite.Text = string.Empty;
        }

        private void GenerateNewCustomerNumber()
        {
            //Get next Number
            TxtInputCustomerNumber.Text = 3.ToString();
        }

        /*---------------------------------------*/


        private void CmdCreateNewCustomer_Click(object sender, EventArgs e)
        {
            //Check if nessesary Fields contain Content
            //Create new Customer with Inputfields
        }

        private void CmdSaveChangesCustomer_Click(object sender, EventArgs e)
        {
            //Check if nessesary Fields contain Content
            //Check if something changed

            //Throw warning
            if (WarningUpdatedObject())
            {
                //update selected Object with inputfields
            }
        }

        private void CmdDeleteCustomer_Click(object sender, EventArgs e)
        {
            //Throw warning
            if (WarningDeletedObject())
            {
                //delete all selected Customer
            }
        }


        #endregion


        #region Orders


        private void CmdOpenSelectedOrder_Click(object sender, EventArgs e)
        {
            //Check if exactly one Order is selected
            //Chance Form (Order) with selected Ordernumber already searched
        }

        private void CmdCreateNewOrder_Click(object sender, EventArgs e)
        {
            //Change Form (Order) with selected Customer already filled in
            //this.Hide();
            //Program.formOrders.Show();
        }

        private void CmdDeleteSelectedOrders_Click(object sender, EventArgs e)
        {
            //Throw warning
            if (WarningDeletedObject())
            {
                //delete all selected Objects
            }
        }


        #endregion


        private bool WarningDeletedObject()
        {
            DialogResult result = MessageBox.Show("Would you wish to delete all selected Objects?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool WarningUpdatedObject()
        {
            DialogResult result = MessageBox.Show("Would you wish to update the selected Object?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
