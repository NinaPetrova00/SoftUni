<<<<<<< HEAD
﻿namespace AnimalFarm
{
    using System;
    using AnimalFarm.Models;
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            try
            {
            Chicken chicken = new Chicken(name, age);
                Console.WriteLine(
             $"Chicken {chicken.Name} (age {chicken.Age}) can produce {chicken.ProductPerDay} eggs per day.",
             chicken.Name,
             chicken.Age,
             chicken.ProductPerDay);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
=======
﻿namespace AnimalFarm
{
    using System;
    using AnimalFarm.Models;
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            try
            {
            Chicken chicken = new Chicken(name, age);
                Console.WriteLine(
             $"Chicken {chicken.Name} (age {chicken.Age}) can produce {chicken.ProductPerDay} eggs per day.",
             chicken.Name,
             chicken.Age,
             chicken.ProductPerDay);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
}