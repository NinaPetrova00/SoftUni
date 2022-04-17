using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, int foodEaten, string livingRegion, string breed)
            : base(name, weight, foodEaten, livingRegion, breed)
        {
        }

        public override string Feed(string food)
        {
            throw new NotImplementedException();
        }

        public override string MakeSound()
        {
            return "Meow";
        }
    }
}
