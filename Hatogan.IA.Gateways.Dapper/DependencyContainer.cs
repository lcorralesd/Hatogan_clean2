using Hatogan.EB.Abstractions.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Hatogan.IA.Gateways.Dapper
{
    public static class DependencyContainer
    {
        public static IServiceCollection ConfigureDapperRepository(this IServiceCollection services)
        {
            services.AddSingleton<DapperContext>();
            services.AddSingleton<IDapperAnimalRepository, DapperAnimalRepository>();
            services.AddScoped<IDapperBreedRepository, DapperBreedRepository>();
            services.AddScoped<IDapperCategoryRepository, DapperCategoryRepository>();

            return services;
        }
    }
}
