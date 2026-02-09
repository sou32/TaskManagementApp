using TaskManagementApp.UseCase;

namespace TaskManagementApp.UI;

public class ChangeTaskStatusUI: IChangeTaskStatusUI
{
    private readonly IChangeTaskStatusUseCase _changeTaskStatusUseCase = new ChangeTaskStatusUseCase();
    private readonly IChangeTaskStatusValidation _changeTaskStatusValidation = new ChangeTaskStatusValidation();
    
    public void ChangeTaskStatus()
    {
        ShowChangeTaskStatusMenu();
        ChangeTaskStatusToDb();
    }
    
    private void ShowChangeTaskStatusMenu()
    {
        Console.WriteLine("タスクのステータス変更画面です。");
        
    }

    private void ChangeTaskStatusToDb()
    {
        while (true)
        {
            Console.WriteLine("まずは、現在進行中のタスクを完了にします。よろしい場合は現在進行中のタスクNoを入力してください");
            string completeTaskId = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("続いて、進行中に変更したいタスクのタスクNoを入力してください");
            string inProgressTaskId = Console.ReadLine() ?? string.Empty;

            if (_changeTaskStatusValidation.Validate(completeTaskId, inProgressTaskId))
            {
                _changeTaskStatusUseCase.ChangeTaskStatus(int.Parse(completeTaskId), int.Parse(inProgressTaskId));
                break;
            }

            Console.WriteLine("数値を入力してください");
        }
        
    }
    
}