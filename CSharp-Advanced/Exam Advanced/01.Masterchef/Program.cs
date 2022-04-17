using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Masterchef
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredients = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            var freshness = new Stack<int>(Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse));

            int multiplication = 0;
            int cnt = 0;
            int chCake = 0;
            int dSauce = 0;
            int gSalad = 0;
            int lobster = 0;
            while (true)
            {
                if(ingredients.Count<=0 || freshness.Count <= 0)
                {
                    break;
                }
                string dish;

                int currentIngredient = ingredients.Peek();
                int currentFreshness = freshness.Peek();
                // multiplication = ingredients.Peek() * freshness.Peek();
                if (currentIngredient == 0)
                {
                    ingredients.Dequeue();
                    continue;
                }
                multiplication = currentIngredient * currentFreshness;

                if (multiplication == 150)
                {
                    dish = "Dipping sauce";
                    dSauce++;
                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else if (multiplication == 250)
                {
                    dish = "Green salad";
                    gSalad++;
                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else if (multiplication == 300)
                {
                    dish = "Chocolate cake";
                    chCake++;
                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else if (multiplication == 400)
                {
                    dish = "Lobster";
                    lobster++;
                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else
                {
                    freshness.Pop();
                    var increasedIngredient = ingredients.Peek() + 5;
                    ingredients.Dequeue();
                    ingredients.Enqueue(increasedIngredient);
                }

               
            }
            cnt = chCake + dSauce + gSalad + lobster;
            if (cnt >= 4)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
            }

            if (ingredients.Count > 0)
            {
                int sum = 0;
                foreach (int ingredint in ingredients)
                {
                    sum += ingredint;
                }
                Console.WriteLine($"Ingredients left: {sum}");
              
            }

            if (chCake > 0)
            {
                Console.WriteLine($" # Chocolate cake --> {chCake}");
            }
            if (dSauce > 0)
            {
                Console.WriteLine($" # Dipping sauce --> {dSauce}");
            }
            if (gSalad > 0)
            {
                Console.WriteLine($" # Green salad --> {gSalad}");
            }
            if (lobster > 0)
            {
                Console.WriteLine($" # Lobster --> {lobster}");
            }
        }
    }
}
