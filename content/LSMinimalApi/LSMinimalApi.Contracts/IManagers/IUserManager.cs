using LSMinimalApi.Contracts.Dtos.Users;

namespace LSMinimalApi.Contracts.IManagers;

public interface IUserManager
{
    List<UserDto> GetUsers();
}