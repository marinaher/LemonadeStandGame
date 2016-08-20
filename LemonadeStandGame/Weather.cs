using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class Weather                        //temperature degrees do not match weather conditions!!!!
    {
        public int currentTemperature;
        public int currentWeatherCondition;
        public string weatherCondition;

        public string CurrentWeatherCondition()
        {
            Random randomWeather = new Random();
            int weather = randomWeather.Next(1, 4);
            switch (weather)
            {
                case 1:
                    weatherCondition = "HOT AND HUMID";
                    break;
                case 2:
                    weatherCondition = "RAIN";
                    break;
                default:
                    weatherCondition = "SUNNY AND BREEZY";
                    break;
            }
            return weatherCondition;
        }
        public int CurrentTemperature()
        {
            Random randomTemperature = new Random();
            int currentTemperature = randomTemperature.Next(72, 98) + 30;
            return currentTemperature;
        }
        public int TemperatureChange()
        {
            if (weatherCondition == "RAIN")
            {
                currentTemperature = currentTemperature - 20;
                return currentTemperature;
            }
            else if (weatherCondition == "HOT AND HUMID")
            {
                currentTemperature = currentTemperature + 10;
                return currentTemperature;
            }
            else
            {
                currentTemperature = currentTemperature - 5;
                return currentTemperature;
            }
        }
    }
}
