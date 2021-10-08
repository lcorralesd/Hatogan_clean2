using FluentValidation;
using Hatogan.AB.UseCases.Common.Validator;
using Hatogan.AB.UseCases.DTOs.Animals;
using Hatogan.AB.UseCases.Ports.Animals.Create;
using Hatogan.EB.Abstractions.Interfaces;
using Hatogan.EB.Domain.Entities;
using Hatogan.EB.Domain.Enums;
using Hatogan.EB.Domain.Exceptions;
using Hatogan.EB.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.AB.UseCases.Animals.Create
{
    public class CreateAnimalInteractor : ICreateAnimalInputPort
    {
        private readonly IEFCoreAnimalRepository _animalRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICreateAnimalOutputPort _outputPort;
        private readonly IEnumerable<IValidator<CreateAnimalDTO>> _validators;

        public CreateAnimalInteractor(IEFCoreAnimalRepository animalRepository, IUnitOfWork unitOfWork, ICreateAnimalOutputPort outputPort, IEnumerable<IValidator<CreateAnimalDTO>> validators)
        {
            _animalRepository = animalRepository;
            _unitOfWork = unitOfWork;
            _outputPort = outputPort;
            _validators = validators;
        }

        public async Task Handle(CreateAnimalDTO createAnimalDTO)
        {
            await Validator<CreateAnimalDTO>.Validate(createAnimalDTO, _validators);

            var existCode = await _animalRepository.AnyAsync(a => a.Code.Equals(createAnimalDTO.Code));

            if(existCode)
            {
                throw new GeneralException($"Ya existe un registro con el Código: {createAnimalDTO.Code}");
            }

            var animalToCreate = new Animal 
            {
                Code = createAnimalDTO.Code,
                EarTag = createAnimalDTO.EarTag,
                Name = createAnimalDTO.Name,
                Iron = createAnimalDTO.Iron,
                Color = createAnimalDTO.Color,
                Sex = Utils.ParseEnum<Sex>(createAnimalDTO.Sex),
                Status = Utils.ParseEnum<Status>(createAnimalDTO.Status),
                FarmId = createAnimalDTO.FarmId,
                CategoryId = createAnimalDTO.CategoryId,
                BreedId = createAnimalDTO.BreedId,
                BirthDate = createAnimalDTO.BirthDate,
                BirthWeight = createAnimalDTO.BirthWeight,
                AdmissionDate = createAnimalDTO.AdmissionDate,
                IncomeWeight= createAnimalDTO.IncomeWeight,
                ImageUrl = createAnimalDTO.ImageUrl,
                Remark = createAnimalDTO.Remark,
            }; 

            await _animalRepository.Create(animalToCreate);
            await _unitOfWork.SaveChangesAsync();

            var animalDto = new AnimalDTO 
            {
                Id = animalToCreate.Id,
                Code = createAnimalDTO.Code,
                EarTag = createAnimalDTO.EarTag,
                Name = createAnimalDTO.Name,
                Color = createAnimalDTO.Color,
                Sex = createAnimalDTO.Sex,
                Status = createAnimalDTO.Status,
                Farm = createAnimalDTO.FarmId.ToString(),
                Category = createAnimalDTO.CategoryId.ToString(),
                Breed = createAnimalDTO.BreedId.ToString(),
                BirthDate = createAnimalDTO.BirthDate,
                BirthWeight = createAnimalDTO.BirthWeight,
                AdmissionDate = createAnimalDTO.AdmissionDate,
                IncomeWeight = createAnimalDTO.IncomeWeight,
                ImageUrl = createAnimalDTO.ImageUrl,
                Remark = createAnimalDTO.Remark,
            };

            await _outputPort.Handle(animalDto);
        }
    }
}
