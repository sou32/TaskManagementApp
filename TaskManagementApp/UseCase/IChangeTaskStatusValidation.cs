namespace TaskManagementApp.UseCase;

public interface IChangeTaskStatusValidation
{
    bool Validate(string completedId, string inProgressId);
}