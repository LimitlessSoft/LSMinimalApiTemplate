using MyProject.Repository.EntityMaps;
using Microsoft.EntityFrameworkCore;
using MyProject.Contracts.Entities;
using LSCore.Repository;

namespace MyProject.Repository;

public class ProjectDbContext (DbContextOptions<ProjectDbContext> options)
    : LSCoreDbContext<ProjectDbContext>(options)
{
    // Example DbSet. Remove it and add your own
    public DbSet<UserEntity> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Example entity map. Remove it and add your own
        modelBuilder.Entity<UserEntity>().AddMap(new UserEntityMap());
    }
}