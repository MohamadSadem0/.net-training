using Microsoft.Extensions.DependencyInjection;
using Restaurant.Infrastructure.Persistence;

namespace Restaurant.Infrastructure.Extensions;

public class ServiceCollectionExtension
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<RestaurantDbContext>(); 
    } 
}