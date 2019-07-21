using DNTFrameworkCore.ForexToolsWebApp.Domain.Invoices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DNTFrameworkCore.ForexToolsWebApp.Infrastructure.Mappings.Invoices
{
    public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.Property(i => i.Description).HasMaxLength(Invoice.MaxDescriptionLength);
        }
    }
}