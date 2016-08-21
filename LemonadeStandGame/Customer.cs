using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class Customer
    {
        public List<Customer> CustomerList = new List<Customer>();
        Player player;
        Day day = new Day();
        Weather weather = new Weather();
        public int thirst;
        public double customerCash;
        public int pitcher = 6;
        public double people;

        Random random = new Random();

        public Customer()
        {
            this.thirst = 0;
            this.customerCash = 0;
        }
        public List<Customer> CreateCustomer(Game game)
        {
            people = game.dayTemp * 0.60;

            for (int i = 0; i < people; i++)
            {
                Customer customer = new Customer();

                customer.thirst = GetThirst();
                customer.customerCash = GetCustomerCash();

                CustomerList.Add(customer);
            }
            return CustomerList;
        }

        public int GetThirst()
        {
            int thirstiness = 0;
            thirstiness = random.Next(0, 4);
            return thirstiness;
        }
        public double GetCustomerCash()
        {
            double cash = 0;
            cash = random.Next(1, 15);
            return cash * .10;
        }
        //public void CustomerTransactions(Wallet wallet, Inventory inventory)
        //{
        //    int customerCapabilityToBuy = 0;
        //    double Price = day.lemonadePrice;

        //    foreach (Customer customer in CustomerList)
        //    {
        //        if (customer.customerCash >= Price && customer.thirst > 1)
        //        {
        //            customerCapabilityToBuy++;
        //        }
        //    }

        //    if (customerCapabilityToBuy == 0)
        //    {
        //        // Day ends. 
        //    }else if (customerCapabilityToBuy != 0)
        //    {
        //        if(inventory.inventoryLemonCount >= 1 && inventory.inventorySugarCount >= 1 && inventory.inventoryIceCount >= 3 && inventory.inventoryCupsCount >= 6)
        //        {
        //            inventory.UpdateInventory();
        //            while (customerCapabilityToBuy >= pitcher)
        //            {
        //                wallet.amountOfMoney += (Price * pitcher);
        //                customerCapabilityToBuy -= pitcher;
        //                inventory.UpdateInventory();
        //            }
        //            wallet.amountOfMoney += (Price * customerCapabilityToBuy);
        //        }
        //        else
        //        {
        //            Console.WriteLine("Not enough Materials to make Lemonade.");
        //            Console.ReadLine();

        //            player.BuyLemons();
        //            player.BuySugar();
        //            player.BuyIce();
        //            player.BuyCups();

        //        }
        //    }

        //    //not enough materials
        //    //go back to buy more materials

        //    //day.StartDay();
        //}
    }
}
