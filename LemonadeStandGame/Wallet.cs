using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class Wallet
    {
        public double amountOfMoney;
        public double funds;

        public Wallet()
        {
            this.amountOfMoney = 20;
        }
        public double GetAmountOfMoney()
        {
            return this.amountOfMoney;
        }
        public double SetAmountOfMoney()
        {
            return this.amountOfMoney;
        }
    }
}
