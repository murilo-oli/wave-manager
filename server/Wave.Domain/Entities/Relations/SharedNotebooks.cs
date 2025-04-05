using System;
using Wave.Domain.Entities.Notes;

namespace Wave.Domain.Entities.Relations;

public class SharedNotebooks : SharedBase
{
    public long NotebookId { get; set; }
    public Notebook Notebook { get; set; }
}
