using Hatogan.EB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.EB.Abstractions.Interfaces
{
    public interface IEFCoreCategoryRepository
    {
        Task<IEnumerable<Category>> GetAll();
        Task<Category> GetById(int id);
    }
}
