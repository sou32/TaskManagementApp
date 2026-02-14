namespace TaskManagementApp.UseCase;

public sealed class DeleteTaskValidationUseCase:IDeleteTaskValidationUseCase
{
    public bool Validate(string id)
    {
        if (int.TryParse(id, out int result))
        {
            return true;
        }
        return false;
    }
}