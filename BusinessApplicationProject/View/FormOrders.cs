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
            //Search Results with not empty filters
            DisplaySearchResults();
        }

        private void CmdResetSearchFilters_Click(object sender, EventArgs e)
        {
            //Reset Filters
            TxtSearchCustomerNumber.Text = string.Empty;
            TxtSearchCustomerFirstName.Text = string.Empty;
            TxtSearchCustomerLastName.Text = string.Empty;
            TxtSearchOrderPriceFrom.Text = string.Empty;
            TxtSearchOrderPriceTo.Text = string.Empty;
            TxtSearchOrdersPositionNumber.Text = string.Empty;
            DatSearchOrdersFrom.Value = DatSearchOrdersFrom.MinDate;
            DatSearchOrdersUntil.Value = DatSearchOrdersUntil.MaxDate;
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


        #region Orders

        private void CmdShowAllOrders_Click(object sender, EventArgs e)
        {
            //Load all Orders into Grid
        }

        private void CmdEditSelectedOrder_Click(object sender, EventArgs e)
        {
            //Load Ordernumber, Customernumber, Firstname, Lastname, Date and Invoice

        }


        private void CmdDeleteSelectedObject_Click(object sender, EventArgs e)
        {
            //Throw warning
            //Delete selected Orders
        }

        private void CmdShowInvoice_Click(object sender, EventArgs e)
        {
            //change Form to Invoice with selected Order
        }

        private void CmdDeleteOrder_Click(object sender, EventArgs e)
        {
            //Throw warning
            //Delete selected Order
        }


        #endregion


        #region Positions
        private void CmdOpenSelectedPosition_Click(object sender, EventArgs e)
        {
            GrpInformationSelectedPosition.Visible = true;

            //check if only one Position is selected
            //
        }

        private void CmdAddNewPosition_Click(object sender, EventArgs e)
        {
            GrpInformationSelectedPosition.Visible = true;

            //create new PositionID

            //Empty all values
            CmbInputArticle.Select();
            TxtInputOrderPositionArticleQuantity.Text = string.Empty;
        }

        private void CmdDeleteSelectedPositions_Click(object sender, EventArgs e)
        {

        }

        private void CmdSavePositionChanges_Click(object sender, EventArgs e)
        {
            //values to check if valid Inputs
            int number;
            bool isNumeric = int.TryParse(TxtInputOrderPositionArticleQuantity.Text, out number);

            //checks if article is selected
            if (CmbInputArticle.SelectedItem == null)
            {
                //if not send error
                MessageBox.Show("Select a valid Article");

            }
            else if (isNumeric && number >= 1 && number <= 100)
            {
                //Change the selected Position with the new values

            }
            else
            {
                MessageBox.Show("Select a valid Quantity of Articles");
            }
        }

        private void CmdSaveAsNewPosition_Click(object sender, EventArgs e)
        {
            //values to check if valid Inputs
            int number;
            bool isNumeric = int.TryParse(TxtInputOrderPositionArticleQuantity.Text, out number);

            //checks if article is selected
            if (CmbInputArticle.SelectedItem == null)
            {
                //if not send error
                MessageBox.Show("Select a valid Article");

            }
            else if (isNumeric && number >= 1 && number <= 100)
            {
                //Save as new position in selected Order

            }
            else
            {
                MessageBox.Show("Select a valid Quantity of Articles");
            }
        }

        #endregion

    }
}
