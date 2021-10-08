using Hatogan.AB.UseCases.DTOs.Animals;
using Hatogan.AB.UseCases.Ports.Animals.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.IA.Presenters.Animals
{
    public class CreateAnimalPresenter : IPresenter<AnimalDTO>, ICreateAnimalOutputPort
    {
        public AnimalDTO Content { get; private set; } = default!;

        public Task Handle(AnimalDTO animalDTO)
        {
            Content = animalDTO;
            return Task.CompletedTask;
        }
    }
}
