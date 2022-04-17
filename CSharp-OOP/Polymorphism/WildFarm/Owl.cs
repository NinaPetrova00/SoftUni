using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, int foodEaten, double wingSize)
            : base(name, weight, foodEaten, wingSize)
        {
        }

        public override string Feed(string food)
        {
            throw new NotImplementedException();
        }

        public override string MakeSound()
        {
            return "Hoot Hoot";
        }
    }
}
