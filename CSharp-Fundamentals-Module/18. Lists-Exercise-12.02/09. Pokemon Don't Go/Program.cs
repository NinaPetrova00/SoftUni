using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> distance = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            int sum = 0;

            while (true)
            {
                int index = int.Parse(Console.ReadLine());

                if (distance.Count < 0)
                {
                    break;
                }

                for (int i = 0; i < distance.Count; i++)
                {
                    int removeNum = distance[index];

                        sum += removeNum;
                        distance.RemoveAt(index);

                    int currentNum = distance[i];

                    if (removeNum >= currentNum)
                    {
                        currentNum += removeNum;
                    }
                    else if (removeNum < currentNum)
                    {
                        currentNum -= removeNum;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
