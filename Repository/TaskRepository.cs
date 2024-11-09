using Task = Task_Project.Domain.Task;

namespace Task_Project.Repository;

public class TaskRepository : ITaskRepository
{
    private readonly List<Task> _tasks = DataBase.AuxDB.Tasks;
    
    public async Task<Task> CreateAsync(Task entity)
    {
        try
        {
            _tasks.Add(entity);

            foreach (var VARIABLE in _tasks)
            {
                Console.WriteLine(VARIABLE.Title);
            }
            
            return entity;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<Task?> ReadAsync(Guid id)
    {
        try
        {
            var task = from element in _tasks
                                    where element.Id == id
                                    select element;
            return task.FirstOrDefault();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<List<Task>> ReadAllAsync()
    {
        try
        {
            return _tasks;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<List<Task>?> GetAllTasksByStatusAsync(Domain.TaskStatus status)
    {
        try
        {
            var tasks = from VAR in _tasks
                                        where VAR.Status == status
                                        select VAR;
            return tasks.ToList();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<List<Task>?> GetAllTasksByPriorityAsync(int priority)
    {
        try
        {
            var task = from e in _tasks where e.Priority == priority select e;
            return task.ToList();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}