using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class Weather                        //temperature degrees do not match weather conditions!!!!
    {
        Customer customer;

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
                    weatherCondition = "HOT";
                    CurrentTemperature();
                    break;
                case 2:
                    weatherCondition = "RAIN";
                    CurrentTemperature();
                    break;
                default:
                    weatherCondition = "CLOUDY";
                    CurrentTemperature();
                    break;
            }
            return weatherCondition;
        }
        public void CurrentTemperature()
        {
            Random randomTemperature = new Random();
            int currentTemperature = randomTemperature.Next(80, 85);
            this.currentTemperature = TemperatureChange(currentTemperature);
        }
        public int TemperatureChange(int currentTemperature)
        {
            if (weatherCondition == "RAIN")
            {
                currentTemperature -= 20;
                return currentTemperature;
            }
            else if (weatherCondition == "HOT")
            {
                currentTemperature = currentTemperature += 10;
                return currentTemperature;
            }
            else
            {
                currentTemperature = currentTemperature -= 5;
                return currentTemperature;
            }
        }
        public void WeatherEffectsOnCustomer(Day day)
        {
            if (weatherCondition == "HOT")
            {
                customer.customerCash += 0.50;
                customer.thirst += 1;
            }
            else if (weatherCondition == "RAIN")
            {
                customer.thirst /= 2;
            }
            else
            {
                customer.customerCash -= 0.40;
            }
        }
    }
}
