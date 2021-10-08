using Hatogan.AB.UseCases.DTOs.Breeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.AB.UseCases.Ports.Breeds.Create
{
    public interface ICreateBreedOutputPort
    {
        Task Handle(BreedDTO breedDto);
    }
}
