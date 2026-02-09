using Microsoft.Data.Sqlite;

namespace TaskManagementApp.Infrastructure;

public class DBInitializer: IDBInitializer
{
    private readonly string _connectionString =
        $"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "task_management.db")}";

    public void Initialize()
    {
        using var connection = new SqliteConnection(_connectionString);
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText =
            """
            CREATE TABLE IF NOT EXISTS Tasks (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Name TEXT NOT NULL,
                Deadline TEXT,
                Status TEXT NOT NULL
            );
            """;

        command.ExecuteNonQuery();
    }
}