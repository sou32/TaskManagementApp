using TaskManagementApp.Domain.Model;

namespace TaskManagementApp.UseCase;

public interface IViewTaskUseCase
{
    List<TaskModel> ViewTask();
}