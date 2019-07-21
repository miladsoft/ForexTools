using DNTFrameworkCore.ForexToolsWebApi.Application.Blogging;
using DNTFrameworkCore.ForexToolsWebApi.Application.Blogging.Models;
using DNTFrameworkCore.ForexToolsWebApi.Authorization;
using DNTFrameworkCore.Web.API;
using Microsoft.AspNetCore.Mvc;

namespace DNTFrameworkCore.ForexToolsWebApi.Controllers
{
    [Route("api/[controller]")]
    public class BlogsController : CrudController<IBlogService, int, BlogModel>
    {
        public BlogsController(IBlogService service) : base(service)
        {
        }

        protected override string CreatePermissionName => PermissionNames.Blogs_Create;
        protected override string EditPermissionName => PermissionNames.Blogs_Edit;
        protected override string ViewPermissionName => PermissionNames.Blogs_View;
        protected override string DeletePermissionName => PermissionNames.Blogs_Delete;
    }
}