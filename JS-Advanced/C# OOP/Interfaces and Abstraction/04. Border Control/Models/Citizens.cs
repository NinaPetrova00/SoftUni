<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;
using _04.BorderControl.Interfaces;

namespace _04.BorderControl.Models
{
    public class Citizens : ISociety
    {

        public Citizens(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Id { get; }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Text;
using _04.BorderControl.Interfaces;

namespace _04.BorderControl.Models
{
    public class Citizens : ISociety
    {

        public Citizens(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Id { get; }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
