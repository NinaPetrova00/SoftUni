using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CocktailParty
{
    public class Cocktail
    {
        List<Ingredient> Ingredients;

        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.MaxAlcoholLevel = maxAlcoholLevel;
            this.Ingredients = new List<Ingredient>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int MaxAlcoholLevel { get; set; }
        public int CurrentAlcoholLevel { get; set; } = 0;

        public void Add(Ingredient ingredient)
        {
            if ((!(this.Ingredients.Exists(x => x.Name == ingredient.Name)))
                && CurrentAlcoholLevel + ingredient.Alcohol <= this.MaxAlcoholLevel
                && this.Ingredients.Count < this.Capacity)
            {
                this.Ingredients.Add(ingredient);
                CurrentAlcoholLevel += ingredient.Alcohol;
            }
        }

        public bool Remove(string name)
        {
            if (this.Ingredients.Any(x => x.Name == name))
            {
                CurrentAlcoholLevel -= Ingredients.First(x => x.Name == name).Alcohol;
            }
            return this.Ingredients
            .Remove(this.Ingredients
                .FirstOrDefault(x => x.Name == name));
        }


        public Ingredient FindIngredient(string name)
         => this.Ingredients.FirstOrDefault(x => x.Name == name);
        //{
        //    string result;
        //    if (this.Ingredients.Contains(this.Ingredients.FirstOrDefault(x => x.Name == name)))
        //    {
        //        Ingredient currentInrg = this.Ingredients.FirstOrDefault(x => x.Name == name);
        //    }
        //    else
        //    {
        //        result = null;
        //    }

        //    return result;
        //}

        public Ingredient GetMostAlcoholicIngredient()
        {
            if (this.Ingredients.Count > 0)
            {
                return this.Ingredients
                    .OrderByDescending(x => x.Alcohol)
                    .FirstOrDefault();
            }
            return null;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cocktail: {this.Name} - Current Alcohol Level: {CurrentAlcoholLevel}");

            foreach (Ingredient ingredient in Ingredients)
            {
                sb.AppendLine(ingredient.ToString());
            }
            /*
             "Cocktail: {name} - Current Alcohol Level: {CurrentAlcoholLevel}
             {Ingredient1}
             {Ingredient2}
                         … "
             */

            return sb.ToString().TrimEnd();
        }
    }
}
