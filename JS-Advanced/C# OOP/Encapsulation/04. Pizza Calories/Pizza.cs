<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;

namespace _04.PizzaCalories
{
    public class Pizza
    {
        public string name;

        private List<Topping> toppings = new List<Topping>();
        private Dough dough;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.dough = dough;
        }
        public string Name
        {
            get => this.name;

          private  set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }
        public void AddTopping(Topping currentTopping)
        {
            if (toppings.Count < 0 || toppings.Count > 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            toppings.Add(currentTopping);
        }

        public double GetTotalCalories()
        {
            double toppingCalories = 0.0;
            double doughCalories = dough.GetDoughGrams;

            foreach (var topping in toppings)
            {
                toppingCalories += topping.GetToppingGrams;
            }
            double result = doughCalories + toppingCalories;

            return result;
        }

        public override string ToString()
        {
            return $"{this.Name} - {GetTotalCalories():f2} Calories.";
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;

namespace _04.PizzaCalories
{
    public class Pizza
    {
        public string name;

        private List<Topping> toppings = new List<Topping>();
        private Dough dough;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.dough = dough;
        }
        public string Name
        {
            get => this.name;

          private  set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }
        public void AddTopping(Topping currentTopping)
        {
            if (toppings.Count < 0 || toppings.Count > 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            toppings.Add(currentTopping);
        }

        public double GetTotalCalories()
        {
            double toppingCalories = 0.0;
            double doughCalories = dough.GetDoughGrams;

            foreach (var topping in toppings)
            {
                toppingCalories += topping.GetToppingGrams;
            }
            double result = doughCalories + toppingCalories;

            return result;
        }

        public override string ToString()
        {
            return $"{this.Name} - {GetTotalCalories():f2} Calories.";
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
