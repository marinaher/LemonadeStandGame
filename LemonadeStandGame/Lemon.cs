﻿using System;
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
        public int numberOfLemons;
        public double lemonPrice;

        public Lemon()
        {
            this.quality = 100;
            this.numberOfLemons = 0;
            this.spoilRate = quality -= 10;
        }
    }
}
