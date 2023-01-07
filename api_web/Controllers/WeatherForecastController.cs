using api_web.Models;
using api_web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace api_web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public static List<WeatherForecast> Weathers { get; set; }
        private readonly ILogger<WeatherForecastController> _logger;
        public WeatherService WeatherService = new WeatherService();
        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            Weathers = WeatherService.FindAll().ToList();
        }
        [HttpGet]
        public List<WeatherForecast> Get()
        {
            return Weathers;
        }
        [HttpGet("{id}")]
        public WeatherForecast GetOne(string id)
        {
            return Weathers.SingleOrDefault(w => w.Id == id);
        }
        [HttpPost]
        public List<WeatherForecast> AddOne(WeatherForecast weather)
        {
            Weathers.Add(weather);
            return Weathers;
        }
    }
}
