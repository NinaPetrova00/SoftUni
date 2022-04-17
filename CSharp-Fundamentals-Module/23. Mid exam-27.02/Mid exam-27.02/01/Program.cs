using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double finalPrice = 0.0;

            double totalPrice = 0.0;

            for (int i = 0; i < n; i++)
            {
                double pricePerCapsule= double.Parse(Console.ReadLine());
                int days= int.Parse(Console.ReadLine());
                int capsulesCount= int.Parse(Console.ReadLine());

                finalPrice = ((days * capsulesCount) * pricePerCapsule);

                Console.WriteLine($"The price for the coffee is: ${finalPrice:f2}");

                totalPrice += finalPrice;
                finalPrice = 0.0;

            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
