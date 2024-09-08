using MyProject.Contracts.Dtos.Users;
using MyProject.Contracts.IManagers;
using MyProject.Contracts.Entities;
using Microsoft.Extensions.Logging;
using LSCore.Contracts.IManagers;
using LSCore.Domain.Extensions;
using LSCore.Domain.Managers;

namespace MyProject.Domain.Managers;

public class UserManager (ILogger<UserManager> logger, ILSCoreDbContext dbContext)
    : LSCoreManagerBase<UserManager, UserEntity>(logger, dbContext), IUserManager
{
    public List<UserDto> GetUsers() =>
        Queryable()
            .Where(x => x.IsActive)
            .ToDtoList<UserEntity, UserDto>();
}