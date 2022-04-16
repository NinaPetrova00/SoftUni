<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Raw_Data
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var numberOfCars = int.Parse(Console.ReadLine());

            var cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                var parts = Console.ReadLine().Split();

                var engine = new Engine(int.Parse(parts[1]), int.Parse(parts[2]));

                var cargo = new Cargo(int.Parse(parts[3]), parts[4]);

                var tiers = new Tier[]
                {
                    new Tier(double.Parse(parts[5]),int.Parse(parts[6])),
                    new Tier(double.Parse(parts[7]),int.Parse(parts[8])),
                    new Tier(double.Parse(parts[9]),int.Parse(parts[10])),
                    new Tier(double.Parse(parts[11]),int.Parse(parts[12]))
                };
                var model = parts[0];

                cars.Add(new Car(model, engine, cargo, tiers));
            }

            string type = Console.ReadLine();
            var filteredCars = new List<Car>();

            if (type == "fragile")
            {
                filteredCars = cars.Where(c => c.Cargo.Type == "fragile" &&
                c.Tier.Any(t => t.Pressure < 1))
                    .ToList();
            }
            else
            {
                filteredCars = cars.Where(c => c.Cargo.Type == "flamable" &&
                c.Engine.Power > 250)
                    .ToList();
            }

            foreach (Car car in filteredCars)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Raw_Data
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var numberOfCars = int.Parse(Console.ReadLine());

            var cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                var parts = Console.ReadLine().Split();

                var engine = new Engine(int.Parse(parts[1]), int.Parse(parts[2]));

                var cargo = new Cargo(int.Parse(parts[3]), parts[4]);

                var tiers = new Tier[]
                {
                    new Tier(double.Parse(parts[5]),int.Parse(parts[6])),
                    new Tier(double.Parse(parts[7]),int.Parse(parts[8])),
                    new Tier(double.Parse(parts[9]),int.Parse(parts[10])),
                    new Tier(double.Parse(parts[11]),int.Parse(parts[12]))
                };
                var model = parts[0];

                cars.Add(new Car(model, engine, cargo, tiers));
            }

            string type = Console.ReadLine();
            var filteredCars = new List<Car>();

            if (type == "fragile")
            {
                filteredCars = cars.Where(c => c.Cargo.Type == "fragile" &&
                c.Tier.Any(t => t.Pressure < 1))
                    .ToList();
            }
            else
            {
                filteredCars = cars.Where(c => c.Cargo.Type == "flamable" &&
                c.Engine.Power > 250)
                    .ToList();
            }

            foreach (Car car in filteredCars)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
