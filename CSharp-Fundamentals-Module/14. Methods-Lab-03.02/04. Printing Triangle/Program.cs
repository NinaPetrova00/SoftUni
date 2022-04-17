using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                PrintTriangle(i);
            }

            for (int i = num - 1; i > 0; i--)
            {
                PrintTriangle(i);
            }

        }

        static void PrintTriangle(int num)
        {

            for (int i = 1; i <= num; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
