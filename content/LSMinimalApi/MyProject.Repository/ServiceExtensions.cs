using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using MyProject.Contracts.Constants;
using LSCore.Repository;

namespace MyProject.Repository;

public static class ServiceExtensions
{
    public static void RegisterDatabase(this IServiceCollection serviceCollection, IConfigurationRoot configurationRoot)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        serviceCollection.AddEntityFrameworkNpgsql()
            .AddDbContext<ProjectDbContext>((services, options) =>
            {
                options.ConfigureDbContext(configurationRoot, Constants.DbMigrations.MigrationsAssembly)
                    .UseInternalServiceProvider(services);
            });
    }
}