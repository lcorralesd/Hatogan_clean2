using Hatogan.AB.UseCases.DTOs.Categories;
using Hatogan.AB.UseCases.Ports.Categories;
using Hatogan.IA.Presenters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.IA.Controllers.Categories
{
    public class GetCategoryByIdController : BaseApiController
    {
        private readonly IGetCategoryByIdInputPort _inputPort;
        private readonly IGetCategoryByIdOutputPort _outputPort;

        public GetCategoryByIdController(IGetCategoryByIdInputPort inputPort, IGetCategoryByIdOutputPort outputPort)
        {
            _inputPort = inputPort;
            _outputPort = outputPort;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            await _inputPort.Handle(id);
            var presenter = ((IPresenter<CategoryDTO>)_outputPort).Content;
            return Ok(presenter);
        }
    }
}
