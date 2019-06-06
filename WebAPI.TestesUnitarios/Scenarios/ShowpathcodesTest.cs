using FluentAssertions;
using System.Net;
using System.Threading.Tasks;
using WebAPI.TestesUnitarios.Fixtures;
using Xunit;

namespace WebAPI.TestesUnitarios.Scenarios
{
    public class ShowpathcodesTest
    {
        private readonly ShowpathcodesContext _showpathcodesContext;

        public ShowpathcodesTest(ShowpathcodesContext showpathcodesContext)
        {
            _showpathcodesContext = showpathcodesContext;
        }

        [Fact]
        public async Task Showpathcodes_ReturnsOkResponse()
        {
            var response = await _showpathcodesContext.Client.GetAsync("/api/Showpathcodes");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task Showpathcodes_ReturnsBadRequestResponse()
        {
            var response = await _showpathcodesContext.Client.GetAsync("/api/Showpathcodes/XXX");
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task Showpathcodes_CorrectContentType()
        {
            var response = await _showpathcodesContext.Client.GetAsync("/api/Showpathcodes");
            response.EnsureSuccessStatusCode();
            response.Content.Headers.ContentType.ToString().Should().Be("text/json; charset=utf-8");
        }
    }
}
