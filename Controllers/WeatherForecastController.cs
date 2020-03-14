using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event_Driven_Architecture.Models.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Event_Driven_Architecture.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly IWeatherForecastService _weatherForecastService;
        private readonly IAuditService _auditService;

        public WeatherForecastController(IWeatherForecastService weatherForecastService, IAuditService auditService)
        {
            this._weatherForecastService = weatherForecastService;
            this._auditService = auditService;
            this._auditService.Subscribe(this._weatherForecastService);
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get(int days)
        {
            var weatherForecasts = _weatherForecastService.GetWeatherForecasts(days);
            return weatherForecasts;
        }
    }
}
