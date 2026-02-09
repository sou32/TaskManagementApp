using TaskManagementApp.Domain.Model;
using TaskManagementApp.UseCase;
namespace TaskManagementApp.UI;

public class TaskViewUI: IViewTaskUI
{
    private readonly IViewTaskUseCase _viewTaskUseCase = new ViewTaskUseCase();

    public void ShowTaskList()
    {
        ShowTaskViewMenu();
        ViewTask();
    }
    
    /// <summary>
    /// タスク一覧を表示する
    /// </summary>
    private void ShowTaskViewMenu()
    {
        Console.WriteLine("こちらはタスク一覧です");
    }
    
    private void ViewTask()
    {
       List<TaskModel> taskModels = _viewTaskUseCase.ViewTask();
       taskModels.ForEach(taskModel => Console.WriteLine($"タスクID: {taskModel.Id} " +
                                                         $"タスク名:{taskModel.Name} " +
                                                         $"期日:{taskModel.Deadline} " +
                                                         $"ステータス{taskModel.Status}"));
        
       Console.WriteLine("確認できたら何かキーを押してください");
       Console.ReadLine();
    }
}