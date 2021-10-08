using Hatogan.AB.UseCases.DTOs.Categories;
using Hatogan.AB.UseCases.Ports.Categories;
using Hatogan.EB.Abstractions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.AB.UseCases.Categories.Get
{
    public class GetAllCategoriesInteractor : IGetAllCategoriesInputPort
    {
        private readonly IDapperCategoryRepository _categoryRepository;
        private readonly IGetAllCategoriesOutputPort _outputPort;

        public GetAllCategoriesInteractor(IDapperCategoryRepository categoryRepository, IGetAllCategoriesOutputPort outputPort)
        {
            _categoryRepository = categoryRepository;
            _outputPort = outputPort;
        }

        public async Task Handle()
        {
            var categories = await _categoryRepository.GetAll();
            var categoriesDto = new List<CategoryDTO>();
            foreach (var category in categories)
            {
                categoriesDto.Add(new CategoryDTO { Id = category.Id, Name = category.Name });
            }

            await _outputPort.Handle(categoriesDto);
        }
    }
}
