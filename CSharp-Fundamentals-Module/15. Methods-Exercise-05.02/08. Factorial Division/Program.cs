using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(FactorialDevision(a,b));

        }

        static string FactorialDevision(int a, int b)
        {
            double firstFactorial = 1;
            for (int i = 2; i <= a; i++)
            {
                firstFactorial *= i;
            }

            double secondFactorial = 1;

            for (int i = 2; i <= b; i++)
            {
                secondFactorial *= i;
            }

            double result = (double)firstFactorial / secondFactorial;

            string str;
            str = $"{result:f2}";

            return str;
        }
    }
}
