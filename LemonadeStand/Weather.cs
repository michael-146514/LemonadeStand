using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
     class Weather
    {
        public string weather;

        List<string> WeatherList = new List<string> { "Clear Sky", "Cloudy Sky", "Raining", "Storming", "Heat Wave" };

        public void PickWeather()
        {
            Random random = new Random();
            int rand = random.Next(WeatherList.Count);
            weather = WeatherList[rand];

            Console.WriteLine($"Todays forcast will be {weather}");
        }
    } 
}
