using APISoftplan.Models;
using Microsoft.AspNetCore.Mvc;

namespace APISoftplan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowpathcodesController : ControllerBase
    {
        private readonly Showpathcodes _showpathcodes;

        public ShowpathcodesController(Showpathcodes showpathcodes)
        {
            _showpathcodes = showpathcodes;
        }

        // GET api/Showpathcodes
        [HttpGet]        
        public ActionResult<string> ShowMeTheCode()
        {
            string gitPath = _showpathcodes.ShowPathCodeGit();

            return gitPath;
        }

    }
}