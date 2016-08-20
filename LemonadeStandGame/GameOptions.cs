using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class GameOptions
    {
        public void RunGameOptions()
        {
            Console.WriteLine("\nWhat would you like to do next?");
            Console.WriteLine("\n1 - Start Game \n2 - Quit");
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Lets get started!");
                    Console.Read();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Quit Game? \nPress 'y' for yes or 'n' for no");
                    string quitNow = Console.ReadLine();
                    if (quitNow == "y")
                    {
                        Console.WriteLine("Hope you had fun! Good Bye!");    //doesn't exit game!!!!
                    }
                    else if (quitNow == "n")
                    {
                        Console.WriteLine("What would you like to do?");
                        Console.Clear();
                        RunGameOptions();
                    }
                    else
                    {
                        Console.WriteLine("Invalid Choice");
                        RunGameOptions();
                    }
                    break;
            }
        }
    }
}
