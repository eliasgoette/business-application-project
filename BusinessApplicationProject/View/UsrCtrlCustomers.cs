using BusinessApplicationProject.Controller;
using BusinessApplicationProject.Model;
using BusinessApplicationProject.Repository;
using System.Linq.Expressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            CmdSearchCustomers.Enabled = false;
            UpdateSearchResults();
            CmdSearchCustomers.Enabled = true;
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
            TxtSearchCustomerWebsite.Text = string.Empty;
        }
        #endregion

        #region SearchUpdate
        private Controller<Customer> customerController = new Controller<Customer>
        {
            getContext = () => new AppDbContext(),
            getRepository = context => new Repository<Customer>(context)
        };

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
                customers = customerController.Find(filter);

                if (customers.Count > 0)
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

                    DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "emailColumn",
                        HeaderText = "Email Address",
                        DataPropertyName = "Email"
                    };

                    DataGridViewTextBoxColumn websiteColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "websiteColumn",
                        HeaderText = "Website",
                        DataPropertyName = "Website"
                    };

                    DataGridViewCustomersResults.Columns.Add(customerNumberColumn);
                    DataGridViewCustomersResults.Columns.Add(firstNameColumn);
                    DataGridViewCustomersResults.Columns.Add(lastNameColumn);
                    DataGridViewCustomersResults.Columns.Add(emailColumn);
                    DataGridViewCustomersResults.Columns.Add(websiteColumn);

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
            return customer =>
                (string.IsNullOrEmpty(TxtSearchCustomerNumber.Text) || customer.CustomerNumber.Contains(TxtSearchCustomerNumber.Text)) &&
                (string.IsNullOrEmpty(TxtSearchCustomerFirstName.Text) || customer.FirstName.Contains(TxtSearchCustomerFirstName.Text)) &&
                (string.IsNullOrEmpty(TxtSearchCustomerLastName.Text) || customer.LastName.Contains(TxtSearchCustomerLastName.Text)) &&
                (string.IsNullOrEmpty(TxtSearchCustomerCountry.Text) || customer.CustomerAddress.Country.Contains(TxtSearchCustomerCountry.Text)) &&
                (string.IsNullOrEmpty(TxtSearchCustomerCity.Text) || customer.CustomerAddress.City.Contains(TxtSearchCustomerCity.Text)) &&
                (string.IsNullOrEmpty(TxtSearchCustomerAdress.Text) || customer.CustomerAddress.StreetAddress.Contains(TxtSearchCustomerAdress.Text)) &&
                (string.IsNullOrEmpty(TxtSearchCustomerEmail.Text) || (customer.Email != null && customer.Email.Contains(TxtSearchCustomerEmail.Text))) &&
                (string.IsNullOrEmpty(TxtSearchCustomerWebsite.Text) || (customer.Website != null && customer.Website.Contains(TxtSearchCustomerWebsite.Text)));
        }

        #endregion

        #region Customers

        private void CmdShowAllCustomers_Click(object sender, EventArgs e)
        {
            //Load all Customers into Grid
            EmptyFieldsCustomers();
            UpdateSearchResults();
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
