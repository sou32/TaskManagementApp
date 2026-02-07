namespace TaskManagementApp.UseCase;

public class HomeValidation: IHomeValidation
{
    /// <summary>
    /// コマンドの最小値
    /// </summary>
    private const int MinCommand = 1;
    
    /// <summary>
    /// コマンドの最大値
    /// </summary>
    private const int MaxCommand = 5;

    public bool Validation(string input)
    {
        if (input != string.Empty && int.TryParse(input, out int result))
        {
            if (MinCommand <= result && result <= MaxCommand)
            {
                return true;
            }
        }
        return false;
    }
}