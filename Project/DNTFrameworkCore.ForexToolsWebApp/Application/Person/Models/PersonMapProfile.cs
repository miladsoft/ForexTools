using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNTFrameworkCore.ForexToolsWebApp.Application.Person.Models
{
    public class PersonMapProfile : Profile
    {
        public PersonMapProfile()
        {
            CreateMap<Domain.Person.Person, PersonModel>(MemberList.None)
        .ReverseMap()
        .ForMember(d => d.NormalizedName, m => m.MapFrom(s => s.Name.ToUpperInvariant()));

        }
    }
}
