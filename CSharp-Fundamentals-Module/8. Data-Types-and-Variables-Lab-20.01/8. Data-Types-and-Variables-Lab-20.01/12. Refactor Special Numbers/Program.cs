using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            bool isSpecial = false;

            for (int i = 1; i <= num; i++)
            {
                int temp = i;
                int sum = 0;
                while (temp > 0)
                {
                  int digit= temp %10;
                    sum += digit;

                    temp /= 10;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine($"{i} -> {isSpecial}");
            }

        }
    }
}
