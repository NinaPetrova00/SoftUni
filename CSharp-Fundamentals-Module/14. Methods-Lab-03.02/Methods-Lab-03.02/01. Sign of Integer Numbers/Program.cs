using System;

namespace _01._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Sign(num);
        }

        static void Sign(int num)
        {
            string numType = " ";
            if (num > 0)
            {
                numType ="positive";
            }
            else if (num < 0)
            {
                numType = "negative";
            }
            else if (num == 0)
            {
                numType = "zero";
            }
            Console.WriteLine($"The number {num} is {numType}.");

        }
    }
}
