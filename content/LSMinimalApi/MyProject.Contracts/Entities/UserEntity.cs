using LSCore.Contracts.Entities;

namespace MyProject.Contracts.Entities;

public class UserEntity : LSCoreEntity
{
    public string Username { get; set; }
    public string Password { get; set; }
}