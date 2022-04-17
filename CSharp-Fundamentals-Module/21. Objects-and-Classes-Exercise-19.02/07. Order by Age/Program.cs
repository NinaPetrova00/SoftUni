using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{

    public class Persons
    {
        public string Name { get; set; }

        public string ID { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Persons> persons = new List<Persons>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }
                string[] parts = line.Split();

                Persons person = new Persons
                {

                    Name = parts[0],
                    ID = parts[1],
                    Age = int.Parse(parts[2])

                };


                persons.Add(person);
            }

            List<Persons> sortedPersons = persons
                .OrderByDescending(x => x.Age)
                .Reverse()
                .ToList();

            foreach (var person in sortedPersons)
            {
                Console.WriteLine(person);
            }



        }
    }
}
