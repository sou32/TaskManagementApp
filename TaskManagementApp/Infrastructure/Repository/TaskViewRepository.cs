using TaskManagementApp.Domain.Entity;
using TaskManagementApp.Infrastructure.Record;
namespace TaskManagementApp.Infrastructure.Repository;

public sealed class TaskViewRepository: ITaskViewRepository
{
    public List<TaskEntity> ViewTask()
    {
        using var db = new TaskRecord();
        List<TaskEntity> tasks = db.Tasks.ToList();
        return tasks;
    }
}