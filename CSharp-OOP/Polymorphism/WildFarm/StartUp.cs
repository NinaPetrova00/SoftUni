using System;
using System.Collections.Generic;
using System.Linq;

namespace WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] animalParts = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string animalType = animalParts[0];
                string name = animalParts[1];
                double weight = double.Parse(animalParts[2]);

                if (animalType == "Cat")
                {
                    string livingRegion = animalParts[3];
                    string breed = animalParts[4];
                    animals.Add(new Cat(name, weight, livingRegion, breed));
                }
                else if (animalType == "Tiger")
                {
                    string livingRegion = animalParts[3];
                    string breed = animalParts[4];
                }
                else if (animalType == "Owl")
                {
                    double wingSize = double.Parse(animalParts[3]);
                }
                else if (animalType == "Hen")
                {
                    double wingSize = double.Parse(animalParts[3]);
                }
                else if (animalType == "Mouse")
                {
                    string livingRegion = animalParts[3];
                }
                else if (animalType == "Dog")
                {
                    string livingRegion = animalParts[3];
                }      
            }
        }
    }
}
