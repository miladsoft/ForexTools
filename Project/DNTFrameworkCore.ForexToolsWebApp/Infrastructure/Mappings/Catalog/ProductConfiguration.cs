using DNTFrameworkCore.ForexToolsWebApp.Domain.Catalog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DNTFrameworkCore.ForexToolsWebApp.Infrastructure.Mappings.Catalog
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Title).IsRequired().HasMaxLength(Product.MaxTitleLength);
        }
    }
}