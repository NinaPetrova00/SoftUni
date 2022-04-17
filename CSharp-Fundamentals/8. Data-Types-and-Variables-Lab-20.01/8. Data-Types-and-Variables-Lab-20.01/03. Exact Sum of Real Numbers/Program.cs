using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            decimal sum = 0;

            for (int i = 1; i <= num; i++)
            {
                double newNum = double.Parse(Console.ReadLine());
                sum += (decimal)newNum;
            }
            Console.WriteLine($"{sum}");
        }
    }
}
