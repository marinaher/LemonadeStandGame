using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class Wallet
    {
        Player player;

        public double amountOfMoney = 30;

        public double buyLemonAmount;
        public double buySugarAmount;
        public double buyIcemount;
        public double buyCupsAmount;

        public double newValueLemons;
        public double newValueSugar;
        public double newValueIce;
        public double newValueCups;

        public Wallet()
        {
        }
        public double GetAmountOfMoney()
        {
            return this.amountOfMoney;
        }
        public double SetAmountOfMoney()
        {
            return this.amountOfMoney;
        }
        
        public double LemonWalletUpdate()
        {
            return newValueLemons = amountOfMoney - (player.costOfLemon * buyLemonAmount);
        }
        public double SugarWalletUpdate()
        {
            return newValueSugar = amountOfMoney - (player.costOfSugar * buySugarAmount);
        }
        public double IceWalletUpdate()
        {
            return newValueIce = amountOfMoney - (player.costOfIce * buyIcemount);
        }
        public double CupWalletUpdate()
        {
            return newValueCups = amountOfMoney - (player.costOfCups * buyCupsAmount);
        }
        public double UpdateWalletAmount()
        {
            return amountOfMoney - (newValueLemons + newValueSugar + newValueIce + newValueCups);
        }
    }
}
