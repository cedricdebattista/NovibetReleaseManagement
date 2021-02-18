using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ATestWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdditionalController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };


        public AdditionalController()
        {

        }

        [HttpGet]
        public IEnumerable<AditionalForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new AditionalForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)],
                Hello="Hello tyhing55",
                ExpiryDate= DateTime.Now.AddDays(1),
                YYY="Cedric"
            })
            .ToArray();
        }
    }
}
