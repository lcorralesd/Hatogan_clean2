using Hatogan.AB.UseCases.DTOs.Breeds;
using Hatogan.AB.UseCases.Ports.Breeds.Get;
using Hatogan.EB.Abstractions.Interfaces;
using Hatogan.EB.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.AB.UseCases.Breeds.Get
{
    public class GetBreedByIdInteractor : IGetBreedByIdInputPort
    {
        private readonly IDapperBreedRepository _breedRepository;
        private readonly IGetBreedByIdOutputPort _outputPort;

        public GetBreedByIdInteractor(IDapperBreedRepository breedRepository, IGetBreedByIdOutputPort outputPort)
        {
            _breedRepository = breedRepository;
            _outputPort = outputPort;
        }

        public async Task Handle(int id)
        {
            var breed = await _breedRepository.GetById(id);

            if(breed == null)
            {
                throw new GeneralException($"No se encontro el registro con Id: {id}");
            }

            var breedDto = new BreedDTO { Id = breed.Id, Name = breed.Name };

            await _outputPort.Handle(breedDto);
        }
    }
}
