using TaskManagementApp.Domain.Entity;
using TaskManagementApp.Domain.Enum;
using TaskManagementApp.Infrastructure.Repository;
using TaskManagementApp.Domain.Model;
namespace TaskManagementApp.UseCase;

public class AddTaskUseCase: IAddTaskUseCase
{
    private readonly IAddTaskValidationUseCase _addTaskValidationUseCase = new AddTaskValidationUseCase();
    
    /// <summary>
    /// タスクを追加する
    /// </summary>
    public void AddTask(string name, string date)
    {
        DateOnly dateOnly = DateOnly.Parse(date);
        if (_addTaskValidationUseCase.Validate(name, dateOnly))
        {
            TaskModel taskModel = new TaskModel
            {
                Name = name,
                Deadline = dateOnly,
                Status = Status.TaskStatus.NotStarted
            };
            TaskEntity taskEntity = new TaskEntity
            {
                Name = taskModel.Name,
                Deadline = taskModel.Deadline,
                Status = taskModel.Status
            };
            
            TaskAddRepository taskAddRepository = new TaskAddRepository();
            taskAddRepository.AddTask(taskEntity);
        }
    }
}