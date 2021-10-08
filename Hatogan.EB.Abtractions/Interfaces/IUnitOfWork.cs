using System.Threading;
using System.Threading.Tasks;

namespace Hatogan.EB.Abstractions.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();
    }
}
