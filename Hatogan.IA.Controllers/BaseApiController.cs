using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.IA.Controllers
{
    [ApiController]
    [Route("api/v{Version:apiVersion}/[controller]")]
    public class BaseApiController : ControllerBase
    {
    }
}
