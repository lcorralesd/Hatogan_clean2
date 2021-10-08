using Hatogan.EB.Abstractions.Interfaces;
using Hatogan.EB.Domain.Entities;
using Hatogan.IA.Gateways.EFCore.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Hatogan.IA.Gateways.EFCore.Repository
{
    public class EFCoreCategoryRepository : IEFCoreCategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public EFCoreCategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetById(int id)
        {
            return (await _context.Categories.FindAsync(id))!;
        }
    }
}
