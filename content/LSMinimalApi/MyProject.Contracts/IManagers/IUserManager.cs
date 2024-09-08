using MyProject.Contracts.Dtos.Users;

namespace MyProject.Contracts.IManagers;

public interface IUserManager
{
    List<UserDto> GetUsers();
}