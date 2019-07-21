using System;
using System.Threading.Tasks;
using DNTFrameworkCore.ForexToolsWebApi.Application.Common;
using DNTFrameworkCore.ForexToolsWebApi.Application.Identity;
using DNTFrameworkCore.ForexToolsWebApi.Application.Identity.Models;
using DNTFrameworkCore.ForexToolsWebApi.Authorization;
using DNTFrameworkCore.Web.API;
using DNTFrameworkCore.Web.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DNTFrameworkCore.ForexToolsWebApi.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : CrudController<IUserService, long, UserReadModel, UserModel>
    {
        private readonly ILookupService _lookupService;

        public UsersController(IUserService service, ILookupService lookupService) : base(service)
        {
            _lookupService = lookupService ?? throw new ArgumentNullException(nameof(lookupService));
        }

        protected override string CreatePermissionName => PermissionNames.Users_Create;
        protected override string EditPermissionName => PermissionNames.Users_Edit;
        protected override string ViewPermissionName => PermissionNames.Users_View;
        protected override string DeletePermissionName => PermissionNames.Users_Delete;

        [HttpGet("[action]")]
        [PermissionAuthorize(PermissionNames.Users_Create, PermissionNames.Users_Edit)]
        public async Task<IActionResult> RoleList()
        {
            var result = await _lookupService.ReadRolesAsync();
            return Ok(result);
        }
    }
}