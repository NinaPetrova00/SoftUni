using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int origNum = num;
          
            int fact = 1;
            int sum = 0;

            int digit;

            while (origNum > 0)
            {
                digit = origNum % 10;
                for(int i = 1; i <= digit; i++)
                {
                    fact *= i;
                }
                sum += fact;
                fact = 1;
                origNum /= 10;
            }

            if (num == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            


        }
    }
}
