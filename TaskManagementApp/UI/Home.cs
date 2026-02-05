namespace TaskManagementApp.UI;

public class Home
{
    private const int MinCommand = 1;
    private const int MaxCommand = 5;
    
    public int ShowStartMessage()
    {
        DisplayMenu();
        return ReadValidCommand();
    }

    private void DisplayMenu()
    {
        Console.WriteLine("タスク管理ホーム画面");
        Console.WriteLine("実施したいコマンドの数字を選択してください:");
        Console.WriteLine("1. タスク表示");
        Console.WriteLine("2. タスク追加");
        Console.WriteLine("3. タスク削除");
        Console.WriteLine("4. ステータス変更");
        Console.WriteLine("5. 終了");
    }

    private int ReadValidCommand()
    {
        while (true)
        {
            Console.Write("実施したいコマンドを選択してください:");
            string? input = Console.ReadLine();

            if (TryParseCommand(input, out int command))
            {
                return command;
            }

            Console.WriteLine("入力が不正です。再度入力してください。");
        }
    }

    private static bool TryParseCommand(string? input, out int command)
    {
        return int.TryParse(input, out command) 
               && command is >= MinCommand and <= MaxCommand;
    }
}