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
    [ApiVersion("1.0")]
    public  class GetAllBreedsController : BaseApiController
    {
        private readonly IGetAllBreedsInputPort _getAllBreedsInputPort;
        private readonly IGetAllBreedsOutputPort _getAllBreedsOutputPort;
        public GetAllBreedsController(IGetAllBreedsInputPort getAllBreedsInputPort, IGetAllBreedsOutputPort getAllBreedsOutputPort)
        {
            _getAllBreedsInputPort = getAllBreedsInputPort;
            _getAllBreedsOutputPort = getAllBreedsOutputPort;
        }

        [HttpGet]
        
        public async Task<IActionResult> GetBreeds()
        {
            await _getAllBreedsInputPort.Handle();

            var presenter = ((IPresenter<IEnumerable<BreedDTO>>)_getAllBreedsOutputPort).Content;

            return Ok(presenter);
        }
    }
}
