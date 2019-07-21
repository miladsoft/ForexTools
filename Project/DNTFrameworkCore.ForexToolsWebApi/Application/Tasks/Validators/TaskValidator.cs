using System;
using System.Collections.Generic;
using DNTFrameworkCore.ForexToolsWebApi.Application.Tasks.Models;
using DNTFrameworkCore.ForexToolsWebApi.Domain.Tasks;
using DNTFrameworkCore.Validation;

namespace DNTFrameworkCore.ForexToolsWebApi.Application.Tasks.Validators
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