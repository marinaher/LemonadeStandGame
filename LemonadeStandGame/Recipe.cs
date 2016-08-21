using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class Recipe
    {
        public int cupsPerRecipe;
        public int lemon;
        public int sugar;
        public int ice;
        public int useLemons;
        public int useSugar;
        public int useIce;

        public Recipe()
        {

        }
        public List<int> Ingredients()
        {
            Console.WriteLine("Time to mix your Lemonade!");
            Console.WriteLine("How many Lemons would you like to use?");
            int useLemons = Int32.Parse(Console.ReadLine());

            Console.WriteLine("How many cups of sugar would you like to use?");
            int useSugar = Int32.Parse(Console.ReadLine());

            Console.WriteLine("How many cups of ice would you like to use?");
            int useIce = Int32.Parse(Console.ReadLine());

            List<int> awesomeRecipe = new List<int>() { lemon, sugar, ice };
            return awesomeRecipe;
        }
        public double LemonadePrice()
        {
            Console.WriteLine("How much would you like to charge per cup of Lemonade?");
            double lemonadePrice = Int32.Parse(Console.ReadLine());
            if (lemonadePrice >= 10)
            {
                Console.WriteLine("That's really expensive!");
            }
            return LemonadePrice();
        }
        public void LemonadeCreated()
        {
            if (useLemons <= 8 && useSugar <= 6 && useIce <= 3)
            {

            }
        }
    }
}
