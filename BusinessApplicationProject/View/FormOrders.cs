using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessApplicationProject
{
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        #region Navigation
        private void CmdArticles_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.formArticles.Show();
        }

        private void CmdCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.formCustomers.Show();
        }

        private void CmdOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.formOrders.Show();
        }

        private void CmdCloseProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        #endregion


        #region Search
        private void CmdSearchCustomers_Click(object sender, EventArgs e)
        {
            DisplaySearchResults();
        }

        private void CmdResetSearchFilters_Click(object sender, EventArgs e)
        {
            TxtSearchCustomerNumber.Text = string.Empty;
            TxtSearchOrdersCustomerFirstName.Text = string.Empty;
            TxtSearchOrdersCustomerLastName.Text = string.Empty;
        }


        //muss noch verschoben werden in andere Klasse
        private void DisplaySearchResults()
        {

            if (/*searchResults != null*/ true)
            {
                //Search and Visualize all results
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
        }


        private void CmdDeleteSelectedCustomers_Click(object sender, EventArgs e)
        {
            //Delete all selected Customer
        }

        /*-----*/



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

        private void CmdAddNewPosition_Click(object sender, EventArgs e)
        {
            GrpInformationSelectedPosition.Visible = true;

            //create new PositionID


        }

        private void CmdOpenSelectedPosition_Click(object sender, EventArgs e)
        {
            GrpInformationSelectedPosition.Visible = true;
        }
    }
}
