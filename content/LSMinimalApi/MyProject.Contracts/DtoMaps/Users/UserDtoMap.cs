using MyProject.Contracts.Dtos.Users;
using LSCommerce.Contracts.Entities;
using LSCore.Contracts.Interfaces;

namespace MyProject.Contracts.DtoMaps.Users;

public class UserDtoMap : ILSCoreDtoMapper<UserEntity, UserDto>
{
    public UserDto ToDto(UserEntity sender) =>
        new ()
        {
            Id = sender.Id,
            Username = sender.Username
        };
}