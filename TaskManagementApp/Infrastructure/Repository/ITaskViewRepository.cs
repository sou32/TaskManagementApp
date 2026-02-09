using TaskManagementApp.Domain.Entity;

namespace TaskManagementApp.Infrastructure.Repository;

public interface ITaskViewRepository
{   
    List<TaskEntity> ViewTask();
}