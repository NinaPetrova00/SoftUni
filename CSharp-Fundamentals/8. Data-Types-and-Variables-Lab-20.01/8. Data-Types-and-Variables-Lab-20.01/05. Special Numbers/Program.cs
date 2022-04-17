using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            bool isSpecial = false;

            int sum = 0;

            for (int i = 1; i <= num; i++)
            {
                int temp = i;
                while (temp > 0)
                {
                   int digit= temp%10;

                    sum += digit;
                    temp /= 10;
                }
                if(sum==5||sum==7|| sum == 11)
                {
                    isSpecial = true;
                }
                else
                {
                    isSpecial = false;
                }
                Console.WriteLine($"{i} -> {isSpecial}");
                sum = 0;
            }

           
        }
    }
}
