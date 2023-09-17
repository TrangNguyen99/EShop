using EShop.Application.Common.Interfaces.Persistance;
using EShop.Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace EShop.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IProductRepository, ProductRepository>();

        return services;
    }
}
