using TaskStatus = Task_Project.Domain.TaskStatus;

namespace Task_Project.Dto.Task;

public class UpdateTaskDto
{
    public string? Title { get; set; }
    public string? Description { get; set;  }
    public DateTime? DueDate { get; set; }
    public TaskStatus? Status { get; set; }
    public int? Priority { get; set; }

    public Domain.Task UpdateTask(Domain.Task lastLast)
    {
        return new Domain.Task
        {
            Id = lastLast.Id,
            Title = Title ?? lastLast.Title,
            Description = Description ?? lastLast.Description,
            Priority = Priority ?? lastLast.Priority,
            Status = Status ?? lastLast.Status,
            DueDate = DueDate ?? lastLast.DueDate,
        };
    }
}