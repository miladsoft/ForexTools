using AutoMapper;
using DNTFrameworkCore.ForexToolsWebApp.Application.Identity.Models;

namespace DNTFrameworkCore.ForexToolsWebApp.Models.Roles
{
    public class RoleMapProfile : Profile
    {
        public RoleMapProfile()
        {
            CreateMap<RoleModel, RoleModalViewModel>(MemberList.None);
        }
    }
}