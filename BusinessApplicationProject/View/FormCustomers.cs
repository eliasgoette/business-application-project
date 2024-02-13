namespace BusinessApplicationProject
{
    public partial class FormCustomers : Form
    {
        public FormCustomers()
        {
            InitializeComponent();
        }

        #region Navigation
        private void CmdArticles_Click(object sender, EventArgs e)
        {
            FormArticles formArticles = new FormArticles();
            this.Close();
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

    }
}
