using DNTFrameworkCore.Application.Models;
using DNTFrameworkCore.ForexToolsWebApp.Domain.Tasks;

namespace DNTFrameworkCore.ForexToolsWebApp.Application.Tasks.Models
{
    public class TaskFilteredPagedQueryModel : FilteredPagedQueryModel
    {
        public TaskState? State { get; set; }
    }
}