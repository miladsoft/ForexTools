using System;
using System.Collections.Generic;
using System.Linq;
using DNTFrameworkCore.EFCore.Context;
using DNTFrameworkCore.ForexToolsWebApp.Application.Catalog.Models;
using DNTFrameworkCore.ForexToolsWebApp.Domain.Catalog;
using DNTFrameworkCore.ForexToolsWebApp.Resources;
using DNTFrameworkCore.Validation;

namespace DNTFrameworkCore.ForexToolsWebApp.Application.Catalog.Validators
{
    public class ProductValidator : ModelValidator<ProductModel>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMessageLocalizer _localizer;

        public ProductValidator(IUnitOfWork uow, IMessageLocalizer localizer)
        {
            _uow = uow ?? throw new ArgumentNullException(nameof(uow));
            _localizer = localizer ?? throw new ArgumentNullException(nameof(localizer));
        }
        
        public override IEnumerable<ValidationFailure> Validate(ProductModel model)
        {
            if (!IsUniqueNumber(model))
            {
                yield return new ValidationFailure(nameof(ProductModel.Number), _localizer["Product.Fields.Number.Unique"]);
            }
        }

        private bool IsUniqueNumber(ProductModel model)
        {
            return _uow.Set<Product>().Any(p => p.Number == model.Number && p.Id != model.Id);
        }
    }
}