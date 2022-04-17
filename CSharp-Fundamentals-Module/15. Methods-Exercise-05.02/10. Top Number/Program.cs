using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (TopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool TopNumber(int num)
        {
           
            bool isOddDigitFound = false;
            int sum = 0;

            while (num != 0)
            {
                int digit = num % 10;

                if (digit % 2 != 0)
                {
                    isOddDigitFound = true;
                }

                sum += digit;

                num /= 10;
            }

            if(sum%8==0 && isOddDigitFound)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
