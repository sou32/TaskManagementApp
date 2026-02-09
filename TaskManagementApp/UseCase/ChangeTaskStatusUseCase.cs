using TaskManagementApp.Infrastructure.Repository;
namespace TaskManagementApp.UseCase;

public class ChangeTaskStatusUseCase: IChangeTaskStatusUseCase
{
    ITaskChangeStatusRepository _taskChangeStatusRepository = new TaskChangeStatusRepository();
    
    public void ChangeTaskStatus(int completedId, int inProgressId)
    {
        _taskChangeStatusRepository.ChangeStatus(completedId, inProgressId);
    }
}