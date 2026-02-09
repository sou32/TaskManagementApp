namespace TaskManagementApp.Infrastructure.Repository;

public interface ITaskChangeStatusRepository
{
    void ChangeStatus(int completedId, int inProgressId);
}