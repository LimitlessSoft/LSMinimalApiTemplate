using LSCore.Repository;
using LSMinimalApi.Contracts.Constants;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LSMinimalApi.Repository;


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