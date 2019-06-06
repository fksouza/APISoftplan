using APISoftplan;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net.Http;

namespace WebAPI.TestesUnitarios.Fixtures
{
    public class CalculaJurosContext
    {
        public HttpClient Client { get; set; }

        private TestServer _server;

        public CalculaJurosContext()
        {
            SetupClient();
        }

        private void SetupClient()
        {
            _server = new TestServer(new WebHostBuilder().UseStartup<Startup>());

            Client = _server.CreateClient();

        }

    }
}
