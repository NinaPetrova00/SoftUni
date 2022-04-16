<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _04.PizzaCalories
{
    public class Topping
    {
        private string toppingType;
        private double toppingWeight;

        public Topping(string toppingType, double toppingWeight)
        {
            this.ToppingType = toppingType;
            this.ToppingWeight = toppingWeight;
        }

        public string ToppingType
        {
            get => this.toppingType;

          private  set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.toppingType = value;
            }
        }

        public double ToppingWeight
        {
            get => this.toppingWeight;

          private  set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.ToppingType} weight should be in the range [1..50].");
                }
                this.toppingWeight = value;
            }
        }

        public double GetToppingGrams
        {
            get
            {
                return this.CaluclateToppingGrams();
            }
        }
        private double CaluclateToppingGrams()
        {
            double toppingModifier = 0.0;
            double grams = this.ToppingWeight * 2;

            if (this.ToppingType.ToLower() == "meat")
            {
                toppingModifier = 1.2;
            }
            else if (this.ToppingType.ToLower() == "veggies")
            {
                toppingModifier = 0.8;
            }
            else if (this.ToppingType.ToLower() == "cheese")
            {
                toppingModifier = 1.1;
            }
            else if (this.ToppingType.ToLower() == "sauce")
            {
                toppingModifier = 0.9;
            }

            double result = grams * toppingModifier;

            return result;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _04.PizzaCalories
{
    public class Topping
    {
        private string toppingType;
        private double toppingWeight;

        public Topping(string toppingType, double toppingWeight)
        {
            this.ToppingType = toppingType;
            this.ToppingWeight = toppingWeight;
        }

        public string ToppingType
        {
            get => this.toppingType;

          private  set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.toppingType = value;
            }
        }

        public double ToppingWeight
        {
            get => this.toppingWeight;

          private  set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.ToppingType} weight should be in the range [1..50].");
                }
                this.toppingWeight = value;
            }
        }

        public double GetToppingGrams
        {
            get
            {
                return this.CaluclateToppingGrams();
            }
        }
        private double CaluclateToppingGrams()
        {
            double toppingModifier = 0.0;
            double grams = this.ToppingWeight * 2;

            if (this.ToppingType.ToLower() == "meat")
            {
                toppingModifier = 1.2;
            }
            else if (this.ToppingType.ToLower() == "veggies")
            {
                toppingModifier = 0.8;
            }
            else if (this.ToppingType.ToLower() == "cheese")
            {
                toppingModifier = 1.1;
            }
            else if (this.ToppingType.ToLower() == "sauce")
            {
                toppingModifier = 0.9;
            }

            double result = grams * toppingModifier;

            return result;
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
