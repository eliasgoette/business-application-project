using BusinessApplicationProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessApplicationProject.View
{
    public partial class UsrCtrlOrders : UserControl
    {
        public static UsrCtrlOrders instance = new();

        public UsrCtrlOrders()
        {
            InitializeComponent();

        }

        #region Search
        private void CmdSearchCustomers_Click(object sender, EventArgs e)
        {
            //Search Results with not empty filters
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

        /*
        private TemporalController<Article> articleController = new TemporalController<Article>
        {
            getContext = () => new AppDbContext(),
            getRepository = context => new TemporalRepository<Article>(context)
        };

        public void UpdateSearchResults()
        {
            DataGridViewInvoices.AutoGenerateColumns = false;
            LblNoResults.Visible = false;
            DataGridViewInvoices.DataSource = null;
            DataGridViewInvoices.Columns.Clear();

            try
            {
                List<Invoice> invoices = [];
                var filter = CreateFilterFunction();
                invoices = invoiceController.Find(filter);

                if (invoices.Count > 0)
                {
                    DataGridViewTextBoxColumn invoiceNumberColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "invoiceNumberColumn",
                        HeaderText = "Invoice Number",
                        DataPropertyName = "InvoiceNumber"
                    };

                    DataGridViewTextBoxColumn dueDateColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "dueDateColumn",
                        HeaderText = "Due Date",
                        DataPropertyName = "DueDate"
                    };

                    DataGridViewTextBoxColumn paymentStatusColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "paymentStatusColumn",
                        HeaderText = "Payment Status",
                        DataPropertyName = "PaymentStatus"
                    };

                    DataGridViewTextBoxColumn paymentMethodColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "paymentMethodColumn",
                        HeaderText = "Payment Method",
                        DataPropertyName = "PaymentMethod"
                    };

                    DataGridViewTextBoxColumn discountColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "discountColumn",
                        HeaderText = "Discount",
                        DataPropertyName = "Discount"
                    };

                    DataGridViewTextBoxColumn taxPercentageColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "taxPercentageColumn",
                        HeaderText = "Tax Percentage",
                        DataPropertyName = "TaxPercentage"
                    };

                    DataGridViewInvoices.Columns.Add(invoiceNumberColumn);
                    DataGridViewInvoices.Columns.Add(dueDateColumn);
                    DataGridViewInvoices.Columns.Add(paymentStatusColumn);
                    DataGridViewInvoices.Columns.Add(paymentMethodColumn);
                    DataGridViewInvoices.Columns.Add(discountColumn);
                    DataGridViewInvoices.Columns.Add(taxPercentageColumn);

                    DataGridViewInvoices.DataSource = invoices;
                }
                else
                {
                    LblNoResults.Visible = true;
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

        private Expression<Func<Invoice, bool>> CreateFilterFunction()
        {
            return invoice =>
                (string.IsNullOrEmpty(TxtSearchInvoiceNumber.Text) || invoice.InvoiceNumber.Contains(TxtSearchInvoiceNumber.Text)) &&
                (string.IsNullOrEmpty(TxtSearchCustomerNumber.Text) || invoice.OrderInformations.CustomerDetails.CustomerNumber.Contains(TxtSearchCustomerNumber.Text)) &&
                (string.IsNullOrEmpty(TxtSearchOrderNumber.Text) || invoice.OrderInformations.OrderNumber.Contains(TxtSearchOrderNumber.Text)) &&
                (string.IsNullOrEmpty(TxtSearchFirstName.Text) || invoice.OrderInformations.CustomerDetails.FirstName.Contains(TxtSearchFirstName.Text)) &&
                (string.IsNullOrEmpty(TxtSearchLastName.Text) || invoice.OrderInformations.CustomerDetails.LastName.Contains(TxtSearchLastName.Text)) &&
                (string.IsNullOrEmpty(TxtStreetAddress.Text) || invoice.BillingAddress.StreetAddress.Contains(TxtStreetAddress.Text)) &&
                (string.IsNullOrEmpty(TxtSearchZipCode.Text) || invoice.BillingAddress.ZipCode.Contains(TxtSearchZipCode.Text)) &&
                (string.IsNullOrEmpty(TxtSearchCountry.Text) || invoice.BillingAddress.Country.Contains(TxtSearchCountry.Text)) &&
                (DatPckInvoiceDateFrom.Value == DatPckInvoiceDateFrom.MinDate || invoice.OrderInformations.Date >= DatPckInvoiceDateFrom.Value) &&
                (DatPckInvoiceDateTo.Value == DatPckInvoiceDateTo.MaxDate || invoice.OrderInformations.Date <= DatPckInvoiceDateTo.Value);
        }
        */

        #endregion


        #region Orders

        private void CmdShowAllOrders_Click(object sender, EventArgs e)
        {
            //Load all Orders into Grid
        }

        private void CmdEditSelectedOrder_Click(object sender, EventArgs e)
        {
            //Throw warning
            if (WarningUpdatedObject())
            {
                //Load Ordernumber, Customernumber, Firstname, Lastname, Date and Invoice
                //update selected Object with inputfields
            }
        }


        private void CmdDeleteSelectedObject_Click(object sender, EventArgs e)
        {
            //Throw warning
            if (WarningDeletedObject())
            {
                //delete all selected Objects
            }
        }

        private void CmdShowInvoice_Click(object sender, EventArgs e)
        {
            //change Form to Invoice with selected Order
        }

        private void CmdDeleteOrder_Click(object sender, EventArgs e)
        {
            if (WarningDeletedObject())
            {
                //delete all selected Objects
            }
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
            if (WarningDeletedObject())
            {
                //delete all selected Objects
            }
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
                //Throw warning
                if (WarningUpdatedObject())
                {
                    //Change the selected Position with the new values
                }
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
