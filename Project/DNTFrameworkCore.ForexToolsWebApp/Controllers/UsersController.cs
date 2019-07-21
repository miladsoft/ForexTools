using DNTFrameworkCore.ForexToolsWebApp.Application.Identity;
using DNTFrameworkCore.ForexToolsWebApp.Application.Identity.Models;
using DNTFrameworkCore.ForexToolsWebApp.Authorization;
using DNTFrameworkCore.Web.Mvc;

namespace DNTFrameworkCore.ForexToolsWebApp.Controllers
{
    public class UsersController : CrudController<IUserService, long, UserReadModel, UserModel>
    {
        public UsersController(IUserService service) : base(service)
        {
        }

        protected override string CreatePermissionName => PermissionNames.Users_Create;
        protected override string EditPermissionName => PermissionNames.Users_Edit;
        protected override string ViewPermissionName => PermissionNames.Users_View;
        protected override string DeletePermissionName => PermissionNames.Users_Delete;
        protected override string ViewName => "_User";
    }
}