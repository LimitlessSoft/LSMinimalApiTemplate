using LSCore.Contracts.Entities;

namespace LSCommerce.Contracts.Entities;

public class UserEntity : LSCoreEntity
{
    public string Username { get; set; }
    public string Password { get; set; }
}