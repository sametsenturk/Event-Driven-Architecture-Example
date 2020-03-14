using Event_Driven_Architecture.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event_Driven_Architecture.Models.Abstract
{
    public interface IWeatherForecastService
    {
        public event EventHandler<WeatherForecastEventArgs> OnWeatherTransactionProcessed;
        public IEnumerable<WeatherForecast> GetWeatherForecasts(int days);
    }
}
