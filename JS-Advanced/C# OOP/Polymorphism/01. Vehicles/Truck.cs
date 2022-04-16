<<<<<<< HEAD
﻿namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double AirCondtitionerConsumption = 1.6;
        public Truck(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption)
        {
        }

        public override double FuelConsumption => base.FuelConsumption + AirCondtitionerConsumption;

        public override void Refuel(double amount)
        {
            base.Refuel(amount * 0.95);
        }
    }
}
=======
﻿namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double AirCondtitionerConsumption = 1.6;
        public Truck(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption)
        {
        }

        public override double FuelConsumption => base.FuelConsumption + AirCondtitionerConsumption;

        public override void Refuel(double amount)
        {
            base.Refuel(amount * 0.95);
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
