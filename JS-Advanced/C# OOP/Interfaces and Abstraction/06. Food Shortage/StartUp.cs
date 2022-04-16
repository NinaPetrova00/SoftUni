<<<<<<< HEAD
﻿using System;
using System.Linq;
using _04.BorderControl.Models;
using _04.BorderControl.Interfaces;
using System.Collections.Generic;

namespace _04.BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<IBuyer> buyers = new List<IBuyer>();

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();


                if (parts.Length == 4)
                {
                    //Citizens
                    string name = parts[0];
                    int age = int.Parse(parts[1]);
                    string id = parts[2];
                    string birthdateCitizen = parts[3];

                    buyers.Add(new Citizens(name, age, id, birthdateCitizen));
                }
                else if (parts.Length == 3)
                {
                    //Rebels
                    string name = parts[0];
                    int age = int.Parse(parts[1]);
                    string group = parts[2];
                    buyers.Add(new Rebel(name, age, group));
                }
            }

            int sum = 0;
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }


                foreach (var buyer in buyers)
                {
                    string name = buyer.Name;

                    if (command == name)
                    {
                      buyer.BuyFood();
                        sum += buyer.Food;
                    }

                }
            }

            Console.WriteLine(sum);
        }
    }
}
=======
﻿using System;
using System.Linq;
using _04.BorderControl.Models;
using _04.BorderControl.Interfaces;
using System.Collections.Generic;

namespace _04.BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<IBuyer> buyers = new List<IBuyer>();

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();


                if (parts.Length == 4)
                {
                    //Citizens
                    string name = parts[0];
                    int age = int.Parse(parts[1]);
                    string id = parts[2];
                    string birthdateCitizen = parts[3];

                    buyers.Add(new Citizens(name, age, id, birthdateCitizen));
                }
                else if (parts.Length == 3)
                {
                    //Rebels
                    string name = parts[0];
                    int age = int.Parse(parts[1]);
                    string group = parts[2];
                    buyers.Add(new Rebel(name, age, group));
                }
            }

            int sum = 0;
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }


                foreach (var buyer in buyers)
                {
                    string name = buyer.Name;

                    if (command == name)
                    {
                      buyer.BuyFood();
                        sum += buyer.Food;
                    }

                }
            }

            Console.WriteLine(sum);
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
