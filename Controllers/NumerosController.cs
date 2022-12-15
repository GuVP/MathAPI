using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MathAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NumerosController : ControllerBase
    {
        [HttpGet("EhPar/{numero}")]
        public IActionResult EhPar(int numero)
        {
            object retorno = new
            {
                EhPar = (numero%2 == 0)
            };

            return Ok(retorno);
        }
    }
}