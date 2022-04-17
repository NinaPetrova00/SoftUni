using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] queries = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

                int command = queries[0];

                switch (command)
                {
                    case 1:
                        int x = queries[1];
                        stack.Push(x);
                        break;

                    case 2:
                        if (stack.Count > 0)
                        {
                            stack.Pop();
                        }                
                        break;

                    case 3:
                        if (stack.Count > 0) Console.WriteLine(stack.Max());
                        break;

                    case 4:
                        if (stack.Count > 0) Console.WriteLine(stack.Min());
                        break;
                }
            }
            
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
