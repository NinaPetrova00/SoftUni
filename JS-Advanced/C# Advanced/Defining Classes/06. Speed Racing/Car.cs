<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public string Model { get; set; }

        public decimal FuelAmount { get; set; }

        public decimal FuelCompsumption { get; set; }

        public decimal TravelledDistance { get; set; }

        public Car(string model,decimal fuel,decimal consumption)
        {
            Model = model;
            FuelAmount = fuel;
            FuelCompsumption = consumption;
            TravelledDistance = 0;
        }

        public void Drive(decimal distance)
        {
            decimal fuelNeeded = distance * FuelCompsumption;

            if (FuelAmount >= fuelNeeded)
            {
                FuelAmount -= fuelNeeded;
                TravelledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public string Model { get; set; }

        public decimal FuelAmount { get; set; }

        public decimal FuelCompsumption { get; set; }

        public decimal TravelledDistance { get; set; }

        public Car(string model,decimal fuel,decimal consumption)
        {
            Model = model;
            FuelAmount = fuel;
            FuelCompsumption = consumption;
            TravelledDistance = 0;
        }

        public void Drive(decimal distance)
        {
            decimal fuelNeeded = distance * FuelCompsumption;

            if (FuelAmount >= fuelNeeded)
            {
                FuelAmount -= fuelNeeded;
                TravelledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
