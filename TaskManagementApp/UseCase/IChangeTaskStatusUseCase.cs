namespace TaskManagementApp.UseCase;

public interface IChangeTaskStatusUseCase
{
    void ChangeTaskStatus(int completedId, int inProgressId);
}