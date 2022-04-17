using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceM = int.Parse(Console.ReadLine());
            decimal distanceKm = (decimal)(distanceM / 1000.0);

            Console.WriteLine($"{distanceKm:f2}");
        }
    }
}
