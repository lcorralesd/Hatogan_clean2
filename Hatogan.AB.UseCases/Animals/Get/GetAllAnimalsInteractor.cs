using Hatogan.AB.UseCases.DTOs.Animals;
using Hatogan.AB.UseCases.Ports.Animals.Get;
using Hatogan.EB.Abstractions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.AB.UseCases.Animals.Get
{
    public class GetAllAnimalsInteractor : IGetAllAnimalsInputPort
    {
        private readonly IEFCoreAnimalRepository _animalRepository;
        private readonly IGetAllAnimalsOutputPort _outputPort;

        public GetAllAnimalsInteractor(IEFCoreAnimalRepository animalRepository, IGetAllAnimalsOutputPort outputPort)
        {
            _animalRepository = animalRepository;
            _outputPort = outputPort;
        }

        public async Task Handle()
        {
            var animals = await _animalRepository.GetAll();
            var animalsDto = new List<AnimalDTO>();

            foreach (var animal in animals)
            {
                animalsDto.Add(new AnimalDTO
                {
                    Id = animal.Id,
                    Code = animal.Code,
                    EarTag = animal.EarTag,
                    Name = animal.Name,
                    Color = animal.Color,
                    Sex = animal.Sex.ToString(),
                    Status = animal.Sex.ToString(),
                    Farm = animal.Farm.Code,
                    Breed = animal.Breed.Name,
                    Category = animal.Category.Name,
                    BirthDate = animal.BirthDate,
                    BirthWeight = animal.BirthWeight,
                    AdmissionDate = animal.AdmissionDate,
                    IncomeWeight = animal.IncomeWeight,
                    ImageUrl = animal.ImageUrl,
                    Remark = animal.Remark,
                });
            }

            await _outputPort.Handle(animalsDto);
        }
    }
}
