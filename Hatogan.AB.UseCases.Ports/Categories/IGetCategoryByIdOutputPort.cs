using Hatogan.AB.UseCases.DTOs.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.AB.UseCases.Ports.Categories
{
    public interface IGetCategoryByIdOutputPort
    {
        Task Handle(CategoryDTO categoryDTO);
    }
}
