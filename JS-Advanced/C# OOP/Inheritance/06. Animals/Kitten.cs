<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Kitten : Cat
    {
        public const string DefaultGender = "Female";
        public Kitten(string name, int age)
            : base(name, age, DefaultGender)
        {
        }
        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}

=======
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Kitten : Cat
    {
        public const string DefaultGender = "Female";
        public Kitten(string name, int age)
            : base(name, age, DefaultGender)
        {
        }
        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}

>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
