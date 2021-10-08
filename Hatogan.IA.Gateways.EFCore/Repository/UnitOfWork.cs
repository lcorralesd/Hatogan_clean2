using Hatogan.EB.Abstractions.Interfaces;
using Hatogan.IA.Gateways.EFCore.Contexts;

namespace Hatogan.IA.Gateways.EFCore.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
