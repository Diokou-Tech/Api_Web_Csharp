using api_web.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace api_web.Services
{
    public static class Seeder
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        public static IEnumerable<WeatherForecast> InitData()
        {
            var rng = new Random();
            var Weathers = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Id = Guid.NewGuid().ToString(),
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
            return Weathers;
        }
    }
}
