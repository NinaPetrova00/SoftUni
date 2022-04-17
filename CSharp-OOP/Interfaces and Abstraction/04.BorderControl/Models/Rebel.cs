using _04.BorderControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04.BorderControl.Models
{
    public class Rebel : IBuyer
    {
        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;

        }
        public int Age { get; set; }
        public string Group { get; set; }
        public int Food { get; set; }
        public string Name { get; }

        public void BuyFood()
        {
            this.Food = 5;
        }
    }
}
