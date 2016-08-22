using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class Day
    {
        
        //Wallet wallet;
        Weather weather = new Weather();
        public int dayNumber = 1;
        public double lemonadePrice;
        public string condition = "";
        public int degrees = 0;

        public Day()
        {

        }
        public void PrintDayWeather()
        {
            condition = weather.CurrentWeatherCondition();
            degrees = weather.currentTemperature;
            Console.Clear();
            Console.WriteLine("DAY {0} of 7.", dayNumber);
            Console.WriteLine("\nWeather condition: {0}. \tToday's temperature is: {1} degrees.", condition, degrees);
            Console.WriteLine("___________________________________________________________________________");
            dayNumber++;
        }
        public double StartDay()
        {
            Console.WriteLine("It's time to sell some Lemonade!");
            Console.WriteLine("\nHow much would you like to charge per cup of Lemonade?");
            string input = Console.ReadLine();
            if (input != null)
            {
                lemonadePrice = double.Parse(input);
            }
            else
            {
                StartDay();
            }
            
            Console.WriteLine("Got it. Each cup of Lemonade cost ${0}.", lemonadePrice);

            return lemonadePrice;
        }
    }
}
