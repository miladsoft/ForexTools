using DNTFrameworkCore.ForexToolsWebApi.Application.Identity;
using DNTFrameworkCore.ForexToolsWebApi.Application.Identity.Models;
using DNTFrameworkCore.ForexToolsWebApi.Authorization;
using DNTFrameworkCore.Web.API;
using Microsoft.AspNetCore.Mvc;

namespace DNTFrameworkCore.ForexToolsWebApi.Controllers
{
    [Route("api/[controller]")]
    public class RolesController : CrudController<IRoleService, long, RoleReadModel, RoleModel>
    {
        public RolesController(IRoleService service) : base(service)
        {
        }

        protected override string CreatePermissionName => PermissionNames.Roles_Create;
        protected override string EditPermissionName => PermissionNames.Roles_Edit;
        protected override string ViewPermissionName => PermissionNames.Roles_View;
        protected override string DeletePermissionName => PermissionNames.Roles_Delete;
    }
}