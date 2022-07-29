namespace ICommerce.Domain.Entities
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
