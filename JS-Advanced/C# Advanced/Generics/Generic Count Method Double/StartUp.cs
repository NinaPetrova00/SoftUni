<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    class StartUp
    {
        static void Main(string[] args)
        {
            /* Task 3 and 4
           { var numberOfLines = int.Parse(Console.ReadLine());
            var list = new List<int>();

            for (int i = 0; i < numberOfLines; i++)
            {
                var input = int.Parse(Console.ReadLine());
                list.Add(input);
            }

            var box = new Box<int>(list);
            var indexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            box.Swap(list, indexes[0], indexes[1]);

            Console.WriteLine(box); } */


            /*Task 5 and 6*/
            var numberOfLines = int.Parse(Console.ReadLine());
            var list = new List<double>();

            for (int i = 0; i < numberOfLines; i++)
            {
                var input = double.Parse(Console.ReadLine());
                list.Add(input);
            }

            var box = new Box<double>(list);
            var elementToCompare = double.Parse(Console.ReadLine());
            var count = box.CountOfGreaterElements(list, elementToCompare);
            Console.WriteLine(count);
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    class StartUp
    {
        static void Main(string[] args)
        {
            /* Task 3 and 4
           { var numberOfLines = int.Parse(Console.ReadLine());
            var list = new List<int>();

            for (int i = 0; i < numberOfLines; i++)
            {
                var input = int.Parse(Console.ReadLine());
                list.Add(input);
            }

            var box = new Box<int>(list);
            var indexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            box.Swap(list, indexes[0], indexes[1]);

            Console.WriteLine(box); } */


            /*Task 5 and 6*/
            var numberOfLines = int.Parse(Console.ReadLine());
            var list = new List<double>();

            for (int i = 0; i < numberOfLines; i++)
            {
                var input = double.Parse(Console.ReadLine());
                list.Add(input);
            }

            var box = new Box<double>(list);
            var elementToCompare = double.Parse(Console.ReadLine());
            var count = box.CountOfGreaterElements(list, elementToCompare);
            Console.WriteLine(count);
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
