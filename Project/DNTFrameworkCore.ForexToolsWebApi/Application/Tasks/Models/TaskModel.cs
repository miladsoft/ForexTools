using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DNTFrameworkCore.Application.Models;
using DNTFrameworkCore.Localization;
using DNTFrameworkCore.ForexToolsWebApi.Domain.Tasks;

namespace DNTFrameworkCore.ForexToolsWebApi.Application.Tasks.Models
{
    [LocalizationResource(Name = "SharedResource", Location = "DNTFrameworkCore.ForexToolsWebApi")]
    public class TaskModel : MasterModel, IValidatableObject
    {
        public string Title { get; set; }

        [MaxLength(50, ErrorMessage = "Validation from DataAnnotations")]
        public string Number { get; set; }

        public string Description { get; set; }
        public TaskState State { get; set; } = TaskState.Todo;

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Title == "IValidatableObject")
            {
                yield return new ValidationResult("Validation from IValidatableObject");
            }
        }
    }
}