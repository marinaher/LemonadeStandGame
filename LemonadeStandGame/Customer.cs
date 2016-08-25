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
        Day day = new Day();
        Weather weather = new Weather();
        public int thirst;
        public double customerCash;
        public int pitcher;
        public double people;

        Random random = new Random();

        public Customer()
        {
            thirst = 0;
            customerCash = 0;
            pitcher = 6;
        }
        public List<Customer> CreateCustomer(Game game)
        {
            people = game.dayTemp * 0.50;

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
    }
}
