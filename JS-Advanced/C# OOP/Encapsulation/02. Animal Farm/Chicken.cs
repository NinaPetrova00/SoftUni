<<<<<<< HEAD
﻿using System;

namespace AnimalFarm.Models
{
    public class Chicken
    {
        private const int MinAge = 0;
        private const int MaxAge = 15;

        private string name;
        private int age;

        internal Chicken(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"{nameof(Name)} cannot be empty.");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                if (value <= MinAge || value >= MaxAge)
                {
                    throw new ArgumentException($"{nameof(Age)} should be between {MinAge} and {MaxAge}.");
                }

                this.age = value;
            }
        }

        public double ProductPerDay
        {
            get
            {
                return this.CalculateProductPerDay();
            }
        }
        private double CalculateProductPerDay() => this.Age switch
        {
            var x when x >= 0 && x <= 3 => 1.5,
            var x when x >= 4 && x <= 7 => 2,
            var x when x >= 8 && x <= 11 => 1,
            _ => 0.75 //default
        };


    }
}
=======
﻿using System;

namespace AnimalFarm.Models
{
    public class Chicken
    {
        private const int MinAge = 0;
        private const int MaxAge = 15;

        private string name;
        private int age;

        internal Chicken(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"{nameof(Name)} cannot be empty.");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                if (value <= MinAge || value >= MaxAge)
                {
                    throw new ArgumentException($"{nameof(Age)} should be between {MinAge} and {MaxAge}.");
                }

                this.age = value;
            }
        }

        public double ProductPerDay
        {
            get
            {
                return this.CalculateProductPerDay();
            }
        }
        private double CalculateProductPerDay() => this.Age switch
        {
            var x when x >= 0 && x <= 3 => 1.5,
            var x when x >= 4 && x <= 7 => 2,
            var x when x >= 8 && x <= 11 => 1,
            _ => 0.75 //default
        };


    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
