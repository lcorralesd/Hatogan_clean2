using Hatogan.AB.UseCases.DTOs.Animals;
using Hatogan.AB.UseCases.Ports.Animals.Get;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.IA.Presenters.Animals
{
    public class GetAllAnimalsPresenter : IPresenter<IEnumerable<AnimalDTO>>, IGetAllAnimalsOutputPort
    {
        public IEnumerable<AnimalDTO> Content { get; private set; } = default!;

        public Task Handle(IEnumerable<AnimalDTO> animalsDTO)
        {
            Content = animalsDTO;
            return Task.CompletedTask;
        }
    }
}
