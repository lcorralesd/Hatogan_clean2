using Hatogan.AB.UseCases.Ports.Breeds.Delete;
using Hatogan.EB.Abstractions.Interfaces;
using Hatogan.EB.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.AB.UseCases.Breeds.Delete
{
    public class DeleteBreedInteractor : IDeleteBreedInputPort
    {
        private readonly IEFCoreBreedRepository _breedRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDeleteBreedOutputPort _outputPort;

        public DeleteBreedInteractor(IEFCoreBreedRepository breedRepository, IUnitOfWork unitOfWork, IDeleteBreedOutputPort outputPort)
        {
            _breedRepository = breedRepository;
            _unitOfWork = unitOfWork;
            _outputPort = outputPort;
        }

        public async Task Handle(int id)
        {
            var recordToDelete = await _breedRepository.GetById(id);

            if(recordToDelete == null)
            {
                throw new GeneralException($"No se encontro el registro con Id:{id} para eliminar");
            }

            await _breedRepository.Delete(recordToDelete);
            var response = await _unitOfWork.SaveChangesAsync() > 0;

            await _outputPort.Handle(response);

        }
    }
}
