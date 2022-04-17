using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Multiply(n));
        }

        static int Multiply(int number)
        {
            int oddSum = 0;
            int evenSum = 0;

            while (number!= 0)
            {
                int digit;
                digit = number % 10;

                if (digit % 2 == 0)
                {
                    evenSum += digit;
                }
                else
                {
                    oddSum += digit;
                }
                number /= 10;
            }
            return oddSum * evenSum;
        }
    }
}
