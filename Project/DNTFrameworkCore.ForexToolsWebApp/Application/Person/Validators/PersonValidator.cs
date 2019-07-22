using DNTFrameworkCore.FluentValidation;
using DNTFrameworkCore.ForexToolsWebApp.Application.Person.Models;
using DNTFrameworkCore.ForexToolsWebApp.Resources;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNTFrameworkCore.ForexToolsWebApp.Application.Person.Validators
{
    public class PersonValidator : FluentModelValidator<PersonModel>
    {
        public PersonValidator(IMessageLocalizer localizer)
        {
            RuleFor(b => b.Name).NotEmpty()
                .WithMessage(localizer["Person.Fields.Name.Required"]);
        }
    }

}
