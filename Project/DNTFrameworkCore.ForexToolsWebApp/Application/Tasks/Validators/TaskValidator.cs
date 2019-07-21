using System;
using System.Collections.Generic;
using DNTFrameworkCore.ForexToolsWebApp.Application.Tasks.Models;
using DNTFrameworkCore.ForexToolsWebApp.Domain.Tasks;
using DNTFrameworkCore.Validation;

namespace DNTFrameworkCore.ForexToolsWebApp.Application.Tasks.Validators
{
    public class TaskValidator : ModelValidator<TaskModel>
         {
             public override IEnumerable<ValidationFailure> Validate(TaskModel model)
             {
                 if (!Enum.IsDefined(typeof(TaskState), model.State))
                 {
                     yield return new ValidationFailure(nameof(TaskModel.State), "Validation from IModelValidator");
                 }
             }
         }

    // FluentValidation Library can be used 
    // public class TaskFluentValidator : FluentModelValidator<TaskModel>
    //{
    //  public TaskFluentValidator()
    //  {
    //  }
    //}
}