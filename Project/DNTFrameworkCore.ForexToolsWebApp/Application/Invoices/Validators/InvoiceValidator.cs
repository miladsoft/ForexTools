using System;
using System.Collections.Generic;
using System.Linq;
using DNTFrameworkCore.EFCore.Context;
using DNTFrameworkCore.ForexToolsWebApp.Application.Invoices.Models;
using DNTFrameworkCore.ForexToolsWebApp.Domain.Invoices;
using DNTFrameworkCore.ForexToolsWebApp.Resources;
using DNTFrameworkCore.Validation;

namespace DNTFrameworkCore.ForexToolsWebApp.Application.Invoices.Validators
{
    public class InvoiceValidator : ModelValidator<InvoiceModel>
    {
        private readonly IUnitOfWork _context;
        private readonly IMessageLocalizer _localizer;
        public InvoiceValidator(IUnitOfWork context, IMessageLocalizer localizer)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _localizer = localizer ?? throw new ArgumentNullException(nameof(localizer));
        }
        public override IEnumerable<ValidationFailure> Validate(InvoiceModel model)
        {
            if (CheckDuplicateNumber(model))
            {
                yield return new ValidationFailure(nameof(InvoiceModel.Number), _localizer["Invoice.Fields.Number.Unique"]);
            }
        }

        private bool CheckDuplicateNumber(InvoiceModel model)
        {
            return _context.Set<Invoice>().Any(p => p.Number == model.Number && p.Id != model.Id);
        }
    }
}