using DNTFrameworkCore.FluentValidation;
using DNTFrameworkCore.ForexToolsWebApi.Application.Blogging.Models;
using DNTFrameworkCore.ForexToolsWebApi.Resources;
using FluentValidation;

namespace DNTFrameworkCore.ForexToolsWebApi.Application.Blogging.Validators
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