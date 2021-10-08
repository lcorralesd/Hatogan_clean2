using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.AB.UseCases.Ports.Breeds.Delete
{
    public interface IDeleteBreedInputPort
    {
        Task Handle(int id);
    }
}
