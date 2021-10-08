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
    public class GetCategoryByIdInteractor : IGetCategoryByIdInputPort
    {
        private readonly IDapperBreedRepository _categoryRepository;
        private readonly IGetCategoryByIdOutputPort _outputPort;

        public GetCategoryByIdInteractor(IDapperBreedRepository categoryRepository, IGetCategoryByIdOutputPort outputPort)
        {
            _categoryRepository = categoryRepository;
            _outputPort = outputPort;
        }

        public async Task Handle(int id)
        {
            var category = await _categoryRepository.GetById(id);
            var categoryDto = new CategoryDTO { Id = category.Id, Name = category.Name };

            await _outputPort.Handle(categoryDto);
        }
    }
}
