using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            int bombNumber = arr[0];
            int bombPower = arr[1];

           while(true)
            {
                int bombIndex = numbers.IndexOf(bombNumber);

                if (bombIndex == -1)
                {
                    break;
                }

                int startIndex = bombIndex - bombPower;

                if (startIndex < 0)
                {
                    startIndex = 0;
                }

                int count = 2 * bombPower + 1;

                if (count > numbers.Count - startIndex)
                {
                    count = numbers.Count - startIndex;
                }

                numbers.RemoveRange(startIndex, count);

                
            }
            int sum = 0;
            foreach (var elelemt in numbers)
            {
                sum += elelemt;
            }
            Console.WriteLine(sum);
        }
    }
}
