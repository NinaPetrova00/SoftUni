using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                  .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToArray();

            int originalLenght = arr.Length - 1;

            for (int i = 0; i < originalLenght; i++)
            {
                int[] condensed = new int[arr.Length-1];

                for (int j = 0; j < condensed.Length; j++)
                {
                    condensed[j] = arr[j] + arr[j + 1];
                }
                arr = condensed;
            }

            Console.WriteLine(arr[0]);
        }
    }
}
