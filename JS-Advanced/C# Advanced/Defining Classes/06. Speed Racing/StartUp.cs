<<<<<<< HEAD
﻿using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
         static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var cars = new Car[n];

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                var parts = input
                    .Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

                var model = parts[0];
                var fuelAmount = decimal.Parse(parts[1]);
                var fuelCost = decimal.Parse(parts[2]);

                cars[i] = new Car(model, fuelAmount, fuelCost);
            }

            while (true)
            {
                var input = Console.ReadLine();
                var parts = input
                   .Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

                if (input == "End")
                {
                    break;
                }

                var model = parts[1];
                var distance = decimal.Parse(parts[2]);

                cars.Where(c => c.Model == model)
                    .ToList()
                    .ForEach(c => c.Drive(distance));
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
=======
﻿using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
         static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var cars = new Car[n];

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                var parts = input
                    .Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

                var model = parts[0];
                var fuelAmount = decimal.Parse(parts[1]);
                var fuelCost = decimal.Parse(parts[2]);

                cars[i] = new Car(model, fuelAmount, fuelCost);
            }

            while (true)
            {
                var input = Console.ReadLine();
                var parts = input
                   .Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

                if (input == "End")
                {
                    break;
                }

                var model = parts[1];
                var distance = decimal.Parse(parts[2]);

                cars.Where(c => c.Model == model)
                    .ToList()
                    .ForEach(c => c.Drive(distance));
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
