using Hatogan.EB.Abstractions.Interfaces;
using Hatogan.EB.Domain.Entities;
using Hatogan.IA.Gateways.EFCore.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Hatogan.IA.Gateways.EFCore.Repository
{
    public class EFCoreAnimalRepository : IEFCoreAnimalRepository
    {
        private readonly ApplicationDbContext _context;

        public EFCoreAnimalRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<bool> AnyAsync(Expression<Func<Animal, bool>> criteria)
        {
            return _context.Animals.AnyAsync(criteria);
        }

        public async Task Create(Animal animal)
        {
            await _context.Animals.AddAsync(animal);
        }

        public Task Delete(Animal animal)
        {
            _context.Animals.Remove(animal);
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<Animal>> GetAll()
        {
            return await _context.Animals
                .Include(b => b.Breed)
                .Include(c => c.Category)
                .Include(f => f.Farm)
                .ToListAsync();
        }

        public async Task<Animal> GetById(Animal id)
        {
            return (await _context.Animals
                .Include(b => b.Breed)
                .Include(c => c.Category)
                .Include(f => f.Farm)
                .FirstOrDefaultAsync())!;
        }

        public Task Update(Animal animal)
        {
            _context.Animals.Update(animal);
            return Task.CompletedTask;
        }
    }
}
