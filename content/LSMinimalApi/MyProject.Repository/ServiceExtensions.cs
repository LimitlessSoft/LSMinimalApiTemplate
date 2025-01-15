using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
namespace MyProject.Repository;

public static class ServiceExtensions
{
    public static void RegisterDatabase(this IServiceCollection serviceCollection, IConfigurationRoot configurationRoot)
    {
        // Inject database context into serviceCollection
        throw new NotImplementedException();
    }
}