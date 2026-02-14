namespace TaskManagementApp.UseCase;

public sealed class ChangeTaskStatusValidation: IChangeTaskStatusValidation
{
    public bool Validate(string completedId, string inProgressId)
    {
        if (int.TryParse(completedId.ToString(), out int result) && int.TryParse(inProgressId.ToString(), out result))
        {
            return true;
        }
        return false;
    }
}