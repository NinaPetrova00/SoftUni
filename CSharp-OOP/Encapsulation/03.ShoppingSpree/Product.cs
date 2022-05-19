﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _03.ShoppingSpree
{
   public class Product
    {
        private string name;
        private double cost;

        public Product(string name,double cost)
        {
            this.Name = name;
            this.Cost = cost;
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

        public double Cost
        {
            get => this.cost;
            set
            {
                this.cost = value;
            }
        }
    }
}