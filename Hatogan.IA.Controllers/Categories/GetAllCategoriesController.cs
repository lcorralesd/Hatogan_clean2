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
    public class GetAllCategoriesController : BaseApiController
    {
        private readonly IGetAllCategoriesInputPort _inputPort;
        private readonly IGetAllCategoriesOutputPort _outputPort;

        public GetAllCategoriesController(IGetAllCategoriesInputPort inputPort, IGetAllCategoriesOutputPort outputPort)
        {
            _inputPort = inputPort;
            _outputPort = outputPort;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            await _inputPort.Handle();
            var presenter = ((IPresenter<IEnumerable<CategoryDTO>>)_outputPort).Content;
            return Ok(presenter);
        }

        
    }
}
