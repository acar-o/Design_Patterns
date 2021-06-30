using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation ws = new();
            NewsAgency agency1 = new("Alpha");
            NewsAgency agency2 = new("Beta ");

            ws.Attach(agency1);
            ws.Attach(agency2);

            ws.Temperature = 25.5f;
            //Alpha reporting temprature 25,5 celcius degree
            //Beta  reporting temprature 25,5 celcius degree

            ws.Temperature = 29.2f;
            //Alpha reporting temprature 29,2 celcius degree
            //Beta  reporting temprature 29,2 celcius degree
        }
    }
}
