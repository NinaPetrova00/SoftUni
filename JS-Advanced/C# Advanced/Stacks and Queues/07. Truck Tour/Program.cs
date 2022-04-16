<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int[]> petrolPumps = new Queue<int[]>();

            int countOfPetrolPumps = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfPetrolPumps; i++)
            {
                int[] currentPetrolPump = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                petrolPumps.Enqueue(currentPetrolPump);
            }
            int index = 0;

            while (true)
            {
                int totoalFuel = 0;

                foreach (int[] currentPetrolPump in petrolPumps)
                {
                    int petrolAmount = currentPetrolPump[0];
                    int distance = currentPetrolPump[1];

                    totoalFuel += petrolAmount - distance;

                    if (totoalFuel < 0)
                    {
                        petrolPumps.Enqueue(petrolPumps.Dequeue());
                        index++;
                        break;
                    }
                }

                if (totoalFuel >= 0)
                {
                    break;
                }
            }
            Console.WriteLine(index);
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int[]> petrolPumps = new Queue<int[]>();

            int countOfPetrolPumps = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfPetrolPumps; i++)
            {
                int[] currentPetrolPump = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                petrolPumps.Enqueue(currentPetrolPump);
            }
            int index = 0;

            while (true)
            {
                int totoalFuel = 0;

                foreach (int[] currentPetrolPump in petrolPumps)
                {
                    int petrolAmount = currentPetrolPump[0];
                    int distance = currentPetrolPump[1];

                    totoalFuel += petrolAmount - distance;

                    if (totoalFuel < 0)
                    {
                        petrolPumps.Enqueue(petrolPumps.Dequeue());
                        index++;
                        break;
                    }
                }

                if (totoalFuel >= 0)
                {
                    break;
                }
            }
            Console.WriteLine(index);
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
