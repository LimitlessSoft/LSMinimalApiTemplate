using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyProject.Contracts.Entities;
using LSCore.Repository;

namespace MyProject.Repository.EntityMaps;

// Example entity map. Remove it and add your own
public class UserEntityMap : LSCoreEntityMap<UserEntity>
{
    public override Action<EntityTypeBuilder<UserEntity>> Mapper { get; } = builder =>
    {
        builder.Property(x => x.Username)
            .IsRequired();
    };
}