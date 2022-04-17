using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            int blacklistedCount = 0;
            int lostNamesCount = 0;

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Report")
                {
                    break;
                }

                string[] parts = line.Split();

                string command = parts[0];

                if (command == "Blacklist")
                {
                    string name = parts[1];
                    string orgName = name;

                    if (!names.Contains(name))
                    {
                        Console.WriteLine($"{name} was not found.");
                    }
                    else
                    {
                        for (int i = 0; i < names.Count; i++)
                        {
                            if (names[i] == name)
                            {
                                blacklistedCount++;
                                names[i] = "Blacklisted";
                                Console.WriteLine($"{orgName} was blacklisted.");
                                break;
                            }
                        }

                    }
                }
                else if (command == "Error")
                {
                    int index = int.Parse(parts[1]);

                    string currentName = names[index];

                    if ((currentName != "Blacklisted") &&(currentName != "Lost"))
                    {
                        lostNamesCount++;
                        names[index] = "Lost";
                        Console.WriteLine($"{currentName} was lost due to an error.");
                    }
                    


                }
                else if (command == "Change")
                {
                    int index = int.Parse(parts[1]);
                    string newName = parts[2];

                    string currentName = names[index];

                    if (index < names.Count)
                    {
                        for (int i = 0; i < names.Count; i++)
                        {
                            names[index] = newName;
                        }

                        Console.WriteLine($"{currentName} changed his username to {newName}.");
                    }
                }
            }
            Console.WriteLine($"Blacklisted names: {blacklistedCount}");
            Console.WriteLine($"Lost names: {lostNamesCount}");
            Console.WriteLine(string.Join(" ", names));


        }
    }
}
