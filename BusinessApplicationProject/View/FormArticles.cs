namespace BusinessApplicationProject
{
    public partial class FormArticles : Form
    {
        public FormArticles()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        #region Navigation
        private void CmdArticles_Click(object sender, EventArgs e)
        {

        }

        private void CmdCustomers_Click(object sender, EventArgs e)
        {
            Program.formCustomers.Show();
            this.Hide();

            //Evt. Methode um Fenster zu wechseln
        }

        private void CmdOrders_Click(object sender, EventArgs e)
        {

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
            TxtSearchArticleGroup.Text = string.Empty;
            TxtSearchArticleName.Text = string.Empty;
            TxtSearchArticleNumber.Text = string.Empty;
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
            GrpInformationArticle.Visible = true;
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

    }
}
