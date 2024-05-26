using LSCommerce.Contracts.Entities;
using LSCore.Repository;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LSMinimalApi.Repository.EntityMaps;

public class UserEntityMap : LSCoreEntityMap<UserEntity>
{
    public override Action<EntityTypeBuilder<UserEntity>> Mapper { get; } = builder =>
    {
        builder.Property(x => x.Username)
            .IsRequired();
    };
}