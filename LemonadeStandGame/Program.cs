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
            Day day = new Day();


            Inventory inventory = game.StartGame();
            double lemonadePrice = day.StartDay();

            customer.CreateCustomer();
            customer.CustomerTransactions(wallet, inventory, lemonadePrice);








            Console.ReadKey();
        }
    }

}

// MAKE SURE INVENTORY AND MONEY DOESNT START BACK OVER ON NEXT DAY
// PIECE THINGS TOGETHER