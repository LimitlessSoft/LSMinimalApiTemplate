using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyProject.Contracts.Entities;
using LSCore.Repository;

namespace MyProject.Repository.EntityMaps;

public class UserEntityMap : LSCoreEntityMap<UserEntity>
{
    public override Action<EntityTypeBuilder<UserEntity>> Mapper { get; } = builder =>
    {
        builder.Property(x => x.Username)
            .IsRequired();
    };
}