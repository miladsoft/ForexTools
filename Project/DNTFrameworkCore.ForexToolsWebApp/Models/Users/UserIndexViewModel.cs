using System.Collections.Generic;
using DNTFrameworkCore.Application.Models;

namespace DNTFrameworkCore.ForexToolsWebApp.Models.Users
{
    public class UserIndexViewModel
    {
        public IReadOnlyList<LookupItem<long>> Roles { get; set; }
    }
}