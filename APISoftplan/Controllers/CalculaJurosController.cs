using APISoftplan.Models;
using Microsoft.AspNetCore.Mvc;

namespace APISoftplan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {

        private readonly CalculaJuros _calculaJuros;

        public CalculaJurosController(CalculaJuros calculaJuros)
        {
            _calculaJuros = calculaJuros;
        }

        // GET api/calculajuros
        [HttpGet()]
        public ActionResult<decimal> Calculajuros(decimal valorinicial, int meses)
        {
            //var calculaJuros = new CalculaJuros { ValorInicial = valorInicial, Meses = meses };

            //return _calculaJuros.CalcularjurosCompostos();
            return valorinicial * meses;
        }

    }
}