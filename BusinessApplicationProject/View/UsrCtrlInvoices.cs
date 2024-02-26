using BusinessApplicationProject.Controller;
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
            InitializeChkListBoxes();
            CmbDateProperty.SelectedIndex = 0;
        }

        private void InitializeChkListBoxes()
        {
            ChkListBoxPaymentMethod.Items.Clear();
            ChkListBoxPaymentMethod.Items.Add(PaymentInformationConstants.PaymentMethods.ApplePay);
            ChkListBoxPaymentMethod.Items.Add(PaymentInformationConstants.PaymentMethods.BankTransfer);
            ChkListBoxPaymentMethod.Items.Add(PaymentInformationConstants.PaymentMethods.CreditCard);
            ChkListBoxPaymentMethod.Items.Add(PaymentInformationConstants.PaymentMethods.PayPal);
            ChkListBoxPaymentMethod.Items.Add(PaymentInformationConstants.PaymentMethods.SamsungPay);

            for (int i = 0; i < ChkListBoxPaymentMethod.Items.Count; i++)
            {
                ChkListBoxPaymentMethod.SetItemChecked(i, true);
            }

            ChkListBoxPaymentStatus.Items.Clear();
            ChkListBoxPaymentStatus.Items.Add(PaymentInformationConstants.PaymentStatuses.Pending);
            ChkListBoxPaymentStatus.Items.Add(PaymentInformationConstants.PaymentStatuses.Paid);
            ChkListBoxPaymentStatus.Items.Add(PaymentInformationConstants.PaymentStatuses.Cancelled);

            for (int i = 0; i < ChkListBoxPaymentStatus.Items.Count; i++)
            {
                ChkListBoxPaymentStatus.SetItemChecked(i, true);
            }
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

            List<Invoice> invoices;

            try
            {
                if (/* Filters clear */ true) invoices = invoiceController.GetAll();

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

                    DataGridViewInvoices.Columns.Add(invoiceNumberColumn);
                    DataGridViewInvoices.Columns.Add(dueDateColumn);
                    DataGridViewInvoices.Columns.Add(paymentStatusColumn);

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

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
