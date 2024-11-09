
using Task_Project.Dto.Task;

namespace Task_Project.Service;

public interface ITaskService
{
    Task<List<Domain.Task>> GetAllTasksAsync();
    Task<Domain.Task> GetTaskByIdAsync(Guid id);
    Task<Domain.Task> CreateTaskAsync(CreateTaskDto task);
    
}