using APISoftplan.Interface;

namespace APISoftplan.Models
{
    public class Showpathcodes : IShowpathcodes
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
