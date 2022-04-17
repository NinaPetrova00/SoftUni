using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            Console.WriteLine(Price(product, quantity));
        }
        static string Price(string product, int quantity)
        {

            if (product == "coffee")
            {
                return $"{(1.50 * quantity):f2} ";
            }
            else if (product == "coke")
            {
                return $"{(1.40 * quantity):f2}";
            }
            else if (product == "water")
            {
                return $"{(1.00 * quantity):f2}";
            }
            else 
            {
                return $"{(2.00 * quantity):f2}";
            }


        }
    }
}
