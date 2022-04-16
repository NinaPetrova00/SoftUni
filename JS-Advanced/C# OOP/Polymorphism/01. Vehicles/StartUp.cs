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

            double carFuelQuantity = double.Parse(carTokens[1]);
            double carLitersPerKm = double.Parse(carTokens[2]);

            double truckFuelQuantity = double.Parse(truckTokens[1]);
            double truckLitersPerKm = double.Parse(truckTokens[2]);

            Vehicle car = new Car(carFuelQuantity, carLitersPerKm);
            Vehicle truck = new Truck(truckFuelQuantity, truckLitersPerKm);

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
                    else //Truck
                    {
                        CanDrive(truck, amount);
                    }
                }
                else   //Refuel
                {
                    if (type is "Car")
                    {
                        car.Refuel(amount);
                    }
                    else //Truck
                    {
                        truck.Refuel(amount);
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
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

            double carFuelQuantity = double.Parse(carTokens[1]);
            double carLitersPerKm = double.Parse(carTokens[2]);

            double truckFuelQuantity = double.Parse(truckTokens[1]);
            double truckLitersPerKm = double.Parse(truckTokens[2]);

            Vehicle car = new Car(carFuelQuantity, carLitersPerKm);
            Vehicle truck = new Truck(truckFuelQuantity, truckLitersPerKm);

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
                    else //Truck
                    {
                        CanDrive(truck, amount);
                    }
                }
                else   //Refuel
                {
                    if (type is "Car")
                    {
                        car.Refuel(amount);
                    }
                    else //Truck
                    {
                        truck.Refuel(amount);
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
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
