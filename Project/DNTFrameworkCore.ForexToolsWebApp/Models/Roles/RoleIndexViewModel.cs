using System.Collections.Generic;
using DNTFrameworkCore.Application.Models;
using DNTFrameworkCore.ForexToolsWebApp.Application.Identity.Models;

namespace DNTFrameworkCore.ForexToolsWebApp.Models.Roles
{
    public class RoleIndexViewModel : PagedQueryResult<RoleReadModel>
    {
        public IReadOnlyList<LookupItem> Permissions { get; set; }
    }
}