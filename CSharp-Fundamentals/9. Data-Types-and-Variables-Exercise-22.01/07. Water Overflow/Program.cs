using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 255;

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
              int litters = int.Parse(Console.ReadLine());

                if (sum + litters > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sum += litters;
                }
            }
          
            Console.WriteLine($"{sum}");
        }
    }
}
