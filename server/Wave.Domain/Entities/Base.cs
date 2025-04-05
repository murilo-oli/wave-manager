using System;

namespace Wave.Domain.Entities;

public class Base
{
    public long Id { get; set; }
    public User Owner { get; set; }
    public long OwnerId { get; set; }
}
