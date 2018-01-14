using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace configurationoptions.Controllers
{
    [Route("api/[controller]")]
    public class ConfigurationIOptionsSnapshotController : Controller
    {
        private readonly AppSettings _appSettings;


        public ConfigurationIOptionsSnapshotController(IOptionsSnapshot<AppSettings> configuration)
        {
            _appSettings = configuration.Value;
        }
        // GET api/configurationoption
        [HttpGet]
        public string  Get()
        {
            return  $"you are getting me through IOptionSnapshot<T>"+_appSettings.Option2; 

        }

        
    }
}
