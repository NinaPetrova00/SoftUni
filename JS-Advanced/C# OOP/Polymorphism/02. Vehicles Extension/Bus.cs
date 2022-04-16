<<<<<<< HEAD
﻿namespace Vehicles
{
    public class Bus : Vehicle
    {
        private const double AirCondtitionerConsumption = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public bool IsEmpty { get; set; }
        public override double FuelConsumption => this.IsEmpty
            ? base.FuelConsumption
            : base.FuelConsumption + AirCondtitionerConsumption;
    }
}
=======
﻿namespace Vehicles
{
    public class Bus : Vehicle
    {
        private const double AirCondtitionerConsumption = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public bool IsEmpty { get; set; }
        public override double FuelConsumption => this.IsEmpty
            ? base.FuelConsumption
            : base.FuelConsumption + AirCondtitionerConsumption;
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
