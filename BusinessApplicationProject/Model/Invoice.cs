using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessApplicationProject.Model
{
    public class Invoice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required string InvoiceNumber { get; set; }
        public DateTime DueDate { get; set; }
        public required Address BillingAddress { get; set; }
        public double Discount { get; set; }
        public double TaxPercentage { get; set; }
        public required PaymentMethod PaymentMethodInformation { get; set; }
        public required PaymentStatus PaymentStatusInformation { get; set; }
        public required Order OrderInformations { get; set; }
    }

    public enum PaymentMethod
    {
        CreditCard,
        PayPal,
        ApplePay,
        SamsungPay,
        BankTransfer
    }

    public enum PaymentStatus
    {
        Pending,
        Paid,
        Cancelled
    }
}