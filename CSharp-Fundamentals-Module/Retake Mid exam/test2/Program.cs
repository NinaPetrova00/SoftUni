using System;
using System.Collections.Generic;
using System.Linq;
namespace test2
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
                string[] parts = line
                    .Split(" ");

                if (line.Contains("add to start"))
                {
                    List<int> array = new List<int>();
                    for (int i = 3; i < parts.Length; i++)
                    {
                        array.Add(int.Parse(parts[i]));
                    }

                    numbers.InsertRange(0, array);
                }
                else if (line.Contains("add to end"))
                {
                    List<int> array = new List<int>();
                    for (int i = 3; i < parts.Length; i++)
                    {
                        array.Add(int.Parse(parts[i]));
                    }
                    numbers.AddRange(array);
                }
                else if (line.Contains("remove lower than"))
                {
                    int value = int.Parse(parts[3]);
                    List<int> delete = new List<int>();
                    foreach (int item in numbers)
                    {
                        if (item < value)
                        {
                            delete.Add(item);
                        }
                    }
                    for (int i = 0; i < delete.Count; i++)
                    {
                        numbers.Remove(delete[i]);
                    }
                }
                else if (line.Contains("remove greater than"))
                {
                    int value = int.Parse(parts[3]);
                    List<int> delete = new List<int>();
                    foreach (int item in numbers)
                    {
                        if (item > value)
                        {
                            delete.Add(item);
                        }
                    }
                    for (int i = 0; i < delete.Count; i++)
                    {
                        numbers.Remove(delete[i]);
                    }
                }
                else if (parts[0] == "replace")
                {
                    int value = int.Parse(parts[1]);
                    int replacment = int.Parse(parts[2]);

                    if (numbers.Contains(value))
                    {
                        foreach (int n in numbers)
                        {
                            if (n == value)
                            {
                                int index = numbers.IndexOf(n);
                                numbers[index] = replacment;
                                break;
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                    Console.WriteLine(string.Join(" ", numbers));
                }
                else if (line.Contains("remove at index"))
                {
                    int index = int.Parse(parts[3]);
                    if (index < 0 || index > numbers.Count - 1)
                    {
                        continue;
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }
                }
                else if (line.Contains("remove count"))
                {
                    int count = int.Parse(parts[2]);

                    if (count >= numbers.Count)
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            numbers.RemoveAt(i);
                            i--;
                        }
                    }
                    else //count < numbers.count 
                    {
                        numbers.Reverse();
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Remove(numbers[0]);
                        }
                        numbers.Reverse();
                    }
                }
                else if (line.Contains("find even"))
                {
                    List<int> array = new List<int>();
                    foreach (int item in numbers)
                    {
                        if (item != 0 && item % 2 == 0)
                        {
                            array.Add(item);
                        }
                    }
                    Console.WriteLine(string.Join(" ", array));
                }
                else if (line.Contains("find odd"))
                {
                    List<int> array = new List<int>();
                    foreach (int item in numbers)
                    {
                        if (item != 0 && item % 2 != 0)
                        {
                            array.Add(item);
                        }
                    }
                    Console.WriteLine(string.Join(" ", array));
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
