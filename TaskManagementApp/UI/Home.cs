namespace TaskManagementApp.UI;
public class Home
{
    public void ShowStartMessage()
    {
        Console.WriteLine("タスク管理ホーム画面");
        Console.WriteLine("実施したいコマンドを選択してください:");
        Console.WriteLine("1. タスク表示");
        Console.WriteLine("2. タスク追加");
        Console.WriteLine("3. タスク削除");
        Console.WriteLine("4. ステータス変更");
        Console.WriteLine("5. 終了");
        Console.Write("実施したいコマンドを選択してください:");
        Console.ReadLine();
    }
}