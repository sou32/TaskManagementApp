using Microsoft.EntityFrameworkCore.ChangeTracking;
using TaskManagementApp.Domain.Entity;
using TaskManagementApp.Domain.Model;
using TaskManagementApp.Infrastructure.Repository;
namespace TaskManagementApp.UseCase;

public class ViewTaskUseCase: IViewTaskUseCase
{
    ITaskViewRepository _taskViewRepository = new TaskViewRepository();
    public List<TaskModel> ViewTask()
    {
        List<TaskEntity> taskEntities = _taskViewRepository.ViewTask();
        List<TaskModel> taskModels = taskEntities.Select(taskEntity => new TaskModel
        {
            Id = taskEntity.Id,
            Name = taskEntity.Name,
            Deadline = taskEntity.Deadline,
            Status = taskEntity.Status
        }).ToList();
        return taskModels;
    }
    
}