using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
    
    public DateTime Deadline { get; set; }
    
    [Required]
    public bool Status { get; set; }
    
}