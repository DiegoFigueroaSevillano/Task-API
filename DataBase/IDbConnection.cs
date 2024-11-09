using Task = Task_Project.Domain.Task;

namespace Task_Project.DataBase;

public interface IDbConnection<T>
{
    Task<T> CreateConnectionAsync();
}