using Hatogan.AB.UseCases.DTOs.Breeds;
using Hatogan.AB.UseCases.Ports.Breeds.Get;

namespace Hatogan.IA.Presenters.Breeds
{
    public class GetAllBreedsPresenter : IPresenter<IEnumerable<BreedDTO>>, IGetAllBreedsOutputPort
    {
        public IEnumerable<BreedDTO> Content { get; private set; } = default!;

        public Task Handle(IEnumerable<BreedDTO> breedsDto)
        {
            Content = breedsDto;
            return Task.CompletedTask;
        }
    }
}
