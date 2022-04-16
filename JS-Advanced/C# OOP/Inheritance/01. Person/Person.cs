<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        private int age;
        public Person(string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }
        public string Name { get; set; }

        public virtual int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be negative.");
                }
                this.age = value;
            }
        }
        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
            //StringBuilder sb = new StringBuilder();
            //sb.AppendLine($"Name: {this.Name}, Age: {this.Age}");
            //return sb.ToString();
        }

    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        private int age;
        public Person(string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }
        public string Name { get; set; }

        public virtual int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be negative.");
                }
                this.age = value;
            }
        }
        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
            //StringBuilder sb = new StringBuilder();
            //sb.AppendLine($"Name: {this.Name}, Age: {this.Age}");
            //return sb.ToString();
        }

    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
