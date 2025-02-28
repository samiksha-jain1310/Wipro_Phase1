using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAssignment
{
    public interface IWeatherObserver
    {
        void Update(string report);
    }
    public class WeatherDisplay :IWeatherObserver{
        public void Update(string report)
        {
            Console.WriteLine($" updated : {report}");
        }
    }
}
