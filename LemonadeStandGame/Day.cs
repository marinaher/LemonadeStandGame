using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class Day
    {
        public int dayNumber = 1;
        Weather weather = new Weather();
        public List<Customer> createCustomers;
        
        public Day()
        {

        }
        public void PrintDayWeather()
        {
            Console.WriteLine("DAY {0} of 7.", dayNumber);
            Console.WriteLine("\nWeather condition: {0}. \tToday's temperature is: {1} degrees.", weather.CurrentWeatherCondition(), weather.currentTemperature);
            Console.WriteLine("___________________________________________________________________________");
        }
    }
}
