﻿using BusinessApplicationProject.Controller;
using BusinessApplicationProject.Model;
using BusinessApplicationProject.Repository;

namespace BusinessApplicationProject.View
{
    public partial class UsrCtrlInvoices : UserControl
    {
        public static UsrCtrlInvoices instance = new();

        public UsrCtrlInvoices()
        {
            InitializeComponent();
            DatPckInvoiceDateFrom.MaxDate = DateTime.UtcNow.AddYears(1);
            DatPckInvoiceDateTo.MaxDate = DateTime.UtcNow.AddYears(1);
            DatPckInvoiceDateTo.Value = DatPckInvoiceDateTo.MaxDate;
        }

        private Controller<Invoice> invoiceController = new Controller<Invoice>
        {
            getContext = () => new AppDbContext(),
            getRepository = context => new Repository<Invoice>(context)
        };

        public void UpdateSearchResults()
        {
            LblNoResults.Visible = false;
            DataGridViewInvoices.DataSource = null;
            DataGridViewInvoices.Columns.Clear();

            List<Invoice> invoices = new List<Invoice>();

            try
            {
                if (FiltersAreClear()) invoices = invoiceController.GetAll();
                else if (TxtSearchInvoiceNumber.Text != string.Empty)
                {
                    var inv = invoiceController.FindSingle(
                            x => x.InvoiceNumber == TxtSearchInvoiceNumber.Text
                    );

                    if (inv != null)
                    {
                        invoices.Add(inv);
                    }
                    else
                    {
                        LblNoResults.Visible = true;
                    }
                }

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

        private bool FiltersAreClear()
        {
            return
                TxtSearchInvoiceNumber.Text == string.Empty &&
                TxtSearchCustomerNumber.Text == string.Empty &&
                TxtSearchOrderNumber.Text == string.Empty &&
                TxtSearchGrossAmount.Text == string.Empty &&
                TxtSearchNetAmount.Text == string.Empty &&
                TxtSearchFirstName.Text == string.Empty &&
                TxtSearchLastName.Text == string.Empty &&
                TxtStreetAddress.Text == string.Empty &&
                TxtSearchZipCode.Text == string.Empty &&
                TxtSearchCountry.Text == string.Empty &&
                DatPckInvoiceDateFrom.Value == DatPckInvoiceDateFrom.MinDate &&
                DatPckInvoiceDateTo.Value == DatPckInvoiceDateTo.MaxDate;
        }

        private void CmdSearchInvoices_Click(object sender, EventArgs e)
        {
            CmdSearchInvoices.Enabled = false;
            UpdateSearchResults();
            CmdSearchInvoices.Enabled = true;
        }

        private void CmdResetFilters_Click(object sender, EventArgs e)
        {
            TxtSearchInvoiceNumber.Text = string.Empty;
            TxtSearchCustomerNumber.Text = string.Empty;
            TxtSearchOrderNumber.Text = string.Empty;
            TxtSearchGrossAmount.Text = string.Empty;
            TxtSearchNetAmount.Text = string.Empty;
            TxtSearchFirstName.Text = string.Empty;
            TxtSearchLastName.Text = string.Empty;
            TxtStreetAddress.Text = string.Empty;
            TxtSearchZipCode.Text = string.Empty;
            TxtSearchCountry.Text = string.Empty;
            DatPckInvoiceDateFrom.Value = DatPckInvoiceDateFrom.MinDate;
            DatPckInvoiceDateTo.Value = DatPckInvoiceDateTo.MaxDate;
        }

        private void CmdCopyCustomerNumber_Click(object sender, EventArgs e)
        {
            var selection = GetSelectedItem<Invoice>(DataGridViewInvoices);

            if (selection != null)
            {
                string customerNumber = selection.OrderInformations.CustomerDetails.CustomerNumber;
                Clipboard.SetText(customerNumber);
                MessageBox.Show($"{customerNumber} copied to clipboard.");
            }
            else
            {
                MessageBox.Show("No item selected.");
            }
        }

        private void CmdCopyOrderNumber_Click(object sender, EventArgs e)
        {
            var selection = GetSelectedItem<Invoice>(DataGridViewInvoices);

            if (selection != null)
            {
                string orderNumber = selection.OrderInformations.OrderNumber;
                Clipboard.SetText(orderNumber);
                MessageBox.Show($"{orderNumber} copied to clipboard.");
            }
            else
            {
                MessageBox.Show("No item selected.");
            }
        }

        // Could potentially be outsourced into a service class
        private T? GetSelectedItem<T>(DataGridView dataGridView) where T : class?
        {
            if (dataGridView.DataSource != null)
            {
                List<T> dataGridContent = (List<T>)dataGridView.DataSource;

                if (dataGridView.SelectedCells.Count > 0)
                {
                    return dataGridContent[dataGridView.SelectedCells[0].RowIndex];
                }
            }

            return null;
        }
    }
}
