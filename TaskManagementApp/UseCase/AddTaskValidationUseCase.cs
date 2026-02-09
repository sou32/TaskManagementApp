namespace TaskManagementApp.UseCase;

public class AddTaskValidationUseCase : IAddTaskValidationUseCase
{
    /// <summary>
    /// タスク追加のバリデーション
    /// </summary>
    public bool Validate(string name, string date)
    {
        if (string.IsNullOrWhiteSpace(name) || name.Length > 30)
        {
            return false;
        }
        
        if (!DateOnly.TryParse(date, out var deadline))
        {
            return false;
        }
        
        var today = DateOnly.FromDateTime(DateTime.Today);
        if (deadline <= today)
        {
            return false;
        }

        return true;
    }
}