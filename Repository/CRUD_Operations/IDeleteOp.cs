using Task_Project.Domain;
using Task = System.Threading.Tasks.Task;

namespace Task_Project.Repository.CRUD_Operations;

public interface IDeleteOp<T> where T : IEntity
{
    Task<bool> DeleteAsync(Guid id);
}