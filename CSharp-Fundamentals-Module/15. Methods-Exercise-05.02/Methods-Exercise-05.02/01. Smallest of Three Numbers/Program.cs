using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            Console.WriteLine(Smallest(first, second, third));
        }

        private static int Smallest(int first, object second, int third)
        {
            int smallest = Math.Min((int)first, (int)second);

            return Math.Min(smallest, third);
        }
    }
}
