using Hatogan.EB.Abstractions.Interfaces;
using Hatogan.IA.Gateways.EFCore.Contexts;
using Hatogan.IA.Gateways.EFCore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.IA.Gateways.EFCore
{
    public static class DependencyContainer
    {
        public static IServiceCollection ConfigureEFCoreRepositoryServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("Default"),
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).FullName)));

            services.AddScoped<IEFCoreAnimalRepository, EFCoreAnimalRepository>();
            services.AddScoped<IEFCoreBreedRepository, EFCoreBreedRepository>();
            services.AddScoped<IEFCoreCategoryRepository, EFCoreCategoryRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
