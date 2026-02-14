using TaskManagementApp.Domain.Enum;

namespace TaskManagementApp.Domain.Model;

public sealed class TaskModel
{
    public int Id { get; set; }
    
    public string Name { get; set; } = string.Empty;
    
    public DateOnly Deadline { get; set; }
    
    public Status.TaskStatus Status { get; set; }
}