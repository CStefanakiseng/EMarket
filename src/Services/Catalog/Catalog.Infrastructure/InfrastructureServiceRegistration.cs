using Catalog.Application.Interfaces.Repositories;
using Catalog.Infrastructure.Contexts;
using Catalog.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICatalogContext, CatalogContext>();
            services.AddScoped<IBrandRepository, CatalogRepository>();
            services.AddScoped<ITypeRepository, CatalogRepository>();
            services.AddScoped<IProductRepository, CatalogRepository>();
            return services;
        }
    }
}