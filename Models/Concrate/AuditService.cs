using Event_Driven_Architecture.Events;
using Event_Driven_Architecture.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event_Driven_Architecture.Models.Concrate
{
    public class AuditService : IAuditService
    {
        public void Subscribe(IWeatherForecastService weatherForecastService)
        {
            weatherForecastService.OnWeatherTransactionProcessed += WriteAuditLog;
        }

        private void WriteAuditLog(object sender, WeatherForecastEventArgs e)
        {
            Console.WriteLine($"AUDIT LOG: {e.Day} günlük hava durumu sorgulandı.");
        }
    }
}
