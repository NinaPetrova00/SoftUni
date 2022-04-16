<<<<<<< HEAD
﻿using System;

namespace _01._Class_Box_Data
{
   public class StartUp
    {
        //TODO: 
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            try
            {
                Box box = new Box(length,width,height);
                Console.WriteLine(box.CalculateSurfaceArea());
                Console.WriteLine(box.CalculateLateralSurfaceArea());
                Console.WriteLine(box.CalculateVolume());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
=======
﻿using System;

namespace _01._Class_Box_Data
{
   public class StartUp
    {
        //TODO: 
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            try
            {
                Box box = new Box(length,width,height);
                Console.WriteLine(box.CalculateSurfaceArea());
                Console.WriteLine(box.CalculateLateralSurfaceArea());
                Console.WriteLine(box.CalculateVolume());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
