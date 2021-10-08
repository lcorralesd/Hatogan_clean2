using Hatogan.AB.UseCases.Ports.Breeds.Delete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.IA.Presenters.Breeds
{
    public class DeleteBreedPresenter : IPresenter<string>, IDeleteBreedOutputPort
    {
        public string Content { get; private set; } = default!;


        public Task Handle(bool result)
        {
            Content = $"Se elimino con exito el registro";
            return Task.CompletedTask;
        }
    }
}
