using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using junkbox.webapi;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace lab2.Controllers
{
    [ApiController]
   // [Route("[controller]")]
    public class MusicController : ControllerBase
    {
       private Music myMusic = new Music();
        // private static readonly string[] Summaries = new[]
        // {
        //     "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        // };

        private readonly ILogger<HelloWorldController> _logger;

        public MusicController(ILogger<HelloWorldController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("[controller]")]
        public String Get()
        {
            return "<h1> My Junkbox!</h1>";
        }
        
        [HttpGet]
        [Route("[controller]/Faith")]
        public String GetFaith()
        {
            return myMusic.Faith;
        }
        [HttpGet]
        [Route("[controller]/Queen")]
        public String GetQueen()
        {
            return myMusic.Queen;
        }
    }
}
