using Hatogan.AB.UseCases.DTOs.Breeds;
using Hatogan.AB.UseCases.Ports.Breeds;
using Hatogan.AB.UseCases.Ports.Breeds.Create;
using Hatogan.IA.Presenters;
using Microsoft.AspNetCore.Mvc;

namespace Hatogan.IA.Controllers.Breeds
{
    [ApiVersion("1.0")]
    public class CreateBreedController : BaseApiController
    {
        private readonly ICreateBreedInputPort _createBreedInputPort;
        private readonly ICreateBreedOutputPort _createBreedOutputPort;


        public CreateBreedController(ICreateBreedInputPort createBreedInputPort,
            ICreateBreedOutputPort createBreedOutputPort)
        {
            _createBreedInputPort = createBreedInputPort;
            _createBreedOutputPort = createBreedOutputPort;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBreed(CreateBreedDTO breedParams)
        {
            await _createBreedInputPort.Handle(breedParams);

            var presenter = ((IPresenter<BreedDTO>)_createBreedOutputPort).Content;

            return Ok(presenter);
        }
    }
}
