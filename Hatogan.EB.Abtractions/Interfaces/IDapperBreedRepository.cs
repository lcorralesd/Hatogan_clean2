using Hatogan.EB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.EB.Abstractions.Interfaces
{
    public interface IDapperBreedRepository
    {
        Task<Breed> GetById(int id);
        Task<Breed> GetByName(string name);
        Task<IEnumerable<Breed>> GetAll();
    }
}
