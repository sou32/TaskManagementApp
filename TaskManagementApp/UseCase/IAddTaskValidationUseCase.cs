namespace TaskManagementApp.UseCase;

public interface IAddTaskValidationUseCase
{
    bool Validate(string name, DateOnly date);
}