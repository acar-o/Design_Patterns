using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class NewsAgency : IObserver
    {
        public String AgencyName { get; set; }
        public NewsAgency(String name)
        {
            AgencyName = name;
        }
        public void Update(ISubject subject)
        {
            if (subject is WeatherStation ws)
            {
                Console.WriteLine(String.Format("{0} reporting temprature {1} celcius degree", AgencyName, ws.Temperature));
            }
        }
    }
}
