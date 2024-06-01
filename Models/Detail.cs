namespace Lab11MVC.Models
{
    public class Detail
    {
        public int DetailId { get; set; }
        public virtual Product Product { get; set; }
        public virtual Invoice Invoice { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public decimal SubTotal { get; set; }
    }
}
