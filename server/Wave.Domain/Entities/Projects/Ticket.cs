using System;
using Wave.Domain.Enums;

namespace Wave.Domain.Entities.Projects;

public class Ticket : Base
{
    public required string Title { get; set; }
    public string? Description { get; set; }
    public ETicketStatus Status { get; private set; } = ETicketStatus.Backlog;
    public ETicketCriticality Criticality { get; set; } = ETicketCriticality.Low;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public DateTime Deadline { get; set; } = DateTime.UtcNow;
    public long ProjectId { get; set; }
    public required Project Project { get; set; }
    public long? CategoryId { get; set; }
    public Category? Category { get; set; }

    public long? ResponsibleId { get; set; }
    public User? Responsible { get; set; }

    public void ChangeStatus(ETicketStatus statusToChange)
    {
        this.Status = (this.Status, statusToChange) switch
        {
            (ETicketStatus.Backlog, ETicketStatus.Planned) => ETicketStatus.Planned,
            (ETicketStatus.Backlog, ETicketStatus.Doing) => ETicketStatus.Doing,
            (ETicketStatus.Doing, ETicketStatus.Completed) => ETicketStatus.Completed,
            (ETicketStatus.Doing, ETicketStatus.Canceled) => ETicketStatus.Canceled,
            (ETicketStatus.Doing, ETicketStatus.Paused) => ETicketStatus.Paused,
            (ETicketStatus.Planned, ETicketStatus.Doing) => ETicketStatus.Doing,
            (ETicketStatus.Planned, ETicketStatus.Backlog) => ETicketStatus.Backlog,
            _ => this.Status
        };
    }
}