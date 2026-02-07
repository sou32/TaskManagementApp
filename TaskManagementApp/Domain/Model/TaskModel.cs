namespace TaskManagementApp.Domain.Model;

public class TaskModel
{
    public int Id { get; set; }
    
    public string Name { get; set; } = string.Empty;
    
    public DateTime Deadline { get; set; }
    
    public bool Status { get; set; }
}