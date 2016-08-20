using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class Player
    {
        public string name;
        public Inventory inventory = new Inventory();
        public Wallet wallet = new Wallet();

        public Player(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void GoBuyMaterials()
        {
            double costOfLemon = 0.60;
            double costOfSugar = 0.80;
            double costOfIce = 0.60;
            double costOfCups = 1.00;
            int buyLemonAmount;
            int buySugarAmount;
            int buyIceAmount;
            int buyCupsAmount;

            Console.WriteLine("How many Lemons would you like to buy?");
            buyLemonAmount = Convert.ToInt32(Console.ReadLine());
            //int.TryParse(Console.ReadLine(), out buyLemonAmount);
            for (int i = 0; i < buyLemonAmount; i++)
            {
                Lemon lemon = new Lemon();
                inventory.inventoryLemons.Add(lemon);
            }
            if (wallet.amountOfMoney - (costOfLemon * buyLemonAmount) > 0.60)
            {
                inventory.inventoryLemonCount = inventory.inventoryLemonCount + buyLemonAmount;
                wallet.amountOfMoney = (wallet.amountOfMoney - (costOfLemon * buyLemonAmount));
            }
            else
            {
                Console.WriteLine("Insufficient Funds");
                Console.ReadLine();
            }
            Console.WriteLine("You bought {0} Lemons.", buyLemonAmount);
            Console.ReadLine();
            
            Console.WriteLine("How many cups of sugar would you like to buy?");
            int.TryParse(Console.ReadLine(), out buySugarAmount);
            for (int k = 0; k < buySugarAmount; k++)
            {
                Sugar sugar = new Sugar();
                inventory.inventorySugar.Add(sugar);
            }
            if (wallet.amountOfMoney - (costOfSugar * buySugarAmount) > 0.80)
            {
                inventory.inventorySugarCount = inventory.inventorySugarCount + buySugarAmount;
                wallet.amountOfMoney = wallet.amountOfMoney - (costOfSugar * buySugarAmount);
            }
            else
            {
                Console.WriteLine("Insufficient Funds");
                Console.ReadLine();
            }
            Console.WriteLine("You bought {0} cups of Sugar.", buySugarAmount);
            Console.ReadLine();

            Console.WriteLine("How many pounds of ice would you like to buy?");
            int.TryParse(Console.ReadLine(), out buyIceAmount);
            for (int j = 0; j < buyIceAmount; j++)
            {
                Ice ice = new Ice();
                inventory.inventoryIce.Add(ice);
            }
            if (wallet.amountOfMoney - (costOfIce * buyIceAmount) > 0.40)
            {
                inventory.inventoryIceCount = inventory.inventoryIceCount + buyIceAmount;
                wallet.amountOfMoney = wallet.amountOfMoney - (costOfIce * buyIceAmount);
            }
            else
            {
                Console.WriteLine("Insufficient Funds");
                Console.ReadLine();
            }
            Console.WriteLine("You bought {0} cups of ice.",buyIceAmount);
            Console.ReadLine();

            Console.WriteLine("How many cups would you like to buy?");
            int.TryParse(Console.ReadLine(), out buyCupsAmount);
            for (int l = 0; l < buyCupsAmount; l++)
            {
                Cups cups = new Cups();
                inventory.inventoryCups.Add(cups);
            }
            if (wallet.amountOfMoney - (costOfCups * buyCupsAmount) > 1.00)
            {
                inventory.inventoryCupsCount = inventory.inventoryCupsCount + buyCupsAmount;
                wallet.amountOfMoney = wallet.amountOfMoney - (costOfCups * buyCupsAmount);
            }
            else
            {
                Console.WriteLine("Insufficient Funds");
                Console.ReadLine();
            }
            Console.WriteLine("You bought {0} cups.", buyCupsAmount);
        }
    }
}
