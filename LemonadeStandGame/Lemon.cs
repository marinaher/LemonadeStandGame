using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class Lemon
    {
        public int spoilRate;
        public int quality;
        public double lemonPrice;

        public Lemon()
        {
            this.quality = 100;
            this.spoilRate = quality -= 10;
            this.lemonPrice = 1.00;
        }
    }
}
