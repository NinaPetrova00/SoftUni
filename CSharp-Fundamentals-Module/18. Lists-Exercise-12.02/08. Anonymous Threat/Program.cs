using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> elements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();


            while (true)
            {
                string line = Console.ReadLine();

                if (line == "3:1")
                {
                    break;
                }

                string[] commands = line.Split();

                if (commands[0] == "merge")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);

                    if (startIndex >= elements.Count || endIndex < 0)
                    {
                        continue;
                    }

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }

                    if (endIndex >= elements.Count)
                    {
                        endIndex = elements.Count - 1;
                    }

                    string merged = string.Empty;

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        string element = elements[i];
                        merged += element;
                    }

                    elements.RemoveRange(startIndex, endIndex - startIndex + 1);
                    elements.Insert(startIndex, merged);

                }
                else
                {
                    int index = int.Parse(commands[1]);
                    int partitions = int.Parse(commands[2]);

                    string element = elements[index];

                    elements.RemoveAt(index);

                    int partitionsSize = element.Length / partitions;

                    List<string> substrings = new List<string>();

                    for (int i = 0; i < partitions - 1; i++)
                    {
                        string subtring = element.Substring(i * partitionsSize, partitionsSize);
                        substrings.Add(subtring);

                    }
                    string lastSubstrin = element.Substring((partitions-1)*partitionsSize);
                    substrings.Add(lastSubstrin);
                    elements.InsertRange(index,substrings);
                }
            }
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
