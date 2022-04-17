using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Raw_Data
{
    public class Tier
    {
        public double Pressure { get; set; }

        public int Age { get; set; }

        public Tier(double tierPressure, int tierAge)
        {
            Pressure = tierPressure;
            Age = tierAge;
        }
    }
}
