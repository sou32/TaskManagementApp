using TaskManagementApp.UseCase;
namespace TaskManagementApp.UI;

/// <summary>
/// ホーム画面のUI
/// </summary>
public class HomeUI: IHomeUI
{
    private readonly IHomeValidationUseCase _homeValidationUseCase = new HomeValidationUseCaseUseCase();
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

            if (_homeValidationUseCase.Validation(input))
            {
                return int.Parse(input);
            }

            Console.WriteLine("入力が不正です。再度入力してください。");
        }
    }
}