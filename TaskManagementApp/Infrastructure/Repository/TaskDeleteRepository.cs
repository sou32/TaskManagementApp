using TaskManagementApp.Domain.Entity;
using TaskManagementApp.Infrastructure.Record;

namespace TaskManagementApp.Infrastructure.Repository;

public class TaskDeleteRepository: ITaskDeleteRepository
{
    public void DeleteTask(int id)
    {
        using var db = new TaskRecord();
        TaskEntity? entity = db.Set<TaskEntity>().Find(id);
        if (entity == null) return;
        db.Remove(entity);
        db.SaveChanges();
    }
}