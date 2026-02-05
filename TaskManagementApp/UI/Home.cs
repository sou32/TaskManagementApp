namespace TaskManagementApp.UI;

/// <summary>
/// ホーム画面のUI
/// </summary>
public class Home
{
    /// <summary>
    /// コマンドの最小値
    /// </summary>
    private const int MinCommand = 1;
    
    /// <summary>
    /// コマンドの最大値
    /// </summary>
    private const int MaxCommand = 5;
    
    /// <summary>
    /// タスクアプリのホーム画面の表示とコマンドの入力をする
    /// </summary>
    /// <returns></returns>
    public int ShowStartMessage()
    {
        ShowHomeMessage();
        return ReadCommand();
    }
    
    /// <summary>
    /// ホーム画面のメッセージを表示
    /// </summary>
    private void ShowHomeMessage()
    {
        Console.WriteLine("タスク管理ホーム画面");
        Console.WriteLine("実施したいコマンドの数字を選択してください:");
        Console.WriteLine("1. タスク表示");
        Console.WriteLine("2. タスク追加");
        Console.WriteLine("3. タスク削除");
        Console.WriteLine("4. ステータス変更");
        Console.WriteLine("5. 終了");
    }
    
    /// <summary>
    /// コマンドを読み取る
    /// </summary>
    /// <returns>入力されたコマンド</returns>
    private int ReadCommand()
    {
        while (true)
        {
            Console.Write("実施したいコマンドを選択してください:");
            string input = Console.ReadLine() ?? string.Empty;

            if (ValidCommand(input))
            {
                return int.Parse(input);
            }

            Console.WriteLine("入力が不正です。再度入力してください。");
        }
    }
    
    /// <summary>
    /// コマンドが有効かどうかを判定する
    /// </summary>
    /// <param name="input">入力されたコマンド</param>
    /// <returns>有効か無効か</returns>
    private bool ValidCommand(string input)
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