using Event_Driven_Architecture.Events;
using Event_Driven_Architecture.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event_Driven_Architecture.Models.Concrate
{
    public class WeatherForecastService : IWeatherForecastService
    {
        public event EventHandler<WeatherForecastEventArgs> OnWeatherTransactionProcessed;

        private readonly static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public IEnumerable<WeatherForecast> GetWeatherForecasts(int days)
        {
            Random random = new Random();
            var weatherForecasts = Enumerable.Range(1, days).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = random.Next(-20, 55),
                Summary = Summaries[random.Next(Summaries.Length)]
            }).ToArray();

            if (OnWeatherTransactionProcessed != null)
                OnWeatherTransactionProcessed(this, new WeatherForecastEventArgs(days));

            return weatherForecasts;
        }
    }
}
