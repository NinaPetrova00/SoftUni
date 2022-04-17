using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideSize = double.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());

            double allArea = sideSize * sideSize * 6;

            double coveredArea = 0.0;

            double areaPerSheet = 0.0;


            for (int i = 1; i <= n; i++)
            {

                double length = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());

                areaPerSheet = length * width;

                if (i % 3 == 0)
                {

                    areaPerSheet = areaPerSheet - areaPerSheet * 0.25;
                }
                else if (i % 5 == 0)
                {
                    areaPerSheet = 0.0;
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    areaPerSheet = 0.0;
                }

                coveredArea += areaPerSheet;

                //areaPerSheet = 0.0;

            }

            if (coveredArea >= allArea)
            {
                double percetange = (allArea / coveredArea) * 100.0;


                Console.WriteLine("You've covered the gift box!");

                Console.WriteLine($"{(100.0 - percetange):f2}% wrap paper left.");

            }
            else
            {
                double percentage = (coveredArea / allArea) * 100.0;


                Console.WriteLine("You are out of paper!");

                Console.WriteLine($"{(100.0 - percentage):f2}% of the box is not covered.");


            }
        }
    }
}
