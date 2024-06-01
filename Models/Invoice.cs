namespace Lab11MVC.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public virtual Customer Customer { get; set; }
        public DateTime Date { get; set; }
        public string InvoiceNumber { get; set; }
        public decimal Total { get; set; }
    }
}
