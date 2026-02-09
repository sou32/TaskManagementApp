using TaskManagementApp.Domain.Enum;

namespace TaskManagementApp.Domain.Model;

public class TaskModel
{
    public string Name { get; set; } = string.Empty;
    
    public DateOnly Deadline { get; set; }
    
    public Status.TaskStatus Status { get; set; }
}