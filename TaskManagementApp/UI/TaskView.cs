namespace TaskManagementApp.UI;

public class TaskView
{
    /// <summary>
    /// タスク一覧を表示する
    /// </summary>
    public void ShowTaskList()
    {
        Console.WriteLine("こちらはタスク一覧です");
        Console.WriteLine("現在着手中のタスク");
        // 着手中のタスクを表示する

        Console.WriteLine("未着手のタスク");
        // 未着手のタスクを表示する

        Console.WriteLine("確認できたら何かキーを押してください");
        Console.ReadLine();
    }
}