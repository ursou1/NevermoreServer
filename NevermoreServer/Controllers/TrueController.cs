using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NevermoreServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrueController : ControllerBase
    {

        private static readonly string[] Food = new[]
        {
            "Суп из опилок", "Суп из опилок", "Суп из опилок", "Суп из опилок", "Суп из опилок"
        };
        private static readonly string[] Waiter = new[]
       {
            "Ахмед", "Ахмед", "Ахмед", "Ахмед", "Ахмед"
        };

        private readonly ILogger<TrueController> _logger;

        public TrueController(ILogger<TrueController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            string p = "asfffw";
            var rng = new Random();
            return Enumerable.Range(10, 50).Select(index => new WeatherForecast
            {
                Time = DateTime.Now.AddMinutes(index),
                Price = rng.Next(20, 550),
                Food = Food[rng.Next(Food.Length)],
                Waiter = Waiter[rng.Next(Waiter.Length)]
            })
            .ToArray();
        }

    }
}
