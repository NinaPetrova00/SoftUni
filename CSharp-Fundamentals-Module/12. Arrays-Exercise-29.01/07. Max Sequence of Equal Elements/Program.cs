using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            int maxCounter = 0;

            int maxNumbers = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentNumber = arr[i];
                int counter = 1;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    int rightNumber = arr[j];

                    if (currentNumber == rightNumber)
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    maxNumbers = currentNumber;
                }
            }
            for (int i = 0; i < maxCounter; i++)
            {
                Console.Write($"{maxNumbers} ");
            }
        }
    }
}
