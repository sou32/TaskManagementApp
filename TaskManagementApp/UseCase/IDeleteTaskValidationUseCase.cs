namespace TaskManagementApp.UseCase;

public interface IDeleteTaskValidationUseCase
{
    bool Validate(string id);
}