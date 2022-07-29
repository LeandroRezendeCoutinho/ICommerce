using ICommerce.Domain.Entities;
using ICommerce.Infra.Data.EntitiesConfiguration;
using Microsoft.EntityFrameworkCore;

namespace ICommerce.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
        }
    }
}
