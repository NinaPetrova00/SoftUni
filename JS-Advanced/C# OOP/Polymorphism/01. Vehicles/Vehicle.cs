<<<<<<< HEAD
﻿namespace Vehicles
{
    public abstract class Vehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get; private set; }

        public virtual double FuelConsumption { get; }

        public virtual void Refuel(double amount)
        {
            this.FuelQuantity += amount;
        }

        public bool CanDrive(double distance)
        {
            bool canDrive = ((this.FuelQuantity - this.FuelConsumption * distance) >= 0);

            if (!canDrive)
            {
                return false;
            }

            this.FuelQuantity -= this.FuelConsumption * distance;
            return true;
        }
    }
}
=======
﻿namespace Vehicles
{
    public abstract class Vehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get; private set; }

        public virtual double FuelConsumption { get; }

        public virtual void Refuel(double amount)
        {
            this.FuelQuantity += amount;
        }

        public bool CanDrive(double distance)
        {
            bool canDrive = ((this.FuelQuantity - this.FuelConsumption * distance) >= 0);

            if (!canDrive)
            {
                return false;
            }

            this.FuelQuantity -= this.FuelConsumption * distance;
            return true;
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
