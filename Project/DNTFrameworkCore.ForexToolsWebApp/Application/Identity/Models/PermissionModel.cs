using DNTFrameworkCore.Application.Models;

namespace DNTFrameworkCore.ForexToolsWebApp.Application.Identity.Models
{
    public class PermissionModel : Model<int>
    {
        public string Name { get; set; }
    }
}