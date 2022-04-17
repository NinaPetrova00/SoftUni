using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideSize = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            double allArea = sideSize * sideSize * 6;
            int count = 0;

            double coveredArea = 0;

            for (int i = 0; i < n; i++)
            {
                double length = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());

                count++;
                double areaPerSheet = length * width;

                if (count != 0 && count % 3 == 0 && count % 5 == 0)
                {
                    areaPerSheet = 0;
                }
                else if (count % 3 == 0 && count != 0)
                {
                    areaPerSheet -= areaPerSheet / 4;
                }
                else if (count % 5 == 0 && count != 0)
                {
                    areaPerSheet = 0;
                }
                coveredArea += areaPerSheet;
            }

            if (coveredArea >= allArea)
            {
                Console.WriteLine($"You've covered the gift box!" + "\n" +
                    $"{((coveredArea - allArea) / coveredArea*100).ToString("f2")}% wrap paper left.");
            }
            else
            {
                Console.WriteLine($"You are out of paper!");
                Console.WriteLine($"{((allArea - coveredArea) / allArea*100).ToString("f2")}% of the box is not covered.");
            }
        }
        }
    }
}
