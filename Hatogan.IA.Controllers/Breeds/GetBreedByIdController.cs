using Hatogan.AB.UseCases.DTOs.Breeds;
using Hatogan.AB.UseCases.Ports.Breeds.Get;
using Hatogan.IA.Presenters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.IA.Controllers.Breeds
{
    public class GetBreedByIdController : BaseApiController
    {
        private readonly IGetBreedByIdInputPort _inputPort;
        private readonly IGetBreedByIdOutputPort _outputPort;

        public GetBreedByIdController(IGetBreedByIdInputPort inputPort, IGetBreedByIdOutputPort outputPort)
        {
            _inputPort = inputPort;
            _outputPort = outputPort;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBreedById(int id)
        {
            await _inputPort.Handle(id);
            var presenter = ((IPresenter<BreedDTO>)_outputPort).Content;
            return Ok(presenter);
        }
    }
}
