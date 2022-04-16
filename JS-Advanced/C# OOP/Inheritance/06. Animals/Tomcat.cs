<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
   public class Tomcat: Cat
    {
        public const string DefaultGender = "Male";
        public Tomcat(string name, int age) 
            : base(name, age, DefaultGender)
        {
        }

        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
   public class Tomcat: Cat
    {
        public const string DefaultGender = "Male";
        public Tomcat(string name, int age) 
            : base(name, age, DefaultGender)
        {
        }

        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
