namespace Task_Project.Domain;

public class Task : IEntity
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string? Description { get; set;  }
    public DateTime? DueDate { get; set; }
    public TaskStatus? Status { get; set; }
    public int? Priority { get; set; }
    
    
}