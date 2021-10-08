using Hatogan.AB.UseCases.DTOs.Breeds;
using Hatogan.AB.UseCases.Ports.Breeds.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.IA.Presenters.Breeds
{
    public class UpdateBreedPresenter : IPresenter<BreedDTO>, IUpdateBreedOutputPort
    {
        public BreedDTO Content { get; private set; } = default!;

        public Task Handle(BreedDTO breedDto)
        {
            Content = breedDto;
            return Task.CompletedTask;
        }
    }
}
