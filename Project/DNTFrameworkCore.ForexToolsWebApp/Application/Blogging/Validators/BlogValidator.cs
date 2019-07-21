using DNTFrameworkCore.FluentValidation;
using DNTFrameworkCore.ForexToolsWebApp.Application.Blogging.Models;
using DNTFrameworkCore.ForexToolsWebApp.Resources;
using FluentValidation;

namespace DNTFrameworkCore.ForexToolsWebApp.Application.Blogging.Validators
{
    public class BlogValidator : FluentModelValidator<BlogModel>
    {
        public BlogValidator(IMessageLocalizer localizer)
        {
            RuleFor(b => b.Title).NotEmpty()
                .WithMessage(localizer["Blog.Fields.Title.Required"]);
        }
    }
}