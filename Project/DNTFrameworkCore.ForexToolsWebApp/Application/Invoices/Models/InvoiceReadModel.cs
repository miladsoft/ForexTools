using System;
using DNTFrameworkCore.Application.Models;

namespace DNTFrameworkCore.ForexToolsWebApp.Application.Invoices.Models
{
    public class InvoiceReadModel : ReadModel<long>
    {
        public string Number { get; set; }
        public DateTimeOffset CreationDateTime { get; set; }
    }
}