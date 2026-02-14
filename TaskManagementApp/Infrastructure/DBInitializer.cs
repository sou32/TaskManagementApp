using TaskManagementApp.Infrastructure.Record;

namespace TaskManagementApp.Infrastructure;

public class DbInitializer : IDbInitializer
{
    public void Initialize()
    {
        using var db = new TaskRecord();
        db.Database.EnsureCreated();
    }
}