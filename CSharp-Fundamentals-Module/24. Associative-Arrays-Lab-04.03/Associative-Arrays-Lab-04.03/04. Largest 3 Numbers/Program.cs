using System;
using System.Linq;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .OrderByDescending(n=>n)
                 .ToArray();


            int count = 0;

            if (numbers.Length >= 3)
            {
                count = 3;
            }
            else
            {
                count = numbers.Length;
            }

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}
