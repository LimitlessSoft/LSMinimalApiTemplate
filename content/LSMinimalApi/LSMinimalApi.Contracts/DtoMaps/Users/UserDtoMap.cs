using LSCommerce.Contracts.Entities;
using LSCore.Contracts.Interfaces;
using LSMinimalApi.Contracts.Dtos.Users;

namespace LSMinimalApi.Contracts.DtoMaps.Users;

public class UserDtoMap : ILSCoreDtoMapper<UserEntity, UserDto>
{
    public UserDto ToDto(UserEntity sender) =>
        new ()
        {
            Id = sender.Id,
            Username = sender.Username
        };
}