<<<<<<< HEAD
﻿using System;
using System.Linq;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] truckTokens = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .ToArray();

            string[] busTokens = Console.ReadLine()
             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
             .ToArray();

            double carFuelQuantity = double.Parse(carTokens[1]);
            double carLitersPerKm = double.Parse(carTokens[2]);
            double carTankCapacity = double.Parse(carTokens[3]);

            double truckFuelQuantity = double.Parse(truckTokens[1]);
            double truckLitersPerKm = double.Parse(truckTokens[2]);
            double truckTankCapacity = double.Parse(truckTokens[3]);

            double busFuelQuantity = double.Parse(busTokens[1]);
            double busLitersPerKm = double.Parse(busTokens[2]);
            double busTankCapacity = double.Parse(busTokens[3]);

            Vehicle car = new Car(carFuelQuantity, carLitersPerKm, carTankCapacity);
            Vehicle truck = new Truck(truckFuelQuantity, truckLitersPerKm, truckTankCapacity);
            Bus bus = new Bus(busFuelQuantity, busLitersPerKm, busTankCapacity);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] currentLine = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = currentLine[0];
                string type = currentLine[1];
                double amount = double.Parse(currentLine[2]);


                if (command is "Drive")
                {
                    if (type is "Car")
                    {
                        CanDrive(car, amount);
                    }
                    else if (type is "Truck")
                    {
                        CanDrive(truck, amount);
                    }
                    else //Bus 
                    {
                        bus.IsEmpty = false;
                        CanDrive(bus, amount);
                    }
                }
                else if (command is "Refuel")
                {
                    try
                    {
                        if (type is "Car")
                        {
                            car.Refuel(amount);
                        }
                        else if (type is "Truck")
                        {
                            truck.Refuel(amount);
                        }
                        else //Bus
                        {
                            bus.Refuel(amount);
                        }
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else //Drive empty
                {
                    bus.IsEmpty = true;
                    CanDrive(bus, amount);
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }

        public static void CanDrive(Vehicle vehicle, double distance)
        {
            bool canDrive = vehicle.CanDrive(distance);
            string vehicleType = vehicle.GetType().Name;

            string result = canDrive ? $"{vehicleType} travelled {distance} km" : $"{vehicleType} needs refueling";

            Console.WriteLine(result);
        }
    }
}
=======
﻿using System;
using System.Linq;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] truckTokens = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .ToArray();

            string[] busTokens = Console.ReadLine()
             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
             .ToArray();

            double carFuelQuantity = double.Parse(carTokens[1]);
            double carLitersPerKm = double.Parse(carTokens[2]);
            double carTankCapacity = double.Parse(carTokens[3]);

            double truckFuelQuantity = double.Parse(truckTokens[1]);
            double truckLitersPerKm = double.Parse(truckTokens[2]);
            double truckTankCapacity = double.Parse(truckTokens[3]);

            double busFuelQuantity = double.Parse(busTokens[1]);
            double busLitersPerKm = double.Parse(busTokens[2]);
            double busTankCapacity = double.Parse(busTokens[3]);

            Vehicle car = new Car(carFuelQuantity, carLitersPerKm, carTankCapacity);
            Vehicle truck = new Truck(truckFuelQuantity, truckLitersPerKm, truckTankCapacity);
            Bus bus = new Bus(busFuelQuantity, busLitersPerKm, busTankCapacity);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] currentLine = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = currentLine[0];
                string type = currentLine[1];
                double amount = double.Parse(currentLine[2]);


                if (command is "Drive")
                {
                    if (type is "Car")
                    {
                        CanDrive(car, amount);
                    }
                    else if (type is "Truck")
                    {
                        CanDrive(truck, amount);
                    }
                    else //Bus 
                    {
                        bus.IsEmpty = false;
                        CanDrive(bus, amount);
                    }
                }
                else if (command is "Refuel")
                {
                    try
                    {
                        if (type is "Car")
                        {
                            car.Refuel(amount);
                        }
                        else if (type is "Truck")
                        {
                            truck.Refuel(amount);
                        }
                        else //Bus
                        {
                            bus.Refuel(amount);
                        }
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else //Drive empty
                {
                    bus.IsEmpty = true;
                    CanDrive(bus, amount);
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }

        public static void CanDrive(Vehicle vehicle, double distance)
        {
            bool canDrive = vehicle.CanDrive(distance);
            string vehicleType = vehicle.GetType().Name;

            string result = canDrive ? $"{vehicleType} travelled {distance} km" : $"{vehicleType} needs refueling";

            Console.WriteLine(result);
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
