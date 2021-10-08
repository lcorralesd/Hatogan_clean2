using Hatogan.AB.UseCases.Ports.Animals.Create;
using Hatogan.AB.UseCases.Ports.Animals.Get;
using Hatogan.AB.UseCases.Ports.Breeds.Create;
using Hatogan.AB.UseCases.Ports.Breeds.Delete;
using Hatogan.AB.UseCases.Ports.Breeds.Get;
using Hatogan.AB.UseCases.Ports.Breeds.Update;
using Hatogan.AB.UseCases.Ports.Categories;
using Hatogan.IA.Presenters.Animals;
using Hatogan.IA.Presenters.Breeds;
using Hatogan.IA.Presenters.Categories;
using Microsoft.Extensions.DependencyInjection;

namespace Hatogan.IA.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddHatoganPresenterServices(this IServiceCollection services)
        {
            services.AddScoped<ICreateAnimalOutputPort, CreateAnimalPresenter>();
            services.AddScoped<IGetAllAnimalsOutputPort, GetAllAnimalsPresenter>();

            services.AddScoped<ICreateBreedOutputPort, CreateBreedPresenter>();
            services.AddScoped<IDeleteBreedOutputPort, DeleteBreedPresenter>();
            services.AddScoped<IGetAllBreedsOutputPort, GetAllBreedsPresenter>();
            services.AddScoped<IGetBreedByIdOutputPort, GetBreedByIdPresenter>();
            services.AddScoped<IUpdateBreedOutputPort, UpdateBreedPresenter>();

            services.AddScoped<IGetAllCategoriesOutputPort, GetAllCategoriesPresenter>();
            services.AddScoped<IGetCategoryByIdOutputPort, GetCategoryByIdPresenter>();

            return services;
        }
    }
}
