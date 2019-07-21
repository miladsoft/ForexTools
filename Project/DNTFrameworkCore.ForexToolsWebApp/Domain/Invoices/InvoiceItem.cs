using DNTFrameworkCore.Domain;
using DNTFrameworkCore.ForexToolsWebApp.Domain.Catalog;

namespace DNTFrameworkCore.ForexToolsWebApp.Domain.Invoices
{
    public class InvoiceItem : TrackableEntity<long>
    {
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitDiscount { get; set; }

        public long ProductId { get; set; }
        public Product Product { get; set; }
        public long InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
    }
}