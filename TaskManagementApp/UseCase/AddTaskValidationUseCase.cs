namespace TaskManagementApp.UseCase;

public class AddTaskValidationUseCase: IAddTaskValidationUseCase
{
    /// <summary>                                      
    /// タスク追加のバリデーション                                  
    /// </summary>                                     
    /// <param name="name"></param>                    
    /// <param name="date"></param>                    
    /// <returns></returns>                            
    public bool Validate(string name, DateOnly date)
    {
        DateOnly dateOnly = DateOnly.FromDateTime(DateTime.Now);
        if (name.Length <= 30 && date > dateOnly)
        {
            return true;
        }

        return false;
    }
}