<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Raw_Data
{
    public class Car
    {
        public string Model { get; set; }

        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }

        public Tier[] Tier { get; set; }

        public Car(string model,Engine engine,Cargo cargo,Tier[] tiers)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tier = tiers;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Raw_Data
{
    public class Car
    {
        public string Model { get; set; }

        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }

        public Tier[] Tier { get; set; }

        public Car(string model,Engine engine,Cargo cargo,Tier[] tiers)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tier = tiers;
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
