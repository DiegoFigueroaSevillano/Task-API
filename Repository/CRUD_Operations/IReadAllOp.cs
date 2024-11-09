using Task_Project.Domain;

namespace Task_Project.Repository.CRUD_Operations;

public interface IReadAllOp<T> where T : IEntity
{
    Task<List<T>> ReadAllAsync();
}