using Hatogan.AB.UseCases.DTOs.Categories;
using Hatogan.AB.UseCases.Ports.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.IA.Presenters.Categories
{
    public class GetAllCategoriesPresenter : IPresenter<IEnumerable<CategoryDTO>>, IGetAllCategoriesOutputPort
    {
        public IEnumerable<CategoryDTO> Content { get; private set; } = default!;

        public Task Handle(IEnumerable<CategoryDTO> categoryDTOs)
        {
            Content = categoryDTOs;
            return Task.CompletedTask;
        }
    }
}
