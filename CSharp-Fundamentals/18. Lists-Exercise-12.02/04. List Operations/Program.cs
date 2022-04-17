using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
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

                if (line == "End")
                {
                    break;
                }

                string[] command = line.Split();

                if (command[0] == "Add")
                {
                    int n = int.Parse(command[1]);

                    numbers.Add(n);
                }
                else if (command[0] == "Insert")
                {
                    int n = int.Parse(command[1]);
                    int index = int.Parse(command[2]);

                    if (index >= numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.Insert(index, n);
                }
                else if (command[0] == "Remove")
                {
                    int index = int.Parse(command[1]);
                    if (index >= numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.RemoveAt(index);
                }
                else if (command[0] == "Shift")
                {
                    int count = int.Parse(command[2]);

                    if (command[1] == "left")
                    {

                        for (int i = 0; i < count; i++)
                        {
                            int firstNum = numbers[0];

                            numbers.RemoveAt(0);
                            numbers.Add(firstNum);


                        }
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int lastNum = numbers[numbers.Count - 1];
                            numbers.RemoveAt(numbers.Count - 1);
                            numbers.Insert(0, lastNum);

                        }
                    }
                }

            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
