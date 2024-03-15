namespace BusinessApplicationProject.View
{
    public partial class UsrCtrlArticles : UserControl
    {
        public static UsrCtrlArticles instance = new();

        public UsrCtrlArticles()
        {
            InitializeComponent();
        }

        #region Search
        private void CmdSearchArticles_Click(object sender, EventArgs e)
        {
            DisplaySearchResults();
        }

        private void CmdResetSearchFilters_Click(object sender, EventArgs e)
        {
            CmbSearchArticleGroup.Select();
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


        #region Articles

        private void CmdShowAllArticles_Click(object sender, EventArgs e)
        {
            //Load all Articles into Treeview
        }

        private void CmdEditSelectedObject_Click(object sender, EventArgs e)
        {
            //Edit selected Object
            GrpInformationArticle.Visible = true;
        }


        private void CmdDeleteSelectedObjects_Click(object sender, EventArgs e)
        {
            //check if Node is selected
            if (TreeViewArticles.SelectedNode == null) { return; }

            //Throw warning
            if (WarningDeletedObject())
            {
                //Delete all selected Objects
                DeleteSelectedObjectsTreeView();
            }
        }

        /*-----*/

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

        private void DeleteSelectedObjectsTreeView()
        {
            TreeNode node = TreeViewArticles.SelectedNode;

            if (node.Parent != null)
            {
                node.Parent.Nodes.Remove(node);
            }
            else
            {
                TreeViewArticles.Nodes.Remove(node);
            }

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
