using Task = Task_Project.Domain.Task;
using TaskStatus = Task_Project.Domain.TaskStatus;

namespace Task_Project.DataBase;

public class AuxDB
{
    public static List<Domain.Task> Tasks = new List<Domain.Task>
    {
        new Task
        {
            Id = new Guid("74177344-4b3d-4f1f-b1b9-f346bafa7d9b"),
            Title = "Tarea de fisica",
            Description = "Resolver del ejercicio 1 al 5",
            Priority = 1,
            Status = TaskStatus.TO_DO,
            DueDate = DateTime.Now,
        },
        new Task
        {
            Id = new Guid("d1f953b4-979e-404a-a62d-dd8916f198dc"),
            Title = "Tarea de biologia",
            Description = "Task 2 description",
            Priority = 2,
            Status = TaskStatus.IN_PROGRESS,
            DueDate = DateTime.Now,
        },
        new Task
        {
            Id = new Guid("54e17cc4-fac3-4d25-ad98-76b92620552e"),
            Title = "Tarea de artes",
            Description = "Task 3 description",
            Priority = 3,
            Status = TaskStatus.IN_PROGRESS,
            DueDate = DateTime.Now,
        },
        new Task
        {
            Id = new Guid("1dabd41e-128a-4629-a3a9-6d960915448d"),
            Title = "Tarea de quimica",
            Description = "Task 4 description",
            Priority = 1,
            Status = TaskStatus.COMPLETE,
            DueDate = DateTime.Now,
        },
        new Task
        {
            Id = new Guid("ad3709b3-c851-4dfe-85e9-c80a86625401"),
            Title = "Tarea de matematicas",
            Description = "Task 5 description",
            Priority = 1,
            Status = TaskStatus.COMPLETE,
            DueDate = DateTime.Now,
        },
    };
}