using TaskManagementApp.UseCase;
namespace TaskManagementApp.UI;

public class AddTaskUI: IAddTaskUI
{
    private readonly IAddTaskValidationUseCase _addTaskValidationUseCase = new AddTaskValidationUseCase();
    IAddTaskUseCase addTaskUseCase = new AddTaskUseCase();
    
    /// <summary>
    /// タスク追加処理
    /// </summary>
    public void AddTask()
    {
        ShowAddTaskMenu();
        AddTaskToDb();
    }
    
    /// <summary>
    /// タスク追加画面表示
    /// </summary>
    private void ShowAddTaskMenu()
    {
        Console.WriteLine("こちらはタスク追加画面です。");
        Console.WriteLine("タスクは、タイトルと期日を入力してください。");
    }
    
    /// <summary>
    /// タスクをDBに追加する
    /// </summary>
    private void AddTaskToDb()
    {
        while (true)
        {
            Console.WriteLine("タスク名を入力してください");
            Console.WriteLine("30文字以内でお願いします");
            string taskName = Console.ReadLine()?? string.Empty;
            Console.WriteLine("期日を入力してください");
            Console.WriteLine("YYYY-MM-DDで入力");
            string deadline = Console.ReadLine()?? string.Empty;
            
            DateOnly dateOnly = DateOnly.Parse(deadline);
            if (_addTaskValidationUseCase.Validate(taskName, dateOnly))
            {
                addTaskUseCase.AddTask(taskName, dateOnly);
                break;
            }
            Console.WriteLine("タスク名の文字数または期日に問題があります。再度入力お願いします。");
        }
    }
}