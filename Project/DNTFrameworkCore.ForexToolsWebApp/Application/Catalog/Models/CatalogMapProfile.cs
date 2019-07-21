using AutoMapper;
using DNTFrameworkCore.ForexToolsWebApp.Domain.Catalog;

namespace DNTFrameworkCore.ForexToolsWebApp.Application.Catalog.Models
{
    public class CatalogMapProfile: Profile
    {
        public CatalogMapProfile()
        {
           CreateMap<Product, ProductModel>(MemberList.None)
                .ReverseMap();
        }
    }
}
