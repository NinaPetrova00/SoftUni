using System;
using System.Linq;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
          /*  { //T01
                string name = "Ivan";
                int age = 21;

                Person p1 = new Person()
                {
                    Name = name,
                    Age = age
                };

                Console.WriteLine($"{p1.Name} -> {p1.Age}");
                Console.WriteLine("---------------------------------------------");
            }

            { //T02
                var p2 = new Person();
                Console.WriteLine($"P1: {p2.Name} -> {p2.Age}");

                var p3 = new Person(24);
                Console.WriteLine($"P3: {p3.Name} -> {p3.Age}");

                var p4 = new Person("Ivan", 26);
                Console.WriteLine($"P4: {p4.Name} -> {p4.Age}");
                Console.WriteLine("---------------------------------------------");
            }
            */
           
                int n = int.Parse(Console.ReadLine());
                var family = new Family();

                for (int i = 0; i < n; i++)
                {
                    var cmdArgs = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    string name = cmdArgs[0];
                    int age = int.Parse(cmdArgs[1]);

                    var person = new Person(name, age);

                    family.AddMember(person);
                }
          /*  {//T03
                Console.WriteLine(family.GetOldestMember());
                Console.WriteLine("---------------------------------------------");
            }*/

            { //T04
                HashSet<Person> personABove30 = family.GetAllPepopleAbove30();
                Console.WriteLine(string.Join(Environment.NewLine,personABove30));
            }
        }
    }
}
