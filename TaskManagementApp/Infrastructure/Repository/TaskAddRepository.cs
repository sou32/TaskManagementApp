using TaskManagementApp.Domain.Entity;
using TaskManagementApp.Infrastructure.Record;

namespace TaskManagementApp.Infrastructure.Repository;

public sealed class TaskAddRepository: ITaskAddRepository
{
    /// <summary>
    /// タスク追加
    /// </summary>
    /// <param name="task"></param>
    public void AddTask(TaskEntity task)
    {
        using var db = new TaskRecord();
        db.Add(task);
        db.SaveChanges();
    }
}