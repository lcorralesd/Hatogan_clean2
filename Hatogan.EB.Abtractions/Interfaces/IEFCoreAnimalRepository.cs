using Hatogan.EB.Domain.Entities;
using System.Linq.Expressions;

namespace Hatogan.EB.Abstractions.Interfaces
{
    public interface IEFCoreAnimalRepository
    {
        Task Create(Animal animal);
        Task Delete(Animal animal);
        Task Update(Animal animal);

        Task<bool> AnyAsync(Expression<Func<Animal, bool>> criteria);
        Task<IEnumerable<Animal>> GetAll();
        Task<Animal> GetById(Animal id);
    }
}
