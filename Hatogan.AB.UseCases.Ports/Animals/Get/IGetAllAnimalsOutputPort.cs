using Hatogan.AB.UseCases.DTOs.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.AB.UseCases.Ports.Animals.Get
{
    public interface IGetAllAnimalsOutputPort
    {
        Task Handle(IEnumerable<AnimalDTO> animalsDTO);
    }
}
