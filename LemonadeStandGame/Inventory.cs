using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class Inventory
    {
        public List<Lemon> inventoryLemons;
        public int inventoryLemonCount;

        public List<Sugar> inventorySugar;
        public int inventorySugarCount;

        public List<Ice> inventoryIce;
        public int inventoryIceCount;

        public List<Cups> inventoryCups;
        public int inventoryCupsCount;

        public Inventory()
        {
            this.inventoryLemonCount = 0;
            this.inventorySugarCount = 0;
            this.inventoryIceCount = 0;
            this.inventoryCupsCount = 0;
        }
        public int GetLemonCount()
        {
            return inventoryLemonCount = inventoryLemons.Count;
        }
        public int GetSugarCount()
        {
            return inventorySugarCount = inventorySugar.Count;
        }
        public int GetIceCount()
        {
            return inventoryIceCount = inventoryIce.Count;
        }
        public int GetCupsCount()
        {
            return inventoryCupsCount = inventoryCups.Count;
        }
        public void PrintCurrentInventory()
        {
            Console.WriteLine("This is your current inventory: ");
            Console.WriteLine("\nLemons:\t{0} \tSugar:\t{1} \nIce: \t{2} \tCups: \t{3}", inventoryLemonCount, inventorySugarCount, inventoryIceCount, inventoryCupsCount);
        }
    }
}
