using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());


            switch (line)
            {
                case "add":
                    Console.WriteLine(Add(a,b));
                    break;

                case "multiply":
                    Console.WriteLine(Multiply(a,b));
                    break;

                case "subtract":
                    Console.WriteLine(Subtract(a,b));
                    break;

                default:
                    Console.WriteLine(Divide(a,b));
                    break;
            }
        }

        static int Add(int a,int b)
        {
            return a + b;
        }
        static int Multiply(int a, int b)
        {
            return a*b;
        }
        static double Divide(int a, int b)
        {
            return a/b;
        }
        static int Subtract(int a, int b)
        {
            return a- b;
        }

    }
}
