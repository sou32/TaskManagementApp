using TaskManagementApp.Domain.Entity;

namespace TaskManagementApp.Infrastructure.Repository;

public interface ITaskAddRepository
{
    void AddTask(TaskEntity task);
}