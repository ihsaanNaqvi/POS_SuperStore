namespace POS.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = "";
        public decimal Price { get; set; } 
        public int Quantity { get; set; }

    }
    public class ProductViewModel
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

    }
}
