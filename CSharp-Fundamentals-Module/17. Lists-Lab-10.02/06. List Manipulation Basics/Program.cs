using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
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
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] tokens = command.Split();
                
                if (tokens[0] == "Add")
                {
                    int num = int.Parse(tokens[1]);
                    AddNum(numbers, num);
                  
                }
                else if (tokens[0] == "Remove")
                {
                    int num = int.Parse(tokens[1]);
                    RemoveNum(numbers, num);
                    
                }
                else if (tokens[0] == "RemoveAt")
                {
                    int index = int.Parse(tokens[1]);
                    RemoveAtNum(numbers, index);
                  
                }
                else if (tokens[0] == "Insert")
                {
                    int num = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);

                    InsertNum(numbers, num, index);
                   
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        static List<int> AddNum(List<int> numbers, int num)
        {
            numbers.Add(num);

            return numbers;
        }

        static List<int> RemoveNum(List<int> numbers, int num)
        {
            numbers.Remove(num);

            return numbers;
        }

        static List<int> RemoveAtNum(List<int> numbers, int index)
        {
            numbers.RemoveAt(index);

            return numbers;
        }

        static List<int> InsertNum(List<int> numbers, int num, int index)
        {

            numbers.Insert(index, num);

            return numbers;
        }
    }
}
