namespace TaskManagementApp.Infrastructure.Repository;

public interface ITaskDeleteRepository
{
    void DeleteTask(int id);
}