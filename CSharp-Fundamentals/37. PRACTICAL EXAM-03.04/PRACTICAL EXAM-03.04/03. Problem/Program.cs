using System;
using System.Collections.Generic;
using System.Linq;
namespace _03._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> allGuests = new Dictionary<string, List<string>>();

            int counter = 0;

            while (true)
            {
                string line = Console.ReadLine()
;
                if (line == "Stop")
                {
                    break;
                }

                string[] parts = line.Split("-", StringSplitOptions.RemoveEmptyEntries);

                string command = parts[0];
                string guest = parts[1];
                string meal = parts[2];

                if (command == "Like")
                {
                    if (!allGuests.ContainsKey(guest))
                    {
                        allGuests[guest] = new List<string>();
                        allGuests[guest].Add(meal);
                    }
                    else if (!allGuests[guest].Contains(meal))
                    {
                        allGuests[guest].Add(meal);
                    }
                }
                else if (command == "Dislike")
                {
                    if (allGuests.ContainsKey(guest))
                    {

                        if (allGuests[guest].Contains(meal))
                        {
                            counter++;
                            allGuests[guest].Remove(meal);
                            Console.WriteLine($"{guest} doesn't like the {meal}.");
                        }
                        else
                        {
                            Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                        }
                    }
                    else if (!allGuests.ContainsKey(guest))
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }
                }

              
                
            }
            Dictionary<string, List<string>> sorted = allGuests
                    .OrderByDescending(x => x.Value.Count)
                    .ThenBy(x => x.Key)
                    .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in sorted)
            {
                Console.Write($"{kvp.Key}: ");

                Console.WriteLine(string.Join(", ", kvp.Value));
            }

            Console.WriteLine($"Unliked meals: {counter}");

        }
    }
}

