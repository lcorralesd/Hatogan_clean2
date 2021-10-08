using Hatogan.EB.Abstractions.Interfaces;
using Hatogan.EB.Domain.Entities;
using Hatogan.IA.Gateways.EFCore.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Hatogan.IA.Gateways.EFCore.Repository
{
    public class EFCoreBreedRepository : IEFCoreBreedRepository
    {
        private readonly ApplicationDbContext _context;

        public EFCoreBreedRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<bool> AnyAsync(Expression<Func<Breed, bool>> expression)
        {
            return _context.Breeds.AnyAsync(expression);
        }

        public async Task Create(Breed breed)
        {
            await _context.Breeds.AddAsync(breed);
        }

        public Task Delete(Breed breed)
        {
            _context.Breeds.Remove(breed);
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<Breed>> Find(Expression<Func<Breed, bool>> expression)
        {
            return await _context.Breeds.Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<Breed>> GetAll()
        {
            return await _context.Breeds.ToListAsync();
        }

        public async Task<Breed> GetById(int id)
        {
            return (await _context.Breeds.FindAsync(id))!;
        }

        public Task Update(Breed breed)
        {
            _context.Breeds.Update(breed);
            return Task.CompletedTask;
        }
    }
}
