using TaskManagementApp.UseCase;

namespace TaskManagementApp.UI;

public sealed class DeleteTaskUI: IDeleteTaskUI
{
    private readonly IDeleteTaskUseCase _deleteTaskUseCase = new DeleteTaskUseCase();
    private readonly IDeleteTaskValidationUseCase _deleteTaskValidationUseCase = new DeleteTaskValidationUseCase();
    
    public void DeleteTask()
    {
        ShowDeleteTaskMenu();
        DeleteTaskFromDb();
    }

    private void ShowDeleteTaskMenu()
    {
        Console.WriteLine("こちらはタスク削除画面です。");
        Console.WriteLine("未実施のタスクのみ選択できます。");
    }
    
    private void DeleteTaskFromDb()
    {
        while (true)
        {
            Console.Write("削除したいタスクNoを入力してください:");
            string delteTaskId = Console.ReadLine() ?? string.Empty;
            if (_deleteTaskValidationUseCase.Validate(delteTaskId))
            {
                int id = int.Parse(delteTaskId);
                _deleteTaskUseCase.DeleteTask(id);
                break;
            }
            Console.WriteLine("数値を入力してください。");
        }
    }
}