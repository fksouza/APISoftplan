using Microsoft.Extensions.Options;

namespace APISoftplan.Models
{
    public class Showpathcodes
    {
        private readonly AppSettings _appSettings;

        public Showpathcodes()
        {

        }

        public Showpathcodes(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        public string ShowPathCodeGit()
        {
            var pathGit = _appSettings.Path;

            return pathGit;

        }
    }
}
