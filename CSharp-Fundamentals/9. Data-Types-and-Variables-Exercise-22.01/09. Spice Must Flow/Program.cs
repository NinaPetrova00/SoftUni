using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());

            if (yield < 100)
            {
                Console.WriteLine(0);
                Console.WriteLine(0);
            }
            else
            {
                int days = 0;

                int totalAmount = 0;

                int consumation = 0;

                while (yield >= 100)
                {
                    consumation = yield - 26;
                    totalAmount += consumation;
                    days++;
                    yield -= 10;
                }

                totalAmount -= 26;
                Console.WriteLine(days);
                Console.WriteLine(totalAmount);
            }
        }
    }
}
