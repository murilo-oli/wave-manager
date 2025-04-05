using System;

namespace Wave.Domain.Entities.Notes;

public class Notebook : Base
{
    public ICollection<Note> Notes { get; set; } = [];
}