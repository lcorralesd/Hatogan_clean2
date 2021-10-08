using FluentValidation;
using Hatogan.AB.UseCases.Animals.Create;
using Hatogan.AB.UseCases.Animals.Get;
using Hatogan.AB.UseCases.Breeds.Create;
using Hatogan.AB.UseCases.Breeds.Delete;
using Hatogan.AB.UseCases.Breeds.Get;
using Hatogan.AB.UseCases.Breeds.Update;
using Hatogan.AB.UseCases.Categories.Get;
using Hatogan.AB.UseCases.Common.Validator.Breeds;
using Hatogan.AB.UseCases.Ports.Animals.Create;
using Hatogan.AB.UseCases.Ports.Animals.Get;
using Hatogan.AB.UseCases.Ports.Breeds;
using Hatogan.AB.UseCases.Ports.Breeds.Delete;
using Hatogan.AB.UseCases.Ports.Breeds.Get;
using Hatogan.AB.UseCases.Ports.Breeds.Update;
using Hatogan.AB.UseCases.Ports.Categories;
using Microsoft.Extensions.DependencyInjection;

namespace Hatogan.AB.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCaseServices(this IServiceCollection services)
        {
            services.AddScoped<ICreateAnimalInputPort, CreateAnimalInteractor>();
            services.AddScoped<IGetAllAnimalsInputPort, GetAllAnimalsInteractor>();

            services.AddScoped<ICreateBreedInputPort, CreateBreedInteractor>();
            services.AddScoped<IDeleteBreedInputPort, DeleteBreedInteractor>();
            services.AddScoped<IGetAllBreedsInputPort, GetAllBreedsInteractor>();
            services.AddScoped<IGetBreedByIdInputPort, GetBreedByIdInteractor>();
            services.AddScoped<IUpdateBreedInputPort, UpdateBreedInteractor>();

            services.AddScoped<IGetAllCategoriesInputPort, GetAllCategoriesInteractor>();
            services.AddScoped<IGetCategoryByIdInputPort, GetCategoryByIdInteractor>();

            services.AddValidatorsFromAssembly(typeof(CreateBreedValidator).Assembly);

            return services;
        }
    }
}
