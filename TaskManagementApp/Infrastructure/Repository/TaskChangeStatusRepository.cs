using System.Linq;
using TaskManagementApp.Domain.Entity;
using TaskManagementApp.Domain.Enum;
using TaskManagementApp.Infrastructure.Record;

namespace TaskManagementApp.Infrastructure.Repository;

public class TaskChangeStatusRepository: ITaskChangeStatusRepository
{
    public void ChangeStatus(int completedId, int inProgressId)
    {
           using var db = new TaskRecord();
           TaskEntity? completedTask = db.Set<TaskEntity>().Find(completedId);
           TaskEntity? inprogressTask = db.Set<TaskEntity>().Find(inProgressId);

           if (completedTask == null || inprogressTask == null) return;
           
           completedTask.Status = Status.TaskStatus.Completed;
           inprogressTask.Status = Status.TaskStatus.InProgress;
           
           db.Update(completedTask);
           db.Update(inprogressTask);
           
           db.SaveChanges();
    }
}