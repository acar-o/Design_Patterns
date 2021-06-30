using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class WeatherStation : ISubject
    {
        private List<IObserver> observers;
        private float _temperature;
        public float Temperature
        {
            get
            {
                return _temperature;
            }
            set
            {
                _temperature = value;
                //Everytime the temp is changed, notify the observers
                Notify();
            }
        }
        public WeatherStation()
        {
            observers = new List<IObserver>();
        }
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        //Notify observers calling their Update method
        public void Notify()
        {
            observers.ForEach(o => o.Update(this));
        }
    }
}
