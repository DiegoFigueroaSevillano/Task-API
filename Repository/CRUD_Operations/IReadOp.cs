using Task_Project.Domain;

namespace Task_Project.Repository.CRUD_Operations;

public interface IReadOp<T> where T : IEntity
{
    Task<T?> ReadAsync(Guid id);
}