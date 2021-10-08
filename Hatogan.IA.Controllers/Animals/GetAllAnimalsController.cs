using Hatogan.AB.UseCases.DTOs.Animals;
using Hatogan.AB.UseCases.Ports.Animals.Get;
using Hatogan.IA.Presenters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.IA.Controllers.Animals
{
    public class GetAllAnimalsController : BaseApiController
    {
        private readonly IGetAllAnimalsInputPort _inputPort;
        private readonly IGetAllAnimalsOutputPort _outputPort;

        public GetAllAnimalsController(IGetAllAnimalsInputPort inputPort, IGetAllAnimalsOutputPort outputPort)
        {
            _inputPort = inputPort;
            _outputPort = outputPort;
        }

        [HttpGet]
        public async Task<IActionResult> GetAnimals()
        {
            await _inputPort.Handle();
            var presenter = ((IPresenter<IEnumerable<AnimalDTO>>)_outputPort).Content;
            return Ok(presenter);
        }
    }
}
