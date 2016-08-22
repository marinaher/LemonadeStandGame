using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class Inventory
    {
        Player player;

        public List<Lemon> inventoryLemon = new List<Lemon>();
        public int inventoryLemonCount;

        public List<Sugar> inventorySugar = new List<Sugar>();
        public int inventorySugarCount;

        public List<Ice> inventoryIce = new List<Ice>();
        public int inventoryIceCount;

        public List<Cups> inventoryCups = new List<Cups>();
        public int inventoryCupsCount;

        int lemonsInPitcher = 1;
        int sugarInPitcher = 1;
        int iceInPitcher = 3;
        int cupsInPitcher = 6;

        public Inventory()
        {
            this.inventoryLemonCount = 0;
            this.inventorySugarCount = 0;
            this.inventoryIceCount = 0;
            this.inventoryCupsCount = 0;
        }
        public int GetLemonCount()
        {
            return inventoryLemonCount = inventoryLemon.Count;
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
        public void UpdateInventory()
        {
            inventoryLemonCount -= 1;
            inventorySugarCount -= 1;
            inventoryIceCount -= 3;
            inventoryCupsCount -= 6;
            RemoveItemsFromList();

        }
        public void RemoveItemsFromList()
        {
            for (int i = 0; i < lemonsInPitcher; i++)
            {
                inventoryLemon.RemoveAt(0);
            }
            for (int i = 0; i < sugarInPitcher; i++)
            {
                inventorySugar.RemoveAt(0);
            }
            for (int i = 0; i < iceInPitcher; i++)
            {
                inventoryIce.RemoveAt(0);
            }
            for (int i = 0; i < cupsInPitcher; i++)
            {
                inventoryCups.RemoveAt(0);
            }
        }
        public void PrintCurrentInventory()
        {
            Console.WriteLine("This is your current inventory: ");
            Console.WriteLine("\nLemons:\t{0} \tSugar:\t{1} \nIce: \t{2} \tCups: \t{3}", inventoryLemonCount, inventorySugarCount, inventoryIceCount, inventoryCupsCount);

            
        }
    }
}
