using AutoMapper;
using DNTFrameworkCore.ForexToolsWebApi.Domain.Tasks;
using DNTFrameworkCore.ForexToolsWebApi.Helpers;

namespace DNTFrameworkCore.ForexToolsWebApi.Application.Tasks.Models
{
    public class TasksMapProfile : Profile
    {
        public TasksMapProfile()
        {
            //Required for ModifiedProperties collection of TrackableEntity and Model
            AllowNullCollections = true;

            CreateMap<TaskModel, Task>(MemberList.None)
                .ForMember(d => d.NormalizedTitle, m => m.MapFrom(s => s.Title.NormalizePersianTitle()))
                .ReverseMap();
        }
    }
}