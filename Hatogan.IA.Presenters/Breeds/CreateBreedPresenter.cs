using Hatogan.AB.UseCases.DTOs.Breeds;
using Hatogan.AB.UseCases.Ports.Breeds.Create;

namespace Hatogan.IA.Presenters.Breeds
{
    public class CreateBreedPresenter : IPresenter<BreedDTO>, ICreateBreedOutputPort
    {
        public BreedDTO Content { get; private set; } = default!;

        public Task Handle(BreedDTO breedDto)
        {
            Content = breedDto;
            return Task.CompletedTask;
        }
    }
}
