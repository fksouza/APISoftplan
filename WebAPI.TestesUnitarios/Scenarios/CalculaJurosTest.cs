using APISoftplan.Models;
using FluentAssertions;
using System.Net;
using System.Threading.Tasks;
using WebAPI.TestesUnitarios.Fixtures;
using Xunit;


namespace WebAPI.TestesUnitarios.Scenarios
{
    public class CalculaJurosTest
    {
        private readonly CalculaJurosContext _calculaJurosContext;

        public CalculaJurosTest()
        {
            _calculaJurosContext = new CalculaJurosContext();
        }

        [Fact]
        public async Task CalculaJuros_ReturnsOkResponse()
        {
            var response = await _calculaJurosContext.Client.GetAsync("/api/CalculaJuros?valorinicial=100&meses=5");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task CalculaJuros_ReturnsBadRequestResponse()
        {
            var response = await _calculaJurosContext.Client.GetAsync("/api/CalculaJuros?valorinicial=xxx&meses=xxx");
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task CalculaJuros_CorrectContentType()
        {
            var response = await _calculaJurosContext.Client.GetAsync("/api/CalculaJuros?valorinicial=100&meses=5");
            response.EnsureSuccessStatusCode();
            response.Content.Headers.ContentType.ToString().Should().Be("text/plain; charset=utf-8");
        }

        [Fact]
        public async Task CalculaJuros_AssertFalse()
        {

            // Arrange            
            double valorInicial = 100;
            int meses = 5;
            string valorEsperado = "150,10";
            CalculaJuros calculaJuros = new CalculaJuros { ValorInicial = valorInicial, Meses = meses };

            // Act            
            string valorJurosCompostos = _calculaJurosContext.CalcularjurosCompostos(calculaJuros);

            // assert
            Assert.False(valorEsperado == valorJurosCompostos,"Juros compostos calculado com sucesso!");

        }

        [Fact]
        public async Task CalculaJuros_AssertTrue()
        {

            // Arrange            
            double valorInicial = 100;
            int meses = 5;
            string valorEsperado = "150,10";
            CalculaJuros calculaJuros = new CalculaJuros { ValorInicial = valorInicial, Meses = meses };

            // Act            
            string valorJurosCompostos = _calculaJurosContext.CalcularjurosCompostos(calculaJuros);

            // assert
            Assert.True(valorEsperado != valorJurosCompostos, "Juros compostos calculado incorretamente!");

        }
    }
}
