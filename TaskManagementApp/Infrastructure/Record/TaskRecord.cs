using TaskManagementApp.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace TaskManagementApp.Infrastructure.Record;

public class TaskRecord : DbContext
{
    private readonly string _dbName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "task_management.db");
    
    public DbSet<TaskEntity> Tasks => Set<TaskEntity>();
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={_dbName}");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TaskEntity>()
            .Property(t => t.Name)
            .IsRequired()
            .HasMaxLength(30);
        
        modelBuilder.Entity<TaskEntity>()
            .Property(t => t.Status)
            .IsRequired();
    }
}
