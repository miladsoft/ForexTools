using DNTFrameworkCore.Application.Models;
using DNTFrameworkCore.ForexToolsWebApi.Domain.Tasks;

namespace DNTFrameworkCore.ForexToolsWebApi.Application.Tasks.Models
{
    public class TaskFilteredPagedQueryModel : FilteredPagedQueryModel
    {
        public TaskState? State { get; set; }
    }
}