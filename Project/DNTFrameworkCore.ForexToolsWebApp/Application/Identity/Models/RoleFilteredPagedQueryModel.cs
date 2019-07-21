using System.Collections.Generic;
using DNTFrameworkCore.Application.Models;

namespace DNTFrameworkCore.ForexToolsWebApp.Application.Identity.Models
{
    public class RoleFilteredPagedQueryModel : FilteredPagedQueryModel
    {
        public IList<string> Permissions { get; set; }
    }
}