using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event_Driven_Architecture.Models.Abstract
{
    public interface IAuditService
    {
        public void Subscribe(IWeatherForecastService weatherForecastService);
    }
}
