using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessApplicationProject.Model
{
    public class Invoice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string InvoiceNumber { get; set; }
        public DateTime DueDate { get; set; }
        public Address BillingAddress { get; set; }
        public double Discount { get; set; }
        public double TaxPercentage { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
        public double GrossPrice { get; set; }
        public Order OrderInformations { get; set; }
    }
}