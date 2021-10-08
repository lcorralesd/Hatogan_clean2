using FluentValidation;
using Hatogan.AB.UseCases.Common.Validator;
using Hatogan.AB.UseCases.DTOs.Breeds;
using Hatogan.AB.UseCases.Ports.Breeds;
using Hatogan.AB.UseCases.Ports.Breeds.Create;
using Hatogan.EB.Abstractions.Interfaces;
using Hatogan.EB.Domain.Entities;
using Hatogan.EB.Domain.Exceptions;

namespace Hatogan.AB.UseCases.Breeds.Create
{
    public class CreateBreedInteractor : ICreateBreedInputPort
    {
        private readonly IEFCoreBreedRepository _breedRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICreateBreedOutputPort _outputPort;
        private readonly IEnumerable<IValidator<CreateBreedDTO>> _validators;

        public CreateBreedInteractor(IEFCoreBreedRepository breedRepository, IUnitOfWork unitOfWork, ICreateBreedOutputPort outputPort,
            IEnumerable<IValidator<CreateBreedDTO>> validators)
        {
            _breedRepository = breedRepository;
            _unitOfWork = unitOfWork;
            _outputPort = outputPort;
            _validators = validators;
        }

        public async Task Handle(CreateBreedDTO createBreedDTO)
        {
            await Validator<CreateBreedDTO>.Validate(createBreedDTO, _validators);

            var existName = await _breedRepository.AnyAsync(b => b.Name == createBreedDTO.Name);

            if (existName)
            {
                throw new GeneralException($"Ya existe un registro con el Nombre: {createBreedDTO.Name}");
            }

            var breed = new Breed { Name = createBreedDTO.Name };

            await _breedRepository.Create(breed);
            await _unitOfWork.SaveChangesAsync();

            var breedDto = new BreedDTO { Id = breed.Id, Name = breed.Name };

            await _outputPort.Handle(breedDto);

        }
    }
}
