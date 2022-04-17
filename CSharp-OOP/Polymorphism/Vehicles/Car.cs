﻿namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double AirCondtitionerConsumption = 0.9;
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double FuelConsumption => base.FuelConsumption + AirCondtitionerConsumption;
    }
}
