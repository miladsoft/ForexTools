using DNTFrameworkCore.ForexToolsWebApi.Application.Tasks;
using DNTFrameworkCore.ForexToolsWebApi.Application.Tasks.Models;
using DNTFrameworkCore.ForexToolsWebApi.Authorization;
using DNTFrameworkCore.Web.API;
using Microsoft.AspNetCore.Mvc;

namespace DNTFrameworkCore.ForexToolsWebApi.Controllers
{
    [Route("api/[controller]")]
    public class
        TasksController : CrudController<ITaskService, int, TaskReadModel, TaskModel, TaskFilteredPagedQueryModel>
    {
        public TasksController(ITaskService service) : base(service)
        {
        }

        protected override string CreatePermissionName => PermissionNames.Tasks_Create;
        protected override string EditPermissionName => PermissionNames.Tasks_Edit;
        protected override string ViewPermissionName => PermissionNames.Tasks_View;
        protected override string DeletePermissionName => PermissionNames.Tasks_Delete;
    }
}