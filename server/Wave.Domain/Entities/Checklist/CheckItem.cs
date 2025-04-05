using System;

namespace Wave.Domain.Entities.Checklist;

public class CheckItem : Base
{
    public required string Title { get; set; }
    public string? Description { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? DueDate { get; set; }
    public DateTime? ReminderAt { get; set; }
}