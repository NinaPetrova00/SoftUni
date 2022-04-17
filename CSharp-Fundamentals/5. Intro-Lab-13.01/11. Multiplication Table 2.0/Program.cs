using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int multi = int.Parse(Console.ReadLine());

            if (multi < 10)
            {
                for (int i = multi; i <= 10; i++)
                {
                    Console.WriteLine($"{num} X {i} = {num * i}");
                }
            }
            else
            {
                Console.WriteLine($"{num} X {multi} = {num*multi}");
            }
        }
    }
}
