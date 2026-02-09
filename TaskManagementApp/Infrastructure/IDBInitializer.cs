using Microsoft.Data.Sqlite;
using TaskManagementApp.Domain.Entity;

namespace TaskManagementApp.Infrastructure;

public interface IDBInitializer
{
    void Initialize();
}