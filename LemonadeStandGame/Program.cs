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
            
            Customer customer = new Customer();
            Weather weather = new Weather();
            Day day = new Day();
            Player player = new Player();
            double userLemPrice;
            int dayNumber = day.dayNumber;

            while(dayNumber <= 7)
            {
                double wallet = player.UpdateWallet();
                Inventory inventory = game.StartGame();


                userLemPrice = day.StartDay();

                customer.CreateCustomer(game);

                double funds = player.CustomerTransactions(wallet, inventory, customer.CustomerList, userLemPrice);
                Console.WriteLine("You're total for today is: ${0}.", player.funds);

                dayNumber++;
            }







            Console.ReadKey();
        }
    }

}

// MAKE SURE INVENTORY AND MONEY DOESNT START BACK OVER ON NEXT DAY
// PIECE THINGS TOGETHER