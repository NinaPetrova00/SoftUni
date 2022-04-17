using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .ToArray();

                int number = int.Parse(parts[0]);
                string command = parts[1];

               
                switch (number)
                {
                    case 1:
                        stack.Push(command);
                        break;

                    case 2:

                        break;
                }
                   

            }
        }
    }
}
