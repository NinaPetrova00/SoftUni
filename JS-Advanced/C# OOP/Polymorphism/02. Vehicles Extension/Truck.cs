<<<<<<< HEAD
﻿using System;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double AirCondtitionerConsumption = 1.6;
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double FuelConsumption => base.FuelConsumption + AirCondtitionerConsumption;

        public override void Refuel(double amount)
        {
            if (base.FuelQuantity + amount >this.TankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {amount} fuel in the tank");
            }

            base.Refuel(amount * 0.95);
        }
    }
}
=======
﻿using System;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double AirCondtitionerConsumption = 1.6;
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double FuelConsumption => base.FuelConsumption + AirCondtitionerConsumption;

        public override void Refuel(double amount)
        {
            if (base.FuelQuantity + amount >this.TankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {amount} fuel in the tank");
            }

            base.Refuel(amount * 0.95);
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
