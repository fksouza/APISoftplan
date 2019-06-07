using APISoftplan.Models;
using Microsoft.AspNetCore.Mvc;
using System;

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
        public ActionResult ShowMeTheCode()
        {
            try
            {
                var gitpath = _showpathcodes.ShowPathCodeGit();

                if (string.IsNullOrEmpty(gitpath))
                    return NotFound();

                return Ok(gitpath);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message); 
            }
           
        }

    }
}