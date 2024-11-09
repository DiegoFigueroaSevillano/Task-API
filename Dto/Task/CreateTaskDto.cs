using TaskStatus = Task_Project.Domain.TaskStatus;

namespace Task_Project.Dto.Task;

public class CreateTaskDto
{
    public string Title { get; set; }
    public string? Description { get; set;  }
    public DateTime? DueDate { get; set; }
    public TaskStatus? Status { get; set; }
    public int? Priority { get; set; }

    public Domain.Task CreateTask()
    {
        return new Domain.Task
        {
            Id = Guid.NewGuid(),
            Title = Title,
            Description = Description,
            Priority = Priority,
            Status = Status,
            DueDate = DueDate
        };
    }
}