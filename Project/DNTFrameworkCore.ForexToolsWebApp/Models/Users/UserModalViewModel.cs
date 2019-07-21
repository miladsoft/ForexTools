using System.Collections.Generic;
using DNTFrameworkCore.Application.Models;
using DNTFrameworkCore.ForexToolsWebApp.Application.Identity.Models;

namespace DNTFrameworkCore.ForexToolsWebApp.Models
{
    // public class UserModalViewModel : UserModel
    // {
    //     public IReadOnlyList<LookupItem<long>> RoleList { get; set; }
    // }

    public class UserModalViewModel
    {
        public UserModel Model { get; set; }
        public IReadOnlyList<LookupItem<long>> Roles { get; set; }
    }
}