using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                  .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToArray();

            int givenNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                int currentNumber = arr[i];

                for (int j = i+1; j < arr.Length; j++)
                {
                    int rightNumber = arr[j];

                    if ((currentNumber + rightNumber) == givenNumber)
                    {
                        Console.Write($"{currentNumber} {rightNumber}");
                        Console.WriteLine();
                    }
                   
                }
            }
        }
    }
}
