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
    public class HelloWorldController : ControllerBase
    {
       private HelloWorld myHelloWorld = new HelloWorld();
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<HelloWorldController> _logger;

        public HelloWorldController(ILogger<HelloWorldController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("[controller]")]
        public String Get()
        {
            return "<h1> Hello World </h1>";
        }
        
        [HttpGet]
        [Route("[controller]/HelloWorld")]
        public String GetHelloWorld()
        {
            return myHelloWorld.Helloworld;
        }
    }
}
