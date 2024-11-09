namespace Task_Project.Repository.CRUD_Operations;

public interface IUpdateOp
{
    Task<bool> UpdateTask(Task task);
}