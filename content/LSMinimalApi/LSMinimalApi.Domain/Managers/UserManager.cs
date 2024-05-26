using LSMinimalApi.Contracts.Dtos.Users;
using LSMinimalApi.Contracts.IManagers;
using LSCommerce.Contracts.Entities;
using Microsoft.Extensions.Logging;
using LSCore.Contracts.IManagers;
using LSCore.Domain.Extensions;
using LSCore.Domain.Managers;

namespace LSMinimalApi.Domain.Managers;

public class UserManager (ILogger<UserManager> logger, ILSCoreDbContext dbContext)
    : LSCoreManagerBase<UserManager, UserEntity>(logger, dbContext), IUserManager
{
    public List<UserDto> GetUsers() =>
        Queryable()
            .Where(x => x.IsActive)
            .ToDtoList<UserEntity, UserDto>();
}