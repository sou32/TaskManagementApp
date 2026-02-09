using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TaskManagementApp.Domain.Enum;

namespace TaskManagementApp.Domain.Entity;

[Table("Tasks")]
public class TaskEntity
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(30)]
    public string Name { get; set; } = string.Empty;
    
    [Required]
    
    public DateOnly Deadline { get; set; }
    
    [Required]
    public Status.TaskStatus Status { get; set; }
    
}