using Task_Project.Repository.CRUD_Operations;
using Task = Task_Project.Domain.Task;

namespace Task_Project.Repository;

public interface ITaskRepository : ICreateOp<Task>, IReadOp<Task>, IReadAllOp<Task>
{
    Task<List<Task>?> GetAllTasksByStatusAsync(Domain.TaskStatus status);
    Task<List<Task>?> GetAllTasksByPriorityAsync(int priority);
}

