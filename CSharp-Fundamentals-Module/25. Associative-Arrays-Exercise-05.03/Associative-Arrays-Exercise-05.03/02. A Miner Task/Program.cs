using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._A_Miner_Task
{
    class Program
    {
      
        static void Main(string[] args)
        {        
            Dicitionary<string, int> quantityByResource = new Dicitionary<string, int>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (quantityByResource.containskey(line))
                {
                    quantityByResource[line] += quantity;
                }
                else
                {
                    quantityByResource.Add(line, quantity);
                }


            }

            foreach (var kvp in quantityByResource)
            {
                Console.WriteLine($"{kvp.key} -> {kvp.value}");
            }
        }
    }
}
