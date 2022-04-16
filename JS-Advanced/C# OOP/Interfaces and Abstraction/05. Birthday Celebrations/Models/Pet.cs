<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;
using _04.BorderControl.Interfaces;

namespace _04.BorderControl.Models
{
   public class Pet: IBirthdate
    {
        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }
        public string Name { get; set; }
        public string Birthdate { get; }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Text;
using _04.BorderControl.Interfaces;

namespace _04.BorderControl.Models
{
   public class Pet: IBirthdate
    {
        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }
        public string Name { get; set; }
        public string Birthdate { get; }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
