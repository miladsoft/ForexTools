using DNTFrameworkCore.ForexToolsWebApp.Application.Catalog;
using DNTFrameworkCore.ForexToolsWebApp.Application.Catalog.Models;
using DNTFrameworkCore.ForexToolsWebApp.Authorization;
using DNTFrameworkCore.Web.Mvc;

namespace DNTFrameworkCore.ForexToolsWebApp
{
    public class ProductsController : CrudController<IProductService, long, ProductModel>
    {
        public ProductsController(IProductService service) : base(service)
        {
        }

        protected override string CreatePermissionName => PermissionNames.Products_Create;
        protected override string EditPermissionName => PermissionNames.Products_Edit;
        protected override string ViewPermissionName => PermissionNames.Products_View;
        protected override string DeletePermissionName => PermissionNames.Products_Delete;
        protected override string ViewName => "_ProductModal";
    }
}
