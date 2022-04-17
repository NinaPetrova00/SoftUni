using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            

            for (int i = 0; i < n; i++)
            {
                int[] rowValues = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rowValues[j];
                }
            }

            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;

            for (int i = 0; i < n; i++)
            {
                primaryDiagonal += matrix[i, i];
                secondaryDiagonal += matrix[i, n -i - 1];
            }

            Console.WriteLine(Math.Abs(primaryDiagonal-secondaryDiagonal));
        }
    }
}
