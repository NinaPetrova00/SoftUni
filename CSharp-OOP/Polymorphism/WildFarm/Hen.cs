using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, int foodEaten, double wingSize) 
            : base(name, weight, foodEaten, wingSize)
        {
        }
        public override string MakeSound()
        {
            return "Cluck";
        }

        public override string Feed(string food)
        {
            return "";
        }
    }
}
