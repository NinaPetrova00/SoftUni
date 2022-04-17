using System;
using System.Collections.Generic;
using System.Text;

namespace _04.PizzaCalories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;
        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }
        public string FlourType
        {
            get => this.flourType;

            private set
            {
                if (value.ToLower() != "white"&& value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
               this.flourType = value;
            }
        }
        public string BakingTechnique
        {
            get => this.bakingTechnique;

            set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.bakingTechnique = value;
            }
        }
        public double Weight
        {
            get => this.weight;

            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                this.weight = value;
            }
        }

        public double GetDoughGrams
        {
            get
            {
                return this.CaluclateDoughGrams();
            }
        }
        private double CaluclateDoughGrams()
        {
            double flourModifier = 0.0;
            double bakeModifier = 0.0;

            double grams = this.Weight * 2;

            if (this.FlourType.ToLower() == "white")
            {
                flourModifier = 1.5;
            }
            else if (this.FlourType.ToLower() == "wholegrain")
            {
                flourModifier = 1.0;
            }

            if (this.BakingTechnique.ToLower() == "crispy")
            {
                bakeModifier = 0.9;
            }
            else if (this.BakingTechnique.ToLower() == "chewy")
            {
                bakeModifier = 1.1;
            }
            else if (this.BakingTechnique.ToLower() == "homemade")
            {
                bakeModifier = 1.0;
            }

            double result = grams * bakeModifier * flourModifier;

            return result;
        }
    }
}
