using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.FlowerWreaths
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var lilies = new Stack<int>(Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse));

            var roses = new Queue<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse));

            int sum = 0;
            int storedSum = 0;
            int wreath = 0;

            while (lilies.Count > 0 && roses.Count > 0)
            {
                var lastLily = lilies.Peek();
                var firstRose = roses.Peek();

                sum = lastLily + firstRose;

                if (sum == 15)
                {
                    wreath++;
                    lilies.Pop();
                    roses.Dequeue();
                }
                else if (sum > 15)
                {
                    lilies.Pop();
                    lastLily -= 2;
                    lilies.Push(lastLily);

                }
                else //sum < 15
                {
                    storedSum += sum;
                    lilies.Pop();
                    roses.Dequeue();
                }
            }

            if (storedSum >= 15)
            {   
                int result = storedSum / 15;
                wreath += result;
            }

            if (wreath >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreath} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreath} wreaths more!");
            }
        }
    }
}
