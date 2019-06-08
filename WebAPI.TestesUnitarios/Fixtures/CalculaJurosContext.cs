using APISoftplan;
using APISoftplan.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net.Http;

namespace WebAPI.TestesUnitarios.Fixtures
{
    public class CalculaJurosContext
    {
        public HttpClient Client { get; set; }

        private TestServer _server;

        private readonly CalculaJuros _calculaJuros;

        public CalculaJurosContext()
        {
            SetupClient();
            _calculaJuros = new CalculaJuros();
        }

        private void SetupClient()
        {
            _server = new TestServer(new WebHostBuilder().UseStartup<Startup>());

            Client = _server.CreateClient();

        }

        public string CalcularjurosCompostos(CalculaJuros calculaJuros)
        {
           return _calculaJuros.CalcularjurosCompostos(calculaJuros);
        }
    }
}
