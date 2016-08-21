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
            var x = game.StartGame();
            Wallet wallet = new Wallet();
            Customer a = new Customer();
            a.CreateCustomer();
            a.CustomerTransactions(wallet, x);
            Console.ReadKey();
        }
    }

}

// MAKE SURE INVENTORY AND MONEY DOESNT START BACK OVER ON NEXT DAY
// PIECE THINGS TOGETHER