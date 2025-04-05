using System;

namespace Wave.Domain.Entities.Projects;

public class Category : Base
{
    public required string Label { get; set; }
}