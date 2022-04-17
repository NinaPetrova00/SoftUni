using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                

            int rotations = int.Parse(Console.ReadLine());

            for (int j = 0; j < rotations; j++)
            {
                string firstElement = arr[0];

                for (int i = 1; i < arr.Length; i++)
                {
                    int prevIndex = i - 1;
                    arr[prevIndex] = arr[i];

                }
                arr[arr.Length - 1] = firstElement;

            }
            foreach (var element in arr)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }
    }
}
