using APISoftplan.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace APISoftplan.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]    
    public class ShowpathcodesController : ControllerBase
    {
        private readonly IShowpathcodes _showpathcodes;

        public ShowpathcodesController(IShowpathcodes showpathcodes)
        {
            _showpathcodes = showpathcodes;
        }

        // GET api/Showpathcodes
        /// <summary>
        /// Retorna repositório GIT da aplicação.
        /// </summary>
        /// <returns> </returns>
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