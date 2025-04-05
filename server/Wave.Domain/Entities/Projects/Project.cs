using System;

namespace Wave.Domain.Entities.Projects;

public class Project : Base
{
    public ICollection<Ticket> Tickets { get; set; } = [];
}
