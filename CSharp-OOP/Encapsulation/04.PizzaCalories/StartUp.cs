using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Topping> toppings = new List<Topping>();
            string input = Console.ReadLine();

            var tokens = input
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .ToArray();

            string pizzaName = tokens[1];

            var doughTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .ToArray();

            string flourType = doughTokens[1];
            string bakedTechnique = doughTokens[2];
            double doughGrams = int.Parse(doughTokens[3]);

            try
            {
                Dough dough = new Dough(flourType, bakedTechnique, doughGrams);
                Pizza pizza = new Pizza(pizzaName, dough);
                while (true)
                {


                    if (input == "END")
                    {
                        break;
                    }

               
                    var toppingTokens = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();
                    if (toppingTokens[0] == "END")
                    {
                        break;
                    }
                    string toppingType = toppingTokens[1];
                    int toppingWeight = int.Parse(toppingTokens[2]);

                    Topping topping = new Topping(toppingType, toppingWeight);

                    pizza.AddTopping(topping);
                   
                }
                Console.WriteLine(pizza);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
/*
Dough
White
Chewy
100
 */