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
            List<ISociety> society = new List<ISociety>();

            while (true)
            {
                string[] parts = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();

                if (parts[0] == "End")
                {
                    break;
                }

                if (parts.Length == 3)
                {
                    //Citizens
                    string name = parts[0];
                    int age = int.Parse(parts[1]);
                    string id = parts[2];
                    society.Add(new Citizens(name, age, id));
                }
                else
                {
                    //Robots
                    string name = parts[0];
                    string id = parts[1];
                    society.Add(new Robots(name, id));
                }
            }

            string fakeId = Console.ReadLine();

            foreach (var inhabitant in society)
            {
                string id = inhabitant.Id;

                if (id.EndsWith(fakeId))
                {
                    Console.WriteLine(inhabitant.Id);
                }
            }
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
            List<ISociety> society = new List<ISociety>();

            while (true)
            {
                string[] parts = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();

                if (parts[0] == "End")
                {
                    break;
                }

                if (parts.Length == 3)
                {
                    //Citizens
                    string name = parts[0];
                    int age = int.Parse(parts[1]);
                    string id = parts[2];
                    society.Add(new Citizens(name, age, id));
                }
                else
                {
                    //Robots
                    string name = parts[0];
                    string id = parts[1];
                    society.Add(new Robots(name, id));
                }
            }

            string fakeId = Console.ReadLine();

            foreach (var inhabitant in society)
            {
                string id = inhabitant.Id;

                if (id.EndsWith(fakeId))
                {
                    Console.WriteLine(inhabitant.Id);
                }
            }
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
