using Task_Project.Dto.Task;
using Task_Project.Repository;
using Task = Task_Project.Domain.Task;

namespace Task_Project.Service;

public class TaskService : ITaskService
{
    private readonly ITaskRepository _repository;

    public TaskService(ITaskRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<List<Task>> GetAllTasksAsync()
    {
        var tasks = await _repository.ReadAllAsync();
        return tasks ?? [];
    }

    public async Task<Task> GetTaskByIdAsync(Guid id)
    {
        var task = await _repository.ReadAsync(id);
        if(task == null) throw new KeyNotFoundException($"Task with ID {id} not found");
        return task;
    }

    public async Task<Task> CreateTaskAsync(CreateTaskDto task)
    {
        var newTask = await _repository.CreateAsync(task.CreateTask());
        return newTask;
    }
}