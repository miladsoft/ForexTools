using System.Collections.Generic;
using DNTFrameworkCore.Application.Models;
using DNTFrameworkCore.ForexToolsWebApp.Application.Identity.Models;

namespace DNTFrameworkCore.ForexToolsWebApp.Models.Roles
{
    public class RoleModalViewModel : RoleModel
    {
        public IReadOnlyList<LookupItem> PermissionList { get; set; }
    }
}