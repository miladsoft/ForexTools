using DNTFrameworkCore.Application.Models;
using DNTFrameworkCore.Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DNTFrameworkCore.ForexToolsWebApp.Application.Person.Models
{
    [LocalizationResource(Name = "SharedResource", Location = "DNTFrameworkCore.ForexToolsWebApp")]
    public class PersonModel : MasterModel, IValidatableObject
    {
        [Required] public string Name { get; set; }

        [MaxLength(50, ErrorMessage = "Maximum length is 50")]
        [Required]
        public string Family { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Name == "Name")
            {
                yield return new ValidationResult("IValidatableObject Message", new[] { nameof(Name) });
            }
        }
    }

}
