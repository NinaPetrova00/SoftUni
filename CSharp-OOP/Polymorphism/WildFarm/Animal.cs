using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
   public abstract class Animal
    {
        public Animal(string name,double weight,int foodEaten )
        {
            this.Name = name;
            this.Weight = weight;
            this.FoodEaten = foodEaten;
        }
        public string Name { get;  }
        public double Weight { get;  }
        public int FoodEaten { get;  }

        public abstract string MakeSound();
        public abstract string Feed(string food);


    }
}
