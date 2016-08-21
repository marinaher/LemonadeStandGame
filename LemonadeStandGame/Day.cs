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
        Wallet wallet;
        Weather weather = new Weather();
        

        public Day()
        {

        }
        public void PrintDayWeather()
        {
            Console.WriteLine("DAY {0} of 7.", dayNumber);
            Console.WriteLine("\nWeather condition: {0}. \tToday's temperature is: {1} degrees.", weather.CurrentWeatherCondition(), weather.currentTemperature);
            Console.WriteLine("___________________________________________________________________________");
        }
        public double StartDay()
        {
            Console.WriteLine("It's time to sell some Lemonade!");
            Console.WriteLine("\nHow much would you like to charge per cup of Lemonade?");
            double lemonadePrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Got it. Each cup of Lemonade cost ${0}.", lemonadePrice);

            return lemonadePrice;

            //once lemonade price is set, customers start coming to buy or not

            //if no more lemonade, need to stop deducting and stop game because sold out

            //start next day

            //at end of 7 days, show total profit amt

            //end game
        }
    }
}
