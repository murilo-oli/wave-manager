using System;
using Wave.Domain.Entities.Projects;

namespace Wave.Domain.Entities.Relations;

public class SharedProjects : SharedBase
{
    public long ProjectId { get; set; }
    public Project Project { get; set; }
}
