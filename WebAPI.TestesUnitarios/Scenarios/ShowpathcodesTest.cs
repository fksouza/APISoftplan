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

        public ShowpathcodesTest()
        {
            _showpathcodesContext = new ShowpathcodesContext();
        }

        [Fact]
        public async Task Showpathcodes_ReturnsOkResponse()
        {
            var response = await _showpathcodesContext.Client.GetAsync("/api/Showpathcodes");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task Showpathcodes_CorrectContentType()
        {
            var response = await _showpathcodesContext.Client.GetAsync("/api/Showpathcodes");
            response.EnsureSuccessStatusCode();
            response.Content.Headers.ContentType.ToString().Should().Be("text/plain; charset=utf-8");
        }
    }
}
