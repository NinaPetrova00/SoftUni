using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(Operation(a,str,b));
        }

        static double Operation(int a,string line,int b)
        {
            double result=0;
            switch (line)
            {
                case "/":
                  result = a / b;
                    break;

                case "*":
                   result= a * b;
                    break;

                case "+":
                  result= a + b;
                    break;

                case "-":
                  result= a - b;
                    break;
            }

            return result;
        }
    }
}
