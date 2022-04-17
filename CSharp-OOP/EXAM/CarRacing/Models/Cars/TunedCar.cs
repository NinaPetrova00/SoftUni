using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Cars
{
    public class TunedCar : Car
    {
        private const double FuelAvailable = 65;
        private const double FuelConsumtpionPerRace = 7.5;
        public TunedCar(string make, string model, string vin, int horsePower)
            : base(make, model, vin, horsePower, FuelAvailable, FuelConsumtpionPerRace)
        {
        }

        public override void Drive()
        {
            this.HorsePower = this.HorsePower;
        }
    }
}
