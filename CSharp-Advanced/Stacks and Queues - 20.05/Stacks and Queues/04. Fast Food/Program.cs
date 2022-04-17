using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(orders);

            Console.WriteLine(queue.Max());

            int sum = 0;
           
            while (queue.Count > 0)
            {
                int firstInLine = queue.Peek();
                sum += firstInLine;

                if (sum <= quantity)
                {
                    queue.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ",queue)}");
                    return;
                }
            }
            Console.WriteLine("Orders complete");
        }
    }
}
