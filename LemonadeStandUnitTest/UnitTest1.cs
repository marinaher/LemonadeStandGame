using System;
using LemonadeStandGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LemonadeStandUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetAmountOfMoney()
        {
            Wallet wallet = new Wallet();
            int amountOfMoney = 30;
            int result;

            result = amountOfMoney;

            Assert.AreEqual(result, wallet.amountOfMoney);
        }
        [TestMethod]
        public void WelcomeMessage()
        {

        }
    }
}
