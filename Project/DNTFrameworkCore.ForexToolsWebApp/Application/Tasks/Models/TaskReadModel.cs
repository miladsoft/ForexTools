using DNTFrameworkCore.Application.Models;
using DNTFrameworkCore.ForexToolsWebApp.Domain.Tasks;

namespace DNTFrameworkCore.ForexToolsWebApp.Application.Tasks.Models
{
    public class TaskReadModel : ReadModel
    {
        public string Title { get; set; }
        public string Number { get; set; }
        public TaskState State { get; set; } = TaskState.Todo;
    }
}