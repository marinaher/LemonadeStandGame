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
        Customer customer = new Customer();
        Day day = new Day();

        public Player()
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
        public void BuyLemons()                 //what if player enters in string instead of int ??? it doesn't break. it tells player that they bought 0 items.
        {
            int buyLemonAmount;
            double costOfLemon = 0.10;
            Console.WriteLine("How many Lemons would you like to buy?");
            string lemonAmountInput = Console.ReadLine();
            int.TryParse(lemonAmountInput, out buyLemonAmount);
            if (wallet.amountOfMoney - (costOfLemon * buyLemonAmount) > costOfLemon)
            {
                inventory.inventoryLemonCount += buyLemonAmount;
                wallet.amountOfMoney = (wallet.amountOfMoney - (costOfLemon * buyLemonAmount));
                Console.WriteLine("You bought {0} Lemons.", buyLemonAmount);
            }
            else if(wallet.amountOfMoney < (costOfLemon * buyLemonAmount))
            {
                Console.WriteLine("Insufficient Funds");
                Console.ReadLine();
                BuyLemons();
            }
            for (int i = 0; i < buyLemonAmount; i++)
            {
                Lemon lemon = new Lemon();
                inventory.inventoryLemon.Add(lemon);
            }
        }
        public void BuySugar()
        {
            int buySugarAmount;
            double costOfSugar = 0.10;
            Console.WriteLine("\nHow many cups of sugar would you like to buy?");
            string sugarAmountInput = Console.ReadLine();
            int.TryParse(sugarAmountInput, out buySugarAmount);
            if (wallet.amountOfMoney - (costOfSugar * buySugarAmount) > costOfSugar)
            {
                inventory.inventorySugarCount += buySugarAmount;
                wallet.amountOfMoney = wallet.amountOfMoney - (costOfSugar * buySugarAmount);
                Console.WriteLine("You bought {0} cups of Sugar.", buySugarAmount);
            }
            else if(wallet.amountOfMoney < (costOfSugar * buySugarAmount))
            {
                Console.WriteLine("Insufficient Funds");
                Console.ReadLine();
                BuySugar();
            }
            for (int k = 0; k < buySugarAmount; k++)
            {
                Sugar sugar = new Sugar();
                inventory.inventorySugar.Add(sugar);
            }
        }
        public void BuyIce()
        {
            int buyIceAmount;
            double costOfIce = 0.10;
            Console.WriteLine("\nHow many cups of ice would you like to buy?");
            string iceAmountInput = Console.ReadLine();
            int.TryParse(iceAmountInput, out buyIceAmount);
            if (wallet.amountOfMoney - (costOfIce * buyIceAmount) > costOfIce)
            {
                inventory.inventoryIceCount += buyIceAmount;
                wallet.amountOfMoney = wallet.amountOfMoney - (costOfIce * buyIceAmount);
                Console.WriteLine("You bought {0} cups of ice.", buyIceAmount);
            }
            else if(wallet.amountOfMoney < (costOfIce * buyIceAmount))
            {
                Console.WriteLine("Insufficient Funds");
                Console.ReadLine();
                BuyIce();
            }
            for (int j = 0; j < buyIceAmount; j++)
            {
                Ice ice = new Ice();
                inventory.inventoryIce.Add(ice);
            }
        }
        public void BuyCups()
        {
            double costOfCups = 0.10;
            int buyCupsAmount;
            Console.WriteLine("\nHow many cups would you like to buy?");
            string cupsAmountInput = Console.ReadLine();
            int.TryParse(cupsAmountInput, out buyCupsAmount);
            if (wallet.amountOfMoney - (costOfCups * buyCupsAmount) > costOfCups)
            {
                inventory.inventoryCupsCount += buyCupsAmount;
                wallet.amountOfMoney = wallet.amountOfMoney - (costOfCups * buyCupsAmount);
                Console.WriteLine("You bought {0} cups.", buyCupsAmount);
            }
            else if(wallet.amountOfMoney < (costOfCups * buyCupsAmount))
            {
                Console.WriteLine("Insufficient Funds");
                Console.ReadLine();
                BuyCups();
            }
            for (int l = 0; l < buyCupsAmount; l++)
            {
                Cups cups = new Cups();
                inventory.inventoryCups.Add(cups);
            }
        }
        public Inventory GoBuyMaterials()
        {
            BuyLemons();
            BuySugar();
            BuyIce();
            BuyCups();
            Console.Clear();

            return inventory;
        }
        public void CustomerTransactions(Wallet wallet, Inventory inventory)
        {
            int customerCapabilityToBuy = 0;
            double Price = day.lemonadePrice;

            foreach (Customer customer in customer.CustomerList)
            {
                if (customer.customerCash >= Price && customer.thirst > 1)
                {
                    customerCapabilityToBuy++;
                }
            }

            if (customerCapabilityToBuy == 0)
            {
                // Day ends. 
            }
            else if (customerCapabilityToBuy != 0)
            {
                if (inventory.inventoryLemonCount >= 1 && inventory.inventorySugarCount >= 1 && inventory.inventoryIceCount >= 3 && inventory.inventoryCupsCount >= 6)
                {
                    inventory.UpdateInventory();
                    while (customerCapabilityToBuy >= customer.pitcher)
                    {
                        wallet.amountOfMoney += (Price * customer.pitcher);
                        customerCapabilityToBuy -= customer.pitcher;
                        inventory.UpdateInventory();
                    }
                    wallet.amountOfMoney += (Price * customerCapabilityToBuy);
                }
                else
                {
                    Console.WriteLine("Not enough Materials to make Lemonade.");
                    Console.ReadLine();

                    BuyLemons();
                    BuySugar();
                    BuyIce();
                    BuyCups();

                }
            }

            //not enough materials
            //go back to buy more materials

            //day.StartDay();
        }

    }
}
