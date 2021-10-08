using Hatogan.EB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.EB.Abstractions.Interfaces
{
    public  interface IEFCoreBreedRepository
    {
        Task Create(Breed breed);
        Task Delete(Breed breed);
        Task Update(Breed breed);

        Task<bool> AnyAsync(Expression<Func<Breed, bool>> expression);

        Task<IEnumerable<Breed>> Find(Expression<Func<Breed, bool>> expression);
        Task<IEnumerable<Breed>> GetAll();
        Task<Breed> GetById(int id);

    }
}
