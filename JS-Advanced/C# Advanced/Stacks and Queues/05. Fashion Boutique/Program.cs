<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int capacity = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(clothes);

            int sum = 0;
            int racks = 1;

            while (stack.Count > 0)
            {
                int piece = stack.Pop();
                sum += piece;

                if (sum > capacity)
                {
                    sum = piece;
                    racks++;
                }

            }

            Console.WriteLine(racks);
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int capacity = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(clothes);

            int sum = 0;
            int racks = 1;

            while (stack.Count > 0)
            {
                int piece = stack.Pop();
                sum += piece;

                if (sum > capacity)
                {
                    sum = piece;
                    racks++;
                }

            }

            Console.WriteLine(racks);
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
