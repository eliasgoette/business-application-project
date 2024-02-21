using BusinessApplicationProject.Controller;
using BusinessApplicationProject.Model;
using BusinessApplicationProject.Repository;
using Microsoft.EntityFrameworkCore;

namespace BusinessApplicationProject
{
    public partial class FormCustomers : Form
    {
        private Controller<Customer> customerController = new Controller<Customer>
        {
            getContext = () => new AppDbContext(),
            getRepository = context => new Repository<Customer>(context)
        };

        public FormCustomers()
        {
            InitializeComponent();
        }

        #region Navigation
        private void CmdArticles_Click(object sender, EventArgs e)
        {
            FormArticles formArticles = new FormArticles();
            formArticles.Show(this);
            this.Hide();

            //Evt. Methode um Fenster zu wechseln
        }

        private void CmdCustomers_Click(object sender, EventArgs e)
        {

        }

        private void CmdOrders_Click(object sender, EventArgs e)
        {

        }

        private void CmdCloseProgram_Click(object sender, EventArgs e)
        {
            Close();
        }


        #endregion


        #region Search
        private void CmdSearchCustomers_Click(object sender, EventArgs e)
        {
            DisplaySearchResults();
        }

        private void CmdResetSearchFilters_Click(object sender, EventArgs e)
        {
            TxtSearchCustomerAdress.Text = string.Empty;
            TxtSearchCustomerCity.Text = string.Empty;
            TxtSearchCustomerCountry.Text = string.Empty;
            TxtSearchCustomerEmail.Text = string.Empty;
            TxtSearchCustomerFirstName.Text = string.Empty;
            TxtSearchCustomerLastName.Text = string.Empty;
            TxtSearchCustomerNumber.Text = string.Empty;
        }


        //muss noch verschoben werden in andere Klasse
        private void DisplaySearchResults()
        {
            DataGridViewCustomersResults.DataSource = null;
            DataGridViewCustomersResults.Columns.Clear();

            var searchResults = new List<Customer> { customerController.FindSingle(x => x.Id == 1) };

            if (searchResults.Count > 0)
            {
                DataGridViewTextBoxColumn firstNameColumn = new DataGridViewTextBoxColumn
                {
                    Name = "firstNameColumn",
                    HeaderText = "First Name",
                    DataPropertyName = "firstName"
                };

                DataGridViewTextBoxColumn lastNameColumn = new DataGridViewTextBoxColumn
                {
                    Name = "lastNameColumn",
                    HeaderText = "Last Name",
                    DataPropertyName = "lastName"
                };

                DataGridViewTextBoxColumn CustomerNumberColumn = new DataGridViewTextBoxColumn
                {
                    Name = "customerNumberColumn",
                    HeaderText = "Customer Number",
                    DataPropertyName = "customerNumber"
                };

                DataGridViewCustomersResults.Columns.Add(CustomerNumberColumn);
                DataGridViewCustomersResults.Columns.Add(firstNameColumn);
                DataGridViewCustomersResults.Columns.Add(lastNameColumn);

                DataGridViewCustomersResults.DataSource = searchResults;
            }
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
            //Delete all selected Customer
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
            throw new NotImplementedException();
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
            //Update Customer with Inputfields
        }

        private void CmdDeleteCustomer_Click(object sender, EventArgs e)
        {
            //Throw warning
            //Delete selected Customer
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
            //Delete selected Orders
        }


        #endregion

    }
}
