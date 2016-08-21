using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class Day
    {
        
        Wallet wallet;
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
        public void StartDay()
        {
            Console.WriteLine("It's time to sell some Lemonade!");
            Console.WriteLine("\nHow much would you like to charge per cup of Lemonade?");
            lemonadePrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Got it. Each cup of Lemonade cost ${0}.", lemonadePrice);

            //once lemonade price is set, customers start coming to buy or not

            //if no more lemonade, need to stop deducting and stop game because sold out

            //start next day

            //at end of 7 days, show total profit amt

            //end game
        }
    }
}
