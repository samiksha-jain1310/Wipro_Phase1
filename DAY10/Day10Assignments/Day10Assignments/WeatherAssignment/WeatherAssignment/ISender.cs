using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable IDE0008;
namespace WeatherAssignment
{
    public interface ISender
    {
        void AddObservations(IWeatherObserver weatherObserver);
        void RemoveObservations(IWeatherObserver weatherObserver);
        void SendNotificationUpdate();
    }
    public class WeatherClass : ISender
    {
        public List<IWeatherObserver> observations=new List<IWeatherObserver>();
        private string report;
        public void AddObservations(IWeatherObserver weatherObserver) { 
            observations.Add(weatherObserver);
        }
        public void RemoveObservations(IWeatherObserver weatherObserver) { 
            observations.Remove(weatherObserver);
        }
        public void SendNotificationUpdate() {
            foreach(var observation in observations) { 
                observation.Update(report);
            }
        }
        public void SetWeatherReport(string weatherreport) { 
         report = weatherreport;
        SendNotificationUpdate();
        }
    }
}
