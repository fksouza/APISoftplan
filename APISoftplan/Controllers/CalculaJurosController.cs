using APISoftplan.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;

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
        [HttpGet]
        public ActionResult<string> Calculajuros(decimal valorinicial, int meses)
        {
            try
            {
                if (valorinicial <= 0 && meses <= 0)
                    return NotFound();

                var calculaJuros = new CalculaJuros { ValorInicial = (double)valorinicial, Meses = meses };

                var result = _calculaJuros.CalcularjurosCompostos(calculaJuros);

                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}