using LSCommerce.Contracts.Entities;
using LSCore.Repository;
using LSMinimalApi.Repository.EntityMaps;
using Microsoft.EntityFrameworkCore;

namespace LSMinimalApi.Repository;

public class ProjectDbContext (DbContextOptions<ProjectDbContext> options)
    : LSCoreDbContext<ProjectDbContext>(options)
{
    public DbSet<UserEntity> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserEntity>().AddMap(new UserEntityMap());
    }
}