using System;
using System.Collections.Generic;
using System.Linq;

namespace _02
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

                if (line == "END")
                {
                    break;
                }

                string[] parts = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = parts[0];


                if (command == "add")
                {
                    List<int> result = new List<int>();

                    if (parts[2] == "start")
                    {
                        for (int i = 3; i < parts.Length; i++)
                        {
                            result.Add(int.Parse(parts[i]));

                        }
                        numbers.InsertRange(0, result);
                    }
                    else if (parts[2] == "end")
                    {
                        for (int i = 3; i < parts.Length; i++)
                        {
                            result.Add(int.Parse(parts[i]));
                        }
                        numbers.AddRange(result);
                    }

                }
                else if (command == "remove")
                {
                    if (parts[1] == "lower")
                    {

                        int value = int.Parse(parts[3]);
                        numbers.RemoveAll(n => n < value);
                    }
                    else if (parts[1] == "greater")
                    {
                        int value = int.Parse(parts[3]);
                        numbers.RemoveAll(n => n > value);
                    }
                    else if (parts[1] == "at")
                    {
                        int index = int.Parse(parts[3]);

                        if (index >= 0 && index < numbers.Count)
                        {
                            numbers.RemoveAt(index);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (parts[1] == "count")
                    {
                        int count = int.Parse(parts[2]);

                        if (count < numbers.Count)
                        {
                            numbers.Reverse();
                            for (int i = 0; i < count; i++)
                            {

                                numbers.Remove(numbers[0]);
                            }
                            numbers.Reverse();
                        }
                        else
                        {
                            for(int i = 0; i < numbers.Count; i++)
                            {
                                numbers.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                }
                else if (command == "replace")
                {
                    int value = int.Parse(parts[1]);
                    int replacement = int.Parse(parts[2]);

                    if (numbers.Contains(value))
                    {
                        foreach (int n in numbers)
                        {
                            if (n == value)
                            {
                                int index1 = numbers.IndexOf(n);
                                numbers[index1] = replacement;
                                break;
                            }

                        }
                    }
                    else
                    {
                        continue;
                    }
                    /* int index1 = numbers.IndexOf(value);
                     int index2 = numbers.IndexOf(replacement);

                     numbers.Remove(value);
                     numbers.Remove(replacement);

                     int tmp = index1;
                     index1 = index2;
                     index2 = tmp;

                     numbers.Insert(index2,replacement);
                     numbers.Insert(index1, value);*/

                }
                else if (command == "find")
                {
                    if (parts[1] == "even")
                    {
                        Console.WriteLine(string.Join(" ", numbers.FindAll(n => n % 2 == 0)));
                    }
                    else if (parts[1] == "odd")
                    {
                        Console.WriteLine(string.Join(" ", numbers.FindAll(n => n % 2 != 0)));
                    }
                }
            }
            Console.WriteLine(string.Join(", ", numbers));

        }
    }
}
