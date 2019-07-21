using AutoMapper;
using DNTFrameworkCore.ForexToolsWebApp.Domain.Tasks;
using DNTFrameworkCore.ForexToolsWebApp.Helpers;

namespace DNTFrameworkCore.ForexToolsWebApp.Application.Tasks.Models
{
    public class TasksMapProfile : Profile
    {
        public TasksMapProfile()
        {
            CreateMap<Task, TaskReadModel>(MemberList.None);
            
            CreateMap<TaskModel, Task>(MemberList.None)
                .ForMember(d => d.NormalizedTitle, m => m.MapFrom(s => s.Title.NormalizePersianTitle()))
                .ReverseMap();
        }
    }
}