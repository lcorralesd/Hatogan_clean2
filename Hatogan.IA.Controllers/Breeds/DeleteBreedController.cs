using Hatogan.AB.UseCases.Ports.Breeds.Delete;
using Hatogan.IA.Presenters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.IA.Controllers.Breeds
{
    public class DeleteBreedController : BaseApiController
    {
        private readonly IDeleteBreedInputPort _deleteBreedInputPort;
        private readonly IDeleteBreedOutputPort _deleteBreedOutputPort;

        public DeleteBreedController(IDeleteBreedInputPort deleteBreedInputPort, IDeleteBreedOutputPort deleteBreedOutputPort)
        {
            _deleteBreedInputPort = deleteBreedInputPort;
            _deleteBreedOutputPort = deleteBreedOutputPort;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBreed(int id)
        {
            await _deleteBreedInputPort.Handle(id);

            var presenter = ((IPresenter<string>)_deleteBreedOutputPort).Content;

            return Ok(presenter);
        }
    }
}
