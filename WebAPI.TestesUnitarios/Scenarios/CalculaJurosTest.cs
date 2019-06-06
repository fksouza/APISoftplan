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

        public CalculaJurosTest(CalculaJurosContext calculaJurosContext)
        {
            _calculaJurosContext = calculaJurosContext;
        }

        [Fact]
        public async Task CalculaJurosReturnsOkResponse()
        {
            var response = await _calculaJurosContext.Client.GetAsync("/api/CalculaJuros?valorinicial=100&meses=5");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task CalculaJurosReturnsBadRequestResponse()
        {
            var response = await _calculaJurosContext.Client.GetAsync("/api/CalculaJuros?valorinicial=xxx&meses=xxx");
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task CalculaJurosCorrectContentType()
        {
            var response = await _calculaJurosContext.Client.GetAsync("/api/CalculaJuros?valorinicial=100&meses=5");
            response.EnsureSuccessStatusCode();
            response.Content.Headers.ContentType.ToString().Should().Be("text/plain; charset=utf-8");
        }
    }
}
