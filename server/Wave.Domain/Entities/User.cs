using System;

namespace Wave.Domain.Entities;

public class User
{
    public long Id { get; set; }
    public required string Email { get; set; }
    public required string PasswordHash { get; set; }
    public string? Name { get; set; }
    public string? AvatarPath { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public bool IsActive { get; set; } = false;
    public bool EmailConfirmed { get; set; } = false;
    public void SetDefaultUserName()
    {
        this.Name = ""; //generate default username using random words, numbers and part of email
    }
}
