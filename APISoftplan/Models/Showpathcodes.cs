using Microsoft.Extensions.Options;

namespace APISoftplan.Models
{
    public class Showpathcodes
    {
      
        public Showpathcodes()
        {

        }

        public string ShowPathCodeGit()
        {
            var pathGit = "https://github.com/fksouza/APISoftplan";
           
            return pathGit;

        }
    }
}
