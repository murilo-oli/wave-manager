using System;

namespace Wave.Domain.Entities.Notes;

public class Note : Base
{
    public required string Title { get; set; }
    public required string Content { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public long? NotebookId { get; set; }
    public Notebook? Notebook { get; set; }

    public void SetDefaultTitle()
    {
        this.Title = $"Orbit-Note-{DateTime.UtcNow:yyyyMMdd-HHmmss}";
    }
}
