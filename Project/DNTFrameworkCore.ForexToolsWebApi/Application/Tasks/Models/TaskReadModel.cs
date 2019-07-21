using DNTFrameworkCore.Application.Models;
using DNTFrameworkCore.ForexToolsWebApi.Domain.Tasks;

namespace DNTFrameworkCore.ForexToolsWebApi.Application.Tasks.Models
{
    public class TaskReadModel : ReadModel
    {
        public string Title { get; set; }
        public string Number { get; set; }
        public TaskState State { get; set; } = TaskState.Todo;
    }
}