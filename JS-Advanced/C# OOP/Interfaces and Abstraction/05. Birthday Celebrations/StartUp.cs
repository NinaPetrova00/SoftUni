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
            List<IBirthdate> society = new List<IBirthdate>();

            while (true)
            {
                string[] parts = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();

                if (parts[0] == "End")
                {
                    break;
                }

                string classType = parts[0];

                if (classType == "Citizen")
                {                 
                    string name = parts[1];
                    int age = int.Parse(parts[2]);
                    string id = parts[3];
                    string birthdateCitizen = parts[4];
                    society.Add(new Citizens(name, age, id, birthdateCitizen));
                }
                else if (classType == "Robot")
                {                   
                    string name = parts[1];
                    string id = parts[2];                 
                }
                else if (classType == "Pet")
                {
                    string name = parts[1];
                    string birthdatePet = parts[2];
                    society.Add(new Pet(name, birthdatePet));
                }
            }

            string birthdate = Console.ReadLine();

            foreach (var inhabitant in society)
            {
                if (inhabitant.Birthdate.EndsWith(birthdate))
                {
                    Console.WriteLine(inhabitant.Birthdate);
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
            List<IBirthdate> society = new List<IBirthdate>();

            while (true)
            {
                string[] parts = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();

                if (parts[0] == "End")
                {
                    break;
                }

                string classType = parts[0];

                if (classType == "Citizen")
                {                 
                    string name = parts[1];
                    int age = int.Parse(parts[2]);
                    string id = parts[3];
                    string birthdateCitizen = parts[4];
                    society.Add(new Citizens(name, age, id, birthdateCitizen));
                }
                else if (classType == "Robot")
                {                   
                    string name = parts[1];
                    string id = parts[2];                 
                }
                else if (classType == "Pet")
                {
                    string name = parts[1];
                    string birthdatePet = parts[2];
                    society.Add(new Pet(name, birthdatePet));
                }
            }

            string birthdate = Console.ReadLine();

            foreach (var inhabitant in society)
            {
                if (inhabitant.Birthdate.EndsWith(birthdate))
                {
                    Console.WriteLine(inhabitant.Birthdate);
                }
            }
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
