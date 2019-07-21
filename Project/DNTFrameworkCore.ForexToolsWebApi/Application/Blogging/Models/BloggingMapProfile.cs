﻿using AutoMapper;
using DNTFrameworkCore.ForexToolsWebApi.Domain.Blogging;

namespace DNTFrameworkCore.ForexToolsWebApi.Application.Blogging.Models
{
    public class BloggingMapProfile : Profile
    {
        public BloggingMapProfile()
        {
            //Required for ModifiedProperties collection of TrackableEntity and Model
            AllowNullCollections = true;
            
            CreateMap<Blog, BlogModel>(MemberList.None)
                .ReverseMap()
                .ForMember(d => d.NormalizedTitle, m => m.MapFrom(s => s.Title.ToUpperInvariant()));
        }
    }
}