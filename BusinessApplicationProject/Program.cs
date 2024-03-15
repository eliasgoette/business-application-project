
namespace BusinessApplicationProject
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Create all UsableForms
            InitializeForms();

            Application.Run(formCustomers);
        }

        public static FormCustomers formCustomers;
        public static FormArticles formArticles;
        public static FormOrders formOrders;

        private static void InitializeForms()
        {
            formCustomers = new FormCustomers();
            formArticles = new FormArticles();
            formOrders = new FormOrders();
        }
    }
}