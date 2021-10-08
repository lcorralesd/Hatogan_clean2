using Hatogan.AB.UseCases.DTOs.Breeds;
using Hatogan.AB.UseCases.Ports.Breeds.Update;
using Hatogan.EB.Abstractions.Interfaces;
using Hatogan.EB.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.AB.UseCases.Breeds.Update
{
    public class UpdateBreedInteractor : IUpdateBreedInputPort
    {
        private readonly IEFCoreBreedRepository _breedRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUpdateBreedOutputPort _outputPort;

        public UpdateBreedInteractor(IEFCoreBreedRepository breedRepository, IUnitOfWork unitOfWork, IUpdateBreedOutputPort updateBreedOutputPort)
        {
            _breedRepository = breedRepository;
            _unitOfWork = unitOfWork;
            _outputPort = updateBreedOutputPort;
        }

        public async Task Handle(UpdateBreedDTO updateBreedDTO)
        {
            var breedToUpdate = await _breedRepository.GetById(updateBreedDTO.Id);

            if(breedToUpdate == null)
            {
                throw new GeneralException($"No se encontro el registro con ID: {updateBreedDTO.Id} para actualizar");
            }

            breedToUpdate.Name = updateBreedDTO.Name;

            await _breedRepository.Update(breedToUpdate);
            await _unitOfWork.SaveChangesAsync();

            var breedDto = new BreedDTO { Id = breedToUpdate.Id, Name = breedToUpdate.Name };

            await _outputPort.Handle(breedDto);
        }
    }
}
