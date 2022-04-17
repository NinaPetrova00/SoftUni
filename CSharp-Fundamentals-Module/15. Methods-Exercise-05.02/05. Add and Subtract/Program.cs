using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b= int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(AddSubtract(a,b,c));

        }

        static int AddSubtract(int first,int second,int third)
        {
            int sum = first + second;

            return sum -third;
        }
    }
}
