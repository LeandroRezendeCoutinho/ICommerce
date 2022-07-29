using ICommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ICommerce.Infra.Data.EntitiesConfiguration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasOne<Department>()
                .WithMany(x => x.Categories)
                .HasForeignKey(x => x.DepartmentId)
                .IsRequired();
        }
    }
}
