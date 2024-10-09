namespace project_rem.Models // Adjust the namespace based on your project structure
{
    public class Product
    {
        public int Id { get; set; }  // Primary key
        public string? Name { get; set; }  // Name of the product
        public decimal Price { get; set; }  // Price of the product
    }
}
