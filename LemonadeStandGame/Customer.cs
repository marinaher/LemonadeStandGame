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
        public Weather weather;
        Day day = new Day();
        public int thirst;
        public double customerCash;
        public int pitcher = 8;

        Random random = new Random();

        public Customer()
        {
            this.thirst = 0;
            this.customerCash = 0;

        }
        public List<Customer> CreateCustomer()
        {
            for (int i = 0; i < 30; i++)
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
        public void CustomerTransactions(Wallet wallet, Inventory inventory, double lemonadePrice)
        {
            int customerCapabilityToBuy = 0;
            double Price = day.StartDay();

            foreach (Customer customer in CustomerList)
            {
                if (customer.customerCash >= Price && customer.thirst > 1)
                {
                    customerCapabilityToBuy++;
                }
            }

            if (customerCapabilityToBuy == 0)
            {
                // Day ends. 
            }else if (customerCapabilityToBuy != 0)
            {
                while(customerCapabilityToBuy >= pitcher)
                {
                    wallet.amountOfMoney += (Price * 8);
                    customerCapabilityToBuy -= 8;
                    inventory.UpdateInventory();
                }
                wallet.amountOfMoney += (Price * customerCapabilityToBuy);
            }
            day.StartDay();
        }
    }
}
