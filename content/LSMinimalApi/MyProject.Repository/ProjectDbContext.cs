using MyProject.Repository.EntityMaps;
using Microsoft.EntityFrameworkCore;
using MyProject.Contracts.Entities;
using LSCore.Repository;

namespace MyProject.Repository;

public class ProjectDbContext (DbContextOptions<ProjectDbContext> options)
    : LSCoreDbContext<ProjectDbContext>(options)
{
    public DbSet<UserEntity> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserEntity>().AddMap(new UserEntityMap());
    }
}