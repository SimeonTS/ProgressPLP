namespace ProgressPLP.Data
{
    public class Product
    {
        public Product()
        {
        }

        public int ProductId { get; set; }
        public string ProductName {     get; set; } = string.Empty;
        public int UnitInStock { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime DeliveryOn { get; set; }
        public string ImageFileName { get; set; }
    }
}