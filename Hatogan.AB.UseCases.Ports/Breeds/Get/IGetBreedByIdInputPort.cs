using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.AB.UseCases.Ports.Breeds.Get
{
    public interface IGetBreedByIdInputPort
    {
        Task Handle(int id);
    }
}
