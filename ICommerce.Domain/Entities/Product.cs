namespace ICommerce.Domain.Entities
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string? Color { get; set; }
        public int? Size { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
