using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
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

                string[] tokens = line.Split();

                if (tokens[0] == "end")
                {
                    break;
                }

                if (tokens[0] == "Contains")
                {
                    int n = int.Parse(tokens[1]);
                    Contains(numbers, n);

                }
                else if (tokens[0] == "PrintEven")
                {
                    Console.WriteLine(Printeven(numbers));
                }
                else if (tokens[0] == "PrintOdd")
                {
                    Console.WriteLine(PrintOdd(numbers));
                }
                else if (tokens[0] == "GetSum")
                {
                    Console.WriteLine(GetSum(numbers));
                }
                else if (tokens[0] == "Filter")
                {
                    string condition = tokens[1];
                    int n = int.Parse(tokens[2]);

                    Console.WriteLine( GetFilter(numbers, condition, n));
                }
            }


        }

        static void Contains(List<int> numbers, int n)
        {
            bool flag = false;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == n)
                {
                    flag = true;
                    break;
                }
                else
                {

                }
            }

            if (flag)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }

        static string Printeven(List<int> numbers)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    result.Add(numbers[i]);
                }
            }
            return string.Join(" ", result);
        }

        static string PrintOdd(List<int> numbers)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    result.Add(numbers[i]);
                }
            }
            return string.Join(" ", result);
        }

        static int GetSum(List<int> numbers)
        {
            int sum = 0;

            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        static string GetFilter(List<int> numbers, string condtion, int n)
        {
            List<int> result = new List<int>();

            foreach (var number in numbers)
            {
                switch (condtion)
                {
                    case "<":
                        if (number < n)
                        {
                            result.Add(number);
                        }
                        break;

                    case ">":
                        if (number > n)
                        {
                            result.Add(number);
                        }
                        break;

                    case ">=":
                        if (number >= n)
                        {
                            result.Add(number);
                        }
                        break;

                    case "<=":
                        if (number <= n)
                        {
                            result.Add(number);
                        }
                        break;
                }
            }

            string output = string.Join(" ", result);

            return output;


        }
    }
}
