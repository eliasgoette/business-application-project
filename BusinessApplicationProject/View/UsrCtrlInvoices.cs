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

                    DataGridViewTextBoxColumn customerNumberColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "customerNumberColumn",
                        HeaderText = "Customer Number",
                        DataPropertyName = "OrderInformations.CustomerDetails.CustomerNumber"
                    };

                    DataGridViewInvoices.Columns.Add(invoiceNumberColumn);
                    DataGridViewInvoices.Columns.Add(customerNumberColumn);

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
            ;
        }
    }
}
