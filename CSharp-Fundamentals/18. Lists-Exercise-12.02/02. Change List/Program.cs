using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToList();

            while (true)
            {
                string line = Console.ReadLine();

                string[] command = line.Split();

                if (command[0] == "end")
                {
                    break;
                }

                int element = int.Parse(command[1]);

                if (command[0] == "Delete")
                {
                    numbers.RemoveAll(n=> n==element);
                }
                else
                {
                    int position = int.Parse(command[2]);

                    numbers.Insert(position, element);
                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }

        



    }
}
