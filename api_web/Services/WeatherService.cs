using api_web.Models;
using System.Collections.Generic;
using System.Linq;

namespace api_web.Services
{
    public class WeatherService
    {
        public List<WeatherForecast> Elements { get; set; }
        public WeatherService() 
        {
            this.Elements = Seeder.InitData().ToList();
        }
        public IEnumerable<WeatherForecast> FindAll()
        {
            return Elements;
        }
        public WeatherForecast FindOne(string id)
        {
            return Elements.SingleOrDefault(w => w.Id == id);
        }
        public void Add(WeatherForecast weather)
        {
            Elements.Add(weather);
        }
        public void DeleteOne(WeatherForecast weather)
        {
            Elements.Remove(weather);
        }
    }
}
