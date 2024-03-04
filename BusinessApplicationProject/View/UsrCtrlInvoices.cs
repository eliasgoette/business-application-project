using BusinessApplicationProject.Controller;
using BusinessApplicationProject.Model;
using BusinessApplicationProject.Repository;
using System.Linq.Expressions;

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

                    UpdateAdditionalInformations(invoices.FirstOrDefault());
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

        private void DataGridViewInvoices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var i = DataGridViewInvoices.CurrentCell.RowIndex;
            var invoice = ((List<Invoice>)DataGridViewInvoices.DataSource)[i];
            UpdateAdditionalInformations(invoice);
        }

        private void UpdateAdditionalInformations(Invoice invoice)
        {
            UpdateCustomerInformations(invoice.OrderInformations.CustomerDetails);
            UpdateOrderInformations(invoice);
            UpdatePositionInformations(invoice);
        }

        private void UpdateCustomerInformations(Customer customer)
        {
            DataGridViewCustomerInformations.Columns.Clear();
            DataGridViewCustomerInformations.DataSource = null;
            DataGridViewCustomerInformations.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn customerNumberColumn = new DataGridViewTextBoxColumn
            {
                Name = "customerNumberColumn",
                HeaderText = "Customer Number",
                DataPropertyName = "CustomerNumber"
            };

            DataGridViewCustomerInformations.Columns.Add(customerNumberColumn);

            DataGridViewCustomerInformations.DataSource = new List<Customer> { customer };
        }

        private void UpdateOrderInformations(Invoice invoice)
        {
            DataGridViewOrderDetails.Columns.Clear();
            DataGridViewOrderDetails.DataSource = null;
            DataGridViewOrderDetails.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn orderNumberColumn = new DataGridViewTextBoxColumn
            {
                Name = "orderNumberColumn",
                HeaderText = "Order Number",
                DataPropertyName = "OrderNumber"
            };

            DataGridViewTextBoxColumn orderDateColumn = new DataGridViewTextBoxColumn
            {
                Name = "orderDateColumn",
                HeaderText = "Order Date",
                DataPropertyName = "Date"
            };

            DataGridViewTextBoxColumn grossPriceColumn = new DataGridViewTextBoxColumn
            {
                Name = "grossPriceColumn ",
                HeaderText = "Gross Price",
                DataPropertyName = "GrossPrice"
            };

            DataGridViewTextBoxColumn netPriceColumn = new DataGridViewTextBoxColumn
            {
                Name = "netPriceColumn",
                HeaderText = "Net Price",
                DataPropertyName = "NetPrice"
            };

            DataGridViewOrderDetails.Columns.Add(orderNumberColumn);
            DataGridViewOrderDetails.Columns.Add(orderDateColumn);
            DataGridViewOrderDetails.Columns.Add(grossPriceColumn);
            DataGridViewOrderDetails.Columns.Add(netPriceColumn);

            Order order = invoice.OrderInformations;

            double grossPrice = 0;

            foreach (var pos in order.Positions)
            {
                var art = articleController.FindAsOf(order.Date, x => x.Id == pos.ArticleDetails.Id).FirstOrDefault();
                grossPrice += pos.Quantity * art.Price;
            }

            var netPrice = grossPrice * ((100 + invoice.TaxPercentage) / 100);

            var flatOrder = new { 
                order.OrderNumber, 
                order.Date, 
                GrossPrice = grossPrice, 
                NetPrice = netPrice 
            };

            DataGridViewOrderDetails.DataSource = new List<object> { flatOrder };
        }

        private void UpdatePositionInformations(Invoice invoice)
        {
            DataGridViewOrderPositions.Columns.Clear();
            DataGridViewOrderPositions.DataSource = null;
            DataGridViewOrderPositions.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn positionNumberColumn = new DataGridViewTextBoxColumn
            {
                Name = "positionNumberColumn",
                HeaderText = "Position Number",
                DataPropertyName = "PositionNumber"
            };

            DataGridViewTextBoxColumn articleNumberColumn = new DataGridViewTextBoxColumn
            {
                Name = "articleNumberColumn",
                HeaderText = "Article Number",
                DataPropertyName = "ArticleNumber"
            };

            DataGridViewTextBoxColumn articleNameColumn = new DataGridViewTextBoxColumn
            {
                Name = "articleNameColumn",
                HeaderText = "Name",
                DataPropertyName = "ArticleName"
            };

            DataGridViewTextBoxColumn grossPriceColumn = new DataGridViewTextBoxColumn
            {
                Name = "grossPriceColumn",
                HeaderText = "Gross Price",
                DataPropertyName = "GrossPrice"
            };

            DataGridViewOrderPositions.Columns.Add(positionNumberColumn);
            DataGridViewOrderPositions.Columns.Add(articleNumberColumn);
            DataGridViewOrderPositions.Columns.Add(articleNameColumn);
            DataGridViewOrderPositions.Columns.Add(grossPriceColumn);

            Order order = invoice.OrderInformations;

            var flatPositions = new List<object>();

            foreach (var pos in order.Positions)
            {
                var art = articleController.FindAsOf(order.Date, x => x.Id == pos.ArticleDetails.Id).FirstOrDefault();
                var grossPrice = pos.Quantity * art.Price;

                var flatPos = new
                {
                    pos.PositionNumber,
                    art.ArticleNumber,
                    ArticleName = art.Name,
                    GrossPrice = grossPrice
                };

                flatPositions.Add(flatPos);
            }

            DataGridViewOrderPositions.DataSource = flatPositions;
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
