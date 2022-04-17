using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string line = Console.ReadLine();

                string[] text = line.Split();

                if (text[0] == "end")
                {
                    break;
                }

          
                if (text[0] == "Add")
                {
                    int passengers = int.Parse(text[1]);
                    AddPassengers(wagons, passengers);
                }
                else
                {
                    int passengers = int.Parse(text[0]);

                  for(int i=0;i<wagons.Count;i++)
                    {
                        if (wagons[i] + passengers <=maxCapacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }

            }

            Console.WriteLine(string.Join(" ",wagons));
        }

        static string AddPassengers(List<int> wagons, int passengers)
        {
            wagons.Add(passengers);

            string result = (string.Join(" ", wagons));

            return result;
        }
       

    }
}
