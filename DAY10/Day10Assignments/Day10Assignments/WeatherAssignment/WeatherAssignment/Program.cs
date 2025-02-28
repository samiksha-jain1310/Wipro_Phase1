using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherClass sender = new WeatherClass();
            IWeatherObserver observer1 = new WeatherDisplay();
            IWeatherObserver observer2= new WeatherDisplay();
            
           sender.AddObservations(observer1);
            sender.AddObservations(observer2);
            sender.RemoveObservations(observer2 );

           sender.SetWeatherReport("Rainy, 19'c");
           sender.SetWeatherReport("Summer,35,c");
            
        }
    }
}
