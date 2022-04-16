<<<<<<< HEAD
﻿using System;
namespace ValidationAttributes.Models
{
using ValidationAttributes.CustomAtributes;
    public class Person
    {
        public Person(string fullName,int age)
        {
            this.FullName = fullName;
            this.Age = age;
        }

        [MyRequiredAttribute]
        public string FullName { get; set; }

        [MyRangeAttribute(12,90)]
        public int Age { get; set; }
    }
}
=======
﻿using System;
namespace ValidationAttributes.Models
{
using ValidationAttributes.CustomAtributes;
    public class Person
    {
        public Person(string fullName,int age)
        {
            this.FullName = fullName;
            this.Age = age;
        }

        [MyRequiredAttribute]
        public string FullName { get; set; }

        [MyRangeAttribute(12,90)]
        public int Age { get; set; }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
