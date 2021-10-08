using Hatogan.AB.UseCases.DTOs.Breeds;
using Hatogan.AB.UseCases.Ports.Breeds.Get;
using Hatogan.EB.Abstractions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.AB.UseCases.Breeds.Get
{
    public class GetAllBreedsInteractor : IGetAllBreedsInputPort
    {
        private readonly IDapperBreedRepository _breedRepository;
        private readonly IGetAllBreedsOutputPort _outputPort;

        public GetAllBreedsInteractor(IDapperBreedRepository breedRepository, IGetAllBreedsOutputPort outputPort)
        {
            _breedRepository = breedRepository;
            _outputPort = outputPort;
        }

        public async Task Handle()
        {
            var breeds = await _breedRepository.GetAll();

            List<BreedDTO> breedsDto = new();
            foreach (var breed in breeds)
            {
                breedsDto.Add(new BreedDTO { Id = breed.Id, Name = breed.Name });
            }

            await _outputPort.Handle(breedsDto); 
        }
    }
}
