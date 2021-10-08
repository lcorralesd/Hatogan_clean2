using Hatogan.AB.UseCases.DTOs.Animals;
using Hatogan.EB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.EB.Abstractions.Interfaces
{
    public interface IDapperAnimalRepository
    {
        Task<Animal> GetById(int id);
        Task<Animal> GetByCode(string code);
        Task<IEnumerable<Animal>> GetAll();
    }
}
