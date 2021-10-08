using Hatogan.IA.Gateways.EFCore.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Hatogan.IA.Gateways.EFCore
{
    public class ApplicationDbContextFActory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Hatogan;MultipleActiveResultSets=True");

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
