using System;
using Wave.Domain.Enums;

namespace Wave.Domain.Entities.Relations;

public class SharedBase
{
    public long Id { get; set; }
    public long UserId { get; set; }
    public User User { get; set; }
    public EPermission Permission { get; set; }
}
