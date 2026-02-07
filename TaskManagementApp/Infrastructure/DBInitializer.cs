using Microsoft.Data.Sqlite;
namespace TaskManagementApp.Infrastructure;

public class DbManager: IDBManager
{
    private readonly string DB_NAME = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "task_management.db");

    public void Initialize()
    {
        using var connection = new SqliteConnection($"Data Source={DB_NAME}");
        connection.Open();
        using var command = connection.CreateCommand();
        command.CommandText = $"CREATE TABLE IF NOT EXISTS Tasks (Id INTEGER PRIMARY KEY AUTOINCREMENT, Title TEXT, DueDate TEXT, Status TEXT)";
        
        command.ExecuteNonQuery();
        
    }
    
    public void Close()
    {
        using var connection = new SqliteConnection($"Data Source={DB_NAME}");
        connection.Close();
    }
    
    
}