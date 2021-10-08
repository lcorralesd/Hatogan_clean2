using Hatogan.AB.UseCases.DTOs.Breeds;
using Hatogan.AB.UseCases.Ports.Breeds.Update;
using Hatogan.IA.Presenters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.IA.Controllers.Breeds
{
    public class UpdateBreedController : BaseApiController
    {
        private readonly IUpdateBreedInputPort _updateBreedInputPort;
        private readonly IUpdateBreedOutputPort _updateBreedOutputPort;

        public UpdateBreedController(IUpdateBreedInputPort updateBreedInputPort, IUpdateBreedOutputPort updateBreedOutputPort)
        {
            _updateBreedInputPort = updateBreedInputPort;
            _updateBreedOutputPort = updateBreedOutputPort;
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBreed(UpdateBreedDTO updateBreedDTO)
        {
            await _updateBreedInputPort.Handle(updateBreedDTO);
            var presenter = ((IPresenter<BreedDTO>)_updateBreedOutputPort).Content;

            return Ok(presenter);
        }
    }
}
