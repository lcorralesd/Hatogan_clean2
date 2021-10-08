using Hatogan.AB.UseCases;
using Hatogan.IA.Gateways.Dapper;
using Hatogan.IA.Gateways.EFCore;
using Hatogan.IA.Presenters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Hatogan.IA.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddHatoganServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddUseCaseServices();
            services.ConfigureEFCoreRepositoryServices(configuration);
            services.ConfigureDapperRepository();
            services.AddHatoganPresenterServices();

            return services;
        }
    }
}
