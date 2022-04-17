using System;
using System.Collections.Generic;
using System.Text;

namespace _03.ShoppingSpree
{
    public class Person
    {
        private string name;
        private double money;
        private List<Product> bag = new List<Product>();

        public Person(string name,double money)
        {
            this.Name = name;
            this.Money = money;
        }
        public string Name
        {
            get => this.name;

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public double Money {
            get => this.money;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }

        public void BuyProduct(Product product)
        {
            foreach (var item in bag)
            {
                if (this.Money < item.Cost)
                {
                    throw new ArgumentException($"{this.Name} can't afford {item}");
                }
                bag.Add(item);
            }
        }
    }
}
