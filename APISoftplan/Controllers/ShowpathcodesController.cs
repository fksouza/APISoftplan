using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APISoftplan.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

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
               
        // GET api/values
        [HttpGet]
        public ActionResult<string> ShowMeTheCode()
        {

            string gitPath = _showpathcodes.ShowPathCodeGit();

            return gitPath;
        }

    }
}