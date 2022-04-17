using System;
using System.Collections.Generic;
using System.Text;
using _04.BorderControl.Interfaces;

namespace _04.BorderControl.Models
{
    public class Citizens : ISociety, IBirthdate, IBuyer
    {
        public Citizens(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;          
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; }
        public string Birthdate { get; }
        public int Food { get; set; }

        public void BuyFood()
        {
            this.Food = 10;
        }
    }
}
