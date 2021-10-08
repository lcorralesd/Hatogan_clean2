using Hatogan.AB.UseCases.DTOs.Animals;
using Hatogan.AB.UseCases.Ports.Animals.Create;
using Hatogan.IA.Presenters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.IA.Controllers.Animals
{
    public class CreateAnimalController : BaseApiController
    {
        private readonly ICreateAnimalInputPort _inputPort;
        private readonly ICreateAnimalOutputPort _outputPort;

        public CreateAnimalController(ICreateAnimalInputPort inputPort, ICreateAnimalOutputPort outputPort)
        {
            _inputPort = inputPort;
            _outputPort = outputPort;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAnimal(CreateAnimalDTO createAnimalDTO)
        {
            await _inputPort.Handle(createAnimalDTO);
            var presenter = ((IPresenter<AnimalDTO>)_outputPort).Content;
            return Ok(presenter);
        }
    }
}
