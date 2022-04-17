using System;

namespace _07._Vehicle_Catalogue
{
    class Truck
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public double Weight { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public double HorsePower { get; set; }
    }

    class Catalogue
    {
        
    }

    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] parts = line.Split();


            }
        }
    }
}
