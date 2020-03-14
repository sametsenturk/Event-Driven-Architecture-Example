using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event_Driven_Architecture.Events
{
    public class WeatherForecastEventArgs : EventArgs
    {
        public int Day { get; set; }

        public WeatherForecastEventArgs(int day)
        {
            this.Day = day;
        }
    }
}
