using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Cars
{
    public class SuperCar : Car
    {
        private const double FuelAvailableConst = 80;
        private const double FuelConsumtpionPerRaceConst = 10;
        public SuperCar(string make, string model, string vin, int horsePower)
            : base(make, model, vin, horsePower, FuelAvailableConst, FuelConsumtpionPerRaceConst)
        {
        }

        public override void Drive()
        {
            this.HorsePower = this.HorsePower;
        }
    }
}
