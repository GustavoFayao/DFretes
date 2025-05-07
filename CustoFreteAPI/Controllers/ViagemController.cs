using Microsoft.AspNetCore.Mvc;
using CustoFreteAPI.Models;
using CustoFreteAPI.Services;

namespace CustoFreteAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ViagemController : ControllerBase
    {
        private readonly CalculoCombustivelService _service = new();

        [HttpPost("calcular-combustivel")]
        public IActionResult CalcularCombustivel([FromBody] CustoViagemRequest request)
        {
            var resultado = _service.Calcular(request);
            return Ok(resultado);
        }
    }
}
