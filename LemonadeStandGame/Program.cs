using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Game game = new Game();
            Wallet wallet = new Wallet();
            Customer customer = new Customer();
            Weather weather = new Weather();
            Day day = new Day();
            Player player = new Player();

            int dayNumber = day.dayNumber;

            while(dayNumber <= 7)
            {
                Inventory inventory = game.StartGame();
                day.StartDay();

                customer.CreateCustomer(game);
                player.CustomerTransactions(wallet, inventory);

                dayNumber++;
            }







            Console.ReadKey();
        }
    }

}

// MAKE SURE INVENTORY AND MONEY DOESNT START BACK OVER ON NEXT DAY
// PIECE THINGS TOGETHER