using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._P_rates
{
    public class Town
    {
        public string Name { get; set; }
        public long Gold { get; set; }
        public long Population { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Town> towns = ReadTowns();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] parts = line.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string command = parts[0];
                string townName = parts[1];

                Town town = towns[townName];

                if (command == "Plunder")
                {
                    int people = int.Parse(parts[2]);
                    int gold = int.Parse(parts[3]);
                     
                    town.Gold -= gold;
                    town.Population -= people;

                    Console.WriteLine($"{townName} plundered! {gold} gold stolen, {people} citizens killed.");

                    if (town.Gold == 0 || town.Population == 0)
                    {
                        towns.Remove(townName);

                        Console.WriteLine($"{townName} has been wiped off the map!");
                    }

                }
                else if (command == "Prosper")
                {
                    int gold = int.Parse(parts[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                        continue;
                    }

                    town.Gold += gold;
                    Console.WriteLine($"{gold} gold added to the city treasury. {townName} now has {town.Gold} gold.");
                }
            }

            Dictionary<string, Town> sorted = towns
                .OrderByDescending(t => t.Value.Gold)
                .ThenBy(t => t.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            if (sorted.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {sorted.Count} wealthy settlements to go to:");

                foreach (Town town in sorted.Values)
                {
                    Console.WriteLine($"{town.Name} -> Population: {town.Population} citizens, Gold: {town.Gold} kg");
                }
            }
        }

        private static Dictionary<string, Town> ReadTowns()
        {
            Dictionary<string, Town> towns = new Dictionary<string, Town>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Sail")
                {
                    break;
                }

                string[] parts = line.Split("||", StringSplitOptions.RemoveEmptyEntries);

                string townName = parts[0];
                long population = long.Parse(parts[1]);
                long gold = long.Parse(parts[2]);

                if (towns.ContainsKey(townName))
                {
                    Town town = towns[townName];

                    town.Population += population;
                    town.Gold += gold;

                }
                else
                {
                    Town town = new Town
                    {
                        Name = townName,
                        Population = population,
                        Gold = gold
                    };

                    towns.Add(townName, town);
                }
            }
            return towns;
        }
    }
}
