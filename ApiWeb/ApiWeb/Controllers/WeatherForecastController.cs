using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiWeb.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {

        [HttpGet]
        public string Get()
        {
            var t = "HELLO WORD!!";
            return t;
            
        }
    }
}
